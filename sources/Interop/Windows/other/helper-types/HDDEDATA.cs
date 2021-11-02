// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDDEDATA : IComparable, IComparable<HDDEDATA>, IEquatable<HDDEDATA>, IFormattable
    {
        public readonly nint Value;

        public HDDEDATA(nint value)
        {
            Value = value;
        }

        public static HDDEDATA INVALID_VALUE => new HDDEDATA(-1);

        public static HDDEDATA NULL => new HDDEDATA(0);

        public static bool operator ==(HDDEDATA left, HDDEDATA right) => left.Value == right.Value;

        public static bool operator !=(HDDEDATA left, HDDEDATA right) => left.Value != right.Value;

        public static bool operator <(HDDEDATA left, HDDEDATA right) => left.Value < right.Value;

        public static bool operator <=(HDDEDATA left, HDDEDATA right) => left.Value <= right.Value;

        public static bool operator >(HDDEDATA left, HDDEDATA right) => left.Value > right.Value;

        public static bool operator >=(HDDEDATA left, HDDEDATA right) => left.Value >= right.Value;

        public static explicit operator HDDEDATA(void* value) => new HDDEDATA((nint)(value));

        public static implicit operator void*(HDDEDATA value) => (void*)(value.Value);

        public static explicit operator HDDEDATA(HANDLE value) => new HDDEDATA(value);

        public static implicit operator HANDLE(HDDEDATA value) => new HANDLE(value.Value);

        public static explicit operator HDDEDATA(byte value) => new HDDEDATA((nint)(value));

        public static explicit operator byte(HDDEDATA value) => (byte)(value.Value);

        public static explicit operator HDDEDATA(short value) => new HDDEDATA((nint)(value));

        public static explicit operator short(HDDEDATA value) => (short)(value.Value);

        public static explicit operator HDDEDATA(int value) => new HDDEDATA((nint)(value));

        public static explicit operator int(HDDEDATA value) => (int)(value.Value);

        public static explicit operator HDDEDATA(long value) => new HDDEDATA((nint)(value));

        public static implicit operator long(HDDEDATA value) => value.Value;

        public static explicit operator HDDEDATA(nint value) => new HDDEDATA((nint)(value));

        public static implicit operator nint(HDDEDATA value) => value.Value;

        public static explicit operator HDDEDATA(sbyte value) => new HDDEDATA((nint)(value));

        public static explicit operator sbyte(HDDEDATA value) => (sbyte)(value.Value);

        public static explicit operator HDDEDATA(ushort value) => new HDDEDATA((nint)(value));

        public static explicit operator ushort(HDDEDATA value) => (ushort)(value.Value);

        public static explicit operator HDDEDATA(uint value) => new HDDEDATA((nint)(value));

        public static explicit operator uint(HDDEDATA value) => (uint)(value.Value);

        public static explicit operator HDDEDATA(ulong value) => new HDDEDATA((nint)(value));

        public static explicit operator ulong(HDDEDATA value) => (ulong)(value.Value);

        public static explicit operator HDDEDATA(nuint value) => new HDDEDATA((nint)(value));

        public static explicit operator nuint(HDDEDATA value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDDEDATA other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDDEDATA.");
        }

        public int CompareTo(HDDEDATA other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDDEDATA other) && Equals(other);

        public bool Equals(HDDEDATA other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}