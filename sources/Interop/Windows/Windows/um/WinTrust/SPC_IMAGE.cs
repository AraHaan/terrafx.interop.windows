// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SPC_IMAGE
    {
        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pImageLink;

        public CRYPT_DATA_BLOB Bitmap;

        public CRYPT_DATA_BLOB Metafile;

        public CRYPT_DATA_BLOB EnhancedMetafile;

        public CRYPT_DATA_BLOB GifFile;
    }
}