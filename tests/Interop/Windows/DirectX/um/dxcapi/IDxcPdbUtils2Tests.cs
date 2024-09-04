// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcPdbUtils2" /> struct.</summary>
public static unsafe partial class IDxcPdbUtils2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcPdbUtils2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcPdbUtils2).GUID, Is.EqualTo(IID_IDxcPdbUtils2));
    }
}