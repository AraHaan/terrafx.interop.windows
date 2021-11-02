// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVERID : IComparable, IComparable<HACMDRIVERID>, IEquatable<HACMDRIVERID>, IFormattable
    {
        public readonly nint Value;

        public HACMDRIVERID(nint value)
        {
            Value = value;
        }

        public static HACMDRIVERID INVALID_VALUE => new HACMDRIVERID(-1);

        public static HACMDRIVERID NULL => new HACMDRIVERID(0);

        public static bool operator ==(HACMDRIVERID left, HACMDRIVERID right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVERID left, HACMDRIVERID right) => left.Value != right.Value;

        public static bool operator <(HACMDRIVERID left, HACMDRIVERID right) => left.Value < right.Value;

        public static bool operator <=(HACMDRIVERID left, HACMDRIVERID right) => left.Value <= right.Value;

        public static bool operator >(HACMDRIVERID left, HACMDRIVERID right) => left.Value > right.Value;

        public static bool operator >=(HACMDRIVERID left, HACMDRIVERID right) => left.Value >= right.Value;

        public static explicit operator HACMDRIVERID(void* value) => new HACMDRIVERID((nint)(value));

        public static implicit operator void*(HACMDRIVERID value) => (void*)(value.Value);

        public static explicit operator HACMDRIVERID(HANDLE value) => new HACMDRIVERID(value);

        public static implicit operator HANDLE(HACMDRIVERID value) => new HANDLE(value.Value);

        public static explicit operator HACMDRIVERID(byte value) => new HACMDRIVERID((nint)(value));

        public static explicit operator byte(HACMDRIVERID value) => (byte)(value.Value);

        public static explicit operator HACMDRIVERID(short value) => new HACMDRIVERID((nint)(value));

        public static explicit operator short(HACMDRIVERID value) => (short)(value.Value);

        public static explicit operator HACMDRIVERID(int value) => new HACMDRIVERID((nint)(value));

        public static explicit operator int(HACMDRIVERID value) => (int)(value.Value);

        public static explicit operator HACMDRIVERID(long value) => new HACMDRIVERID((nint)(value));

        public static implicit operator long(HACMDRIVERID value) => value.Value;

        public static explicit operator HACMDRIVERID(nint value) => new HACMDRIVERID((nint)(value));

        public static implicit operator nint(HACMDRIVERID value) => value.Value;

        public static explicit operator HACMDRIVERID(sbyte value) => new HACMDRIVERID((nint)(value));

        public static explicit operator sbyte(HACMDRIVERID value) => (sbyte)(value.Value);

        public static explicit operator HACMDRIVERID(ushort value) => new HACMDRIVERID((nint)(value));

        public static explicit operator ushort(HACMDRIVERID value) => (ushort)(value.Value);

        public static explicit operator HACMDRIVERID(uint value) => new HACMDRIVERID((nint)(value));

        public static explicit operator uint(HACMDRIVERID value) => (uint)(value.Value);

        public static explicit operator HACMDRIVERID(ulong value) => new HACMDRIVERID((nint)(value));

        public static explicit operator ulong(HACMDRIVERID value) => (ulong)(value.Value);

        public static explicit operator HACMDRIVERID(nuint value) => new HACMDRIVERID((nint)(value));

        public static explicit operator nuint(HACMDRIVERID value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HACMDRIVERID other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HACMDRIVERID.");
        }

        public int CompareTo(HACMDRIVERID other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVERID other) && Equals(other);

        public bool Equals(HACMDRIVERID other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}