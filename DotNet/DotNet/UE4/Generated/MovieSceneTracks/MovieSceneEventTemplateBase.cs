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


namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Event Template Base</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MovieSceneEventTemplateBase {
            [FieldOffset(32)] byte EventReceivers; //TODO: array TArray EventReceivers

            [FieldOffset(48)] public bool bFireEventsWhenForwards;

            [FieldOffset(48)] public bool bFireEventsWhenBackwards;

        }
}
