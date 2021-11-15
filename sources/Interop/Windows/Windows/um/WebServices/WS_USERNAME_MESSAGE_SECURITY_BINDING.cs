// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WS_USERNAME_MESSAGE_SECURITY_BINDING
    {
        public WS_SECURITY_BINDING binding;

        public WS_MESSAGE_SECURITY_USAGE bindingUsage;

        public WS_USERNAME_CREDENTIAL* clientCredential;

        [NativeTypeName("WS_VALIDATE_PASSWORD_CALLBACK")]
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> passwordValidator;

        public void* passwordValidatorCallbackState;
    }
}