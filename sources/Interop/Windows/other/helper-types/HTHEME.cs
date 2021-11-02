// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTHEME : IComparable, IComparable<HTHEME>, IEquatable<HTHEME>, IFormattable
    {
        public readonly nint Value;

        public HTHEME(nint value)
        {
            Value = value;
        }

        public static HTHEME INVALID_VALUE => new HTHEME(-1);

        public static HTHEME NULL => new HTHEME(0);

        public static bool operator ==(HTHEME left, HTHEME right) => left.Value == right.Value;

        public static bool operator !=(HTHEME left, HTHEME right) => left.Value != right.Value;

        public static bool operator <(HTHEME left, HTHEME right) => left.Value < right.Value;

        public static bool operator <=(HTHEME left, HTHEME right) => left.Value <= right.Value;

        public static bool operator >(HTHEME left, HTHEME right) => left.Value > right.Value;

        public static bool operator >=(HTHEME left, HTHEME right) => left.Value >= right.Value;

        public static explicit operator HTHEME(void* value) => new HTHEME((nint)(value));

        public static implicit operator void*(HTHEME value) => (void*)(value.Value);

        public static explicit operator HTHEME(HANDLE value) => new HTHEME(value);

        public static implicit operator HANDLE(HTHEME value) => new HANDLE(value.Value);

        public static explicit operator HTHEME(byte value) => new HTHEME((nint)(value));

        public static explicit operator byte(HTHEME value) => (byte)(value.Value);

        public static explicit operator HTHEME(short value) => new HTHEME((nint)(value));

        public static explicit operator short(HTHEME value) => (short)(value.Value);

        public static explicit operator HTHEME(int value) => new HTHEME((nint)(value));

        public static explicit operator int(HTHEME value) => (int)(value.Value);

        public static explicit operator HTHEME(long value) => new HTHEME((nint)(value));

        public static implicit operator long(HTHEME value) => value.Value;

        public static explicit operator HTHEME(nint value) => new HTHEME((nint)(value));

        public static implicit operator nint(HTHEME value) => value.Value;

        public static explicit operator HTHEME(sbyte value) => new HTHEME((nint)(value));

        public static explicit operator sbyte(HTHEME value) => (sbyte)(value.Value);

        public static explicit operator HTHEME(ushort value) => new HTHEME((nint)(value));

        public static explicit operator ushort(HTHEME value) => (ushort)(value.Value);

        public static explicit operator HTHEME(uint value) => new HTHEME((nint)(value));

        public static explicit operator uint(HTHEME value) => (uint)(value.Value);

        public static explicit operator HTHEME(ulong value) => new HTHEME((nint)(value));

        public static explicit operator ulong(HTHEME value) => (ulong)(value.Value);

        public static explicit operator HTHEME(nuint value) => new HTHEME((nint)(value));

        public static explicit operator nuint(HTHEME value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HTHEME other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTHEME.");
        }

        public int CompareTo(HTHEME other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HTHEME other) && Equals(other);

        public bool Equals(HTHEME other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}