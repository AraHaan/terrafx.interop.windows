// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDLtRtCenterMixLvl_x10.xml' path='doc/member[@name="CODECAPI_AVEncDDLtRtCenterMixLvl_x10"]/*' />
[Guid("DCA128A2-491F-4600-B2DA-76E3344B4197")]
public unsafe partial struct CODECAPI_AVEncDDLtRtCenterMixLvl_x10 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDLtRtCenterMixLvl_x10));
}
