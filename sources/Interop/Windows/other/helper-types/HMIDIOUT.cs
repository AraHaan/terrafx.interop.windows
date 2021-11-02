// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIOUT : IComparable, IComparable<HMIDIOUT>, IEquatable<HMIDIOUT>, IFormattable
    {
        public readonly nint Value;

        public HMIDIOUT(nint value)
        {
            Value = value;
        }

        public static HMIDIOUT INVALID_VALUE => new HMIDIOUT(-1);

        public static HMIDIOUT NULL => new HMIDIOUT(0);

        public static bool operator ==(HMIDIOUT left, HMIDIOUT right) => left.Value == right.Value;

        public static bool operator !=(HMIDIOUT left, HMIDIOUT right) => left.Value != right.Value;

        public static bool operator <(HMIDIOUT left, HMIDIOUT right) => left.Value < right.Value;

        public static bool operator <=(HMIDIOUT left, HMIDIOUT right) => left.Value <= right.Value;

        public static bool operator >(HMIDIOUT left, HMIDIOUT right) => left.Value > right.Value;

        public static bool operator >=(HMIDIOUT left, HMIDIOUT right) => left.Value >= right.Value;

        public static explicit operator HMIDIOUT(void* value) => new HMIDIOUT((nint)(value));

        public static implicit operator void*(HMIDIOUT value) => (void*)(value.Value);

        public static explicit operator HMIDIOUT(HANDLE value) => new HMIDIOUT(value);

        public static implicit operator HANDLE(HMIDIOUT value) => new HANDLE(value.Value);

        public static explicit operator HMIDIOUT(byte value) => new HMIDIOUT((nint)(value));

        public static explicit operator byte(HMIDIOUT value) => (byte)(value.Value);

        public static explicit operator HMIDIOUT(short value) => new HMIDIOUT((nint)(value));

        public static explicit operator short(HMIDIOUT value) => (short)(value.Value);

        public static explicit operator HMIDIOUT(int value) => new HMIDIOUT((nint)(value));

        public static explicit operator int(HMIDIOUT value) => (int)(value.Value);

        public static explicit operator HMIDIOUT(long value) => new HMIDIOUT((nint)(value));

        public static implicit operator long(HMIDIOUT value) => value.Value;

        public static explicit operator HMIDIOUT(nint value) => new HMIDIOUT((nint)(value));

        public static implicit operator nint(HMIDIOUT value) => value.Value;

        public static explicit operator HMIDIOUT(sbyte value) => new HMIDIOUT((nint)(value));

        public static explicit operator sbyte(HMIDIOUT value) => (sbyte)(value.Value);

        public static explicit operator HMIDIOUT(ushort value) => new HMIDIOUT((nint)(value));

        public static explicit operator ushort(HMIDIOUT value) => (ushort)(value.Value);

        public static explicit operator HMIDIOUT(uint value) => new HMIDIOUT((nint)(value));

        public static explicit operator uint(HMIDIOUT value) => (uint)(value.Value);

        public static explicit operator HMIDIOUT(ulong value) => new HMIDIOUT((nint)(value));

        public static explicit operator ulong(HMIDIOUT value) => (ulong)(value.Value);

        public static explicit operator HMIDIOUT(nuint value) => new HMIDIOUT((nint)(value));

        public static explicit operator nuint(HMIDIOUT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMIDIOUT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIDIOUT.");
        }

        public int CompareTo(HMIDIOUT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HMIDIOUT other) && Equals(other);

        public bool Equals(HMIDIOUT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}