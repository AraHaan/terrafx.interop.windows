// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPSTATEHANDLE : IComparable, IComparable<SPSTATEHANDLE>, IEquatable<SPSTATEHANDLE>, IFormattable
    {
        public readonly nint Value;

        public SPSTATEHANDLE(nint value)
        {
            Value = value;
        }

        public static SPSTATEHANDLE INVALID_VALUE => new SPSTATEHANDLE(-1);

        public static SPSTATEHANDLE NULL => new SPSTATEHANDLE(0);

        public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPSTATEHANDLE(void* value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator void*(SPSTATEHANDLE value) => (void*)(value.Value);

        public static explicit operator SPSTATEHANDLE(HANDLE value) => new SPSTATEHANDLE(value);

        public static implicit operator HANDLE(SPSTATEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPSTATEHANDLE(byte value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator byte(SPSTATEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPSTATEHANDLE(short value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator short(SPSTATEHANDLE value) => (short)(value.Value);

        public static explicit operator SPSTATEHANDLE(int value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator int(SPSTATEHANDLE value) => (int)(value.Value);

        public static explicit operator SPSTATEHANDLE(long value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator long(SPSTATEHANDLE value) => value.Value;

        public static explicit operator SPSTATEHANDLE(nint value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator nint(SPSTATEHANDLE value) => value.Value;

        public static explicit operator SPSTATEHANDLE(sbyte value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator sbyte(SPSTATEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPSTATEHANDLE(ushort value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator ushort(SPSTATEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPSTATEHANDLE(uint value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator uint(SPSTATEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPSTATEHANDLE(ulong value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator ulong(SPSTATEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPSTATEHANDLE(nuint value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator nuint(SPSTATEHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPSTATEHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPSTATEHANDLE.");
        }

        public int CompareTo(SPSTATEHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is SPSTATEHANDLE other) && Equals(other);

        public bool Equals(SPSTATEHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}