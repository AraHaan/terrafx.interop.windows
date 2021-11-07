// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct D3D11_VIDEO_DECODER_EXTENSION
    {
        public uint Function;

        public void* pPrivateInputData;

        public uint PrivateInputDataSize;

        public void* pPrivateOutputData;

        public uint PrivateOutputDataSize;

        public uint ResourceCount;

        public ID3D11Resource** ppResourceList;
    }
}
