// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT"]/*' />
public partial struct GET_FILTER_FILE_IDENTIFIER_INPUT
{
    /// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT.AltitudeLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort AltitudeLength;

    /// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT.Altitude"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Altitude_e__FixedBuffer Altitude;

    /// <include file='_Altitude_e__FixedBuffer.xml' path='doc/member[@name="_Altitude_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Altitude_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
