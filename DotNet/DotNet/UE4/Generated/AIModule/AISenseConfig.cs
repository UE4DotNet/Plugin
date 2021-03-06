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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AISense Config</summary>
    public unsafe partial class AISenseConfig : UObject  {
        ///<summary>Debug Color</summary>
        public unsafe Color DebugColor {
            get {return AISenseConfig_ptr->DebugColor;}
        }
        ///<summary>specifies age limit after stimuli generated by this sense become forgotten. 0 means "never"</summary>
        public unsafe float MaxAge {
            get {return AISenseConfig_ptr->MaxAge;}
        }
        public bool bStartsEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bStartsEnabled"); }
        }
        static AISenseConfig() {
            StaticClass = Main.GetClass("AISenseConfig");
        }
        internal unsafe AISenseConfig_fields* AISenseConfig_ptr => (AISenseConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseConfig(IntPtr p) => UObject.Make<AISenseConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
