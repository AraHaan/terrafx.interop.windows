// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct TYPEATTR
    {
        #region Fields
        [NativeTypeName("GUID")]
        public Guid guid;

        [NativeTypeName("LCID")]
        public uint lcid;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("MEMBERID")]
        public int memidConstructor;

        [NativeTypeName("MEMBERID")]
        public int memidDestructor;

        [NativeTypeName("LPOLESTR")]
        public char* lpstrSchema;

        [NativeTypeName("ULONG")]
        public uint cbSizeInstance;

        public TYPEKIND typekind;

        [NativeTypeName("WORD")]
        public ushort cFuncs;

        [NativeTypeName("WORD")]
        public ushort cVars;

        [NativeTypeName("WORD")]
        public ushort cImplTypes;

        [NativeTypeName("WORD")]
        public ushort cbSizeVft;

        [NativeTypeName("WORD")]
        public ushort cbAlignment;

        [NativeTypeName("WORD")]
        public ushort wTypeFlags;

        [NativeTypeName("WORD")]
        public ushort wMajorVerNum;

        [NativeTypeName("WORD")]
        public ushort wMinorVerNum;

        public TYPEDESC tdescAlias;

        public IDLDESC idldescType;
        #endregion
    }
}
