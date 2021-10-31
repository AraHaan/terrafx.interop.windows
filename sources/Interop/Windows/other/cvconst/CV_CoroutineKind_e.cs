// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public enum CV_CoroutineKind_e
    {
        CV_COROUTINEKIND_NONE,
        CV_COROUTINEKIND_PRIMARY,
        CV_COROUTINEKIND_INIT,
        CV_COROUTINEKIND_RESUME,
        CV_COROUTINEKIND_DESTROY,
    }
}