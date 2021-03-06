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


namespace UE4.Engine{
        ///<summary>A subtitle localized to a specific language.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct LocalizedSubtitle {
            [FieldOffset(0)] byte LanguageExt; //TODO: string FString LanguageExt

            [FieldOffset(16)] byte Subtitles; //TODO: array TArray Subtitles

            [FieldOffset(32)] public bool bMature;

            [FieldOffset(32)] public bool bManualWordWrap;

            [FieldOffset(32)] public bool bSingleLine;

        }
}
