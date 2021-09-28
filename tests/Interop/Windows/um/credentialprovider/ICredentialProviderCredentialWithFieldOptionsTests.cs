// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICredentialProviderCredentialWithFieldOptions" /> struct.</summary>
    public static unsafe class ICredentialProviderCredentialWithFieldOptionsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICredentialProviderCredentialWithFieldOptions" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICredentialProviderCredentialWithFieldOptions).GUID, Is.EqualTo(IID_ICredentialProviderCredentialWithFieldOptions));
        }

        /// <summary>Validates that the <see cref="ICredentialProviderCredentialWithFieldOptions" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICredentialProviderCredentialWithFieldOptions>(), Is.EqualTo(sizeof(ICredentialProviderCredentialWithFieldOptions)));
        }

        /// <summary>Validates that the <see cref="ICredentialProviderCredentialWithFieldOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICredentialProviderCredentialWithFieldOptions).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICredentialProviderCredentialWithFieldOptions" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICredentialProviderCredentialWithFieldOptions), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICredentialProviderCredentialWithFieldOptions), Is.EqualTo(4));
            }
        }
    }
}