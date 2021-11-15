// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum VIDEOENCODER_BITRATE_MODE
    {
        ConstantBitRate = 0,
        VariableBitRateAverage = (ConstantBitRate + 1),
        VariableBitRatePeak = (VariableBitRateAverage + 1),
    }
}