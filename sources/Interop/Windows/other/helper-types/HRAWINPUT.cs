// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRAWINPUT : IComparable, IComparable<HRAWINPUT>, IEquatable<HRAWINPUT>, IFormattable
    {
        public readonly nint Value;

        public HRAWINPUT(nint value)
        {
            Value = value;
        }

        public static HRAWINPUT INVALID_VALUE => new HRAWINPUT(-1);

        public static HRAWINPUT NULL => new HRAWINPUT(0);

        public static bool operator ==(HRAWINPUT left, HRAWINPUT right) => left.Value == right.Value;

        public static bool operator !=(HRAWINPUT left, HRAWINPUT right) => left.Value != right.Value;

        public static bool operator <(HRAWINPUT left, HRAWINPUT right) => left.Value < right.Value;

        public static bool operator <=(HRAWINPUT left, HRAWINPUT right) => left.Value <= right.Value;

        public static bool operator >(HRAWINPUT left, HRAWINPUT right) => left.Value > right.Value;

        public static bool operator >=(HRAWINPUT left, HRAWINPUT right) => left.Value >= right.Value;

        public static explicit operator HRAWINPUT(void* value) => new HRAWINPUT((nint)(value));

        public static implicit operator void*(HRAWINPUT value) => (void*)(value.Value);

        public static explicit operator HRAWINPUT(HANDLE value) => new HRAWINPUT(value);

        public static implicit operator HANDLE(HRAWINPUT value) => new HANDLE(value.Value);

        public static explicit operator HRAWINPUT(byte value) => new HRAWINPUT((nint)(value));

        public static explicit operator byte(HRAWINPUT value) => (byte)(value.Value);

        public static explicit operator HRAWINPUT(short value) => new HRAWINPUT((nint)(value));

        public static explicit operator short(HRAWINPUT value) => (short)(value.Value);

        public static explicit operator HRAWINPUT(int value) => new HRAWINPUT((nint)(value));

        public static explicit operator int(HRAWINPUT value) => (int)(value.Value);

        public static explicit operator HRAWINPUT(long value) => new HRAWINPUT((nint)(value));

        public static implicit operator long(HRAWINPUT value) => value.Value;

        public static explicit operator HRAWINPUT(nint value) => new HRAWINPUT((nint)(value));

        public static implicit operator nint(HRAWINPUT value) => value.Value;

        public static explicit operator HRAWINPUT(sbyte value) => new HRAWINPUT((nint)(value));

        public static explicit operator sbyte(HRAWINPUT value) => (sbyte)(value.Value);

        public static explicit operator HRAWINPUT(ushort value) => new HRAWINPUT((nint)(value));

        public static explicit operator ushort(HRAWINPUT value) => (ushort)(value.Value);

        public static explicit operator HRAWINPUT(uint value) => new HRAWINPUT((nint)(value));

        public static explicit operator uint(HRAWINPUT value) => (uint)(value.Value);

        public static explicit operator HRAWINPUT(ulong value) => new HRAWINPUT((nint)(value));

        public static explicit operator ulong(HRAWINPUT value) => (ulong)(value.Value);

        public static explicit operator HRAWINPUT(nuint value) => new HRAWINPUT((nint)(value));

        public static explicit operator nuint(HRAWINPUT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HRAWINPUT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRAWINPUT.");
        }

        public int CompareTo(HRAWINPUT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HRAWINPUT other) && Equals(other);

        public bool Equals(HRAWINPUT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}