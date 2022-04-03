/*
 * Copyright(c) 2022 nifanfa, This code is part of the OS-Sharp licensed under the MIT licence.
 */
namespace Kernel.Driver
{
    public static unsafe class VBE
    {
        public static VBEInfo* Info;

        public static void Initialise(VBEInfo* info)
        {
            Info = info;
            
        }
    }
}
