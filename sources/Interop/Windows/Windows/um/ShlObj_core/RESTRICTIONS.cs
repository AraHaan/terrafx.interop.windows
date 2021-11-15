// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum RESTRICTIONS
    {
        REST_NONE = 0x00000000,
        REST_NORUN = 0x00000001,
        REST_NOCLOSE = 0x00000002,
        REST_NOSAVESET = 0x00000004,
        REST_NOFILEMENU = 0x00000008,
        REST_NOSETFOLDERS = 0x00000010,
        REST_NOSETTASKBAR = 0x00000020,
        REST_NODESKTOP = 0x00000040,
        REST_NOFIND = 0x00000080,
        REST_NODRIVES = 0x00000100,
        REST_NODRIVEAUTORUN = 0x00000200,
        REST_NODRIVETYPEAUTORUN = 0x00000400,
        REST_NONETHOOD = 0x00000800,
        REST_STARTBANNER = 0x00001000,
        REST_RESTRICTRUN = 0x00002000,
        REST_NOPRINTERTABS = 0x00004000,
        REST_NOPRINTERDELETE = 0x00008000,
        REST_NOPRINTERADD = 0x00010000,
        REST_NOSTARTMENUSUBFOLDERS = 0x00020000,
        REST_MYDOCSONNET = 0x00040000,
        REST_NOEXITTODOS = 0x00080000,
        REST_ENFORCESHELLEXTSECURITY = 0x00100000,
        REST_LINKRESOLVEIGNORELINKINFO = 0x00200000,
        REST_NOCOMMONGROUPS = 0x00400000,
        REST_SEPARATEDESKTOPPROCESS = 0x00800000,
        REST_NOWEB = 0x01000000,
        REST_NOTRAYCONTEXTMENU = 0x02000000,
        REST_NOVIEWCONTEXTMENU = 0x04000000,
        REST_NONETCONNECTDISCONNECT = 0x08000000,
        REST_STARTMENULOGOFF = 0x10000000,
        REST_NOSETTINGSASSIST = 0x20000000,
        REST_NOINTERNETICON = 0x40000001,
        REST_NORECENTDOCSHISTORY = 0x40000002,
        REST_NORECENTDOCSMENU = 0x40000003,
        REST_NOACTIVEDESKTOP = 0x40000004,
        REST_NOACTIVEDESKTOPCHANGES = 0x40000005,
        REST_NOFAVORITESMENU = 0x40000006,
        REST_CLEARRECENTDOCSONEXIT = 0x40000007,
        REST_CLASSICSHELL = 0x40000008,
        REST_NOCUSTOMIZEWEBVIEW = 0x40000009,
        REST_NOHTMLWALLPAPER = 0x40000010,
        REST_NOCHANGINGWALLPAPER = 0x40000011,
        REST_NODESKCOMP = 0x40000012,
        REST_NOADDDESKCOMP = 0x40000013,
        REST_NODELDESKCOMP = 0x40000014,
        REST_NOCLOSEDESKCOMP = 0x40000015,
        REST_NOCLOSE_DRAGDROPBAND = 0x40000016,
        REST_NOMOVINGBAND = 0x40000017,
        REST_NOEDITDESKCOMP = 0x40000018,
        REST_NORESOLVESEARCH = 0x40000019,
        REST_NORESOLVETRACK = 0x4000001A,
        REST_FORCECOPYACLWITHFILE = 0x4000001B,
        REST_NOFORGETSOFTWAREUPDATE = 0x4000001D,
        REST_NOSETACTIVEDESKTOP = 0x4000001E,
        REST_NOUPDATEWINDOWS = 0x4000001F,
        REST_NOCHANGESTARMENU = 0x40000020,
        REST_NOFOLDEROPTIONS = 0x40000021,
        REST_HASFINDCOMPUTERS = 0x40000022,
        REST_INTELLIMENUS = 0x40000023,
        REST_RUNDLGMEMCHECKBOX = 0x40000024,
        REST_ARP_ShowPostSetup = 0x40000025,
        REST_NOCSC = 0x40000026,
        REST_NOCONTROLPANEL = 0x40000027,
        REST_ENUMWORKGROUP = 0x40000028,
        REST_ARP_NOARP = 0x40000029,
        REST_ARP_NOREMOVEPAGE = 0x4000002A,
        REST_ARP_NOADDPAGE = 0x4000002B,
        REST_ARP_NOWINSETUPPAGE = 0x4000002C,
        REST_GREYMSIADS = 0x4000002D,
        REST_NOCHANGEMAPPEDDRIVELABEL = 0x4000002E,
        REST_NOCHANGEMAPPEDDRIVECOMMENT = 0x4000002F,
        REST_MaxRecentDocs = 0x40000030,
        REST_NONETWORKCONNECTIONS = 0x40000031,
        REST_FORCESTARTMENULOGOFF = 0x40000032,
        REST_NOWEBVIEW = 0x40000033,
        REST_NOCUSTOMIZETHISFOLDER = 0x40000034,
        REST_NOENCRYPTION = 0x40000035,
        REST_DONTSHOWSUPERHIDDEN = 0x40000037,
        REST_NOSHELLSEARCHBUTTON = 0x40000038,
        REST_NOHARDWARETAB = 0x40000039,
        REST_NORUNASINSTALLPROMPT = 0x4000003A,
        REST_PROMPTRUNASINSTALLNETPATH = 0x4000003B,
        REST_NOMANAGEMYCOMPUTERVERB = 0x4000003C,
        REST_DISALLOWRUN = 0x4000003E,
        REST_NOWELCOMESCREEN = 0x4000003F,
        REST_RESTRICTCPL = 0x40000040,
        REST_DISALLOWCPL = 0x40000041,
        REST_NOSMBALLOONTIP = 0x40000042,
        REST_NOSMHELP = 0x40000043,
        REST_NOWINKEYS = 0x40000044,
        REST_NOENCRYPTONMOVE = 0x40000045,
        REST_NOLOCALMACHINERUN = 0x40000046,
        REST_NOCURRENTUSERRUN = 0x40000047,
        REST_NOLOCALMACHINERUNONCE = 0x40000048,
        REST_NOCURRENTUSERRUNONCE = 0x40000049,
        REST_FORCEACTIVEDESKTOPON = 0x4000004A,
        REST_NOVIEWONDRIVE = 0x4000004C,
        REST_NONETCRAWL = 0x4000004D,
        REST_NOSHAREDDOCUMENTS = 0x4000004E,
        REST_NOSMMYDOCS = 0x4000004F,
        REST_NOSMMYPICS = 0x40000050,
        REST_ALLOWBITBUCKDRIVES = 0x40000051,
        REST_NONLEGACYSHELLMODE = 0x40000052,
        REST_NOCONTROLPANELBARRICADE = 0x40000053,
        REST_NOSTARTPAGE = 0x40000054,
        REST_NOAUTOTRAYNOTIFY = 0x40000055,
        REST_NOTASKGROUPING = 0x40000056,
        REST_NOCDBURNING = 0x40000057,
        REST_MYCOMPNOPROP = 0x40000058,
        REST_MYDOCSNOPROP = 0x40000059,
        REST_NOSTARTPANEL = 0x4000005A,
        REST_NODISPLAYAPPEARANCEPAGE = 0x4000005B,
        REST_NOTHEMESTAB = 0x4000005C,
        REST_NOVISUALSTYLECHOICE = 0x4000005D,
        REST_NOSIZECHOICE = 0x4000005E,
        REST_NOCOLORCHOICE = 0x4000005F,
        REST_SETVISUALSTYLE = 0x40000060,
        REST_STARTRUNNOHOMEPATH = 0x40000061,
        REST_NOUSERNAMEINSTARTPANEL = 0x40000062,
        REST_NOMYCOMPUTERICON = 0x40000063,
        REST_NOSMNETWORKPLACES = 0x40000064,
        REST_NOSMPINNEDLIST = 0x40000065,
        REST_NOSMMYMUSIC = 0x40000066,
        REST_NOSMEJECTPC = 0x40000067,
        REST_NOSMMOREPROGRAMS = 0x40000068,
        REST_NOSMMFUPROGRAMS = 0x40000069,
        REST_NOTRAYITEMSDISPLAY = 0x4000006A,
        REST_NOTOOLBARSONTASKBAR = 0x4000006B,
        REST_NOSMCONFIGUREPROGRAMS = 0x4000006F,
        REST_HIDECLOCK = 0x40000070,
        REST_NOLOWDISKSPACECHECKS = 0x40000071,
        REST_NOENTIRENETWORK = 0x40000072,
        REST_NODESKTOPCLEANUP = 0x40000073,
        REST_BITBUCKNUKEONDELETE = 0x40000074,
        REST_BITBUCKCONFIRMDELETE = 0x40000075,
        REST_BITBUCKNOPROP = 0x40000076,
        REST_NODISPBACKGROUND = 0x40000077,
        REST_NODISPSCREENSAVEPG = 0x40000078,
        REST_NODISPSETTINGSPG = 0x40000079,
        REST_NODISPSCREENSAVEPREVIEW = 0x4000007A,
        REST_NODISPLAYCPL = 0x4000007B,
        REST_HIDERUNASVERB = 0x4000007C,
        REST_NOTHUMBNAILCACHE = 0x4000007D,
        REST_NOSTRCMPLOGICAL = 0x4000007E,
        REST_NOPUBLISHWIZARD = 0x4000007F,
        REST_NOONLINEPRINTSWIZARD = 0x40000080,
        REST_NOWEBSERVICES = 0x40000081,
        REST_ALLOWUNHASHEDWEBVIEW = 0x40000082,
        REST_ALLOWLEGACYWEBVIEW = 0x40000083,
        REST_REVERTWEBVIEWSECURITY = 0x40000084,
        REST_INHERITCONSOLEHANDLES = 0x40000086,
        REST_NOREMOTERECURSIVEEVENTS = 0x40000089,
        REST_NOREMOTECHANGENOTIFY = 0x40000091,
        REST_NOENUMENTIRENETWORK = 0x40000093,
        REST_NOINTERNETOPENWITH = 0x40000095,
        REST_DONTRETRYBADNETNAME = 0x4000009B,
        REST_ALLOWFILECLSIDJUNCTIONS = 0x4000009C,
        REST_NOUPNPINSTALL = 0x4000009D,
        REST_ARP_DONTGROUPPATCHES = 0x400000AC,
        REST_ARP_NOCHOOSEPROGRAMSPAGE = 0x400000AD,
        REST_NODISCONNECT = 0x41000001,
        REST_NOSECURITY = 0x41000002,
        REST_NOFILEASSOCIATE = 0x41000003,
        REST_ALLOWCOMMENTTOGGLE = 0x41000004,
    }
}