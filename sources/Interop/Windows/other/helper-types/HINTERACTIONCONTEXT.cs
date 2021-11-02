// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERACTIONCONTEXT : IComparable, IComparable<HINTERACTIONCONTEXT>, IEquatable<HINTERACTIONCONTEXT>, IFormattable
    {
        public readonly nint Value;

        public HINTERACTIONCONTEXT(nint value)
        {
            Value = value;
        }

        public static HINTERACTIONCONTEXT INVALID_VALUE => new HINTERACTIONCONTEXT(-1);

        public static HINTERACTIONCONTEXT NULL => new HINTERACTIONCONTEXT(0);

        public static bool operator ==(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value != right.Value;

        public static bool operator <(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value < right.Value;

        public static bool operator <=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value <= right.Value;

        public static bool operator >(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value > right.Value;

        public static bool operator >=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value >= right.Value;

        public static explicit operator HINTERACTIONCONTEXT(void* value) => new HINTERACTIONCONTEXT((nint)(value));

        public static implicit operator void*(HINTERACTIONCONTEXT value) => (void*)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(HANDLE value) => new HINTERACTIONCONTEXT(value);

        public static implicit operator HANDLE(HINTERACTIONCONTEXT value) => new HANDLE(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(byte value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator byte(HINTERACTIONCONTEXT value) => (byte)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(short value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator short(HINTERACTIONCONTEXT value) => (short)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(int value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator int(HINTERACTIONCONTEXT value) => (int)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(long value) => new HINTERACTIONCONTEXT((nint)(value));

        public static implicit operator long(HINTERACTIONCONTEXT value) => value.Value;

        public static explicit operator HINTERACTIONCONTEXT(nint value) => new HINTERACTIONCONTEXT((nint)(value));

        public static implicit operator nint(HINTERACTIONCONTEXT value) => value.Value;

        public static explicit operator HINTERACTIONCONTEXT(sbyte value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator sbyte(HINTERACTIONCONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(ushort value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator ushort(HINTERACTIONCONTEXT value) => (ushort)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(uint value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator uint(HINTERACTIONCONTEXT value) => (uint)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(ulong value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator ulong(HINTERACTIONCONTEXT value) => (ulong)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(nuint value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator nuint(HINTERACTIONCONTEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HINTERACTIONCONTEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HINTERACTIONCONTEXT.");
        }

        public int CompareTo(HINTERACTIONCONTEXT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HINTERACTIONCONTEXT other) && Equals(other);

        public bool Equals(HINTERACTIONCONTEXT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}