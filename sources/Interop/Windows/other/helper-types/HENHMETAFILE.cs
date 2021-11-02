// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HENHMETAFILE : IComparable, IComparable<HENHMETAFILE>, IEquatable<HENHMETAFILE>, IFormattable
    {
        public readonly nint Value;

        public HENHMETAFILE(nint value)
        {
            Value = value;
        }

        public static HENHMETAFILE INVALID_VALUE => new HENHMETAFILE(-1);

        public static HENHMETAFILE NULL => new HENHMETAFILE(0);

        public static bool operator ==(HENHMETAFILE left, HENHMETAFILE right) => left.Value == right.Value;

        public static bool operator !=(HENHMETAFILE left, HENHMETAFILE right) => left.Value != right.Value;

        public static bool operator <(HENHMETAFILE left, HENHMETAFILE right) => left.Value < right.Value;

        public static bool operator <=(HENHMETAFILE left, HENHMETAFILE right) => left.Value <= right.Value;

        public static bool operator >(HENHMETAFILE left, HENHMETAFILE right) => left.Value > right.Value;

        public static bool operator >=(HENHMETAFILE left, HENHMETAFILE right) => left.Value >= right.Value;

        public static explicit operator HENHMETAFILE(void* value) => new HENHMETAFILE((nint)(value));

        public static implicit operator void*(HENHMETAFILE value) => (void*)(value.Value);

        public static explicit operator HENHMETAFILE(HANDLE value) => new HENHMETAFILE(value);

        public static implicit operator HANDLE(HENHMETAFILE value) => new HANDLE(value.Value);

        public static explicit operator HENHMETAFILE(byte value) => new HENHMETAFILE((nint)(value));

        public static explicit operator byte(HENHMETAFILE value) => (byte)(value.Value);

        public static explicit operator HENHMETAFILE(short value) => new HENHMETAFILE((nint)(value));

        public static explicit operator short(HENHMETAFILE value) => (short)(value.Value);

        public static explicit operator HENHMETAFILE(int value) => new HENHMETAFILE((nint)(value));

        public static explicit operator int(HENHMETAFILE value) => (int)(value.Value);

        public static explicit operator HENHMETAFILE(long value) => new HENHMETAFILE((nint)(value));

        public static implicit operator long(HENHMETAFILE value) => value.Value;

        public static explicit operator HENHMETAFILE(nint value) => new HENHMETAFILE((nint)(value));

        public static implicit operator nint(HENHMETAFILE value) => value.Value;

        public static explicit operator HENHMETAFILE(sbyte value) => new HENHMETAFILE((nint)(value));

        public static explicit operator sbyte(HENHMETAFILE value) => (sbyte)(value.Value);

        public static explicit operator HENHMETAFILE(ushort value) => new HENHMETAFILE((nint)(value));

        public static explicit operator ushort(HENHMETAFILE value) => (ushort)(value.Value);

        public static explicit operator HENHMETAFILE(uint value) => new HENHMETAFILE((nint)(value));

        public static explicit operator uint(HENHMETAFILE value) => (uint)(value.Value);

        public static explicit operator HENHMETAFILE(ulong value) => new HENHMETAFILE((nint)(value));

        public static explicit operator ulong(HENHMETAFILE value) => (ulong)(value.Value);

        public static explicit operator HENHMETAFILE(nuint value) => new HENHMETAFILE((nint)(value));

        public static explicit operator nuint(HENHMETAFILE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HENHMETAFILE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HENHMETAFILE.");
        }

        public int CompareTo(HENHMETAFILE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HENHMETAFILE other) && Equals(other);

        public bool Equals(HENHMETAFILE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}