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
    ///<summary>Material Expression Arctangent 2Fast</summary>
    public unsafe partial class MaterialExpressionArctangent2Fast : MaterialExpression  {
        ///<summary>Y</summary>
        public unsafe ExpressionInput Y {
            get {return MaterialExpressionArctangent2Fast_ptr->Y;}
            set {MaterialExpressionArctangent2Fast_ptr->Y = value;}
        }
        ///<summary>X</summary>
        public unsafe ExpressionInput X {
            get {return MaterialExpressionArctangent2Fast_ptr->X;}
            set {MaterialExpressionArctangent2Fast_ptr->X = value;}
        }
        static MaterialExpressionArctangent2Fast() {
            StaticClass = Main.GetClass("MaterialExpressionArctangent2Fast");
        }
        internal unsafe MaterialExpressionArctangent2Fast_fields* MaterialExpressionArctangent2Fast_ptr => (MaterialExpressionArctangent2Fast_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionArctangent2Fast(IntPtr p) => UObject.Make<MaterialExpressionArctangent2Fast>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionArctangent2Fast DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionArctangent2Fast New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
