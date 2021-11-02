// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DHPDEV : IComparable, IComparable<DHPDEV>, IEquatable<DHPDEV>, IFormattable
    {
        public readonly nint Value;

        public DHPDEV(nint value)
        {
            Value = value;
        }

        public static DHPDEV INVALID_VALUE => new DHPDEV(-1);

        public static DHPDEV NULL => new DHPDEV(0);

        public static bool operator ==(DHPDEV left, DHPDEV right) => left.Value == right.Value;

        public static bool operator !=(DHPDEV left, DHPDEV right) => left.Value != right.Value;

        public static bool operator <(DHPDEV left, DHPDEV right) => left.Value < right.Value;

        public static bool operator <=(DHPDEV left, DHPDEV right) => left.Value <= right.Value;

        public static bool operator >(DHPDEV left, DHPDEV right) => left.Value > right.Value;

        public static bool operator >=(DHPDEV left, DHPDEV right) => left.Value >= right.Value;

        public static explicit operator DHPDEV(void* value) => new DHPDEV((nint)(value));

        public static implicit operator void*(DHPDEV value) => (void*)(value.Value);

        public static explicit operator DHPDEV(HANDLE value) => new DHPDEV(value);

        public static implicit operator HANDLE(DHPDEV value) => new HANDLE(value.Value);

        public static explicit operator DHPDEV(byte value) => new DHPDEV((nint)(value));

        public static explicit operator byte(DHPDEV value) => (byte)(value.Value);

        public static explicit operator DHPDEV(short value) => new DHPDEV((nint)(value));

        public static explicit operator short(DHPDEV value) => (short)(value.Value);

        public static explicit operator DHPDEV(int value) => new DHPDEV((nint)(value));

        public static explicit operator int(DHPDEV value) => (int)(value.Value);

        public static explicit operator DHPDEV(long value) => new DHPDEV((nint)(value));

        public static implicit operator long(DHPDEV value) => value.Value;

        public static explicit operator DHPDEV(nint value) => new DHPDEV((nint)(value));

        public static implicit operator nint(DHPDEV value) => value.Value;

        public static explicit operator DHPDEV(sbyte value) => new DHPDEV((nint)(value));

        public static explicit operator sbyte(DHPDEV value) => (sbyte)(value.Value);

        public static explicit operator DHPDEV(ushort value) => new DHPDEV((nint)(value));

        public static explicit operator ushort(DHPDEV value) => (ushort)(value.Value);

        public static explicit operator DHPDEV(uint value) => new DHPDEV((nint)(value));

        public static explicit operator uint(DHPDEV value) => (uint)(value.Value);

        public static explicit operator DHPDEV(ulong value) => new DHPDEV((nint)(value));

        public static explicit operator ulong(DHPDEV value) => (ulong)(value.Value);

        public static explicit operator DHPDEV(nuint value) => new DHPDEV((nint)(value));

        public static explicit operator nuint(DHPDEV value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is DHPDEV other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of DHPDEV.");
        }

        public int CompareTo(DHPDEV other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is DHPDEV other) && Equals(other);

        public bool Equals(DHPDEV other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}