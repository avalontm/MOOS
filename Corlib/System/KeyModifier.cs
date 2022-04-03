/*
 * Copyright(c) 2022 nifanfa, This code is part of the OS-Sharp licensed under the MIT licence.
 */

namespace System
{
    [Flags]
    public enum KeyModifier
    {
        None = 0,
        Alt = 1,
        Shift = 2,
        Ctrl = 4,
    }
}