// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBODY : IComparable, IComparable<HBODY>, IEquatable<HBODY>, IFormattable
    {
        public readonly nint Value;

        public HBODY(nint value)
        {
            Value = value;
        }

        public static HBODY INVALID_VALUE => new HBODY(-1);

        public static HBODY NULL => new HBODY(0);

        public static bool operator ==(HBODY left, HBODY right) => left.Value == right.Value;

        public static bool operator !=(HBODY left, HBODY right) => left.Value != right.Value;

        public static bool operator <(HBODY left, HBODY right) => left.Value < right.Value;

        public static bool operator <=(HBODY left, HBODY right) => left.Value <= right.Value;

        public static bool operator >(HBODY left, HBODY right) => left.Value > right.Value;

        public static bool operator >=(HBODY left, HBODY right) => left.Value >= right.Value;

        public static explicit operator HBODY(void* value) => new HBODY((nint)(value));

        public static implicit operator void*(HBODY value) => (void*)(value.Value);

        public static explicit operator HBODY(HANDLE value) => new HBODY(value);

        public static implicit operator HANDLE(HBODY value) => new HANDLE(value.Value);

        public static explicit operator HBODY(byte value) => new HBODY((nint)(value));

        public static explicit operator byte(HBODY value) => (byte)(value.Value);

        public static explicit operator HBODY(short value) => new HBODY((nint)(value));

        public static explicit operator short(HBODY value) => (short)(value.Value);

        public static explicit operator HBODY(int value) => new HBODY((nint)(value));

        public static explicit operator int(HBODY value) => (int)(value.Value);

        public static explicit operator HBODY(long value) => new HBODY((nint)(value));

        public static implicit operator long(HBODY value) => value.Value;

        public static explicit operator HBODY(nint value) => new HBODY((nint)(value));

        public static implicit operator nint(HBODY value) => value.Value;

        public static explicit operator HBODY(sbyte value) => new HBODY((nint)(value));

        public static explicit operator sbyte(HBODY value) => (sbyte)(value.Value);

        public static explicit operator HBODY(ushort value) => new HBODY((nint)(value));

        public static explicit operator ushort(HBODY value) => (ushort)(value.Value);

        public static explicit operator HBODY(uint value) => new HBODY((nint)(value));

        public static explicit operator uint(HBODY value) => (uint)(value.Value);

        public static explicit operator HBODY(ulong value) => new HBODY((nint)(value));

        public static explicit operator ulong(HBODY value) => (ulong)(value.Value);

        public static explicit operator HBODY(nuint value) => new HBODY((nint)(value));

        public static explicit operator nuint(HBODY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HBODY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBODY.");
        }

        public int CompareTo(HBODY other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HBODY other) && Equals(other);

        public bool Equals(HBODY other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}