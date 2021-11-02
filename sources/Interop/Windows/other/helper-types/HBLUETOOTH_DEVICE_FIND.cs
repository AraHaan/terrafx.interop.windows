// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBLUETOOTH_DEVICE_FIND : IComparable, IComparable<HBLUETOOTH_DEVICE_FIND>, IEquatable<HBLUETOOTH_DEVICE_FIND>, IFormattable
    {
        public readonly nint Value;

        public HBLUETOOTH_DEVICE_FIND(nint value)
        {
            Value = value;
        }

        public static HBLUETOOTH_DEVICE_FIND INVALID_VALUE => new HBLUETOOTH_DEVICE_FIND(-1);

        public static HBLUETOOTH_DEVICE_FIND NULL => new HBLUETOOTH_DEVICE_FIND(0);

        public static bool operator ==(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value == right.Value;

        public static bool operator !=(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value != right.Value;

        public static bool operator <(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value < right.Value;

        public static bool operator <=(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value <= right.Value;

        public static bool operator >(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value > right.Value;

        public static bool operator >=(HBLUETOOTH_DEVICE_FIND left, HBLUETOOTH_DEVICE_FIND right) => left.Value >= right.Value;

        public static explicit operator HBLUETOOTH_DEVICE_FIND(void* value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static implicit operator void*(HBLUETOOTH_DEVICE_FIND value) => (void*)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(HANDLE value) => new HBLUETOOTH_DEVICE_FIND(value);

        public static implicit operator HANDLE(HBLUETOOTH_DEVICE_FIND value) => new HANDLE(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(byte value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator byte(HBLUETOOTH_DEVICE_FIND value) => (byte)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(short value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator short(HBLUETOOTH_DEVICE_FIND value) => (short)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(int value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator int(HBLUETOOTH_DEVICE_FIND value) => (int)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(long value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static implicit operator long(HBLUETOOTH_DEVICE_FIND value) => value.Value;

        public static explicit operator HBLUETOOTH_DEVICE_FIND(nint value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static implicit operator nint(HBLUETOOTH_DEVICE_FIND value) => value.Value;

        public static explicit operator HBLUETOOTH_DEVICE_FIND(sbyte value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator sbyte(HBLUETOOTH_DEVICE_FIND value) => (sbyte)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(ushort value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator ushort(HBLUETOOTH_DEVICE_FIND value) => (ushort)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(uint value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator uint(HBLUETOOTH_DEVICE_FIND value) => (uint)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(ulong value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator ulong(HBLUETOOTH_DEVICE_FIND value) => (ulong)(value.Value);

        public static explicit operator HBLUETOOTH_DEVICE_FIND(nuint value) => new HBLUETOOTH_DEVICE_FIND((nint)(value));

        public static explicit operator nuint(HBLUETOOTH_DEVICE_FIND value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HBLUETOOTH_DEVICE_FIND other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBLUETOOTH_DEVICE_FIND.");
        }

        public int CompareTo(HBLUETOOTH_DEVICE_FIND other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HBLUETOOTH_DEVICE_FIND other) && Equals(other);

        public bool Equals(HBLUETOOTH_DEVICE_FIND other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}