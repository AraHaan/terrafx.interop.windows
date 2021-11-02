// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPCON : IComparable, IComparable<HPCON>, IEquatable<HPCON>, IFormattable
    {
        public readonly nint Value;

        public HPCON(nint value)
        {
            Value = value;
        }

        public static HPCON INVALID_VALUE => new HPCON(-1);

        public static HPCON NULL => new HPCON(0);

        public static bool operator ==(HPCON left, HPCON right) => left.Value == right.Value;

        public static bool operator !=(HPCON left, HPCON right) => left.Value != right.Value;

        public static bool operator <(HPCON left, HPCON right) => left.Value < right.Value;

        public static bool operator <=(HPCON left, HPCON right) => left.Value <= right.Value;

        public static bool operator >(HPCON left, HPCON right) => left.Value > right.Value;

        public static bool operator >=(HPCON left, HPCON right) => left.Value >= right.Value;

        public static explicit operator HPCON(void* value) => new HPCON((nint)(value));

        public static implicit operator void*(HPCON value) => (void*)(value.Value);

        public static explicit operator HPCON(HANDLE value) => new HPCON(value);

        public static implicit operator HANDLE(HPCON value) => new HANDLE(value.Value);

        public static explicit operator HPCON(byte value) => new HPCON((nint)(value));

        public static explicit operator byte(HPCON value) => (byte)(value.Value);

        public static explicit operator HPCON(short value) => new HPCON((nint)(value));

        public static explicit operator short(HPCON value) => (short)(value.Value);

        public static explicit operator HPCON(int value) => new HPCON((nint)(value));

        public static explicit operator int(HPCON value) => (int)(value.Value);

        public static explicit operator HPCON(long value) => new HPCON((nint)(value));

        public static implicit operator long(HPCON value) => value.Value;

        public static explicit operator HPCON(nint value) => new HPCON((nint)(value));

        public static implicit operator nint(HPCON value) => value.Value;

        public static explicit operator HPCON(sbyte value) => new HPCON((nint)(value));

        public static explicit operator sbyte(HPCON value) => (sbyte)(value.Value);

        public static explicit operator HPCON(ushort value) => new HPCON((nint)(value));

        public static explicit operator ushort(HPCON value) => (ushort)(value.Value);

        public static explicit operator HPCON(uint value) => new HPCON((nint)(value));

        public static explicit operator uint(HPCON value) => (uint)(value.Value);

        public static explicit operator HPCON(ulong value) => new HPCON((nint)(value));

        public static explicit operator ulong(HPCON value) => (ulong)(value.Value);

        public static explicit operator HPCON(nuint value) => new HPCON((nint)(value));

        public static explicit operator nuint(HPCON value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HPCON other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPCON.");
        }

        public int CompareTo(HPCON other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HPCON other) && Equals(other);

        public bool Equals(HPCON other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}