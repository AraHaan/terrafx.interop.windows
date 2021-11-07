// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public partial struct STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NodeCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("STORAGE_PHYSICAL_NODE_DATA [1]")]
        public _Node_e__FixedBuffer Node;

        public partial struct _Node_e__FixedBuffer
        {
            public STORAGE_PHYSICAL_NODE_DATA e0;

            public ref STORAGE_PHYSICAL_NODE_DATA this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<STORAGE_PHYSICAL_NODE_DATA> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
