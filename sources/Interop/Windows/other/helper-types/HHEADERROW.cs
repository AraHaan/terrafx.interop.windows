// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHEADERROW : IComparable, IComparable<HHEADERROW>, IEquatable<HHEADERROW>, IFormattable
    {
        public readonly nint Value;

        public HHEADERROW(nint value)
        {
            Value = value;
        }

        public static HHEADERROW INVALID_VALUE => new HHEADERROW(-1);

        public static HHEADERROW NULL => new HHEADERROW(0);

        public static bool operator ==(HHEADERROW left, HHEADERROW right) => left.Value == right.Value;

        public static bool operator !=(HHEADERROW left, HHEADERROW right) => left.Value != right.Value;

        public static bool operator <(HHEADERROW left, HHEADERROW right) => left.Value < right.Value;

        public static bool operator <=(HHEADERROW left, HHEADERROW right) => left.Value <= right.Value;

        public static bool operator >(HHEADERROW left, HHEADERROW right) => left.Value > right.Value;

        public static bool operator >=(HHEADERROW left, HHEADERROW right) => left.Value >= right.Value;

        public static explicit operator HHEADERROW(void* value) => new HHEADERROW((nint)(value));

        public static implicit operator void*(HHEADERROW value) => (void*)(value.Value);

        public static explicit operator HHEADERROW(HANDLE value) => new HHEADERROW(value);

        public static implicit operator HANDLE(HHEADERROW value) => new HANDLE(value.Value);

        public static explicit operator HHEADERROW(byte value) => new HHEADERROW((nint)(value));

        public static explicit operator byte(HHEADERROW value) => (byte)(value.Value);

        public static explicit operator HHEADERROW(short value) => new HHEADERROW((nint)(value));

        public static explicit operator short(HHEADERROW value) => (short)(value.Value);

        public static explicit operator HHEADERROW(int value) => new HHEADERROW((nint)(value));

        public static explicit operator int(HHEADERROW value) => (int)(value.Value);

        public static explicit operator HHEADERROW(long value) => new HHEADERROW((nint)(value));

        public static implicit operator long(HHEADERROW value) => value.Value;

        public static explicit operator HHEADERROW(nint value) => new HHEADERROW((nint)(value));

        public static implicit operator nint(HHEADERROW value) => value.Value;

        public static explicit operator HHEADERROW(sbyte value) => new HHEADERROW((nint)(value));

        public static explicit operator sbyte(HHEADERROW value) => (sbyte)(value.Value);

        public static explicit operator HHEADERROW(ushort value) => new HHEADERROW((nint)(value));

        public static explicit operator ushort(HHEADERROW value) => (ushort)(value.Value);

        public static explicit operator HHEADERROW(uint value) => new HHEADERROW((nint)(value));

        public static explicit operator uint(HHEADERROW value) => (uint)(value.Value);

        public static explicit operator HHEADERROW(ulong value) => new HHEADERROW((nint)(value));

        public static explicit operator ulong(HHEADERROW value) => (ulong)(value.Value);

        public static explicit operator HHEADERROW(nuint value) => new HHEADERROW((nint)(value));

        public static explicit operator nuint(HHEADERROW value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HHEADERROW other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HHEADERROW.");
        }

        public int CompareTo(HHEADERROW other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HHEADERROW other) && Equals(other);

        public bool Equals(HHEADERROW other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}