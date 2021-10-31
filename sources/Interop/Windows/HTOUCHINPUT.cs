// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTOUCHINPUT : IEquatable<HTOUCHINPUT>
    {
        public readonly nint Value;

        public static HTOUCHINPUT NULL => (HTOUCHINPUT)(0);

        public HTOUCHINPUT(int value)
        {
            Value = ((nint)(value));
        }

        public HTOUCHINPUT(uint value)
        {
            Value = ((nint)(value));
        }

        public HTOUCHINPUT(nint value)
        {
            Value = ((nint)(value));
        }

        public HTOUCHINPUT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HTOUCHINPUT(void* value)
        {
            Value = ((nint)(value));
        }

        public HTOUCHINPUT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value == right.Value;

        public static bool operator !=(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value != right.Value;

        public static explicit operator HTOUCHINPUT(int value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(uint value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(nint value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(nuint value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(void* value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(HANDLE value) => new HTOUCHINPUT(value);

        public static explicit operator int(HTOUCHINPUT value) => (int)(value.Value);

        public static explicit operator uint(HTOUCHINPUT value) => (uint)(value.Value);

        public static implicit operator nint(HTOUCHINPUT value) => (nint)(value.Value);

        public static implicit operator nuint(HTOUCHINPUT value) => (nuint)(value.Value);

        public static implicit operator void*(HTOUCHINPUT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HTOUCHINPUT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HTOUCHINPUT other) && Equals(other);

        public bool Equals(HTOUCHINPUT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}