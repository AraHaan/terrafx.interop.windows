// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("10A72A66-E91C-43F4-993F-DDF4B82B0B4A")]
    [NativeTypeName("struct ID2D1StrokeStyle1 : ID2D1StrokeStyle")]
    [NativeInheritance("ID2D1StrokeStyle")]
    public unsafe partial struct ID2D1StrokeStyle1 : ID2D1StrokeStyle1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, uint>)(lpVtbl[1]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, uint>)(lpVtbl[2]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1StrokeStyle1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public D2D1_CAP_STYLE GetStartCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[4]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public D2D1_CAP_STYLE GetEndCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[5]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public D2D1_CAP_STYLE GetDashCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[6]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public float GetMiterLimit()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, float>)(lpVtbl[7]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D2D1_LINE_JOIN GetLineJoin()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_LINE_JOIN>)(lpVtbl[8]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public float GetDashOffset()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, float>)(lpVtbl[9]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public D2D1_DASH_STYLE GetDashStyle()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_DASH_STYLE>)(lpVtbl[10]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, uint>)(lpVtbl[11]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            ((delegate* unmanaged<ID2D1StrokeStyle1*, float*, uint, void>)(lpVtbl[12]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), dashes, dashesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_STROKE_TRANSFORM_TYPE>)(lpVtbl[13]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : ID2D1StrokeStyle.Interface
        {
            [VtblIndex(13)]
            D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE> GetStartCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE> GetEndCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_CAP_STYLE> GetDashCap;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, float> GetMiterLimit;

            [NativeTypeName("D2D1_LINE_JOIN () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_LINE_JOIN> GetLineJoin;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, float> GetDashOffset;

            [NativeTypeName("D2D1_DASH_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_DASH_STYLE> GetDashStyle;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, uint> GetDashesCount;

            [NativeTypeName("void (FLOAT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, float*, uint, void> GetDashes;

            [NativeTypeName("D2D1_STROKE_TRANSFORM_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1StrokeStyle1*, D2D1_STROKE_TRANSFORM_TYPE> GetStrokeTransformType;
        }
    }
}