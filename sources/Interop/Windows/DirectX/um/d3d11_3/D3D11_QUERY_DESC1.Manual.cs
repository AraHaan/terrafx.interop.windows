// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3D11_CONTEXT_TYPE;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_QUERY_DESC1
{
    public D3D11_QUERY_DESC1(D3D11_QUERY query, uint miscFlags = 0, D3D11_CONTEXT_TYPE contextType = D3D11_CONTEXT_TYPE_ALL)
    {
        Query = query;
        MiscFlags = miscFlags;
        ContextType = contextType;
    }
}
