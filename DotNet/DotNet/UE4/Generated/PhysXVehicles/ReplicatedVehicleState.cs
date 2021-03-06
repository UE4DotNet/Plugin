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


namespace UE4.PhysXVehicles{
        ///<summary>Replicated Vehicle State</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct ReplicatedVehicleState {
            [FieldOffset(0)] public float SteeringInput;

            [FieldOffset(4)] public float ThrottleInput;

            [FieldOffset(8)] public float BrakeInput;

            [FieldOffset(12)] public float HandbrakeInput;

            [FieldOffset(16)] public int CurrentGear;

        }
}
