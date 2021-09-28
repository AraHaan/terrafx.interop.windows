// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumSyncMgrEvents" /> struct.</summary>
    public static unsafe class IEnumSyncMgrEventsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumSyncMgrEvents" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumSyncMgrEvents).GUID, Is.EqualTo(IID_IEnumSyncMgrEvents));
        }

        /// <summary>Validates that the <see cref="IEnumSyncMgrEvents" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IEnumSyncMgrEvents>(), Is.EqualTo(sizeof(IEnumSyncMgrEvents)));
        }

        /// <summary>Validates that the <see cref="IEnumSyncMgrEvents" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumSyncMgrEvents).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IEnumSyncMgrEvents" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IEnumSyncMgrEvents), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IEnumSyncMgrEvents), Is.EqualTo(4));
            }
        }
    }
}