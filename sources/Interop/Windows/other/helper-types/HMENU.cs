// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMENU : IComparable, IComparable<HMENU>, IEquatable<HMENU>, IFormattable
    {
        public readonly nint Value;

        public HMENU(nint value)
        {
            Value = value;
        }

        public static HMENU INVALID_VALUE => new HMENU(-1);

        public static HMENU NULL => new HMENU(0);

        public static bool operator ==(HMENU left, HMENU right) => left.Value == right.Value;

        public static bool operator !=(HMENU left, HMENU right) => left.Value != right.Value;

        public static bool operator <(HMENU left, HMENU right) => left.Value < right.Value;

        public static bool operator <=(HMENU left, HMENU right) => left.Value <= right.Value;

        public static bool operator >(HMENU left, HMENU right) => left.Value > right.Value;

        public static bool operator >=(HMENU left, HMENU right) => left.Value >= right.Value;

        public static explicit operator HMENU(void* value) => new HMENU((nint)(value));

        public static implicit operator void*(HMENU value) => (void*)(value.Value);

        public static explicit operator HMENU(HANDLE value) => new HMENU(value);

        public static implicit operator HANDLE(HMENU value) => new HANDLE(value.Value);

        public static explicit operator HMENU(byte value) => new HMENU((nint)(value));

        public static explicit operator byte(HMENU value) => (byte)(value.Value);

        public static explicit operator HMENU(short value) => new HMENU((nint)(value));

        public static explicit operator short(HMENU value) => (short)(value.Value);

        public static explicit operator HMENU(int value) => new HMENU((nint)(value));

        public static explicit operator int(HMENU value) => (int)(value.Value);

        public static explicit operator HMENU(long value) => new HMENU((nint)(value));

        public static implicit operator long(HMENU value) => value.Value;

        public static explicit operator HMENU(nint value) => new HMENU((nint)(value));

        public static implicit operator nint(HMENU value) => value.Value;

        public static explicit operator HMENU(sbyte value) => new HMENU((nint)(value));

        public static explicit operator sbyte(HMENU value) => (sbyte)(value.Value);

        public static explicit operator HMENU(ushort value) => new HMENU((nint)(value));

        public static explicit operator ushort(HMENU value) => (ushort)(value.Value);

        public static explicit operator HMENU(uint value) => new HMENU((nint)(value));

        public static explicit operator uint(HMENU value) => (uint)(value.Value);

        public static explicit operator HMENU(ulong value) => new HMENU((nint)(value));

        public static explicit operator ulong(HMENU value) => (ulong)(value.Value);

        public static explicit operator HMENU(nuint value) => new HMENU((nint)(value));

        public static explicit operator nuint(HMENU value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMENU other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMENU.");
        }

        public int CompareTo(HMENU other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HMENU other) && Equals(other);

        public bool Equals(HMENU other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}