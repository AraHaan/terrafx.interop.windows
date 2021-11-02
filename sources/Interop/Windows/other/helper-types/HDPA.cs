// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDPA : IComparable, IComparable<HDPA>, IEquatable<HDPA>, IFormattable
    {
        public readonly nint Value;

        public HDPA(nint value)
        {
            Value = value;
        }

        public static HDPA INVALID_VALUE => new HDPA(-1);

        public static HDPA NULL => new HDPA(0);

        public static bool operator ==(HDPA left, HDPA right) => left.Value == right.Value;

        public static bool operator !=(HDPA left, HDPA right) => left.Value != right.Value;

        public static bool operator <(HDPA left, HDPA right) => left.Value < right.Value;

        public static bool operator <=(HDPA left, HDPA right) => left.Value <= right.Value;

        public static bool operator >(HDPA left, HDPA right) => left.Value > right.Value;

        public static bool operator >=(HDPA left, HDPA right) => left.Value >= right.Value;

        public static explicit operator HDPA(void* value) => new HDPA((nint)(value));

        public static implicit operator void*(HDPA value) => (void*)(value.Value);

        public static explicit operator HDPA(HANDLE value) => new HDPA(value);

        public static implicit operator HANDLE(HDPA value) => new HANDLE(value.Value);

        public static explicit operator HDPA(byte value) => new HDPA((nint)(value));

        public static explicit operator byte(HDPA value) => (byte)(value.Value);

        public static explicit operator HDPA(short value) => new HDPA((nint)(value));

        public static explicit operator short(HDPA value) => (short)(value.Value);

        public static explicit operator HDPA(int value) => new HDPA((nint)(value));

        public static explicit operator int(HDPA value) => (int)(value.Value);

        public static explicit operator HDPA(long value) => new HDPA((nint)(value));

        public static implicit operator long(HDPA value) => value.Value;

        public static explicit operator HDPA(nint value) => new HDPA((nint)(value));

        public static implicit operator nint(HDPA value) => value.Value;

        public static explicit operator HDPA(sbyte value) => new HDPA((nint)(value));

        public static explicit operator sbyte(HDPA value) => (sbyte)(value.Value);

        public static explicit operator HDPA(ushort value) => new HDPA((nint)(value));

        public static explicit operator ushort(HDPA value) => (ushort)(value.Value);

        public static explicit operator HDPA(uint value) => new HDPA((nint)(value));

        public static explicit operator uint(HDPA value) => (uint)(value.Value);

        public static explicit operator HDPA(ulong value) => new HDPA((nint)(value));

        public static explicit operator ulong(HDPA value) => (ulong)(value.Value);

        public static explicit operator HDPA(nuint value) => new HDPA((nint)(value));

        public static explicit operator nuint(HDPA value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDPA other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDPA.");
        }

        public int CompareTo(HDPA other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDPA other) && Equals(other);

        public bool Equals(HDPA other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}