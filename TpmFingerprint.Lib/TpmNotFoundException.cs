using System;

namespace TpmFingerprint.Lib
{
    public class TpmNotFoundException : Exception
    {
        public TpmNotFoundException() : this("A compatible TPM with version 2.0 could not be found, or it has not been properly initialized. Run 'tpm.msc' command to diagnose.")
        {
        }

        public TpmNotFoundException(string message) : base(message)
        {
        }

        public TpmNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
