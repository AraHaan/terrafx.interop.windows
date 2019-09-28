// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct POINTER_TYPE_INFO
    {
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint type;

        [NativeTypeName("struct (anonymous struct at um/winuser.h:6325:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("POINTER_TOUCH_INFO")]
            public POINTER_TOUCH_INFO touchInfo;

            [FieldOffset(0)]
            [NativeTypeName("POINTER_PEN_INFO")]
            public POINTER_PEN_INFO penInfo;
        }
    }
}