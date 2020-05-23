// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate COPYFILE2_MESSAGE_ACTION PCOPYFILE2_PROGRESS_ROUTINE([NativeTypeName("const COPYFILE2_MESSAGE *")] COPYFILE2_MESSAGE* pMessage, [NativeTypeName("PVOID")] void* pvCallbackContext);
}
