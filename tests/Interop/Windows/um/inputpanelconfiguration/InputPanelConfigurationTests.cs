// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="InputPanelConfiguration" /> struct.</summary>
    public static unsafe class InputPanelConfigurationTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="InputPanelConfiguration" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(InputPanelConfiguration).GUID, Is.EqualTo(IID_InputPanelConfiguration));
        }

        /// <summary>Validates that the <see cref="InputPanelConfiguration" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<InputPanelConfiguration>(), Is.EqualTo(sizeof(InputPanelConfiguration)));
        }

        /// <summary>Validates that the <see cref="InputPanelConfiguration" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(InputPanelConfiguration).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="InputPanelConfiguration" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(InputPanelConfiguration), Is.EqualTo(1));
        }
    }
}