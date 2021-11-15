// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum KNOWN_FOLDER_FLAG
    {
        KF_FLAG_DEFAULT = 0x00000000,
        KF_FLAG_FORCE_APP_DATA_REDIRECTION = 0x00080000,
        KF_FLAG_RETURN_FILTER_REDIRECTION_TARGET = 0x00040000,
        KF_FLAG_FORCE_PACKAGE_REDIRECTION = 0x00020000,
        KF_FLAG_NO_PACKAGE_REDIRECTION = 0x00010000,
        KF_FLAG_FORCE_APPCONTAINER_REDIRECTION = 0x00020000,
        KF_FLAG_NO_APPCONTAINER_REDIRECTION = 0x00010000,
        KF_FLAG_CREATE = 0x00008000,
        KF_FLAG_DONT_VERIFY = 0x00004000,
        KF_FLAG_DONT_UNEXPAND = 0x00002000,
        KF_FLAG_NO_ALIAS = 0x00001000,
        KF_FLAG_INIT = 0x00000800,
        KF_FLAG_DEFAULT_PATH = 0x00000400,
        KF_FLAG_NOT_PARENT_RELATIVE = 0x00000200,
        KF_FLAG_SIMPLE_IDLIST = 0x00000100,
        KF_FLAG_ALIAS_ONLY = unchecked((int)(0x80000000)),
    }
}