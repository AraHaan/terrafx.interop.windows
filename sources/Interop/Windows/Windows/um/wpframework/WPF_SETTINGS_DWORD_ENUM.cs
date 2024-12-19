// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM"]/*' />
public enum WPF_SETTINGS_DWORD_ENUM
{
    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.PERIODIC_RESTART_REQUESTS"]/*' />
    PERIODIC_RESTART_REQUESTS = 1,

    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.PERIODIC_RESTART_TIME"]/*' />
    PERIODIC_RESTART_TIME,

    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.IDLE_TIMEOUT"]/*' />
    IDLE_TIMEOUT,

    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.MANAGED_PIPELINE_MODE"]/*' />
    MANAGED_PIPELINE_MODE,

    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.THREAD_AFFINITY_POLICY"]/*' />
    THREAD_AFFINITY_POLICY,

    /// <include file='WPF_SETTINGS_DWORD_ENUM.xml' path='doc/member[@name="WPF_SETTINGS_DWORD_ENUM.IDLE_TIMEOUT_ACTION"]/*' />
    IDLE_TIMEOUT_ACTION,
}