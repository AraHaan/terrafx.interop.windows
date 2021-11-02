// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PDH_HLOG : IComparable, IComparable<PDH_HLOG>, IEquatable<PDH_HLOG>, IFormattable
    {
        public readonly nint Value;

        public PDH_HLOG(nint value)
        {
            Value = value;
        }

        public static PDH_HLOG INVALID_VALUE => new PDH_HLOG(-1);

        public static PDH_HLOG NULL => new PDH_HLOG(0);

        public static bool operator ==(PDH_HLOG left, PDH_HLOG right) => left.Value == right.Value;

        public static bool operator !=(PDH_HLOG left, PDH_HLOG right) => left.Value != right.Value;

        public static bool operator <(PDH_HLOG left, PDH_HLOG right) => left.Value < right.Value;

        public static bool operator <=(PDH_HLOG left, PDH_HLOG right) => left.Value <= right.Value;

        public static bool operator >(PDH_HLOG left, PDH_HLOG right) => left.Value > right.Value;

        public static bool operator >=(PDH_HLOG left, PDH_HLOG right) => left.Value >= right.Value;

        public static explicit operator PDH_HLOG(void* value) => new PDH_HLOG((nint)(value));

        public static implicit operator void*(PDH_HLOG value) => (void*)(value.Value);

        public static explicit operator PDH_HLOG(HANDLE value) => new PDH_HLOG(value);

        public static implicit operator HANDLE(PDH_HLOG value) => new HANDLE(value.Value);

        public static explicit operator PDH_HLOG(byte value) => new PDH_HLOG((nint)(value));

        public static explicit operator byte(PDH_HLOG value) => (byte)(value.Value);

        public static explicit operator PDH_HLOG(short value) => new PDH_HLOG((nint)(value));

        public static explicit operator short(PDH_HLOG value) => (short)(value.Value);

        public static explicit operator PDH_HLOG(int value) => new PDH_HLOG((nint)(value));

        public static explicit operator int(PDH_HLOG value) => (int)(value.Value);

        public static explicit operator PDH_HLOG(long value) => new PDH_HLOG((nint)(value));

        public static implicit operator long(PDH_HLOG value) => value.Value;

        public static explicit operator PDH_HLOG(nint value) => new PDH_HLOG((nint)(value));

        public static implicit operator nint(PDH_HLOG value) => value.Value;

        public static explicit operator PDH_HLOG(sbyte value) => new PDH_HLOG((nint)(value));

        public static explicit operator sbyte(PDH_HLOG value) => (sbyte)(value.Value);

        public static explicit operator PDH_HLOG(ushort value) => new PDH_HLOG((nint)(value));

        public static explicit operator ushort(PDH_HLOG value) => (ushort)(value.Value);

        public static explicit operator PDH_HLOG(uint value) => new PDH_HLOG((nint)(value));

        public static explicit operator uint(PDH_HLOG value) => (uint)(value.Value);

        public static explicit operator PDH_HLOG(ulong value) => new PDH_HLOG((nint)(value));

        public static explicit operator ulong(PDH_HLOG value) => (ulong)(value.Value);

        public static explicit operator PDH_HLOG(nuint value) => new PDH_HLOG((nint)(value));

        public static explicit operator nuint(PDH_HLOG value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PDH_HLOG other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PDH_HLOG.");
        }

        public int CompareTo(PDH_HLOG other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is PDH_HLOG other) && Equals(other);

        public bool Equals(PDH_HLOG other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}