// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMOBJECTNOTIFY
    {
        public NMHDR hdr;

        public int iItem;

        [NativeTypeName("const IID *")]
        public Guid* piid;

        public void* pObject;

        [NativeTypeName("HRESULT")]
        public int hResult;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }
}