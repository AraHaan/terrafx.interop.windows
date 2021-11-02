// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPRITE : IComparable, IComparable<HSPRITE>, IEquatable<HSPRITE>, IFormattable
    {
        public readonly nint Value;

        public HSPRITE(nint value)
        {
            Value = value;
        }

        public static HSPRITE INVALID_VALUE => new HSPRITE(-1);

        public static HSPRITE NULL => new HSPRITE(0);

        public static bool operator ==(HSPRITE left, HSPRITE right) => left.Value == right.Value;

        public static bool operator !=(HSPRITE left, HSPRITE right) => left.Value != right.Value;

        public static bool operator <(HSPRITE left, HSPRITE right) => left.Value < right.Value;

        public static bool operator <=(HSPRITE left, HSPRITE right) => left.Value <= right.Value;

        public static bool operator >(HSPRITE left, HSPRITE right) => left.Value > right.Value;

        public static bool operator >=(HSPRITE left, HSPRITE right) => left.Value >= right.Value;

        public static explicit operator HSPRITE(void* value) => new HSPRITE((nint)(value));

        public static implicit operator void*(HSPRITE value) => (void*)(value.Value);

        public static explicit operator HSPRITE(HANDLE value) => new HSPRITE(value);

        public static implicit operator HANDLE(HSPRITE value) => new HANDLE(value.Value);

        public static explicit operator HSPRITE(byte value) => new HSPRITE((nint)(value));

        public static explicit operator byte(HSPRITE value) => (byte)(value.Value);

        public static explicit operator HSPRITE(short value) => new HSPRITE((nint)(value));

        public static explicit operator short(HSPRITE value) => (short)(value.Value);

        public static explicit operator HSPRITE(int value) => new HSPRITE((nint)(value));

        public static explicit operator int(HSPRITE value) => (int)(value.Value);

        public static explicit operator HSPRITE(long value) => new HSPRITE((nint)(value));

        public static implicit operator long(HSPRITE value) => value.Value;

        public static explicit operator HSPRITE(nint value) => new HSPRITE((nint)(value));

        public static implicit operator nint(HSPRITE value) => value.Value;

        public static explicit operator HSPRITE(sbyte value) => new HSPRITE((nint)(value));

        public static explicit operator sbyte(HSPRITE value) => (sbyte)(value.Value);

        public static explicit operator HSPRITE(ushort value) => new HSPRITE((nint)(value));

        public static explicit operator ushort(HSPRITE value) => (ushort)(value.Value);

        public static explicit operator HSPRITE(uint value) => new HSPRITE((nint)(value));

        public static explicit operator uint(HSPRITE value) => (uint)(value.Value);

        public static explicit operator HSPRITE(ulong value) => new HSPRITE((nint)(value));

        public static explicit operator ulong(HSPRITE value) => (ulong)(value.Value);

        public static explicit operator HSPRITE(nuint value) => new HSPRITE((nint)(value));

        public static explicit operator nuint(HSPRITE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSPRITE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSPRITE.");
        }

        public int CompareTo(HSPRITE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSPRITE other) && Equals(other);

        public bool Equals(HSPRITE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}