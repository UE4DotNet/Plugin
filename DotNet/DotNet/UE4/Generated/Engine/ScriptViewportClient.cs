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
    ///<summary>Script Viewport Client</summary>
    public unsafe partial class ScriptViewportClient : UObject  {
        static ScriptViewportClient() {
            StaticClass = Main.GetClass("ScriptViewportClient");
        }
        internal unsafe ScriptViewportClient_fields* ScriptViewportClient_ptr => (ScriptViewportClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScriptViewportClient(IntPtr p) => UObject.Make<ScriptViewportClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScriptViewportClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScriptViewportClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
