// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBITMAP : IComparable, IComparable<HBITMAP>, IEquatable<HBITMAP>, IFormattable
    {
        public readonly nint Value;

        public HBITMAP(nint value)
        {
            Value = value;
        }

        public static HBITMAP INVALID_VALUE => new HBITMAP(-1);

        public static HBITMAP NULL => new HBITMAP(0);

        public static bool operator ==(HBITMAP left, HBITMAP right) => left.Value == right.Value;

        public static bool operator !=(HBITMAP left, HBITMAP right) => left.Value != right.Value;

        public static bool operator <(HBITMAP left, HBITMAP right) => left.Value < right.Value;

        public static bool operator <=(HBITMAP left, HBITMAP right) => left.Value <= right.Value;

        public static bool operator >(HBITMAP left, HBITMAP right) => left.Value > right.Value;

        public static bool operator >=(HBITMAP left, HBITMAP right) => left.Value >= right.Value;

        public static explicit operator HBITMAP(void* value) => new HBITMAP((nint)(value));

        public static implicit operator void*(HBITMAP value) => (void*)(value.Value);

        public static explicit operator HBITMAP(HANDLE value) => new HBITMAP(value);

        public static implicit operator HANDLE(HBITMAP value) => new HANDLE(value.Value);

        public static explicit operator HBITMAP(byte value) => new HBITMAP((nint)(value));

        public static explicit operator byte(HBITMAP value) => (byte)(value.Value);

        public static explicit operator HBITMAP(short value) => new HBITMAP((nint)(value));

        public static explicit operator short(HBITMAP value) => (short)(value.Value);

        public static explicit operator HBITMAP(int value) => new HBITMAP((nint)(value));

        public static explicit operator int(HBITMAP value) => (int)(value.Value);

        public static explicit operator HBITMAP(long value) => new HBITMAP((nint)(value));

        public static implicit operator long(HBITMAP value) => value.Value;

        public static explicit operator HBITMAP(nint value) => new HBITMAP((nint)(value));

        public static implicit operator nint(HBITMAP value) => value.Value;

        public static explicit operator HBITMAP(sbyte value) => new HBITMAP((nint)(value));

        public static explicit operator sbyte(HBITMAP value) => (sbyte)(value.Value);

        public static explicit operator HBITMAP(ushort value) => new HBITMAP((nint)(value));

        public static explicit operator ushort(HBITMAP value) => (ushort)(value.Value);

        public static explicit operator HBITMAP(uint value) => new HBITMAP((nint)(value));

        public static explicit operator uint(HBITMAP value) => (uint)(value.Value);

        public static explicit operator HBITMAP(ulong value) => new HBITMAP((nint)(value));

        public static explicit operator ulong(HBITMAP value) => (ulong)(value.Value);

        public static explicit operator HBITMAP(nuint value) => new HBITMAP((nint)(value));

        public static explicit operator nuint(HBITMAP value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HBITMAP other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBITMAP.");
        }

        public int CompareTo(HBITMAP other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HBITMAP other) && Equals(other);

        public bool Equals(HBITMAP other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}