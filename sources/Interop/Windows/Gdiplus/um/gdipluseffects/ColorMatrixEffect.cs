// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorMatrixEffect.xml' path='doc/member[@name="ColorMatrixEffect"]/*' />
[NativeTypeName("struct ColorMatrixEffect : Effect")]
[NativeInheritance("Effect")]
public unsafe partial struct ColorMatrixEffect
{
    public Effect Base;

    public int GetAuxDataSize()
    {
        return Base.GetAuxDataSize();
    }

    public void* GetAuxData()
    {
        return Base.GetAuxData();
    }

    public void UseAuxData([NativeTypeName("const BOOL")] BOOL useAuxDataFlag)
    {
        Base.UseAuxData(useAuxDataFlag);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public Status GetParameterSize(uint* size)
    {
        return Base.GetParameterSize(size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public Status SetParameters([NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size)
    {
        return Base.SetParameters(@params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public Status GetParameters(uint* size, void* @params)
    {
        return Base.GetParameters(size, @params);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public Status SetParameters([NativeTypeName("const Gdiplus::ColorMatrix *")] ColorMatrix* matrix)
    {
        uint size = 100;

        return Base.SetParameters(matrix, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public Status GetParameters(uint* size, [NativeTypeName("Gdiplus::ColorMatrix *")] ColorMatrix* matrix)
    {
        return Base.GetParameters(size, unchecked((void*)(matrix)));
    }
}
