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
using UE4.MovieSceneCapture.Native;

namespace UE4.MovieSceneCapture {
    ///<summary>Image Sequence Protocol EXR</summary>
    public unsafe partial class ImageSequenceProtocol_EXR : ImageSequenceProtocol  {
        public bool bCompressed {
            get {return Main.GetGetBoolPropertyByName(this, "bCompressed"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompressed", value); }
        }
        ///<summary>The color gamut to use when storing HDR captured data.</summary>
        public unsafe byte CaptureGamut {
            get {return ImageSequenceProtocol_EXR_ptr->CaptureGamut;}
            set {ImageSequenceProtocol_EXR_ptr->CaptureGamut = value;}
        }
        static ImageSequenceProtocol_EXR() {
            StaticClass = Main.GetClass("ImageSequenceProtocol_EXR");
        }
        internal unsafe ImageSequenceProtocol_EXR_fields* ImageSequenceProtocol_EXR_ptr => (ImageSequenceProtocol_EXR_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageSequenceProtocol_EXR(IntPtr p) => UObject.Make<ImageSequenceProtocol_EXR>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageSequenceProtocol_EXR DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageSequenceProtocol_EXR New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
