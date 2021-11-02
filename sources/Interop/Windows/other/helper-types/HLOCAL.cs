// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HLOCAL : IComparable, IComparable<HLOCAL>, IEquatable<HLOCAL>, IFormattable
    {
        public readonly nint Value;

        public HLOCAL(nint value)
        {
            Value = value;
        }

        public static HLOCAL INVALID_VALUE => new HLOCAL(-1);

        public static HLOCAL NULL => new HLOCAL(0);

        public static bool operator ==(HLOCAL left, HLOCAL right) => left.Value == right.Value;

        public static bool operator !=(HLOCAL left, HLOCAL right) => left.Value != right.Value;

        public static bool operator <(HLOCAL left, HLOCAL right) => left.Value < right.Value;

        public static bool operator <=(HLOCAL left, HLOCAL right) => left.Value <= right.Value;

        public static bool operator >(HLOCAL left, HLOCAL right) => left.Value > right.Value;

        public static bool operator >=(HLOCAL left, HLOCAL right) => left.Value >= right.Value;

        public static explicit operator HLOCAL(void* value) => new HLOCAL((nint)(value));

        public static implicit operator void*(HLOCAL value) => (void*)(value.Value);

        public static explicit operator HLOCAL(HANDLE value) => new HLOCAL(value);

        public static implicit operator HANDLE(HLOCAL value) => new HANDLE(value.Value);

        public static explicit operator HLOCAL(byte value) => new HLOCAL((nint)(value));

        public static explicit operator byte(HLOCAL value) => (byte)(value.Value);

        public static explicit operator HLOCAL(short value) => new HLOCAL((nint)(value));

        public static explicit operator short(HLOCAL value) => (short)(value.Value);

        public static explicit operator HLOCAL(int value) => new HLOCAL((nint)(value));

        public static explicit operator int(HLOCAL value) => (int)(value.Value);

        public static explicit operator HLOCAL(long value) => new HLOCAL((nint)(value));

        public static implicit operator long(HLOCAL value) => value.Value;

        public static explicit operator HLOCAL(nint value) => new HLOCAL((nint)(value));

        public static implicit operator nint(HLOCAL value) => value.Value;

        public static explicit operator HLOCAL(sbyte value) => new HLOCAL((nint)(value));

        public static explicit operator sbyte(HLOCAL value) => (sbyte)(value.Value);

        public static explicit operator HLOCAL(ushort value) => new HLOCAL((nint)(value));

        public static explicit operator ushort(HLOCAL value) => (ushort)(value.Value);

        public static explicit operator HLOCAL(uint value) => new HLOCAL((nint)(value));

        public static explicit operator uint(HLOCAL value) => (uint)(value.Value);

        public static explicit operator HLOCAL(ulong value) => new HLOCAL((nint)(value));

        public static explicit operator ulong(HLOCAL value) => (ulong)(value.Value);

        public static explicit operator HLOCAL(nuint value) => new HLOCAL((nint)(value));

        public static explicit operator nuint(HLOCAL value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HLOCAL other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HLOCAL.");
        }

        public int CompareTo(HLOCAL other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HLOCAL other) && Equals(other);

        public bool Equals(HLOCAL other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}