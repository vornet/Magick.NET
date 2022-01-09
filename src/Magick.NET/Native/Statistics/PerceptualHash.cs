// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public partial class PerceptualHash
    {
        [SuppressUnmanagedCodeSecurity]
        private static unsafe class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            public static class X64
            {
                #if PLATFORM_AnyCPU
                static X64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void PerceptualHash_DisposeList(IntPtr list);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr PerceptualHash_GetInstance(IntPtr image, IntPtr list, UIntPtr channel);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void PerceptualHash_DisposeList(IntPtr list);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr PerceptualHash_GetInstance(IntPtr image, IntPtr list, UIntPtr channel);
            }
            #endif
            #if PLATFORM_Arm64 || PLATFORM_AnyCPU
            public static class Arm64
            {
                #if PLATFORM_AnyCPU
                static Arm64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void PerceptualHash_DisposeList(IntPtr list);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr PerceptualHash_GetInstance(IntPtr image, IntPtr list, UIntPtr channel);
            }
            #endif
        }
        private unsafe static class NativePerceptualHash
        {
            static NativePerceptualHash() { Environment.Initialize(); }
            public static void DisposeList(IntPtr list)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.PerceptualHash_DisposeList(list);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.PerceptualHash_DisposeList(list);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.PerceptualHash_DisposeList(list);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public static IntPtr GetInstance(IMagickImage? image, IntPtr list, PixelChannel channel)
            {
                IntPtr result;
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     result = NativeMethods.X64.PerceptualHash_GetInstance(MagickImage.GetInstance(image), list, (UIntPtr)channel);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     result = NativeMethods.X86.PerceptualHash_GetInstance(MagickImage.GetInstance(image), list, (UIntPtr)channel);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     result = NativeMethods.Arm64.PerceptualHash_GetInstance(MagickImage.GetInstance(image), list, (UIntPtr)channel);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
                return result;
            }
        }
    }
}
