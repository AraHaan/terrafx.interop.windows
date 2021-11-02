// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPALETTE : IComparable, IComparable<HPALETTE>, IEquatable<HPALETTE>, IFormattable
    {
        public readonly nint Value;

        public HPALETTE(nint value)
        {
            Value = value;
        }

        public static HPALETTE INVALID_VALUE => new HPALETTE(-1);

        public static HPALETTE NULL => new HPALETTE(0);

        public static bool operator ==(HPALETTE left, HPALETTE right) => left.Value == right.Value;

        public static bool operator !=(HPALETTE left, HPALETTE right) => left.Value != right.Value;

        public static bool operator <(HPALETTE left, HPALETTE right) => left.Value < right.Value;

        public static bool operator <=(HPALETTE left, HPALETTE right) => left.Value <= right.Value;

        public static bool operator >(HPALETTE left, HPALETTE right) => left.Value > right.Value;

        public static bool operator >=(HPALETTE left, HPALETTE right) => left.Value >= right.Value;

        public static explicit operator HPALETTE(void* value) => new HPALETTE((nint)(value));

        public static implicit operator void*(HPALETTE value) => (void*)(value.Value);

        public static explicit operator HPALETTE(HANDLE value) => new HPALETTE(value);

        public static implicit operator HANDLE(HPALETTE value) => new HANDLE(value.Value);

        public static explicit operator HPALETTE(byte value) => new HPALETTE((nint)(value));

        public static explicit operator byte(HPALETTE value) => (byte)(value.Value);

        public static explicit operator HPALETTE(short value) => new HPALETTE((nint)(value));

        public static explicit operator short(HPALETTE value) => (short)(value.Value);

        public static explicit operator HPALETTE(int value) => new HPALETTE((nint)(value));

        public static explicit operator int(HPALETTE value) => (int)(value.Value);

        public static explicit operator HPALETTE(long value) => new HPALETTE((nint)(value));

        public static implicit operator long(HPALETTE value) => value.Value;

        public static explicit operator HPALETTE(nint value) => new HPALETTE((nint)(value));

        public static implicit operator nint(HPALETTE value) => value.Value;

        public static explicit operator HPALETTE(sbyte value) => new HPALETTE((nint)(value));

        public static explicit operator sbyte(HPALETTE value) => (sbyte)(value.Value);

        public static explicit operator HPALETTE(ushort value) => new HPALETTE((nint)(value));

        public static explicit operator ushort(HPALETTE value) => (ushort)(value.Value);

        public static explicit operator HPALETTE(uint value) => new HPALETTE((nint)(value));

        public static explicit operator uint(HPALETTE value) => (uint)(value.Value);

        public static explicit operator HPALETTE(ulong value) => new HPALETTE((nint)(value));

        public static explicit operator ulong(HPALETTE value) => (ulong)(value.Value);

        public static explicit operator HPALETTE(nuint value) => new HPALETTE((nint)(value));

        public static explicit operator nuint(HPALETTE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HPALETTE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPALETTE.");
        }

        public int CompareTo(HPALETTE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HPALETTE other) && Equals(other);

        public bool Equals(HPALETTE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}