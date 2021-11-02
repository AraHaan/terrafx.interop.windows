// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RHANDLE : IComparable, IComparable<RHANDLE>, IEquatable<RHANDLE>, IFormattable
    {
        public readonly nint Value;

        public RHANDLE(nint value)
        {
            Value = value;
        }

        public static RHANDLE INVALID_VALUE => new RHANDLE(-1);

        public static RHANDLE NULL => new RHANDLE(0);

        public static bool operator ==(RHANDLE left, RHANDLE right) => left.Value == right.Value;

        public static bool operator !=(RHANDLE left, RHANDLE right) => left.Value != right.Value;

        public static bool operator <(RHANDLE left, RHANDLE right) => left.Value < right.Value;

        public static bool operator <=(RHANDLE left, RHANDLE right) => left.Value <= right.Value;

        public static bool operator >(RHANDLE left, RHANDLE right) => left.Value > right.Value;

        public static bool operator >=(RHANDLE left, RHANDLE right) => left.Value >= right.Value;

        public static explicit operator RHANDLE(void* value) => new RHANDLE((nint)(value));

        public static implicit operator void*(RHANDLE value) => (void*)(value.Value);

        public static explicit operator RHANDLE(HANDLE value) => new RHANDLE(value);

        public static implicit operator HANDLE(RHANDLE value) => new HANDLE(value.Value);

        public static explicit operator RHANDLE(byte value) => new RHANDLE((nint)(value));

        public static explicit operator byte(RHANDLE value) => (byte)(value.Value);

        public static explicit operator RHANDLE(short value) => new RHANDLE((nint)(value));

        public static explicit operator short(RHANDLE value) => (short)(value.Value);

        public static explicit operator RHANDLE(int value) => new RHANDLE((nint)(value));

        public static explicit operator int(RHANDLE value) => (int)(value.Value);

        public static explicit operator RHANDLE(long value) => new RHANDLE((nint)(value));

        public static implicit operator long(RHANDLE value) => value.Value;

        public static explicit operator RHANDLE(nint value) => new RHANDLE((nint)(value));

        public static implicit operator nint(RHANDLE value) => value.Value;

        public static explicit operator RHANDLE(sbyte value) => new RHANDLE((nint)(value));

        public static explicit operator sbyte(RHANDLE value) => (sbyte)(value.Value);

        public static explicit operator RHANDLE(ushort value) => new RHANDLE((nint)(value));

        public static explicit operator ushort(RHANDLE value) => (ushort)(value.Value);

        public static explicit operator RHANDLE(uint value) => new RHANDLE((nint)(value));

        public static explicit operator uint(RHANDLE value) => (uint)(value.Value);

        public static explicit operator RHANDLE(ulong value) => new RHANDLE((nint)(value));

        public static explicit operator ulong(RHANDLE value) => (ulong)(value.Value);

        public static explicit operator RHANDLE(nuint value) => new RHANDLE((nint)(value));

        public static explicit operator nuint(RHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is RHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of RHANDLE.");
        }

        public int CompareTo(RHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is RHANDLE other) && Equals(other);

        public bool Equals(RHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}