// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD"]/*' />
public partial struct IMAGEHLP_DEFERRED_SYMBOL_LOAD
{
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.BaseOfImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseOfImage;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.FileName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.Reparse"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Reparse;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.hFile"]/*' />
    public HANDLE hFile;

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _FileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
