// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SP_ENABLECLASS_PARAMS64
    {
        public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

        [NativeTypeName("GUID")]
        public Guid ClassGuid;

        [NativeTypeName("DWORD")]
        public uint EnableMessage;
    }
}