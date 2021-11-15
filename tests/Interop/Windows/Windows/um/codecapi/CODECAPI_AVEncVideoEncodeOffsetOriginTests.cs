// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncVideoEncodeOffsetOrigin" /> struct.</summary>
    public static unsafe partial class CODECAPI_AVEncVideoEncodeOffsetOriginTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncVideoEncodeOffsetOrigin" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoEncodeOffsetOrigin).GUID, Is.EqualTo(IID_CODECAPI_AVEncVideoEncodeOffsetOrigin));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoEncodeOffsetOrigin" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncVideoEncodeOffsetOrigin>(), Is.EqualTo(sizeof(CODECAPI_AVEncVideoEncodeOffsetOrigin)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoEncodeOffsetOrigin" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoEncodeOffsetOrigin).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoEncodeOffsetOrigin" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncVideoEncodeOffsetOrigin), Is.EqualTo(1));
        }
    }
}