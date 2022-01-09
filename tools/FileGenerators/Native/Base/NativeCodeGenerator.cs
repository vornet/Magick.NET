﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Collections.Generic;
using System.Linq;

namespace FileGenerator.Native
{
    internal abstract class NativeCodeGenerator : CodeGenerator
    {
        private static MagickClass[] _classes = default!;

        protected NativeCodeGenerator(MagickClass magickClass)
        {
            Class = magickClass;
        }

        protected NativeCodeGenerator(NativeCodeGenerator parent)
          : base(parent)
        {
            Class = parent.Class;
        }

        protected MagickClass Class { get; }

        protected static void RegisterClasses(IEnumerable<MagickClass> magickClasses)
            => _classes = magickClasses.ToArray();

        protected string? GetArgumentsDeclaration(IEnumerable<MagickArgument> arguments)
        {
            return GetArgumentsDeclaration(arguments, (argument) =>
            {
                var isNullable = IsNullable(argument.Type);

                if (argument.IsOut && !IsDynamic(argument.Type))
                    return "out " + argument.Type.NativeName;
                else if (argument.IsOut)
                    return "out " + argument.Type.ManagedName;
                else if (IsQuantumType(argument.Type))
                    return "I" + argument.Type.ManagedName + "<QuantumType>?";
                else if (HasInterface(argument.Type))
                    return "I" + argument.Type.ManagedName + (isNullable ? "?" : string.Empty);
                else
                    return argument.Type.ManagedName + (isNullable ? "?" : string.Empty);
            }, (argument) =>
            {
                return argument.IsHidden;
            });
        }

        protected string? GetArgumentsDeclaration(IEnumerable<MagickArgument> arguments, Func<MagickArgument, string> typeFunc, Func<MagickArgument, bool> skipFunc)
        {
            string? result = null;

            foreach (var argument in arguments)
            {
                if (skipFunc(argument))
                    continue;

                if (result != null)
                    result += ", ";

                result += typeFunc(argument) + " " + argument.Name;
            }

            return result;
        }

        protected string? GetNativeArgumentsCall(IEnumerable<MagickArgument> arguments)
        {
            string? result = null;

            foreach (var argument in arguments)
            {
                if (result != null)
                    result += ", ";

                if (argument.IsOut)
                {
                    if (!IsDynamic(argument.Type))
                        result += "out ";
                }
                else
                {
                    result += argument.Type.NativeTypeCast;
                }

                if (argument.Type.IsFixed)
                {
                    result += argument.Name + "Fixed";
                }
                else if (NeedsCreate(argument.Type))
                {
                    result += argument.Name + "Native";
                    if (argument.IsOut)
                        result += "Out";
                    else
                        result += ".Instance";
                }
                else if (argument.Type.HasInstance)
                {
                    result += argument.Type.ManagedName + ".GetInstance(" + argument.Name + ")";
                }
                else
                {
                    result += argument.Name;
                }
            }

            return result;
        }

        protected string? GetNativeArgumentsCall(MagickMethod method)
        {
            var arguments = GetNativeArgumentsCall(method.Arguments);

            if (Class.IsStatic || method.IsStatic)
                return arguments;
            else if (string.IsNullOrEmpty(arguments))
                return "Instance";
            else
                return "Instance, " + arguments;
        }

        protected string? GetNativeArgumentsDeclaration(IEnumerable<MagickArgument> arguments)
        {
            return GetArgumentsDeclaration(arguments, (argument) =>
            {
                var isNullable = argument.Type.IsDelegate;

                if (argument.Type.HasInstance || argument.Type.IsString)
                    return "IntPtr";

                if (argument.Type.IsFixed)
                    return argument.Type.FixedName;

                if (argument.Type.IsBool)
                    return "[MarshalAs(UnmanagedType.Bool)] bool";

                if (argument.IsOut && !IsDynamic(argument.Type))
                    return "out " + argument.Type.NativeName;
                else
                    return argument.Type.NativeName + (isNullable ? "?" : string.Empty);
            }, (argument) =>
            {
                return false;
            });
        }

        protected string? GetNativeArgumentsDeclaration(MagickMethod method)
        {
            var arguments = GetNativeArgumentsDeclaration(method.Arguments);

            if (Class.IsStatic || method.IsStatic)
                return arguments;
            else if (string.IsNullOrEmpty(arguments))
                return "IntPtr Instance";
            else
                return "IntPtr Instance, " + arguments;
        }

        protected bool HasInterface(MagickType type)
            => _classes.Any(c => c.Name == type.ManagedName && c.HasInterface);

        protected bool HasSpan(MagickMethod method)
            => method.Arguments.Any(argument => argument.Type.IsSpan);

        protected bool IsDynamic(string typeName)
            => _classes.Any(c => c.Name == typeName && c.IsDynamic);

        protected bool IsNullable(MagickType type)
            => !type.IsVoid && !NotNullable(type) && (type.IsNativeString || type.IsDelegate || NeedsCreate(type) || HasInterface(type));

        protected bool IsDynamic(MagickType type)
            => IsDynamic(type.ManagedName);

        protected bool IsQuantumType(MagickType type)
            => _classes.Any(c => c.Name == type.ManagedName && c.IsQuantumType);

        protected bool NeedsCreate(MagickType type)
        {
            if (type.IsString)
                return true;

            return IsDynamic(type.ManagedName);
        }

        protected void WriteCheckException(bool throws)
        {
            if (!throws)
                return;

            if (Class.IsStatic)
                WriteLine("MagickExceptionHelper.Check(exception);");
            else
                WriteLine("CheckException(exception);");
        }

        protected void WriteNativeIf(string action)
            => WriteNativeIfContent(action);

        protected void WriteNativeIfContent(string action)
        {
            WriteLine("switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)");
            WriteLine("{");

            WriteLine("#if PLATFORM_x64 || PLATFORM_AnyCPU");
            WriteLine("case Architecture.X64:");
            WriteLine("     " + string.Format(action, "X64"));
            WriteLine("     break;");
            WriteLine("#endif");

            WriteLine("#if PLATFORM_x86 || PLATFORM_AnyCPU");
            WriteLine("case Architecture.X86:");
            WriteLine("     " + string.Format(action, "X86"));
            WriteLine("     break;");
            WriteLine("#endif");

            WriteLine("#if PLATFORM_Arm64 || PLATFORM_AnyCPU");
            WriteLine("case Architecture.Arm64:");
            WriteLine("     " + string.Format(action, "Arm64"));
            WriteLine("     break;");
            WriteLine("#endif");

            WriteLine("default:");
            WriteLine("     throw new NotSupportedException(\"Processor architecture not supported.\");");

            WriteLine("}");
        }

        protected void WriteThrowStart(bool throws)
        {
            if (throws)
                WriteLine("IntPtr exception = IntPtr.Zero;");
        }

        protected override void WriteUsing()
        {
            WriteLine("using System;");
            WriteLine("using System.Security;");
            WriteLine("using System.Runtime.InteropServices;");

            if (UsesQuantumType())
                WriteQuantumType();
            else
                WriteLine();
        }

        private bool UsesQuantumType()
        {
            if (Class.Properties.Any(property => UsesQuantumType(property.Type)))
                return true;

            if (Class.Methods.Any(method => UsesQuantumType(method.ReturnType) || method.Arguments.Any(argument => UsesQuantumType(argument.Type))))
                return true;

            return false;
        }

        private bool NotNullable(MagickType type)
            => _classes.Any(c => c.Name == type.ManagedName && c.NotNullable);

        private bool UsesQuantumType(MagickType type)
            => type.IsQuantumType || IsQuantumType(type);
    }
}
