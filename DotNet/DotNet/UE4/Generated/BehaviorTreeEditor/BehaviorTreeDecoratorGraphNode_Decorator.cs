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
using UE4.BehaviorTreeEditor.Native;
using UE4.AIGraph;

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Decorator Graph Node Decorator</summary>
    public unsafe partial class BehaviorTreeDecoratorGraphNode_Decorator : BehaviorTreeDecoratorGraphNode  {
        ///<summary>Node Instance</summary>
        public unsafe UObject NodeInstance {
            get {return BehaviorTreeDecoratorGraphNode_Decorator_ptr->NodeInstance;}
            set {BehaviorTreeDecoratorGraphNode_Decorator_ptr->NodeInstance = value;}
        }
        ///<summary>Class Data</summary>
        public unsafe GraphNodeClassData ClassData {
            get {return BehaviorTreeDecoratorGraphNode_Decorator_ptr->ClassData;}
            set {BehaviorTreeDecoratorGraphNode_Decorator_ptr->ClassData = value;}
        }
        static BehaviorTreeDecoratorGraphNode_Decorator() {
            StaticClass = Main.GetClass("BehaviorTreeDecoratorGraphNode_Decorator");
        }
        internal unsafe BehaviorTreeDecoratorGraphNode_Decorator_fields* BehaviorTreeDecoratorGraphNode_Decorator_ptr => (BehaviorTreeDecoratorGraphNode_Decorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeDecoratorGraphNode_Decorator(IntPtr p) => UObject.Make<BehaviorTreeDecoratorGraphNode_Decorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeDecoratorGraphNode_Decorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeDecoratorGraphNode_Decorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
