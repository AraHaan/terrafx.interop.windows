// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class PERSISTENT
    {
        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED (0x00000001)")]
        public const int PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED = (0x00000001);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED (0x00000002)")]
        public const int PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED = (0x00000002);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY (0x00000004)")]
        public const int PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY = (0x00000004);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY (0x00000008)")]
        public const int PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY = (0x00000008);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING (0x00000010)")]
        public const int PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING = (0x00000010);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM (0x00000020)")]
        public const int PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM = (0x00000020);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_BACKED_BY_WIM (0x00000040)")]
        public const int PERSISTENT_VOLUME_STATE_BACKED_BY_WIM = (0x00000040);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING (0x00000080)")]
        public const int PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING = (0x00000080);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_TXF_DISABLED (0x00000100)")]
        public const int PERSISTENT_VOLUME_STATE_TXF_DISABLED = (0x00000100);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES (0x00000200)")]
        public const int PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES = (0x00000200);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE (0x00000400)")]
        public const int PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE = (0x00000400);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK (0x00000800)")]
        public const int PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK = (0x00000800);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_DAX_FORMATTED (0x00001000)")]
        public const int PERSISTENT_VOLUME_STATE_DAX_FORMATTED = (0x00001000);
    }
}
