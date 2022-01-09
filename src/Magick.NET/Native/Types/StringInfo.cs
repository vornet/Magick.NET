// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    internal partial class StringInfo
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
                public static extern IntPtr StringInfo_Datum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr StringInfo_Length_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr StringInfo_Datum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr StringInfo_Length_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_Arm64 || PLATFORM_AnyCPU
            public static class Arm64
            {
                #if PLATFORM_AnyCPU
                static Arm64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr StringInfo_Datum_Get(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr StringInfo_Length_Get(IntPtr instance);
            }
            #endif
        }
        private unsafe sealed class NativeStringInfo : ConstNativeInstance
        {
            static NativeStringInfo() { Environment.Initialize(); }
            public NativeStringInfo(IntPtr instance)
            {
                Instance = instance;
            }
            protected override string TypeName
            {
                get
                {
                    return nameof(StringInfo);
                }
            }
            public IntPtr Datum
            {
                get
                {
                    IntPtr result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.StringInfo_Datum_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.StringInfo_Datum_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.StringInfo_Datum_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
            }
            public int Length
            {
                get
                {
                    UIntPtr result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.StringInfo_Length_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.StringInfo_Length_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.StringInfo_Length_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return (int)result;
                }
            }
        }
    }
}
