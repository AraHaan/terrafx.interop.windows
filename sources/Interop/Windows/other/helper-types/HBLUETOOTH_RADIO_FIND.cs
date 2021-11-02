// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBLUETOOTH_RADIO_FIND : IComparable, IComparable<HBLUETOOTH_RADIO_FIND>, IEquatable<HBLUETOOTH_RADIO_FIND>, IFormattable
    {
        public readonly nint Value;

        public HBLUETOOTH_RADIO_FIND(nint value)
        {
            Value = value;
        }

        public static HBLUETOOTH_RADIO_FIND INVALID_VALUE => new HBLUETOOTH_RADIO_FIND(-1);

        public static HBLUETOOTH_RADIO_FIND NULL => new HBLUETOOTH_RADIO_FIND(0);

        public static bool operator ==(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value == right.Value;

        public static bool operator !=(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value != right.Value;

        public static bool operator <(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value < right.Value;

        public static bool operator <=(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value <= right.Value;

        public static bool operator >(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value > right.Value;

        public static bool operator >=(HBLUETOOTH_RADIO_FIND left, HBLUETOOTH_RADIO_FIND right) => left.Value >= right.Value;

        public static explicit operator HBLUETOOTH_RADIO_FIND(void* value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static implicit operator void*(HBLUETOOTH_RADIO_FIND value) => (void*)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(HANDLE value) => new HBLUETOOTH_RADIO_FIND(value);

        public static implicit operator HANDLE(HBLUETOOTH_RADIO_FIND value) => new HANDLE(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(byte value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator byte(HBLUETOOTH_RADIO_FIND value) => (byte)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(short value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator short(HBLUETOOTH_RADIO_FIND value) => (short)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(int value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator int(HBLUETOOTH_RADIO_FIND value) => (int)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(long value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static implicit operator long(HBLUETOOTH_RADIO_FIND value) => value.Value;

        public static explicit operator HBLUETOOTH_RADIO_FIND(nint value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static implicit operator nint(HBLUETOOTH_RADIO_FIND value) => value.Value;

        public static explicit operator HBLUETOOTH_RADIO_FIND(sbyte value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator sbyte(HBLUETOOTH_RADIO_FIND value) => (sbyte)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(ushort value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator ushort(HBLUETOOTH_RADIO_FIND value) => (ushort)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(uint value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator uint(HBLUETOOTH_RADIO_FIND value) => (uint)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(ulong value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator ulong(HBLUETOOTH_RADIO_FIND value) => (ulong)(value.Value);

        public static explicit operator HBLUETOOTH_RADIO_FIND(nuint value) => new HBLUETOOTH_RADIO_FIND((nint)(value));

        public static explicit operator nuint(HBLUETOOTH_RADIO_FIND value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HBLUETOOTH_RADIO_FIND other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBLUETOOTH_RADIO_FIND.");
        }

        public int CompareTo(HBLUETOOTH_RADIO_FIND other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HBLUETOOTH_RADIO_FIND other) && Equals(other);

        public bool Equals(HBLUETOOTH_RADIO_FIND other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}