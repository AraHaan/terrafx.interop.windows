// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncStatAudioAverageBPS.xml' path='doc/member[@name="CODECAPI_AVEncStatAudioAverageBPS"]/*' />
[Guid("CA6724DB-7059-4351-8B43-F82198826A14")]
public unsafe partial struct CODECAPI_AVEncStatAudioAverageBPS : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncStatAudioAverageBPS));
}
