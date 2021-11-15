// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows
{
    public static partial class E
    {
        [NativeTypeName("#define E_DATATYPE_MISMATCH HRESULT_FROM_WIN32(ERROR_DATATYPE_MISMATCH)")]
        public static HRESULT E_DATATYPE_MISMATCH => HRESULT_FROM_WIN32(1629);
    }
}