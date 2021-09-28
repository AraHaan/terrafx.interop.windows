// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFileOpenDialog" /> struct.</summary>
    public static unsafe class IFileOpenDialogTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFileOpenDialog" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFileOpenDialog).GUID, Is.EqualTo(IID_IFileOpenDialog));
        }

        /// <summary>Validates that the <see cref="IFileOpenDialog" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFileOpenDialog>(), Is.EqualTo(sizeof(IFileOpenDialog)));
        }

        /// <summary>Validates that the <see cref="IFileOpenDialog" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFileOpenDialog).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFileOpenDialog" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFileOpenDialog), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFileOpenDialog), Is.EqualTo(4));
            }
        }
    }
}