// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Converts the current system time to timecode, relative to a provided frame rate.</summary>
    public unsafe partial class SystemTimeTimecodeProvider : TimecodeProvider  {
        ///<summary>Frame Rate</summary>
        public unsafe FrameRate FrameRate {
            get {return SystemTimeTimecodeProvider_ptr->FrameRate;}
            set {SystemTimeTimecodeProvider_ptr->FrameRate = value;}
        }
        static SystemTimeTimecodeProvider() {
            StaticClass = Main.GetClass("SystemTimeTimecodeProvider");
        }
        internal unsafe SystemTimeTimecodeProvider_fields* SystemTimeTimecodeProvider_ptr => (SystemTimeTimecodeProvider_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SystemTimeTimecodeProvider(IntPtr p) => UObject.Make<SystemTimeTimecodeProvider>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SystemTimeTimecodeProvider DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SystemTimeTimecodeProvider New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
