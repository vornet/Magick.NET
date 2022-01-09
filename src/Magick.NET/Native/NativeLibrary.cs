﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    internal static class NativeLibrary
    {
        public const string Name = "Magick.Native";

        public const string QuantumName = Quantum + OpenMP;

        public const string X86Name = Name + "-" + QuantumName + "-x86.dll";

        public const string X64Name = Name + "-" + QuantumName + "-x64.dll";

        public const string Arm64Name = Name + "-" + QuantumName + "-Arm64.dll";

#if Q8
        private const string Quantum = "Q8";
#elif Q16
        private const string Quantum = "Q16";
#elif Q16HDRI
        private const string Quantum = "Q16-HDRI";
#else
#error Not implemented!
#endif

#if OPENMP
        private const string OpenMP = "-OpenMP";
#else
        private const string OpenMP = "";
#endif

#if PLATFORM_AnyCPU
        public static string PlatformName
        {
            get
            {
                switch (RuntimeInformation.ProcessArchitecture)
                {
                    case Architecture.X64:
                        return "x64";
                    case Architecture.Arm64:
                        return "Arm64";
                    case Architecture.X86:
                        return "x86";
                    case Architecture.Arm:
                        break;
                }

                throw new NotSupportedException("ProcessArchitecture not supported.");
            }
        }
#endif
    }
}
