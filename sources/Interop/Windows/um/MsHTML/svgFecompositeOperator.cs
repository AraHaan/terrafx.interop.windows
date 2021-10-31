// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum svgFecompositeOperator
    {
        SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0,
        SVG_FECOMPOSITE_OPERATOR_OVER = 1,
        SVG_FECOMPOSITE_OPERATOR_IN = 2,
        SVG_FECOMPOSITE_OPERATOR_OUT = 3,
        SVG_FECOMPOSITE_OPERATOR_ATOP = 4,
        SVG_FECOMPOSITE_OPERATOR_XOR = 5,
        SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6,
        svgFecompositeOperator_Max = 2147483647,
    }
}