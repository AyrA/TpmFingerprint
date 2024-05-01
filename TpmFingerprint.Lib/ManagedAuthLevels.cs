using System;

namespace TpmFingerprint.Lib
{
    [Flags]
    internal enum ManagedAuthLevels
    {
        Unknown = -1,
        None = 0,
        Delegated = 2,
        Full = 4
    }
}
