// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY"]/*' />
public unsafe partial struct D3D10_SO_DECLARATION_ENTRY
{
    /// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY.SemanticName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY.SemanticIndex"]/*' />
    public uint SemanticIndex;

    /// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY.StartComponent"]/*' />
    public byte StartComponent;

    /// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY.ComponentCount"]/*' />
    public byte ComponentCount;

    /// <include file='D3D10_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D10_SO_DECLARATION_ENTRY.OutputSlot"]/*' />
    public byte OutputSlot;
}
