﻿namespace LibCpp2IL.MachO
{
    public enum MachOCpuType
    {
        CPU_TYPE_ANY = -1,
        CPU_TYPE_VAX = 1,
        //Skip 2-5
        CPU_TYPE_MC680x0 = 6,
        CPU_TYPE_I386 = 7,
        CPU_TYPE_X86_64 = CPU_TYPE_I386 | CPU_ARCH_ABI64,
        CPU_TYPE_MIPS = 8,
        //Skip 9
        CPU_TYPE_MC98000 = 10,
        CPU_TYPE_HPPA = 11,
        CPU_TYPE_ARM = 12,
        CPU_TYPE_ARM64 = CPU_TYPE_ARM | CPU_ARCH_ABI64,
        CPU_TYPE_ARM64_32 = CPU_TYPE_ARM | CPU_ARCH_ABI64_32,
        CPU_TYPE_MC88000 = 13,
        CPU_TYPE_SPARC = 14,
        CPU_TYPE_I860 = 15,
        CPU_TYPE_ALPHA = 16,
        //Skip 17
        CPU_TYPE_POWERPC = 18,
        CPU_TYPE_POWERPC64 = CPU_TYPE_POWERPC | CPU_ARCH_ABI64,
        
        
        //Helper values
        CPU_ARCH_ABI64 = 0x01000000,
        CPU_ARCH_ABI64_32 = 0x02000000,
    }
}