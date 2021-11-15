// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_ALTPLATFORM_INFO_V3
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_ALTPLATFORM_INFO32_V3));
                }
                else
                {
                    return (uint)(sizeof(SP_ALTPLATFORM_INFO64_V3));
                }
            }
        }

        [FieldOffset(0)]
        public SP_ALTPLATFORM_INFO32_V3 _value32;

        [FieldOffset(0)]
        public SP_ALTPLATFORM_INFO64_V3 _value64;

        [NativeTypeName("DWORD")]
        public ref uint cbSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint Platform
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Platform, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Platform, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint MajorVersion
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.MajorVersion, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.MajorVersion, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint MinorVersion
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.MinorVersion, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.MinorVersion, 1));
                }
            }
        }

        [NativeTypeName("WORD")]
        public ref ushort ProcessorArchitecture
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.ProcessorArchitecture, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.ProcessorArchitecture, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint FirstValidatedMajorVersion
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FirstValidatedMajorVersion, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FirstValidatedMajorVersion, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint FirstValidatedMinorVersion
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FirstValidatedMinorVersion, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FirstValidatedMinorVersion, 1));
                }
            }
        }

        public ref byte ProductType
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.ProductType, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.ProductType, 1));
                }
            }
        }

        [NativeTypeName("WORD")]
        public ref ushort SuiteMask
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.SuiteMask, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.SuiteMask, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint BuildNumber
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.BuildNumber, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.BuildNumber, 1));
                }
            }
        }

        public ref ushort Reserved
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref _value32.Reserved;
                }
                else
                {
                    return ref _value64.Reserved;
                }
            }
        }

        public ref ushort Flags
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref _value32.Flags;
                }
                else
                {
                    return ref _value64.Flags;
                }
            }
        }

    }
}