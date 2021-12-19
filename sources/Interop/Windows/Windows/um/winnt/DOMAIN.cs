// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DOMAIN
{
    [NativeTypeName("#define DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED (0x000001F0L)")]
    public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED = (0x000001F0);

    [NativeTypeName("#define DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS (0x000001F1L)")]
    public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS = (0x000001F1);

    [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS (0x000001F2L)")]
    public const int DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS = (0x000001F2);

    [NativeTypeName("#define DOMAIN_USER_RID_ADMIN (0x000001F4L)")]
    public const int DOMAIN_USER_RID_ADMIN = (0x000001F4);

    [NativeTypeName("#define DOMAIN_USER_RID_GUEST (0x000001F5L)")]
    public const int DOMAIN_USER_RID_GUEST = (0x000001F5);

    [NativeTypeName("#define DOMAIN_USER_RID_KRBTGT (0x000001F6L)")]
    public const int DOMAIN_USER_RID_KRBTGT = (0x000001F6);

    [NativeTypeName("#define DOMAIN_USER_RID_DEFAULT_ACCOUNT (0x000001F7L)")]
    public const int DOMAIN_USER_RID_DEFAULT_ACCOUNT = (0x000001F7);

    [NativeTypeName("#define DOMAIN_USER_RID_WDAG_ACCOUNT (0x000001F8L)")]
    public const int DOMAIN_USER_RID_WDAG_ACCOUNT = (0x000001F8);

    [NativeTypeName("#define DOMAIN_USER_RID_MAX (0x000003E7L)")]
    public const int DOMAIN_USER_RID_MAX = (0x000003E7);

    [NativeTypeName("#define DOMAIN_GROUP_RID_ADMINS (0x00000200L)")]
    public const int DOMAIN_GROUP_RID_ADMINS = (0x00000200);

    [NativeTypeName("#define DOMAIN_GROUP_RID_USERS (0x00000201L)")]
    public const int DOMAIN_GROUP_RID_USERS = (0x00000201);

    [NativeTypeName("#define DOMAIN_GROUP_RID_GUESTS (0x00000202L)")]
    public const int DOMAIN_GROUP_RID_GUESTS = (0x00000202);

    [NativeTypeName("#define DOMAIN_GROUP_RID_COMPUTERS (0x00000203L)")]
    public const int DOMAIN_GROUP_RID_COMPUTERS = (0x00000203);

    [NativeTypeName("#define DOMAIN_GROUP_RID_CONTROLLERS (0x00000204L)")]
    public const int DOMAIN_GROUP_RID_CONTROLLERS = (0x00000204);

    [NativeTypeName("#define DOMAIN_GROUP_RID_CERT_ADMINS (0x00000205L)")]
    public const int DOMAIN_GROUP_RID_CERT_ADMINS = (0x00000205);

    [NativeTypeName("#define DOMAIN_GROUP_RID_SCHEMA_ADMINS (0x00000206L)")]
    public const int DOMAIN_GROUP_RID_SCHEMA_ADMINS = (0x00000206);

    [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_ADMINS (0x00000207L)")]
    public const int DOMAIN_GROUP_RID_ENTERPRISE_ADMINS = (0x00000207);

    [NativeTypeName("#define DOMAIN_GROUP_RID_POLICY_ADMINS (0x00000208L)")]
    public const int DOMAIN_GROUP_RID_POLICY_ADMINS = (0x00000208);

    [NativeTypeName("#define DOMAIN_GROUP_RID_READONLY_CONTROLLERS (0x00000209L)")]
    public const int DOMAIN_GROUP_RID_READONLY_CONTROLLERS = (0x00000209);

    [NativeTypeName("#define DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS (0x0000020AL)")]
    public const int DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS = (0x0000020A);

    [NativeTypeName("#define DOMAIN_GROUP_RID_CDC_RESERVED (0x0000020CL)")]
    public const int DOMAIN_GROUP_RID_CDC_RESERVED = (0x0000020C);

    [NativeTypeName("#define DOMAIN_GROUP_RID_PROTECTED_USERS (0x0000020DL)")]
    public const int DOMAIN_GROUP_RID_PROTECTED_USERS = (0x0000020D);

    [NativeTypeName("#define DOMAIN_GROUP_RID_KEY_ADMINS (0x0000020EL)")]
    public const int DOMAIN_GROUP_RID_KEY_ADMINS = (0x0000020E);

    [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS (0x0000020FL)")]
    public const int DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS = (0x0000020F);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_ADMINS (0x00000220L)")]
    public const int DOMAIN_ALIAS_RID_ADMINS = (0x00000220);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_USERS (0x00000221L)")]
    public const int DOMAIN_ALIAS_RID_USERS = (0x00000221);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_GUESTS (0x00000222L)")]
    public const int DOMAIN_ALIAS_RID_GUESTS = (0x00000222);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_POWER_USERS (0x00000223L)")]
    public const int DOMAIN_ALIAS_RID_POWER_USERS = (0x00000223);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_ACCOUNT_OPS (0x00000224L)")]
    public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = (0x00000224);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_SYSTEM_OPS (0x00000225L)")]
    public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = (0x00000225);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_PRINT_OPS (0x00000226L)")]
    public const int DOMAIN_ALIAS_RID_PRINT_OPS = (0x00000226);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_BACKUP_OPS (0x00000227L)")]
    public const int DOMAIN_ALIAS_RID_BACKUP_OPS = (0x00000227);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_REPLICATOR (0x00000228L)")]
    public const int DOMAIN_ALIAS_RID_REPLICATOR = (0x00000228);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_RAS_SERVERS (0x00000229L)")]
    public const int DOMAIN_ALIAS_RID_RAS_SERVERS = (0x00000229);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_PREW2KCOMPACCESS (0x0000022AL)")]
    public const int DOMAIN_ALIAS_RID_PREW2KCOMPACCESS = (0x0000022A);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS (0x0000022BL)")]
    public const int DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS = (0x0000022B);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS (0x0000022CL)")]
    public const int DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS = (0x0000022C);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS (0x0000022DL)")]
    public const int DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS = (0x0000022D);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_MONITORING_USERS (0x0000022EL)")]
    public const int DOMAIN_ALIAS_RID_MONITORING_USERS = (0x0000022E);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_LOGGING_USERS (0x0000022FL)")]
    public const int DOMAIN_ALIAS_RID_LOGGING_USERS = (0x0000022F);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS (0x00000230L)")]
    public const int DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS = (0x00000230);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS (0x00000231L)")]
    public const int DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS = (0x00000231);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_DCOM_USERS (0x00000232L)")]
    public const int DOMAIN_ALIAS_RID_DCOM_USERS = (0x00000232);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_IUSERS (0x00000238L)")]
    public const int DOMAIN_ALIAS_RID_IUSERS = (0x00000238);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_CRYPTO_OPERATORS (0x00000239L)")]
    public const int DOMAIN_ALIAS_RID_CRYPTO_OPERATORS = (0x00000239);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP (0x0000023BL)")]
    public const int DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP = (0x0000023B);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP (0x0000023CL)")]
    public const int DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP = (0x0000023C);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP (0x0000023DL)")]
    public const int DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP = (0x0000023D);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP (0x0000023EL)")]
    public const int DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP = (0x0000023E);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS (0x0000023FL)")]
    public const int DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS = (0x0000023F);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS (0x00000240L)")]
    public const int DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS = (0x00000240);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS (0x00000241L)")]
    public const int DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS = (0x00000241);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_HYPER_V_ADMINS (0x00000242L)")]
    public const int DOMAIN_ALIAS_RID_HYPER_V_ADMINS = (0x00000242);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS (0x00000243L)")]
    public const int DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS = (0x00000243);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS (0x00000244L)")]
    public const int DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS = (0x00000244);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT (0x00000245L)")]
    public const int DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT = (0x00000245);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS (0x00000246L)")]
    public const int DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS = (0x00000246);

    [NativeTypeName("#define DOMAIN_ALIAS_RID_DEVICE_OWNERS (0x00000247L)")]
    public const int DOMAIN_ALIAS_RID_DEVICE_OWNERS = (0x00000247);
}
