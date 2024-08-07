// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID"]/*' />
public enum WS_CHANNEL_PROPERTY_ID
{
    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_BUFFERED_MESSAGE_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_BUFFERED_MESSAGE_SIZE = 0,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_STREAMED_MESSAGE_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_STREAMED_MESSAGE_SIZE = 1,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_STREAMED_START_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_STREAMED_START_SIZE = 2,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_STREAMED_FLUSH_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_STREAMED_FLUSH_SIZE = 3,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ENCODING"]/*' />
    WS_CHANNEL_PROPERTY_ENCODING = 4,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ENVELOPE_VERSION"]/*' />
    WS_CHANNEL_PROPERTY_ENVELOPE_VERSION = 5,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ADDRESSING_VERSION"]/*' />
    WS_CHANNEL_PROPERTY_ADDRESSING_VERSION = 6,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_SESSION_DICTIONARY_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_SESSION_DICTIONARY_SIZE = 7,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_STATE"]/*' />
    WS_CHANNEL_PROPERTY_STATE = 8,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ASYNC_CALLBACK_MODEL"]/*' />
    WS_CHANNEL_PROPERTY_ASYNC_CALLBACK_MODEL = 9,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_IP_VERSION"]/*' />
    WS_CHANNEL_PROPERTY_IP_VERSION = 10,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_RESOLVE_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_RESOLVE_TIMEOUT = 11,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CONNECT_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_CONNECT_TIMEOUT = 12,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_SEND_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_SEND_TIMEOUT = 13,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_RECEIVE_RESPONSE_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_RECEIVE_RESPONSE_TIMEOUT = 14,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_RECEIVE_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_RECEIVE_TIMEOUT = 15,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CLOSE_TIMEOUT"]/*' />
    WS_CHANNEL_PROPERTY_CLOSE_TIMEOUT = 16,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ENABLE_TIMEOUTS"]/*' />
    WS_CHANNEL_PROPERTY_ENABLE_TIMEOUTS = 17,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_TRANSFER_MODE"]/*' />
    WS_CHANNEL_PROPERTY_TRANSFER_MODE = 18,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MULTICAST_INTERFACE"]/*' />
    WS_CHANNEL_PROPERTY_MULTICAST_INTERFACE = 19,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MULTICAST_HOPS"]/*' />
    WS_CHANNEL_PROPERTY_MULTICAST_HOPS = 20,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_REMOTE_ADDRESS"]/*' />
    WS_CHANNEL_PROPERTY_REMOTE_ADDRESS = 21,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_REMOTE_IP_ADDRESS"]/*' />
    WS_CHANNEL_PROPERTY_REMOTE_IP_ADDRESS = 22,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_CONNECTION_ID"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_CONNECTION_ID = 23,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_CALLBACKS"]/*' />
    WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_CALLBACKS = 24,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_PARAMETERS"]/*' />
    WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_PARAMETERS = 25,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_INSTANCE"]/*' />
    WS_CHANNEL_PROPERTY_CUSTOM_CHANNEL_INSTANCE = 26,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_TRANSPORT_URL"]/*' />
    WS_CHANNEL_PROPERTY_TRANSPORT_URL = 27,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_NO_DELAY"]/*' />
    WS_CHANNEL_PROPERTY_NO_DELAY = 28,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_SEND_KEEP_ALIVES"]/*' />
    WS_CHANNEL_PROPERTY_SEND_KEEP_ALIVES = 29,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_KEEP_ALIVE_TIME"]/*' />
    WS_CHANNEL_PROPERTY_KEEP_ALIVE_TIME = 30,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_KEEP_ALIVE_INTERVAL"]/*' />
    WS_CHANNEL_PROPERTY_KEEP_ALIVE_INTERVAL = 31,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_HTTP_SERVER_CONNECTIONS"]/*' />
    WS_CHANNEL_PROPERTY_MAX_HTTP_SERVER_CONNECTIONS = 32,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_IS_SESSION_SHUT_DOWN"]/*' />
    WS_CHANNEL_PROPERTY_IS_SESSION_SHUT_DOWN = 33,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CHANNEL_TYPE"]/*' />
    WS_CHANNEL_PROPERTY_CHANNEL_TYPE = 34,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_TRIM_BUFFERED_MESSAGE_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_TRIM_BUFFERED_MESSAGE_SIZE = 35,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ENCODER"]/*' />
    WS_CHANNEL_PROPERTY_ENCODER = 36,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_DECODER"]/*' />
    WS_CHANNEL_PROPERTY_DECODER = 37,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_PROTECTION_LEVEL"]/*' />
    WS_CHANNEL_PROPERTY_PROTECTION_LEVEL = 38,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_COOKIE_MODE"]/*' />
    WS_CHANNEL_PROPERTY_COOKIE_MODE = 39,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_PROXY_SETTING_MODE"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_PROXY_SETTING_MODE = 40,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_CUSTOM_HTTP_PROXY"]/*' />
    WS_CHANNEL_PROPERTY_CUSTOM_HTTP_PROXY = 41,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_MESSAGE_MAPPING"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_MESSAGE_MAPPING = 42,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ENABLE_HTTP_REDIRECT"]/*' />
    WS_CHANNEL_PROPERTY_ENABLE_HTTP_REDIRECT = 43,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_REDIRECT_CALLBACK_CONTEXT"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_REDIRECT_CALLBACK_CONTEXT = 44,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_FAULTS_AS_ERRORS"]/*' />
    WS_CHANNEL_PROPERTY_FAULTS_AS_ERRORS = 45,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_ALLOW_UNSECURED_FAULTS"]/*' />
    WS_CHANNEL_PROPERTY_ALLOW_UNSECURED_FAULTS = 46,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_SERVER_SPN"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_SERVER_SPN = 47,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_HTTP_PROXY_SPN"]/*' />
    WS_CHANNEL_PROPERTY_HTTP_PROXY_SPN = 48,

    /// <include file='WS_CHANNEL_PROPERTY_ID.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY_ID.WS_CHANNEL_PROPERTY_MAX_HTTP_REQUEST_HEADERS_BUFFER_SIZE"]/*' />
    WS_CHANNEL_PROPERTY_MAX_HTTP_REQUEST_HEADERS_BUFFER_SIZE = 49,
}
