// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIATEXTRANGE : IComparable, IComparable<HUIATEXTRANGE>, IEquatable<HUIATEXTRANGE>, IFormattable
    {
        public readonly nint Value;

        public HUIATEXTRANGE(nint value)
        {
            Value = value;
        }

        public static HUIATEXTRANGE INVALID_VALUE => new HUIATEXTRANGE(-1);

        public static HUIATEXTRANGE NULL => new HUIATEXTRANGE(0);

        public static bool operator ==(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value == right.Value;

        public static bool operator !=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value != right.Value;

        public static bool operator <(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value < right.Value;

        public static bool operator <=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value <= right.Value;

        public static bool operator >(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value > right.Value;

        public static bool operator >=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value >= right.Value;

        public static explicit operator HUIATEXTRANGE(void* value) => new HUIATEXTRANGE((nint)(value));

        public static implicit operator void*(HUIATEXTRANGE value) => (void*)(value.Value);

        public static explicit operator HUIATEXTRANGE(HANDLE value) => new HUIATEXTRANGE(value);

        public static implicit operator HANDLE(HUIATEXTRANGE value) => new HANDLE(value.Value);

        public static explicit operator HUIATEXTRANGE(byte value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator byte(HUIATEXTRANGE value) => (byte)(value.Value);

        public static explicit operator HUIATEXTRANGE(short value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator short(HUIATEXTRANGE value) => (short)(value.Value);

        public static explicit operator HUIATEXTRANGE(int value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator int(HUIATEXTRANGE value) => (int)(value.Value);

        public static explicit operator HUIATEXTRANGE(long value) => new HUIATEXTRANGE((nint)(value));

        public static implicit operator long(HUIATEXTRANGE value) => value.Value;

        public static explicit operator HUIATEXTRANGE(nint value) => new HUIATEXTRANGE((nint)(value));

        public static implicit operator nint(HUIATEXTRANGE value) => value.Value;

        public static explicit operator HUIATEXTRANGE(sbyte value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator sbyte(HUIATEXTRANGE value) => (sbyte)(value.Value);

        public static explicit operator HUIATEXTRANGE(ushort value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator ushort(HUIATEXTRANGE value) => (ushort)(value.Value);

        public static explicit operator HUIATEXTRANGE(uint value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator uint(HUIATEXTRANGE value) => (uint)(value.Value);

        public static explicit operator HUIATEXTRANGE(ulong value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator ulong(HUIATEXTRANGE value) => (ulong)(value.Value);

        public static explicit operator HUIATEXTRANGE(nuint value) => new HUIATEXTRANGE((nint)(value));

        public static explicit operator nuint(HUIATEXTRANGE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUIATEXTRANGE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUIATEXTRANGE.");
        }

        public int CompareTo(HUIATEXTRANGE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HUIATEXTRANGE other) && Equals(other);

        public bool Equals(HUIATEXTRANGE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}