// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PCUSERIALIZEDPROPSTORAGE : IComparable, IComparable<PCUSERIALIZEDPROPSTORAGE>, IEquatable<PCUSERIALIZEDPROPSTORAGE>, IFormattable
    {
        public readonly nint Value;

        public PCUSERIALIZEDPROPSTORAGE(nint value)
        {
            Value = value;
        }

        public static PCUSERIALIZEDPROPSTORAGE NULL => new PCUSERIALIZEDPROPSTORAGE(0);

        public static bool operator ==(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value == right.Value;

        public static bool operator !=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value != right.Value;

        public static bool operator <(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value < right.Value;

        public static bool operator <=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value <= right.Value;

        public static bool operator >(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value > right.Value;

        public static bool operator >=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value >= right.Value;

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(void* value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static implicit operator void*(PCUSERIALIZEDPROPSTORAGE value) => (void*)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(byte value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator byte(PCUSERIALIZEDPROPSTORAGE value) => (byte)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(short value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator short(PCUSERIALIZEDPROPSTORAGE value) => (short)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(int value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator int(PCUSERIALIZEDPROPSTORAGE value) => (int)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(long value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static implicit operator long(PCUSERIALIZEDPROPSTORAGE value) => value.Value;

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(nint value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static implicit operator nint(PCUSERIALIZEDPROPSTORAGE value) => value.Value;

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(sbyte value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator sbyte(PCUSERIALIZEDPROPSTORAGE value) => (sbyte)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(ushort value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator ushort(PCUSERIALIZEDPROPSTORAGE value) => (ushort)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(uint value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator uint(PCUSERIALIZEDPROPSTORAGE value) => (uint)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(ulong value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator ulong(PCUSERIALIZEDPROPSTORAGE value) => (ulong)(value.Value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(nuint value) => new PCUSERIALIZEDPROPSTORAGE((nint)(value));

        public static explicit operator nuint(PCUSERIALIZEDPROPSTORAGE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PCUSERIALIZEDPROPSTORAGE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PCUSERIALIZEDPROPSTORAGE.");
        }

        public int CompareTo(PCUSERIALIZEDPROPSTORAGE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is PCUSERIALIZEDPROPSTORAGE other) && Equals(other);

        public bool Equals(PCUSERIALIZEDPROPSTORAGE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}