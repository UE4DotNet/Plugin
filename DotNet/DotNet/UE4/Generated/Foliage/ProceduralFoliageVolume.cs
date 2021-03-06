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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Procedural Foliage Volume</summary>
    public unsafe partial class ProceduralFoliageVolume : Volume  {
        ///<summary>Procedural Component</summary>
        public unsafe ProceduralFoliageComponent ProceduralComponent {
            get {return ProceduralFoliageVolume_ptr->ProceduralComponent;}
        }
        static ProceduralFoliageVolume() {
            StaticClass = Main.GetClass("ProceduralFoliageVolume");
        }
        internal unsafe ProceduralFoliageVolume_fields* ProceduralFoliageVolume_ptr => (ProceduralFoliageVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralFoliageVolume(IntPtr p) => UObject.Make<ProceduralFoliageVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralFoliageVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralFoliageVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
