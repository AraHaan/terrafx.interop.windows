// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B53C00B6-9922-4B78-B1F4-DDFE774DC39B")]
    [NativeTypeName("struct ICredentialProviderCredentialEvents2 : ICredentialProviderCredentialEvents")]
    [NativeInheritance("ICredentialProviderCredentialEvents")]
    public unsafe partial struct ICredentialProviderCredentialEvents2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, uint>)(lpVtbl[1]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, uint>)(lpVtbl[2]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetFieldState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE cpfs)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE, int>)(lpVtbl[3]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFieldInteractiveState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE, int>)(lpVtbl[4]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFieldString(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, ushort*, int>)(lpVtbl[5]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetFieldCheckbox(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, BOOL, ushort*, int>)(lpVtbl[6]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, bChecked, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetFieldBitmap(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("HBITMAP")] IntPtr hbmp)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, IntPtr, int>)(lpVtbl[7]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, hbmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetFieldComboBoxSelectedItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[8]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT DeleteFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[9]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AppendFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* pszItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, ushort*, int>)(lpVtbl[10]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, pszItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetFieldSubmitButton(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwAdjacentTo)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[11]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwAdjacentTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT OnCreatingWindow([NativeTypeName("HWND *")] IntPtr* phwndOwner)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, IntPtr*, int>)(lpVtbl[12]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), phwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT BeginFieldUpdates()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, int>)(lpVtbl[13]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EndFieldUpdates()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, int>)(lpVtbl[14]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFieldOptions(ICredentialProviderCredential* credential, [NativeTypeName("DWORD")] uint fieldID, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS options)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS, int>)(lpVtbl[15]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), credential, fieldID, options);
        }
    }
}
