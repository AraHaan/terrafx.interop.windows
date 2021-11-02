// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTHASH : IComparable, IComparable<HCRYPTHASH>, IEquatable<HCRYPTHASH>, IFormattable
    {
        public readonly nint Value;

        public HCRYPTHASH(nint value)
        {
            Value = value;
        }

        public static HCRYPTHASH INVALID_VALUE => new HCRYPTHASH(-1);

        public static HCRYPTHASH NULL => new HCRYPTHASH(0);

        public static bool operator ==(HCRYPTHASH left, HCRYPTHASH right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTHASH left, HCRYPTHASH right) => left.Value != right.Value;

        public static bool operator <(HCRYPTHASH left, HCRYPTHASH right) => left.Value < right.Value;

        public static bool operator <=(HCRYPTHASH left, HCRYPTHASH right) => left.Value <= right.Value;

        public static bool operator >(HCRYPTHASH left, HCRYPTHASH right) => left.Value > right.Value;

        public static bool operator >=(HCRYPTHASH left, HCRYPTHASH right) => left.Value >= right.Value;

        public static explicit operator HCRYPTHASH(void* value) => new HCRYPTHASH((nint)(value));

        public static implicit operator void*(HCRYPTHASH value) => (void*)(value.Value);

        public static explicit operator HCRYPTHASH(HANDLE value) => new HCRYPTHASH(value);

        public static implicit operator HANDLE(HCRYPTHASH value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTHASH(byte value) => new HCRYPTHASH((nint)(value));

        public static explicit operator byte(HCRYPTHASH value) => (byte)(value.Value);

        public static explicit operator HCRYPTHASH(short value) => new HCRYPTHASH((nint)(value));

        public static explicit operator short(HCRYPTHASH value) => (short)(value.Value);

        public static explicit operator HCRYPTHASH(int value) => new HCRYPTHASH((nint)(value));

        public static explicit operator int(HCRYPTHASH value) => (int)(value.Value);

        public static explicit operator HCRYPTHASH(long value) => new HCRYPTHASH((nint)(value));

        public static implicit operator long(HCRYPTHASH value) => value.Value;

        public static explicit operator HCRYPTHASH(nint value) => new HCRYPTHASH((nint)(value));

        public static implicit operator nint(HCRYPTHASH value) => value.Value;

        public static explicit operator HCRYPTHASH(sbyte value) => new HCRYPTHASH((nint)(value));

        public static explicit operator sbyte(HCRYPTHASH value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTHASH(ushort value) => new HCRYPTHASH((nint)(value));

        public static explicit operator ushort(HCRYPTHASH value) => (ushort)(value.Value);

        public static explicit operator HCRYPTHASH(uint value) => new HCRYPTHASH((nint)(value));

        public static explicit operator uint(HCRYPTHASH value) => (uint)(value.Value);

        public static explicit operator HCRYPTHASH(ulong value) => new HCRYPTHASH((nint)(value));

        public static explicit operator ulong(HCRYPTHASH value) => (ulong)(value.Value);

        public static explicit operator HCRYPTHASH(nuint value) => new HCRYPTHASH((nint)(value));

        public static explicit operator nuint(HCRYPTHASH value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCRYPTHASH other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCRYPTHASH.");
        }

        public int CompareTo(HCRYPTHASH other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTHASH other) && Equals(other);

        public bool Equals(HCRYPTHASH other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}