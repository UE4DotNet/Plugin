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
    ///<summary>
    ///Defines level bounds
    ///Updates bounding box automatically based on actors transformation changes or holds fixed user defined bounding box
    ///</summary>
    ///<remarks>Uses only actors where AActor::IsLevelBoundsRelevant() == true</remarks>
    public unsafe partial class LevelBounds : Actor  {
        public bool bAutoUpdateBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoUpdateBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoUpdateBounds", value); }
        }
        static LevelBounds() {
            StaticClass = Main.GetClass("LevelBounds");
        }
        internal unsafe LevelBounds_fields* LevelBounds_ptr => (LevelBounds_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelBounds(IntPtr p) => UObject.Make<LevelBounds>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelBounds DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelBounds New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
