// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_TCP6ROW2
    {
        public IN6_ADDR LocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        public IN6_ADDR RemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        public MIB_TCP_STATE State;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
    }
}
