// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO"]/*' />
public partial struct ENCRYPTED_DATA_INFO
{
    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.StartingFileOffset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong StartingFileOffset;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.OutputBufferOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint OutputBufferOffset;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.BytesWithinFileSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BytesWithinFileSize;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.BytesWithinValidDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint BytesWithinValidDataLength;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.CompressionFormat"]/*' />
    [NativeTypeName("WORD")]
    public ushort CompressionFormat;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.DataUnitShift"]/*' />
    public byte DataUnitShift;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.ChunkShift"]/*' />
    public byte ChunkShift;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.ClusterShift"]/*' />
    public byte ClusterShift;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.EncryptionFormat"]/*' />
    public byte EncryptionFormat;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.NumberOfDataBlocks"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfDataBlocks;

    /// <include file='ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="ENCRYPTED_DATA_INFO.DataBlockSize"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _DataBlockSize_e__FixedBuffer DataBlockSize;

    /// <include file='_DataBlockSize_e__FixedBuffer.xml' path='doc/member[@name="_DataBlockSize_e__FixedBuffer"]/*' />
    public partial struct _DataBlockSize_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
