// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct MIB_IPMCAST_MFE
    {
        [NativeTypeName("DWORD")]
        public uint dwGroup;

        [NativeTypeName("DWORD")]
        public uint dwSource;

        [NativeTypeName("DWORD")]
        public uint dwSrcMask;

        [NativeTypeName("DWORD")]
        public uint dwUpStrmNgbr;

        [NativeTypeName("DWORD")]
        public uint dwInIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwInIfProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteNetwork;

        [NativeTypeName("DWORD")]
        public uint dwRouteMask;

        [NativeTypeName("ULONG")]
        public uint ulUpTime;

        [NativeTypeName("ULONG")]
        public uint ulExpiryTime;

        [NativeTypeName("ULONG")]
        public uint ulTimeOut;

        [NativeTypeName("ULONG")]
        public uint ulNumOutIf;

        [NativeTypeName("DWORD")]
        public uint fFlags;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("MIB_IPMCAST_OIF [1]")]
        public _rgmioOutInfo_e__FixedBuffer rgmioOutInfo;

        public partial struct _rgmioOutInfo_e__FixedBuffer
        {
            public MIB_IPMCAST_OIF_XP e0;

            public ref MIB_IPMCAST_OIF_XP this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MIB_IPMCAST_OIF_XP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}