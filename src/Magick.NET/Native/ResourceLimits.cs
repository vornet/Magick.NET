// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public static partial class ResourceLimits
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
                public static extern ulong ResourceLimits_Area_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Area_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Disk_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Disk_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Height_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Height_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_ListLength_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_ListLength_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Memory_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Memory_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Thread_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Thread_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Throttle_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Throttle_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Width_Get();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Width_Set(ulong value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_LimitMemory(double percentage);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Area_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Area_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Disk_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Disk_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Height_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Height_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_ListLength_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_ListLength_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Memory_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Memory_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Thread_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Thread_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Throttle_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Throttle_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Width_Get();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Width_Set(ulong value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_LimitMemory(double percentage);
            }
            #endif
            #if PLATFORM_Arm64 || PLATFORM_AnyCPU
            public static class Arm64
            {
                #if PLATFORM_AnyCPU
                static Arm64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Area_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Area_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Disk_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Disk_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Height_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Height_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_ListLength_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_ListLength_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Memory_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Memory_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Thread_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Thread_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Throttle_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Throttle_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern ulong ResourceLimits_Width_Get();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_Width_Set(ulong value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void ResourceLimits_LimitMemory(double percentage);
            }
            #endif
        }
        private unsafe static class NativeResourceLimits
        {
            static NativeResourceLimits() { Environment.Initialize(); }
            public static ulong Area
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Area_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Area_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Area_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Area_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Area_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Area_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Disk
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Disk_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Disk_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Disk_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Disk_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Disk_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Disk_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Height
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Height_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Height_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Height_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Height_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Height_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Height_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong ListLength
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_ListLength_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_ListLength_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_ListLength_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_ListLength_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_ListLength_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_ListLength_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Memory
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Memory_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Memory_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Memory_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Memory_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Memory_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Memory_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Thread
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Thread_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Thread_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Thread_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Thread_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Thread_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Thread_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Throttle
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Throttle_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Throttle_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Throttle_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Throttle_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Throttle_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Throttle_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static ulong Width
            {
                get
                {
                    ulong result;
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         result = NativeMethods.X64.ResourceLimits_Width_Get();
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         result = NativeMethods.X86.ResourceLimits_Width_Get();
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         result = NativeMethods.Arm64.ResourceLimits_Width_Get();
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                    return result;
                }
                set
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.ResourceLimits_Width_Set(value);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.ResourceLimits_Width_Set(value);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.ResourceLimits_Width_Set(value);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public static void LimitMemory(double percentage)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.ResourceLimits_LimitMemory(percentage);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.ResourceLimits_LimitMemory(percentage);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.ResourceLimits_LimitMemory(percentage);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
        }
    }
}
