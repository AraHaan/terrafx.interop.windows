// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_RENDER_TARGET_VIEW_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC"]/*' />
public partial struct D3D11_RENDER_TARGET_VIEW_DESC
{
    /// <include file='D3D11_RENDER_TARGET_VIEW_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D11_RENDER_TARGET_VIEW_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC.ViewDimension"]/*' />
    public D3D11_RTV_DIMENSION ViewDimension;

    /// <include file='D3D11_RENDER_TARGET_VIEW_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d11.h:3915:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*' />
    public ref D3D11_BUFFER_RTV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Buffer, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*' />
    public ref D3D11_TEX1D_RTV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1D, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*' />
    public ref D3D11_TEX1D_ARRAY_RTV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1DArray, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
    public ref D3D11_TEX2D_RTV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*' />
    public ref D3D11_TEX2D_ARRAY_RTV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DArray, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*' />
    public ref D3D11_TEX2DMS_RTV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMS, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*' />
    public ref D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMSArray, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*' />
    public ref D3D11_TEX3D_RTV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture3D, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*' />
        [FieldOffset(0)]
        public D3D11_BUFFER_RTV Buffer;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX1D_RTV Texture1D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_RTV Texture1DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_RTV Texture2D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_RTV Texture2DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2DMS_RTV Texture2DMS;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX3D_RTV Texture3D;
    }
}
