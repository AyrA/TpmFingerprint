using Microsoft.Tpm.Commands;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace TpmFingerprint.Lib
{
    public static class TpmAdapter
    {
        private static EndorsementKeyObject keyObject = null;
        private static byte[] fingerprint = null;

        public static byte[] GetFingerprint()
        {
            if (fingerprint == null)
            {
                var key = GetEK();
                using (var hasher = SHA256.Create())
                {
                    fingerprint = hasher.ComputeHash(key.PublicKey.RawData);
                }
            }
            return (byte[])fingerprint.Clone();
        }

        public static TpmKeyInfo GetKeyInfo()
        {
            var ek = GetEK();
            return new TpmKeyInfo(ek);
        }

        public static void PrintTpmInformation()
        {
            var objType = typeof(EndorsementKeyObject).Assembly
                .GetTypes()
                .First(m => m.Name == "TpmObject");
            var instance = objType.GetConstructor(Type.EmptyTypes).Invoke(null);
            foreach (var prop in objType.GetProperties())
            {
                var v = prop.GetValue(instance);
                Console.ResetColor();
                Console.Error.Write("{0}=", prop.Name);
                if (v == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine("<null>");
                }
                else if (v is string s)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Error.WriteLine(s);
                }
                else if (v is int i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Error.WriteLine(i);
                }
                else if (v is bool b)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Error.WriteLine(b);
                }
                else if (v is uint ui)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Error.WriteLine(ui);
                }
                else if (v is long l)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Error.WriteLine(l);
                }
                else if (v is ulong ul)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Error.WriteLine(ul);
                }
                else if (v is byte[] ba)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Error.WriteLine(ba.Length > 0 ? Convert.ToBase64String(ba) : "<empty byte[]>");
                }
                else if (v.GetType().Name == nameof(AutoProvisioningTypes))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    var provType = Convert.ToInt32(v);
                    Console.Error.WriteLine("({0}) {1}", provType, (AutoProvisioningTypes)provType);
                }
                else if (v.GetType().Name == nameof(ManagedAuthLevels))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    var authLevel = Convert.ToInt32(v);
                    Console.Error.WriteLine("({0}) {1}", authLevel, (ManagedAuthLevels)authLevel);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Error.WriteLine("<unknown value type: {0}>", v.GetType().Name);
                }
            }
            Console.ResetColor();
        }

        private static EndorsementKeyObject GetEK()
        {
            if (keyObject == null)
            {
                try
                {
                    keyObject = new EndorsementKeyObject("SHA256");
                }
                catch (TrustedPlatformModuleNotFoundException)
                {
                    throw new TpmNotFoundException();
                }
            }
            return keyObject;
        }
    }
}
