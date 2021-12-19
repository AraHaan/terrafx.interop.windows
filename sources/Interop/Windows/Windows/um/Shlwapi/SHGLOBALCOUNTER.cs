// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER"]/*' />
public enum SHGLOBALCOUNTER
{
    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SEARCHMANAGER"]/*' />
    GLOBALCOUNTER_SEARCHMANAGER,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SEARCHOPTIONS"]/*' />
    GLOBALCOUNTER_SEARCHOPTIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_FOLDERSETTINGSCHANGE"]/*' />
    GLOBALCOUNTER_FOLDERSETTINGSCHANGE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RATINGS"]/*' />
    GLOBALCOUNTER_RATINGS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_APPROVEDSITES"]/*' />
    GLOBALCOUNTER_APPROVEDSITES,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RESTRICTIONS"]/*' />
    GLOBALCOUNTER_RESTRICTIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SHELLSETTINGSCHANGED"]/*' />
    GLOBALCOUNTER_SHELLSETTINGSCHANGED,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SYSTEMPIDLCHANGE"]/*' />
    GLOBALCOUNTER_SYSTEMPIDLCHANGE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_OVERLAYMANAGER"]/*' />
    GLOBALCOUNTER_OVERLAYMANAGER,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_QUERYASSOCIATIONS"]/*' />
    GLOBALCOUNTER_QUERYASSOCIATIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_IESESSIONS"]/*' />
    GLOBALCOUNTER_IESESSIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_IEONLY_SESSIONS"]/*' />
    GLOBALCOUNTER_IEONLY_SESSIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_APPLICATION_DESTINATIONS"]/*' />
    GLOBALCOUNTER_APPLICATION_DESTINATIONS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.__UNUSED_RECYCLE_WAS_GLOBALCOUNTER_CSCSYNCINPROGRESS"]/*' />
    __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_CSCSYNCINPROGRESS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_BITBUCKETNUMDELETERS"]/*' />
    GLOBALCOUNTER_BITBUCKETNUMDELETERS,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SHARES"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SHARES,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_A"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_A,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_B"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_B,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_C"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_C,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_D"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_D,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_E"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_E,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_F"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_F,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_G"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_G,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_H"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_H,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_I"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_I,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_J"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_J,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_K"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_K,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_L"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_L,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_M"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_M,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_N"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_N,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_O"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_O,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_P"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_P,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Q"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Q,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_R"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_R,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_S"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_S,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_T"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_T,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_U"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_U,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_V"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_V,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_W"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_W,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_X"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_X,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Y"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Y,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Z"]/*' />
    GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Z,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.__UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SERVERDRIVE"]/*' />
    __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SERVERDRIVE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.__UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEGLOBALDIRTYCOUNT"]/*' />
    __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEGLOBALDIRTYCOUNT,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEBINENUM"]/*' />
    GLOBALCOUNTER_RECYCLEBINENUM,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RECYCLEBINCORRUPTED"]/*' />
    GLOBALCOUNTER_RECYCLEBINCORRUPTED,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_RATINGS_STATECOUNTER"]/*' />
    GLOBALCOUNTER_RATINGS_STATECOUNTER,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_PRIVATE_PROFILE_CACHE"]/*' />
    GLOBALCOUNTER_PRIVATE_PROFILE_CACHE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_INTERNETTOOLBAR_LAYOUT"]/*' />
    GLOBALCOUNTER_INTERNETTOOLBAR_LAYOUT,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_FOLDERDEFINITION_CACHE"]/*' />
    GLOBALCOUNTER_FOLDERDEFINITION_CACHE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_COMMONPLACES_LIST_CACHE"]/*' />
    GLOBALCOUNTER_COMMONPLACES_LIST_CACHE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_PRIVATE_PROFILE_CACHE_MACHINEWIDE"]/*' />
    GLOBALCOUNTER_PRIVATE_PROFILE_CACHE_MACHINEWIDE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_ASSOCCHANGED"]/*' />
    GLOBALCOUNTER_ASSOCCHANGED,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_APP_ITEMS_STATE_STORE_CACHE"]/*' />
    GLOBALCOUNTER_APP_ITEMS_STATE_STORE_CACHE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SETTINGSYNC_ENABLED"]/*' />
    GLOBALCOUNTER_SETTINGSYNC_ENABLED,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_APPSFOLDER_FILETYPEASSOCIATION_COUNTER"]/*' />
    GLOBALCOUNTER_APPSFOLDER_FILETYPEASSOCIATION_COUNTER,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_USERINFOCHANGED"]/*' />
    GLOBALCOUNTER_USERINFOCHANGED,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_SYNC_ENGINE_INFORMATION_CACHE_MACHINEWIDE"]/*' />
    GLOBALCOUNTER_SYNC_ENGINE_INFORMATION_CACHE_MACHINEWIDE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_BANNERS_DATAMODEL_CACHE_MACHINEWIDE"]/*' />
    GLOBALCOUNTER_BANNERS_DATAMODEL_CACHE_MACHINEWIDE,

    /// <include file='SHGLOBALCOUNTER.xml' path='doc/member[@name="SHGLOBALCOUNTER.GLOBALCOUNTER_MAXIMUMVALUE"]/*' />
    GLOBALCOUNTER_MAXIMUMVALUE,
}
