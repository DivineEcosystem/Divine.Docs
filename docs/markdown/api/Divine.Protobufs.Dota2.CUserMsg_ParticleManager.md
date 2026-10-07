# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager"></a> Class CUserMsg\_ParticleManager

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager : IExtendableMessage<CUserMsg_ParticleManager>, IMessage<CUserMsg_ParticleManager>, IEquatable<CUserMsg_ParticleManager>, IDeepCloneable<CUserMsg_ParticleManager>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)

#### Implements

IExtendableMessage<CUserMsg\_ParticleManager\>, 
IMessage<CUserMsg\_ParticleManager\>, 
[IEquatable<CUserMsg\_ParticleManager\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMsg\_ParticleManager\>\(CUserMsg\_ParticleManager, params CUserMsg\_ParticleManager\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager__ctor"></a> CUserMsg\_ParticleManager\(\)

```csharp
public CUserMsg_ParticleManager()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_"></a> CUserMsg\_ParticleManager\(CUserMsg\_ParticleManager\)

```csharp
public CUserMsg_ParticleManager(CUserMsg_ParticleManager other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_AddFanFieldNumber"></a> AddFanFieldNumber

```csharp
public const int AddFanFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_AddModellistOverrideElementFieldNumber"></a> AddModellistOverrideElementFieldNumber

```csharp
public const int AddModellistOverrideElementFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ChangeControlPointAttachmentFieldNumber"></a> ChangeControlPointAttachmentFieldNumber

```csharp
public const int ChangeControlPointAttachmentFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearModellistOverrideFieldNumber"></a> ClearModellistOverrideFieldNumber

```csharp
public const int ClearModellistOverrideFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreateParticleFieldNumber"></a> CreateParticleFieldNumber

```csharp
public const int CreateParticleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreatePhysicsSimFieldNumber"></a> CreatePhysicsSimFieldNumber

```csharp
public const int CreatePhysicsSimFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreateSmokeGridFieldNumber"></a> CreateSmokeGridFieldNumber

```csharp
public const int CreateSmokeGridFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticleFieldNumber"></a> DestroyParticleFieldNumber

```csharp
public const int DestroyParticleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticleInvolvingFieldNumber"></a> DestroyParticleInvolvingFieldNumber

```csharp
public const int DestroyParticleInvolvingFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticleNamedFieldNumber"></a> DestroyParticleNamedFieldNumber

```csharp
public const int DestroyParticleNamedFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyPhysicsSimFieldNumber"></a> DestroyPhysicsSimFieldNumber

```csharp
public const int DestroyPhysicsSimFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_FreezeParticleInvolvingFieldNumber"></a> FreezeParticleInvolvingFieldNumber

```csharp
public const int FreezeParticleInvolvingFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleCanFreezeFieldNumber"></a> ParticleCanFreezeFieldNumber

```csharp
public const int ParticleCanFreezeFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleFreezeTransitionOverrideFieldNumber"></a> ParticleFreezeTransitionOverrideFieldNumber

```csharp
public const int ParticleFreezeTransitionOverrideFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleSkipToTimeFieldNumber"></a> ParticleSkipToTimeFieldNumber

```csharp
public const int ParticleSkipToTimeFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ReleaseParticleIndexFieldNumber"></a> ReleaseParticleIndexFieldNumber

```csharp
public const int ReleaseParticleIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_RemoveFanFieldNumber"></a> RemoveFanFieldNumber

```csharp
public const int RemoveFanFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetControlPointModelFieldNumber"></a> SetControlPointModelFieldNumber

```csharp
public const int SetControlPointModelFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetControlPointSnapshotFieldNumber"></a> SetControlPointSnapshotFieldNumber

```csharp
public const int SetControlPointSnapshotFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetMaterialOverrideFieldNumber"></a> SetMaterialOverrideFieldNumber

```csharp
public const int SetMaterialOverrideFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetNamedValueContextFieldNumber"></a> SetNamedValueContextFieldNumber

```csharp
public const int SetNamedValueContextFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetOverrideTextureFieldNumber"></a> SetOverrideTextureFieldNumber

```csharp
public const int SetOverrideTextureFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleClusterGrowthFieldNumber"></a> SetParticleClusterGrowthFieldNumber

```csharp
public const int SetParticleClusterGrowthFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleFowPropertiesFieldNumber"></a> SetParticleFowPropertiesFieldNumber

```csharp
public const int SetParticleFowPropertiesFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleShouldCheckFowFieldNumber"></a> SetParticleShouldCheckFowFieldNumber

```csharp
public const int SetParticleShouldCheckFowFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleTextFieldNumber"></a> SetParticleTextFieldNumber

```csharp
public const int SetParticleTextFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetSceneObjectGenericFlagFieldNumber"></a> SetSceneObjectGenericFlagFieldNumber

```csharp
public const int SetSceneObjectGenericFlagFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetSceneObjectTintAndDesatFieldNumber"></a> SetSceneObjectTintAndDesatFieldNumber

```csharp
public const int SetSceneObjectTintAndDesatFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetTextureAttributeFieldNumber"></a> SetTextureAttributeFieldNumber

```csharp
public const int SetTextureAttributeFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetVdataFieldNumber"></a> SetVdataFieldNumber

```csharp
public const int SetVdataFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateEntityPositionFieldNumber"></a> UpdateEntityPositionFieldNumber

```csharp
public const int UpdateEntityPositionFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateFanFieldNumber"></a> UpdateFanFieldNumber

```csharp
public const int UpdateFanFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleEntFieldNumber"></a> UpdateParticleEntFieldNumber

```csharp
public const int UpdateParticleEntFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleFallbackFieldNumber"></a> UpdateParticleFallbackFieldNumber

```csharp
public const int UpdateParticleFallbackFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleFieldNumber"></a> UpdateParticleFieldNumber

```csharp
public const int UpdateParticleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleFwdFieldNumber"></a> UpdateParticleFwdFieldNumber

```csharp
public const int UpdateParticleFwdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleOffsetFieldNumber"></a> UpdateParticleOffsetFieldNumber

```csharp
public const int UpdateParticleOffsetFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleOrientFieldNumber"></a> UpdateParticleOrientFieldNumber

```csharp
public const int UpdateParticleOrientFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleSetFrozenFieldNumber"></a> UpdateParticleSetFrozenFieldNumber

```csharp
public const int UpdateParticleSetFrozenFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleShouldDrawFieldNumber"></a> UpdateParticleShouldDrawFieldNumber

```csharp
public const int UpdateParticleShouldDrawFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleTransformFieldNumber"></a> UpdateParticleTransformFieldNumber

```csharp
public const int UpdateParticleTransformFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_AddFan"></a> AddFan

```csharp
public CUserMsg_ParticleManager.Types.AddFan AddFan { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddFan.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_AddModellistOverrideElement"></a> AddModellistOverrideElement

```csharp
public CUserMsg_ParticleManager.Types.AddModellistOverrideElement AddModellistOverrideElement { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ChangeControlPointAttachment"></a> ChangeControlPointAttachment

```csharp
public CUserMsg_ParticleManager.Types.ChangeControlPointAttachment ChangeControlPointAttachment { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearModellistOverride"></a> ClearModellistOverride

```csharp
public CUserMsg_ParticleManager.Types.ClearModellistOverride ClearModellistOverride { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreateParticle"></a> CreateParticle

```csharp
public CUserMsg_ParticleManager.Types.CreateParticle CreateParticle { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreateParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreateParticle.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreatePhysicsSim"></a> CreatePhysicsSim

```csharp
public CUserMsg_ParticleManager.Types.CreatePhysicsSim CreatePhysicsSim { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CreateSmokeGrid"></a> CreateSmokeGrid

```csharp
public CUserMsg_ParticleManager.Types.CreateSmokeGrid CreateSmokeGrid { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreateSmokeGrid](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreateSmokeGrid.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticle"></a> DestroyParticle

```csharp
public CUserMsg_ParticleManager.Types.DestroyParticle DestroyParticle { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticleInvolving"></a> DestroyParticleInvolving

```csharp
public CUserMsg_ParticleManager.Types.DestroyParticleInvolving DestroyParticleInvolving { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleInvolving](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleInvolving.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyParticleNamed"></a> DestroyParticleNamed

```csharp
public CUserMsg_ParticleManager.Types.DestroyParticleNamed DestroyParticleNamed { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_DestroyPhysicsSim"></a> DestroyPhysicsSim

```csharp
public CUserMsg_ParticleManager.Types.DestroyPhysicsSim DestroyPhysicsSim { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_FreezeParticleInvolving"></a> FreezeParticleInvolving

```csharp
public CUserMsg_ParticleManager.Types.FreezeParticleInvolving FreezeParticleInvolving { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[FreezeParticleInvolving](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.FreezeParticleInvolving.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleCanFreeze"></a> ParticleCanFreeze

```csharp
public CUserMsg_ParticleManager.Types.ParticleCanFreeze ParticleCanFreeze { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleFreezeTransitionOverride"></a> ParticleFreezeTransitionOverride

```csharp
public CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride ParticleFreezeTransitionOverride { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ParticleSkipToTime"></a> ParticleSkipToTime

```csharp
public CUserMsg_ParticleManager.Types.ParticleSkipToTime ParticleSkipToTime { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ReleaseParticleIndex"></a> ReleaseParticleIndex

```csharp
public CUserMsg_ParticleManager.Types.ReleaseParticleIndex ReleaseParticleIndex { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_RemoveFan"></a> RemoveFan

```csharp
public CUserMsg_ParticleManager.Types.RemoveFan RemoveFan { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[RemoveFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.RemoveFan.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetControlPointModel"></a> SetControlPointModel

```csharp
public CUserMsg_ParticleManager.Types.SetControlPointModel SetControlPointModel { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetControlPointSnapshot"></a> SetControlPointSnapshot

```csharp
public CUserMsg_ParticleManager.Types.SetControlPointSnapshot SetControlPointSnapshot { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetMaterialOverride"></a> SetMaterialOverride

```csharp
public CUserMsg_ParticleManager.Types.SetMaterialOverride SetMaterialOverride { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetNamedValueContext"></a> SetNamedValueContext

```csharp
public CUserMsg_ParticleManager.Types.SetParticleNamedValueContext SetNamedValueContext { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetOverrideTexture"></a> SetOverrideTexture

```csharp
public CUserMsg_ParticleManager.Types.SetOverrideTexture SetOverrideTexture { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleClusterGrowth"></a> SetParticleClusterGrowth

```csharp
public CUserMsg_ParticleManager.Types.SetParticleClusterGrowth SetParticleClusterGrowth { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleClusterGrowth](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleClusterGrowth.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleFowProperties"></a> SetParticleFowProperties

```csharp
public CUserMsg_ParticleManager.Types.SetParticleFoWProperties SetParticleFowProperties { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleShouldCheckFow"></a> SetParticleShouldCheckFow

```csharp
public CUserMsg_ParticleManager.Types.SetParticleShouldCheckFoW SetParticleShouldCheckFow { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleShouldCheckFoW](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleShouldCheckFoW.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetParticleText"></a> SetParticleText

```csharp
public CUserMsg_ParticleManager.Types.SetParticleText SetParticleText { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetSceneObjectGenericFlag"></a> SetSceneObjectGenericFlag

```csharp
public CUserMsg_ParticleManager.Types.SetSceneObjectGenericFlag SetSceneObjectGenericFlag { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectGenericFlag](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectGenericFlag.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetSceneObjectTintAndDesat"></a> SetSceneObjectTintAndDesat

```csharp
public CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat SetSceneObjectTintAndDesat { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetTextureAttribute"></a> SetTextureAttribute

```csharp
public CUserMsg_ParticleManager.Types.SetTextureAttribute SetTextureAttribute { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetVdata"></a> SetVdata

```csharp
public CUserMsg_ParticleManager.Types.SetVData SetVdata { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Type"></a> Type

```csharp
public PARTICLE_MESSAGE Type { get; set; }
```

#### Property Value

 [PARTICLE\_MESSAGE](Divine.Protobufs.Dota2.PARTICLE\_MESSAGE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateEntityPosition"></a> UpdateEntityPosition

```csharp
public CUserMsg_ParticleManager.Types.UpdateEntityPosition UpdateEntityPosition { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateEntityPosition](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateEntityPosition.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateFan"></a> UpdateFan

```csharp
public CUserMsg_ParticleManager.Types.UpdateFan UpdateFan { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticle"></a> UpdateParticle

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticle_OBSOLETE UpdateParticle { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticle\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticle\_OBSOLETE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleEnt"></a> UpdateParticleEnt

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleEnt UpdateParticleEnt { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleEnt](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleEnt.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleFallback"></a> UpdateParticleFallback

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleFallback UpdateParticleFallback { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFallback](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFallback.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleFwd"></a> UpdateParticleFwd

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE UpdateParticleFwd { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleOffset"></a> UpdateParticleOffset

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleOffset UpdateParticleOffset { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleOffset](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleOffset.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleOrient"></a> UpdateParticleOrient

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleOrient_OBSOLETE UpdateParticleOrient { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleOrient\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleOrient\_OBSOLETE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleSetFrozen"></a> UpdateParticleSetFrozen

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen UpdateParticleSetFrozen { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleShouldDraw"></a> UpdateParticleShouldDraw

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw UpdateParticleShouldDraw { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_UpdateParticleTransform"></a> UpdateParticleTransform

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleTransform UpdateParticleTransform { get; set; }
```

#### Property Value

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleTransform](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleTransform.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearExtension__1_Google_Protobuf_Extension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> ClearExtension<TValue\>\(Extension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public void ClearExtension<TValue>(Extension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` Extension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearExtension__1_Google_Protobuf_RepeatedExtension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> ClearExtension<TValue\>\(RepeatedExtension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public void ClearExtension<TValue>(RepeatedExtension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` RepeatedExtension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_"></a> Equals\(CUserMsg\_ParticleManager\)

```csharp
public bool Equals(CUserMsg_ParticleManager other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_GetExtension__1_Google_Protobuf_Extension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> GetExtension<TValue\>\(Extension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public TValue GetExtension<TValue>(Extension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` Extension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Returns

 TValue

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_GetExtension__1_Google_Protobuf_RepeatedExtension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> GetExtension<TValue\>\(RepeatedExtension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` RepeatedExtension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Returns

 RepeatedField<TValue\>

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_GetOrInitializeExtension__1_Google_Protobuf_RepeatedExtension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> GetOrInitializeExtension<TValue\>\(RepeatedExtension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` RepeatedExtension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Returns

 RepeatedField<TValue\>

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_HasExtension__1_Google_Protobuf_Extension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0__"></a> HasExtension<TValue\>\(Extension<CUserMsg\_ParticleManager, TValue\>\)

```csharp
public bool HasExtension<TValue>(Extension<CUserMsg_ParticleManager, TValue> extension)
```

#### Parameters

`extension` Extension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_"></a> MergeFrom\(CUserMsg\_ParticleManager\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_SetExtension__1_Google_Protobuf_Extension_Divine_Protobufs_Dota2_CUserMsg_ParticleManager___0____0_"></a> SetExtension<TValue\>\(Extension<CUserMsg\_ParticleManager, TValue\>, TValue\)

```csharp
public void SetExtension<TValue>(Extension<CUserMsg_ParticleManager, TValue> extension, TValue value)
```

#### Parameters

`extension` Extension<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md), TValue\>

`value` TValue

#### Type Parameters

`TValue` 

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

