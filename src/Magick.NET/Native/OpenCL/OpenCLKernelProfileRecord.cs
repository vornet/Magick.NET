// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public partial class OpenCLKernelProfileRecord
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
                public static extern long OpenCLKernelProfileRecord_Count_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MaximumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MinimumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCLKernelProfileRecord_Name_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_TotalDuration_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_Count_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MaximumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MinimumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCLKernelProfileRecord_Name_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_TotalDuration_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_Arm64 || PLATFORM_AnyCPU
            public static class Arm64
            {
                #if PLATFORM_AnyCPU
                static Arm64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_Count_Get(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MaximumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_MinimumDuration_Get(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCLKernelProfileRecord_Name_Get(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern long OpenCLKernelProfileRecord_TotalDuration_Get(IntPtr instance);
            }
            #endif
        }
        private unsafe sealed class NativeOpenCLKernelProfileRecord : ConstNativeInstance
        {
            static NativeOpenCLKernelProfileRecord() { Environment.Initialize(); }
            protected override string TypeName
            {
                get
                {
                    return nameof(OpenCLKernelProfileRecord);
                }
            }
            public long Count
            {
                get
                {
                    long result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.OpenCLKernelProfileRecord_Count_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.OpenCLKernelProfileRecord_Count_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.OpenCLKernelProfileRecord_Count_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
            }
            public long MaximumDuration
            {
                get
                {
                    long result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.OpenCLKernelProfileRecord_MaximumDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.OpenCLKernelProfileRecord_MaximumDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.OpenCLKernelProfileRecord_MaximumDuration_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
            }
            public long MinimumDuration
            {
                get
                {
                    long result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.OpenCLKernelProfileRecord_MinimumDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.OpenCLKernelProfileRecord_MinimumDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.OpenCLKernelProfileRecord_MinimumDuration_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
            }
            public string? Name
            {
                get
                {
                    IntPtr result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.OpenCLKernelProfileRecord_Name_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.OpenCLKernelProfileRecord_Name_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.OpenCLKernelProfileRecord_Name_Get(Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return UTF8Marshaler.NativeToManaged(result);
                }
            }
            public long TotalDuration
            {
                get
                {
                    long result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.OpenCLKernelProfileRecord_TotalDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.OpenCLKernelProfileRecord_TotalDuration_Get(Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.OpenCLKernelProfileRecord_TotalDuration_Get(Instance);
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
}
