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
using UE4.PolygonModeling.Native;
using UE4.MeshEditor;

namespace UE4.PolygonModeling {
    ///<summary>Extrudes the polygon along an axis</summary>
    public unsafe partial class ExtrudePolygonCommand : MeshEditorEditCommand  {
        static ExtrudePolygonCommand() {
            StaticClass = Main.GetClass("ExtrudePolygonCommand");
        }
        internal unsafe ExtrudePolygonCommand_fields* ExtrudePolygonCommand_ptr => (ExtrudePolygonCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ExtrudePolygonCommand(IntPtr p) => UObject.Make<ExtrudePolygonCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ExtrudePolygonCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ExtrudePolygonCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
