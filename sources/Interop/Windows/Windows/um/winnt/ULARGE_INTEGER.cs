// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct ULARGE_INTEGER
{
    /// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("_ULARGE_INTEGER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:895:5)")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER.u"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:899:5)")]
    public _u_e__Struct u;

    /// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER.QuadPart"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("ULONGLONG")]
    public ulong QuadPart;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LowPart"]/*' />
    public ref uint LowPart
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.LowPart, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HighPart"]/*' />
    public ref uint HighPart
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.HighPart, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LowPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint LowPart;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HighPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint HighPart;
    }

    /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct"]/*' />
    public partial struct _u_e__Struct
    {
        /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct.LowPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint LowPart;

        /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct.HighPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint HighPart;
    }
}
