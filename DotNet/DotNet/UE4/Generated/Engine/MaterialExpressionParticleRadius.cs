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
    ///<summary>Material Expression Particle Radius</summary>
    public unsafe partial class MaterialExpressionParticleRadius : MaterialExpression  {
        static MaterialExpressionParticleRadius() {
            StaticClass = Main.GetClass("MaterialExpressionParticleRadius");
        }
        internal unsafe MaterialExpressionParticleRadius_fields* MaterialExpressionParticleRadius_ptr => (MaterialExpressionParticleRadius_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionParticleRadius(IntPtr p) => UObject.Make<MaterialExpressionParticleRadius>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionParticleRadius DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionParticleRadius New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
