// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WINHTTP_PROXY_RESULT_EX
    {
        [NativeTypeName("DWORD")]
        public uint cEntries;

        public WINHTTP_PROXY_RESULT_ENTRY* pEntries;

        public HANDLE hProxyDetectionHandle;

        [NativeTypeName("DWORD")]
        public uint dwProxyInterfaceAffinity;
    }
}