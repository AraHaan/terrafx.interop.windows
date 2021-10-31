// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA1
    {
        public HRESULT DeviceRemovedReason;

        public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT AutoBreadcrumbsOutput;

        public D3D12_DRED_PAGE_FAULT_OUTPUT PageFaultOutput;
    }
}
