// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.18362.0")]
    public enum WINHTTP_REQUEST_TIME_ENTRY
    {
        WinHttpProxyDetectionStart = 0,
        WinHttpProxyDetectionEnd,
        WinHttpConnectionAcquireStart,
        WinHttpConnectionAcquireWaitEnd,
        WinHttpConnectionAcquireEnd,
        WinHttpNameResolutionStart,
        WinHttpNameResolutionEnd,
        WinHttpConnectionEstablishmentStart,
        WinHttpConnectionEstablishmentEnd,
        WinHttpTlsHandshakeClientLeg1Start,
        WinHttpTlsHandshakeClientLeg1End,
        WinHttpTlsHandshakeClientLeg2Start,
        WinHttpTlsHandshakeClientLeg2End,
        WinHttpTlsHandshakeClientLeg3Start,
        WinHttpTlsHandshakeClientLeg3End,
        WinHttpStreamWaitStart,
        WinHttpStreamWaitEnd,
        WinHttpSendRequestStart,
        WinHttpSendRequestHeadersCompressionStart,
        WinHttpSendRequestHeadersCompressionEnd,
        WinHttpSendRequestHeadersEnd,
        WinHttpSendRequestEnd,
        WinHttpReceiveResponseStart,
        WinHttpReceiveResponseHeadersDecompressionStart,
        WinHttpReceiveResponseHeadersDecompressionEnd,
        WinHttpReceiveResponseHeadersEnd,
        WinHttpReceiveResponseBodyDecompressionDelta,
        WinHttpReceiveResponseEnd,
        WinHttpProxyTunnelStart,
        WinHttpProxyTunnelEnd,
        WinHttpProxyTlsHandshakeClientLeg1Start,
        WinHttpProxyTlsHandshakeClientLeg1End,
        WinHttpProxyTlsHandshakeClientLeg2Start,
        WinHttpProxyTlsHandshakeClientLeg2End,
        WinHttpProxyTlsHandshakeClientLeg3Start,
        WinHttpProxyTlsHandshakeClientLeg3End,
        WinHttpRequestTimeLast,
        WinHttpRequestTimeMax = 64,
    }
}
