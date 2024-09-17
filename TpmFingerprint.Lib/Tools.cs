using System;
using System.Linq;
using System.Security.Cryptography;

namespace TpmFingerprint.Lib
{
    public static class Tools
    {
        public static string Hex(byte[] data)
        {
            return string.Concat(data.Select(m => m.ToString("X2")));
        }

        public static string HashHex(byte[] data)
        {
            using (var hasher = SHA256.Create())
            {
                return Hex(hasher.ComputeHash(data));
            }
        }

        public static string HashB64(byte[] data)
        {
            using (var hasher = SHA256.Create())
            {
                return Convert.ToBase64String(hasher.ComputeHash(data));
            }
        }


    }
}
