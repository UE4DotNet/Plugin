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

using UE4.Engine;

namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct LandscapeSplineSegment_fields {
        [FieldOffset(56)] public LandscapeSplineSegmentConnection Connections;
        [FieldOffset(104)] public Name LayerName;
        [FieldOffset(116)] public bool bRaiseTerrain;
        [FieldOffset(116)] public bool bLowerTerrain;
        [FieldOffset(120)] public NativeArray SplineMeshes;
        [FieldOffset(140)] public Name CollisionProfileName;
        [FieldOffset(152)] public bool bCastShadow;
        [FieldOffset(156)] public int RandomSeed;
        [FieldOffset(160)] public float LDMaxDrawDistance;
        [FieldOffset(164)] public int TranslucencySortPriority;
        [FieldOffset(168)] public bool bHiddenInGame;
        [FieldOffset(168)] public bool bPlaceSplineMeshesInStreamingLevels;
        [FieldOffset(176)] public BodyInstance BodyInstance;
        [FieldOffset(544)] public bool bSelected;
        [FieldOffset(544)] public bool bNavDirty;
        [FieldOffset(552)] public InterpCurveVector SplineInfo;
        [FieldOffset(576)] public NativeArray Points;
        [FieldOffset(592)] public Box Bounds;
        [FieldOffset(624)] public NativeArray LocalMeshComponents;
        [FieldOffset(640)] public NativeArray ForeignWorlds;
        [FieldOffset(656)] public FGuid ModificationKey;
    }
    internal unsafe struct LandscapeSplineSegment_methods {
    }
    internal unsafe struct LandscapeSplineSegment_events {
    }
}
