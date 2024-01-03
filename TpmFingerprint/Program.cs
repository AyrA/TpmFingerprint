using Microsoft.Tpm.Commands;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TpmFingerprint
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var verbose = args.Any(m => m.ToUpperInvariant() == "/V");
            var b64 = args.Any(m => m.ToUpperInvariant() == "/B64");

            if (args.Contains("/?"))
            {
                Console.WriteLine(@"TpmFingerprint [/V] [/B64]
Reads the unique operating system independent fingerprint of this device.
The fingerprint is guaranteed to be unchangeable.

Reading the fingerprint requires administrative permissions.

/V   - Show extra information on standard error
/B64 - Output hash as Base64 instead of hexadecimal

Exit codes:

255 - This help screen was shown in response to '/?' argument
2   - No EK is present
1   - No compatible TPM is present
0   - Success, standard output consists of the hex encoded SHA256 value");
                return 255;
            }
            EndorsementKeyObject ek;
            try
            {
                ek = TpmAdapter.GetEK();
            }
            catch (TrustedPlatformModuleNotFoundException)
            {
                if (verbose)
                {
                    Console.Error.WriteLine("This system lacks a compatible TPM");
                }
                return 1;
            }
            if (!ek.IsPresent)
            {
                if (verbose)
                {
                    Console.Error.WriteLine("TPM doesn't contains an endorsement key. Maybe it's not initialized");
                }
                return 2;
            }
            if (verbose)
            {
                TpmAdapter.PrintTpmInformation();
                if (ek.PublicKey.Oid != null)
                {
                    Console.Error.WriteLine("PublicKeyType={0}",
                        ek.PublicKey.Oid.FriendlyName ?? ek.PublicKey.Oid.Value);
                }

                Console.Error.WriteLine("PublicKey={0}",
                    Convert.ToBase64String(ek.PublicKey.RawData));
                foreach (var mancert in ek.ManufacturerCertificates)
                {
                    Console.Error.WriteLine("ManufacturerCert={1} {0}",
                        FormatCert(mancert), mancert.Thumbprint.ToUpper());
                }
                foreach (var addcert in ek.AdditionalCertificates)
                {
                    Console.Error.WriteLine("AdditionalTpmCert={1} {0}",
                        FormatCert(addcert), addcert.Thumbprint.ToUpper());
                }
            }
            Console.WriteLine(b64
                ? HashB64(ek.PublicKey.RawData)
                : HashHex(ek.PublicKey.RawData));
            return 0;
        }

        static string HashHex(byte[] data)
        {
            using (var hasher = SHA256.Create())
            {
                return string.Concat(hasher.ComputeHash(data).Select(m => m.ToString("X2")));
            }
        }

        static string HashB64(byte[] data)
        {
            using (var hasher = SHA256.Create())
            {
                return Convert.ToBase64String(hasher.ComputeHash(data));
            }
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
