// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WS_BINDING_TEMPLATE_TYPE
    {
        WS_HTTP_BINDING_TEMPLATE_TYPE = 0,
        WS_HTTP_SSL_BINDING_TEMPLATE_TYPE = 1,
        WS_HTTP_HEADER_AUTH_BINDING_TEMPLATE_TYPE = 2,
        WS_HTTP_SSL_HEADER_AUTH_BINDING_TEMPLATE_TYPE = 3,
        WS_HTTP_SSL_USERNAME_BINDING_TEMPLATE_TYPE = 4,
        WS_HTTP_SSL_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE = 5,
        WS_TCP_BINDING_TEMPLATE_TYPE = 6,
        WS_TCP_SSPI_BINDING_TEMPLATE_TYPE = 7,
        WS_TCP_SSPI_USERNAME_BINDING_TEMPLATE_TYPE = 8,
        WS_TCP_SSPI_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE = 9,
        WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 10,
        WS_HTTP_SSL_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 11,
        WS_TCP_SSPI_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 12,
        WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 13,
    }
}