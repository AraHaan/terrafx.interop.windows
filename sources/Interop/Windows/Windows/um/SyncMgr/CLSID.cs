// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_SyncMgrClient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0xDB, 0x02, 0x12,
                0xAC, 0x1D,
                0xC5, 0x42,
                0xAE,
                0xD5,
                0x1A,
                0xBD,
                0xD4,
                0x32,
                0x24,
                0x8E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SyncMgrControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0x42, 0x1F, 0x1A,
                0x88, 0x06,
                0x7F, 0x4E,
                0xBE,
                0x03,
                0xD8,
                0x2E,
                0xC6,
                0x9D,
                0xF9,
                0xA5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SyncMgrScheduleWizard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0x8E, 0x8B, 0x8D,
                0x51, 0xC4,
                0x1B, 0x42,
                0x85,
                0x53,
                0xD2,
                0x97,
                0x6A,
                0xFA,
                0x64,
                0x8C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SyncMgrFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0xF5, 0x73, 0x9C,
                0xE7, 0x7A,
                0x32, 0x4E,
                0xA8,
                0xE8,
                0x8D,
                0x23,
                0xB8,
                0x52,
                0x55,
                0xBF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SyncSetupFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC0, 0x59, 0x9E, 0x2E,
                0x37, 0xB4,
                0x81, 0x49,
                0xA6,
                0x47,
                0x9C,
                0x34,
                0xB9,
                0xB9,
                0x08,
                0x91
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ConflictFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0x78, 0x99, 0x28,
                0x01, 0xA1,
                0x41, 0x43,
                0xA8,
                0x17,
                0x21,
                0xEB,
                0xA7,
                0xFD,
                0x04,
                0x6D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SyncResultsFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0x94, 0xD9, 0x71,
                0x6B, 0x3B,
                0x5C, 0x47,
                0xB2,
                0x41,
                0xE1,
                0x58,
                0x83,
                0x20,
                0x75,
                0x29
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SimpleConflictPresenter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x6A, 0x0F, 0x7A,
                0x84, 0xED,
                0xB6, 0x46,
                0xB4,
                0x7E,
                0x02,
                0xAA,
                0x15,
                0x9A,
                0x15,
                0x2B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
