// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMCC : IComparable, IComparable<HIMCC>, IEquatable<HIMCC>, IFormattable
    {
        public readonly nint Value;

        public HIMCC(nint value)
        {
            Value = value;
        }

        public static HIMCC INVALID_VALUE => new HIMCC(-1);

        public static HIMCC NULL => new HIMCC(0);

        public static bool operator ==(HIMCC left, HIMCC right) => left.Value == right.Value;

        public static bool operator !=(HIMCC left, HIMCC right) => left.Value != right.Value;

        public static bool operator <(HIMCC left, HIMCC right) => left.Value < right.Value;

        public static bool operator <=(HIMCC left, HIMCC right) => left.Value <= right.Value;

        public static bool operator >(HIMCC left, HIMCC right) => left.Value > right.Value;

        public static bool operator >=(HIMCC left, HIMCC right) => left.Value >= right.Value;

        public static explicit operator HIMCC(void* value) => new HIMCC((nint)(value));

        public static implicit operator void*(HIMCC value) => (void*)(value.Value);

        public static explicit operator HIMCC(HANDLE value) => new HIMCC(value);

        public static implicit operator HANDLE(HIMCC value) => new HANDLE(value.Value);

        public static explicit operator HIMCC(byte value) => new HIMCC((nint)(value));

        public static explicit operator byte(HIMCC value) => (byte)(value.Value);

        public static explicit operator HIMCC(short value) => new HIMCC((nint)(value));

        public static explicit operator short(HIMCC value) => (short)(value.Value);

        public static explicit operator HIMCC(int value) => new HIMCC((nint)(value));

        public static explicit operator int(HIMCC value) => (int)(value.Value);

        public static explicit operator HIMCC(long value) => new HIMCC((nint)(value));

        public static implicit operator long(HIMCC value) => value.Value;

        public static explicit operator HIMCC(nint value) => new HIMCC((nint)(value));

        public static implicit operator nint(HIMCC value) => value.Value;

        public static explicit operator HIMCC(sbyte value) => new HIMCC((nint)(value));

        public static explicit operator sbyte(HIMCC value) => (sbyte)(value.Value);

        public static explicit operator HIMCC(ushort value) => new HIMCC((nint)(value));

        public static explicit operator ushort(HIMCC value) => (ushort)(value.Value);

        public static explicit operator HIMCC(uint value) => new HIMCC((nint)(value));

        public static explicit operator uint(HIMCC value) => (uint)(value.Value);

        public static explicit operator HIMCC(ulong value) => new HIMCC((nint)(value));

        public static explicit operator ulong(HIMCC value) => (ulong)(value.Value);

        public static explicit operator HIMCC(nuint value) => new HIMCC((nint)(value));

        public static explicit operator nuint(HIMCC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HIMCC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIMCC.");
        }

        public int CompareTo(HIMCC other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HIMCC other) && Equals(other);

        public bool Equals(HIMCC other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}