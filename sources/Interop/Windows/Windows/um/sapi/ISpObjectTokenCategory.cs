// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory"]/*' />
[Guid("2D3D3845-39AF-4850-BBF9-40B49780011D")]
[NativeTypeName("struct ISpObjectTokenCategory : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpObjectTokenCategory : ISpObjectTokenCategory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpObjectTokenCategory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, uint>)(lpVtbl[1]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, uint>)(lpVtbl[2]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpDataKey.SetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.GetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.SetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, char*, int>)(lpVtbl[5]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPWSTR *")] char** ppszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, char**, int>)(lpVtbl[6]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <inheritdoc cref="ISpDataKey.SetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, uint, int>)(lpVtbl[7]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, uint*, int>)(lpVtbl[8]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <inheritdoc cref="ISpDataKey.OpenKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] char* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.CreateKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] char* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] char* pszSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, int>)(lpVtbl[11]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] char* pszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, int>)(lpVtbl[12]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumKeys" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszSubKeyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, uint, char**, int>)(lpVtbl[13]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, uint, char**, int>)(lpVtbl[14]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.SetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetId([NativeTypeName("LPCWSTR")] char* pszCategoryId, BOOL fCreateIfNotExist)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, BOOL, int>)(lpVtbl[15]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszCategoryId, fCreateIfNotExist);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] char** ppszCoMemCategoryId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char**, int>)(lpVtbl[16]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemCategoryId);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetDataKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey** ppDataKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, SPDATAKEYLOCATION, ISpDataKey**, int>)(lpVtbl[17]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), spdkl, ppDataKey);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.EnumTokens"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumTokens([NativeTypeName("LPCWSTR")] char* pzsReqAttribs, [NativeTypeName("LPCWSTR")] char* pszOptAttribs, IEnumSpObjectTokens** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, char*, IEnumSpObjectTokens**, int>)(lpVtbl[18]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pzsReqAttribs, pszOptAttribs, ppEnum);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.SetDefaultTokenId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] char* pszTokenId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char*, int>)(lpVtbl[19]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszTokenId);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetDefaultTokenId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] char** ppszCoMemTokenId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpObjectTokenCategory*, char**, int>)(lpVtbl[20]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
    }

    public interface Interface : ISpDataKey.Interface
    {
        [VtblIndex(15)]
        HRESULT SetId([NativeTypeName("LPCWSTR")] char* pszCategoryId, BOOL fCreateIfNotExist);

        [VtblIndex(16)]
        HRESULT GetId([NativeTypeName("LPWSTR *")] char** ppszCoMemCategoryId);

        [VtblIndex(17)]
        HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey** ppDataKey);

        [VtblIndex(18)]
        HRESULT EnumTokens([NativeTypeName("LPCWSTR")] char* pzsReqAttribs, [NativeTypeName("LPCWSTR")] char* pszOptAttribs, IEnumSpObjectTokens** ppEnum);

        [VtblIndex(19)]
        HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] char* pszTokenId);

        [VtblIndex(20)]
        HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] char** ppszCoMemTokenId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumValues;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL, int> SetId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetId;

        [NativeTypeName("HRESULT (SPDATAKEYLOCATION, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPDATAKEYLOCATION, ISpDataKey**, int> GetDataKey;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IEnumSpObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IEnumSpObjectTokens**, int> EnumTokens;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetDefaultTokenId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDefaultTokenId;
    }
}
