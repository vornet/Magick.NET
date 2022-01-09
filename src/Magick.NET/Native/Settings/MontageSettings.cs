// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    public partial class MontageSettings
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
                public static extern IntPtr MontageSettings_Create();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_Dispose(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBackgroundColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderWidth(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFillColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFont(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFontPointsize(IntPtr Instance, double value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFrameGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGravity(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetShadow(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetStrokeColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTextureFileName(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTileGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTitle(IntPtr Instance, IntPtr value);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MontageSettings_Create();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_Dispose(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBackgroundColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderWidth(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFillColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFont(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFontPointsize(IntPtr Instance, double value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFrameGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGravity(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetShadow(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetStrokeColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTextureFileName(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTileGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTitle(IntPtr Instance, IntPtr value);
            }
            #endif
            #if PLATFORM_Arm64 || PLATFORM_AnyCPU
            public static class Arm64
            {
                #if PLATFORM_AnyCPU
                static Arm64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MontageSettings_Create();
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_Dispose(IntPtr instance);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBackgroundColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetBorderWidth(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFillColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFont(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFontPointsize(IntPtr Instance, double value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetFrameGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetGravity(IntPtr Instance, UIntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetShadow(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetStrokeColor(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTextureFileName(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTileGeometry(IntPtr Instance, IntPtr value);
                [DllImport(NativeLibrary.Arm64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MontageSettings_SetTitle(IntPtr Instance, IntPtr value);
            }
            #endif
        }
        private unsafe sealed class NativeMontageSettings : NativeInstance
        {
            static NativeMontageSettings() { Environment.Initialize(); }
            protected override void Dispose(IntPtr instance)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.MontageSettings_Dispose(instance);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.MontageSettings_Dispose(instance);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.MontageSettings_Dispose(instance);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public NativeMontageSettings()
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     Instance = NativeMethods.X64.MontageSettings_Create();
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     Instance = NativeMethods.X86.MontageSettings_Create();
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     Instance = NativeMethods.Arm64.MontageSettings_Create();
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
                if (Instance == IntPtr.Zero)
                    throw new InvalidOperationException();
            }
            protected override string TypeName
            {
                get
                {
                    return nameof(MontageSettings);
                }
            }
            public void SetBackgroundColor(IMagickColor<QuantumType>? value)
            {
                using (var valueNative = MagickColor.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetBackgroundColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetBackgroundColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetBackgroundColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetBorderColor(IMagickColor<QuantumType>? value)
            {
                using (var valueNative = MagickColor.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetBorderColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetBorderColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetBorderColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetBorderWidth(int value)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.MontageSettings_SetBorderWidth(Instance, (UIntPtr)value);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.MontageSettings_SetBorderWidth(Instance, (UIntPtr)value);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.MontageSettings_SetBorderWidth(Instance, (UIntPtr)value);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public void SetFillColor(IMagickColor<QuantumType>? value)
            {
                using (var valueNative = MagickColor.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetFillColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetFillColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetFillColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetFont(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetFont(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetFont(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetFont(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetFontPointsize(double value)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.MontageSettings_SetFontPointsize(Instance, value);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.MontageSettings_SetFontPointsize(Instance, value);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.MontageSettings_SetFontPointsize(Instance, value);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public void SetFrameGeometry(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetFrameGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetFrameGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetFrameGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetGeometry(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetGravity(Gravity value)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.MontageSettings_SetGravity(Instance, (UIntPtr)value);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.MontageSettings_SetGravity(Instance, (UIntPtr)value);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.MontageSettings_SetGravity(Instance, (UIntPtr)value);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public void SetShadow(bool value)
            {
                switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                {
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                case Architecture.X64:
                     NativeMethods.X64.MontageSettings_SetShadow(Instance, value);
                     break;
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                case Architecture.X86:
                     NativeMethods.X86.MontageSettings_SetShadow(Instance, value);
                     break;
                #endif
                #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                case Architecture.Arm64:
                     NativeMethods.Arm64.MontageSettings_SetShadow(Instance, value);
                     break;
                #endif
                default:
                     throw new NotSupportedException("Processor architecture not supported.");
                }
            }
            public void SetStrokeColor(IMagickColor<QuantumType>? value)
            {
                using (var valueNative = MagickColor.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetStrokeColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetStrokeColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetStrokeColor(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetTextureFileName(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetTextureFileName(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetTextureFileName(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetTextureFileName(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetTileGeometry(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetTileGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetTileGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetTileGeometry(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
            public void SetTitle(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
                    {
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    case Architecture.X64:
                         NativeMethods.X64.MontageSettings_SetTitle(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    case Architecture.X86:
                         NativeMethods.X86.MontageSettings_SetTitle(Instance, valueNative.Instance);
                         break;
                    #endif
                    #if PLATFORM_Arm64 || PLATFORM_AnyCPU
                    case Architecture.Arm64:
                         NativeMethods.Arm64.MontageSettings_SetTitle(Instance, valueNative.Instance);
                         break;
                    #endif
                    default:
                         throw new NotSupportedException("Processor architecture not supported.");
                    }
                }
            }
        }
        internal static INativeInstance CreateInstance(IMontageSettings<QuantumType>? instance)
        {
            if (instance == null)
                return NativeInstance.Zero;
            return MontageSettings.CreateNativeInstance(instance);
        }
    }
}
