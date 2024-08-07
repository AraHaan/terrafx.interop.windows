// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='EnumProgressItems.xml' path='doc/member[@name="EnumProgressItems"]/*' />
[Guid("2C941FCA-975B-59BE-A960-9A2A262853A5")]
public unsafe partial struct EnumProgressItems : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_EnumProgressItems));
}
