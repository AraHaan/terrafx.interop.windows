// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHCREATEPROCESSINFO32W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("ULONG")]
    public uint fMask;

    public HWND hwnd;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszFile;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszParameters;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszCurrentDirectory;

    public HANDLE hUserToken;

    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpProcessAttributes;

    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpThreadAttributes;

    public BOOL bInheritHandles;

    [NativeTypeName("DWORD")]
    public uint dwCreationFlags;

    [NativeTypeName("LPSTARTUPINFOW")]
    public STARTUPINFOW* lpStartupInfo;

    [NativeTypeName("LPPROCESS_INFORMATION")]
    public PROCESS_INFORMATION* lpProcessInformation;
}
