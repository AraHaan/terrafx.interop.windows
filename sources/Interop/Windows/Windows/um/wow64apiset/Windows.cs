// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wow64apiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte Wow64EnableWow64FsRedirection([NativeTypeName("BOOLEAN")] byte Wow64FsEnableRedirection);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL Wow64DisableWow64FsRedirection([NativeTypeName("PVOID *")] void** OldValue);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL Wow64RevertWow64FsRedirection([NativeTypeName("PVOID")] void* OlValue);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsWow64Process(HANDLE hProcess, [NativeTypeName("PBOOL")] BOOL* Wow64Process);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetSystemWow64DirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, uint uSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetSystemWow64DirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, uint uSize);

        [SupportedOSPlatform("windows10.0.10586.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsWow64Process2(HANDLE hProcess, ushort* pProcessMachine, ushort* pNativeMachine);

        [SupportedOSPlatform("windows10.0.10586.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetSystemWow64Directory2A([NativeTypeName("LPSTR")] sbyte* lpBuffer, uint uSize, [NativeTypeName("WORD")] ushort ImageFileMachineType);

        [SupportedOSPlatform("windows10.0.10586.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetSystemWow64Directory2W([NativeTypeName("LPWSTR")] ushort* lpBuffer, uint uSize, [NativeTypeName("WORD")] ushort ImageFileMachineType);

        [SupportedOSPlatform("windows10.0.16299.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HRESULT IsWow64GuestMachineSupported(ushort WowGuestMachine, BOOL* MachineIsSupported);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL Wow64GetThreadContext(HANDLE hThread, [NativeTypeName("PWOW64_CONTEXT")] WOW64_CONTEXT* lpContext);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL Wow64SetThreadContext(HANDLE hThread, [NativeTypeName("const WOW64_CONTEXT *")] WOW64_CONTEXT* lpContext);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint Wow64SuspendThread(HANDLE hThread);

        [NativeTypeName("#define GetSystemWow64Directory GetSystemWow64DirectoryW")]
        public static delegate*<ushort*, uint, uint> GetSystemWow64Directory => &GetSystemWow64DirectoryW;

        [SupportedOSPlatform("windows10.0.10586.0")]
        [NativeTypeName("#define GetSystemWow64Directory2 GetSystemWow64Directory2W")]
        public static delegate*<ushort*, uint, ushort, uint> GetSystemWow64Directory2 => &GetSystemWow64Directory2W;
    }
}
