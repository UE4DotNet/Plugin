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
    ///<summary>Material Expression Set Material Attributes</summary>
    public unsafe partial class MaterialExpressionSetMaterialAttributes : MaterialExpression  {
         //TODO: array not UObject TArray Inputs
         //TODO: array not UObject TArray AttributeSetTypes
        static MaterialExpressionSetMaterialAttributes() {
            StaticClass = Main.GetClass("MaterialExpressionSetMaterialAttributes");
        }
        internal unsafe MaterialExpressionSetMaterialAttributes_fields* MaterialExpressionSetMaterialAttributes_ptr => (MaterialExpressionSetMaterialAttributes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSetMaterialAttributes(IntPtr p) => UObject.Make<MaterialExpressionSetMaterialAttributes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSetMaterialAttributes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSetMaterialAttributes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
