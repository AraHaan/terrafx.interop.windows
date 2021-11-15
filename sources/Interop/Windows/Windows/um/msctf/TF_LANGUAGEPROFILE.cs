// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public partial struct TF_LANGUAGEPROFILE
    {
        [NativeTypeName("CLSID")]
        public Guid clsid;

        [NativeTypeName("LANGID")]
        public ushort langid;

        public Guid catid;

        public BOOL fActive;

        public Guid guidProfile;
    }
}