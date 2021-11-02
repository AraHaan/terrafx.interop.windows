// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVER : IComparable, IComparable<HACMDRIVER>, IEquatable<HACMDRIVER>, IFormattable
    {
        public readonly nint Value;

        public HACMDRIVER(nint value)
        {
            Value = value;
        }

        public static HACMDRIVER INVALID_VALUE => new HACMDRIVER(-1);

        public static HACMDRIVER NULL => new HACMDRIVER(0);

        public static bool operator ==(HACMDRIVER left, HACMDRIVER right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVER left, HACMDRIVER right) => left.Value != right.Value;

        public static bool operator <(HACMDRIVER left, HACMDRIVER right) => left.Value < right.Value;

        public static bool operator <=(HACMDRIVER left, HACMDRIVER right) => left.Value <= right.Value;

        public static bool operator >(HACMDRIVER left, HACMDRIVER right) => left.Value > right.Value;

        public static bool operator >=(HACMDRIVER left, HACMDRIVER right) => left.Value >= right.Value;

        public static explicit operator HACMDRIVER(void* value) => new HACMDRIVER((nint)(value));

        public static implicit operator void*(HACMDRIVER value) => (void*)(value.Value);

        public static explicit operator HACMDRIVER(HANDLE value) => new HACMDRIVER(value);

        public static implicit operator HANDLE(HACMDRIVER value) => new HANDLE(value.Value);

        public static explicit operator HACMDRIVER(byte value) => new HACMDRIVER((nint)(value));

        public static explicit operator byte(HACMDRIVER value) => (byte)(value.Value);

        public static explicit operator HACMDRIVER(short value) => new HACMDRIVER((nint)(value));

        public static explicit operator short(HACMDRIVER value) => (short)(value.Value);

        public static explicit operator HACMDRIVER(int value) => new HACMDRIVER((nint)(value));

        public static explicit operator int(HACMDRIVER value) => (int)(value.Value);

        public static explicit operator HACMDRIVER(long value) => new HACMDRIVER((nint)(value));

        public static implicit operator long(HACMDRIVER value) => value.Value;

        public static explicit operator HACMDRIVER(nint value) => new HACMDRIVER((nint)(value));

        public static implicit operator nint(HACMDRIVER value) => value.Value;

        public static explicit operator HACMDRIVER(sbyte value) => new HACMDRIVER((nint)(value));

        public static explicit operator sbyte(HACMDRIVER value) => (sbyte)(value.Value);

        public static explicit operator HACMDRIVER(ushort value) => new HACMDRIVER((nint)(value));

        public static explicit operator ushort(HACMDRIVER value) => (ushort)(value.Value);

        public static explicit operator HACMDRIVER(uint value) => new HACMDRIVER((nint)(value));

        public static explicit operator uint(HACMDRIVER value) => (uint)(value.Value);

        public static explicit operator HACMDRIVER(ulong value) => new HACMDRIVER((nint)(value));

        public static explicit operator ulong(HACMDRIVER value) => (ulong)(value.Value);

        public static explicit operator HACMDRIVER(nuint value) => new HACMDRIVER((nint)(value));

        public static explicit operator nuint(HACMDRIVER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HACMDRIVER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HACMDRIVER.");
        }

        public int CompareTo(HACMDRIVER other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVER other) && Equals(other);

        public bool Equals(HACMDRIVER other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}