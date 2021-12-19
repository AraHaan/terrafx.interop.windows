// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D10EffectRenderTargetViewVariable" /> struct.</summary>
public static unsafe partial class ID3D10EffectRenderTargetViewVariableTests
{
    /// <summary>Validates that the <see cref="ID3D10EffectRenderTargetViewVariable" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D10EffectRenderTargetViewVariable>(), Is.EqualTo(sizeof(ID3D10EffectRenderTargetViewVariable)));
    }

    /// <summary>Validates that the <see cref="ID3D10EffectRenderTargetViewVariable" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D10EffectRenderTargetViewVariable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ID3D10EffectRenderTargetViewVariable" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D10EffectRenderTargetViewVariable), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D10EffectRenderTargetViewVariable), Is.EqualTo(4));
        }
    }
}
