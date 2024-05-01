using Microsoft.Tpm.Commands;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TpmFingerprint.Lib
{
    public class TpmKeyInfo
    {
        internal TpmKeyInfo(EndorsementKeyObject key)
        {
            IsPresent = key.IsPresent;
            PublicKey = key.PublicKey;
            ManufacturerCertificates = new X509Certificate2[key.ManufacturerCertificates.Count];
            AdditionalCertificates = new X509Certificate2[key.AdditionalCertificates.Count];
            if (key.ManufacturerCertificates.Count > 0)
            {
                key.ManufacturerCertificates.CopyTo(ManufacturerCertificates, 0);
            }
            if (key.AdditionalCertificates.Count > 0)
            {
                key.AdditionalCertificates.CopyTo(AdditionalCertificates, 0);
            }
        }

        public bool IsPresent { get; }
        public AsnEncodedData PublicKey { get; }
        public X509Certificate2[] ManufacturerCertificates { get; }
        public X509Certificate2[] AdditionalCertificates { get; }
    }
}
