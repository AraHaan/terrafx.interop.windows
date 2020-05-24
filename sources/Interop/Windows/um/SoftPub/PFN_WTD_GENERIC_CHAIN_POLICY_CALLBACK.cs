// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFN_WTD_GENERIC_CHAIN_POLICY_CALLBACK([NativeTypeName("PCRYPT_PROVIDER_DATA")] CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("DWORD")] uint dwStepError, [NativeTypeName("DWORD")] uint dwRegPolicySettings, [NativeTypeName("DWORD")] uint cSigner, [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_SIGNER_INFO *")] WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO** rgpSigner, [NativeTypeName("void *")] void* pvPolicyArg);
}