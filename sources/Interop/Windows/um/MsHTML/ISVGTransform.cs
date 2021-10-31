// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104F7-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTransform : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTransform*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTransform*, uint>)(lpVtbl[1]))((ISVGTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTransform*, uint>)(lpVtbl[2]))((ISVGTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTransform*, uint*, int>)(lpVtbl[3]))((ISVGTransform*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTransform*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTransform*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTransform*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTransform*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTransform*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTransform*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_type(short v)
        {
            return ((delegate* unmanaged<ISVGTransform*, short, int>)(lpVtbl[7]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_type(short* p)
        {
            return ((delegate* unmanaged<ISVGTransform*, short*, int>)(lpVtbl[8]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_matrix(ISVGMatrix* v)
        {
            return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int>)(lpVtbl[9]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_matrix(ISVGMatrix** p)
        {
            return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix**, int>)(lpVtbl[10]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_angle(float v)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[11]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_angle(float* p)
        {
            return ((delegate* unmanaged<ISVGTransform*, float*, int>)(lpVtbl[12]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT setMatrix(ISVGMatrix* matrix)
        {
            return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int>)(lpVtbl[13]))((ISVGTransform*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT setTranslate(float tx, float ty)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, float, int>)(lpVtbl[14]))((ISVGTransform*)Unsafe.AsPointer(ref this), tx, ty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT setScale(float sx, float sy)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, float, int>)(lpVtbl[15]))((ISVGTransform*)Unsafe.AsPointer(ref this), sx, sy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT setRotate(float angle, float cx, float cy)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, float, float, int>)(lpVtbl[16]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle, cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT setSkewX(float angle)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[17]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT setSkewY(float angle)
        {
            return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[18]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle);
        }
    }
}
