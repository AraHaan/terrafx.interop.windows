// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510842-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDebugCallbackNotificationHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDebugCallbackNotificationHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, uint>)(lpVtbl[1]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, uint>)(lpVtbl[2]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RequestedCallbackTypes([NativeTypeName("DWORD *")] uint* pCallbackMask)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, uint*, int>)(lpVtbl[3]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pCallbackMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BeforeDispatchEvent(IUnknown* pEvent)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, IUnknown*, int>)(lpVtbl[4]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int DispatchEventComplete(IUnknown* pEvent, [NativeTypeName("DWORD")] uint propagationStatus)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, IUnknown*, uint, int>)(lpVtbl[5]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, propagationStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BeforeInvokeDomCallback(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int>)(lpVtbl[6]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, pCallback, eStage, propagationStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeDomCallbackComplete(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int>)(lpVtbl[7]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, pCallback, eStage, propagationStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BeforeInvokeCallback(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] ushort* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, ushort*, uint, uint, uint, IUnknown*, int>)(lpVtbl[8]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), eCallbackType, callbackCookie, pDispHandler, ullHandlerCookie, functionName, line, column, cchLength, pDebugDocumentContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeCallbackComplete(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] ushort* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext)
        {
            return ((delegate* unmanaged<IDebugCallbackNotificationHandler*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, ushort*, uint, uint, uint, IUnknown*, int>)(lpVtbl[9]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), eCallbackType, callbackCookie, pDispHandler, ullHandlerCookie, functionName, line, column, cchLength, pDebugDocumentContext);
        }
    }
}
