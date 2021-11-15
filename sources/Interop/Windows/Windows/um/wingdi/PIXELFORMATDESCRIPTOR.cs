// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct PIXELFORMATDESCRIPTOR
    {
        [NativeTypeName("WORD")]
        public ushort nSize;

        [NativeTypeName("WORD")]
        public ushort nVersion;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public byte iPixelType;

        public byte cColorBits;

        public byte cRedBits;

        public byte cRedShift;

        public byte cGreenBits;

        public byte cGreenShift;

        public byte cBlueBits;

        public byte cBlueShift;

        public byte cAlphaBits;

        public byte cAlphaShift;

        public byte cAccumBits;

        public byte cAccumRedBits;

        public byte cAccumGreenBits;

        public byte cAccumBlueBits;

        public byte cAccumAlphaBits;

        public byte cDepthBits;

        public byte cStencilBits;

        public byte cAuxBuffers;

        public byte iLayerType;

        public byte bReserved;

        [NativeTypeName("DWORD")]
        public uint dwLayerMask;

        [NativeTypeName("DWORD")]
        public uint dwVisibleMask;

        [NativeTypeName("DWORD")]
        public uint dwDamageMask;
    }
}