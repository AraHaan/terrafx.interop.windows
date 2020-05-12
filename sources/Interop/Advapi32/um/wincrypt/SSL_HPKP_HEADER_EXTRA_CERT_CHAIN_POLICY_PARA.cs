// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszServerName;

        [NativeTypeName("LPSTR [2]")]
        public _rgpszHpkpValue_e__FixedBuffer rgpszHpkpValue;

        public unsafe partial struct _rgpszHpkpValue_e__FixedBuffer
        {
            internal sbyte e0;
            internal sbyte e1;

            public ref sbyte this[int index] => ref AsSpan()[index];

            public Span<sbyte> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}