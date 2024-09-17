using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TpmFingerprint.Lib;
using static System.Console;

namespace TpmFingerprint.Console
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var verbose = args.Any(m => m.ToUpperInvariant() == "/V");
            var b64 = args.Any(m => m.ToUpperInvariant() == "/B64");

            if (args.Contains("/?"))
            {
                WriteLine(@"TpmFingerprint [/V] [/B64]
Reads the unique operating system independent fingerprint of this device.
The fingerprint is guaranteed to be unchangeable.

Reading the fingerprint requires administrative permissions.

/V   - Show extra information on standard error
/B64 - Output hash as Base64 instead of hexadecimal

Exit codes:

255 - This help screen was shown in response to '/?' argument
3   - Other error
2   - No EK is present
1   - No compatible TPM is present
0   - Success, standard output consists of the hex encoded SHA256 value");
                return 255;
            }
            TpmKeyInfo tpmKey;
            try
            {
                tpmKey = TpmAdapter.GetKeyInfo();
            }
            catch (TpmNotFoundException)
            {
                if (verbose)
                {
                    Error.WriteLine("This system lacks a compatible TPM");
                }
                return 1;
            }
            catch (Exception ex)
            {
                Error.WriteLine("Failed to obtain fingerprint from TPM.\r\n{0}: {1}", ex.GetType().Name, ex.Message);
                return 3;
            }
            if (!tpmKey.IsPresent)
            {
                if (verbose)
                {
                    Error.WriteLine("TPM doesn't contains an endorsement key. Maybe it's not initialized");
                }
                return 2;
            }
            if (verbose)
            {
                TpmAdapter.PrintTpmInformation();
                if (tpmKey.PublicKey.Oid != null)
                {
                    Error.WriteLine("PublicKeyType={0}",
                        tpmKey.PublicKey.Oid.FriendlyName ?? tpmKey.PublicKey.Oid.Value);
                }

                Error.WriteLine("PublicKey={0}",
                    Convert.ToBase64String(tpmKey.PublicKey.RawData));
                foreach (var mancert in tpmKey.ManufacturerCertificates)
                {
                    Error.WriteLine("ManufacturerCert={1} {0}",
                        FormatCert(mancert), mancert.Thumbprint.ToUpper());
                }
                foreach (var addcert in tpmKey.AdditionalCertificates)
                {
                    Error.WriteLine("AdditionalTpmCert={1} {0}",
                        FormatCert(addcert), addcert.Thumbprint.ToUpper());
                }
            }
            WriteLine(b64
                ? Tools.HashB64(tpmKey.PublicKey.RawData)
                : Tools.HashHex(tpmKey.PublicKey.RawData));
            return 0;
        }

        static string FormatCert(X509Certificate2 cert)
        {
            var certname = cert.SubjectName.Format(false);
            var issuername = cert.IssuerName.Format(false);
            if (string.IsNullOrEmpty(certname))
            {
                certname = cert.Subject;
            }
            if (string.IsNullOrEmpty(issuername))
            {
                issuername = cert.Issuer;
            }
            return string.Format("'{0}' issued by '{1}'", certname, issuername);
        }
    }
}
