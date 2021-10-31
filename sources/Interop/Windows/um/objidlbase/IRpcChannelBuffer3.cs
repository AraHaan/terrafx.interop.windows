// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25B15600-0115-11D0-BF0D-00AA00B8DFD2")]
    [NativeTypeName("struct IRpcChannelBuffer3 : IRpcChannelBuffer2")]
    [NativeInheritance("IRpcChannelBuffer2")]
    public unsafe partial struct IRpcChannelBuffer3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint>)(lpVtbl[1]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint>)(lpVtbl[2]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsConnected()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, int>)(lpVtbl[7]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint*, int>)(lpVtbl[8]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Send(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[9]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Receive(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint, uint*, int>)(lpVtbl[10]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, ulSize, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Cancel(RPCOLEMESSAGE* pMsg)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[11]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetCallContext(RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, void** pInterface)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, void**, int>)(lpVtbl[12]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, riid, pInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDestCtxEx(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, void**, int>)(lpVtbl[13]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetState(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[14]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT RegisterAsync(RPCOLEMESSAGE* pMsg, IAsyncManager* pAsyncMgr)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, IAsyncManager*, int>)(lpVtbl[15]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pAsyncMgr);
        }
    }
}
