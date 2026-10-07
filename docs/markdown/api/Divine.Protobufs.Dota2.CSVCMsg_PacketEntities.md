# <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities"></a> Class CSVCMsg\_PacketEntities

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_PacketEntities : IMessage<CSVCMsg_PacketEntities>, IEquatable<CSVCMsg_PacketEntities>, IDeepCloneable<CSVCMsg_PacketEntities>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)

#### Implements

IMessage<CSVCMsg\_PacketEntities\>, 
[IEquatable<CSVCMsg\_PacketEntities\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_PacketEntities\>, 
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
[EnumerableExtensions.In<CSVCMsg\_PacketEntities\>\(CSVCMsg\_PacketEntities, params CSVCMsg\_PacketEntities\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities__ctor"></a> CSVCMsg\_PacketEntities\(\)

```csharp
public CSVCMsg_PacketEntities()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities__ctor_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_"></a> CSVCMsg\_PacketEntities\(CSVCMsg\_PacketEntities\)

```csharp
public CSVCMsg_PacketEntities(CSVCMsg_PacketEntities other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ActiveSpawngroupHandleFieldNumber"></a> ActiveSpawngroupHandleFieldNumber

```csharp
public const int ActiveSpawngroupHandleFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_AlternateBaselinesFieldNumber"></a> AlternateBaselinesFieldNumber

```csharp
public const int AlternateBaselinesFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_BaselineFieldNumber"></a> BaselineFieldNumber

```csharp
public const int BaselineFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CmdRecvStatusFieldNumber"></a> CmdRecvStatusFieldNumber

```csharp
public const int CmdRecvStatusFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CqDiscardedCommandTicksFieldNumber"></a> CqDiscardedCommandTicksFieldNumber

```csharp
public const int CqDiscardedCommandTicksFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CqStarvedCommandTicksFieldNumber"></a> CqStarvedCommandTicksFieldNumber

```csharp
public const int CqStarvedCommandTicksFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_DeltaFromFieldNumber"></a> DeltaFromFieldNumber

```csharp
public const int DeltaFromFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_DevPaddingFieldNumber"></a> DevPaddingFieldNumber

```csharp
public const int DevPaddingFieldNumber = 999
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_EntityDataFieldNumber"></a> EntityDataFieldNumber

```csharp
public const int EntityDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasPvsVisBitsDeprecatedFieldNumber"></a> HasPvsVisBitsDeprecatedFieldNumber

```csharp
public const int HasPvsVisBitsDeprecatedFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LastCmdNumberExecutedFieldNumber"></a> LastCmdNumberExecutedFieldNumber

```csharp
public const int LastCmdNumberExecutedFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LastCmdNumberRecvDeltaFieldNumber"></a> LastCmdNumberRecvDeltaFieldNumber

```csharp
public const int LastCmdNumberRecvDeltaFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LegacyIsDeltaFieldNumber"></a> LegacyIsDeltaFieldNumber

```csharp
public const int LegacyIsDeltaFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MaxEntriesFieldNumber"></a> MaxEntriesFieldNumber

```csharp
public const int MaxEntriesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MaxSpawngroupCreationsequenceFieldNumber"></a> MaxSpawngroupCreationsequenceFieldNumber

```csharp
public const int MaxSpawngroupCreationsequenceFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_NonTransmittedEntitiesFieldNumber"></a> NonTransmittedEntitiesFieldNumber

```csharp
public const int NonTransmittedEntitiesFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_OutofpvsEntityUpdatesFieldNumber"></a> OutofpvsEntityUpdatesFieldNumber

```csharp
public const int OutofpvsEntityUpdatesFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_PendingFullFrameFieldNumber"></a> PendingFullFrameFieldNumber

```csharp
public const int PendingFullFrameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_SerializedEntitiesFieldNumber"></a> SerializedEntitiesFieldNumber

```csharp
public const int SerializedEntitiesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ServerTickFieldNumber"></a> ServerTickFieldNumber

```csharp
public const int ServerTickFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_UpdateBaselineFieldNumber"></a> UpdateBaselineFieldNumber

```csharp
public const int UpdateBaselineFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_UpdatedEntriesFieldNumber"></a> UpdatedEntriesFieldNumber

```csharp
public const int UpdatedEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ActiveSpawngroupHandle"></a> ActiveSpawngroupHandle

```csharp
public uint ActiveSpawngroupHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_AlternateBaselines"></a> AlternateBaselines

```csharp
public RepeatedField<CSVCMsg_PacketEntities.Types.alternate_baseline_t> AlternateBaselines { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Baseline"></a> Baseline

```csharp
public int Baseline { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CmdRecvStatus"></a> CmdRecvStatus

```csharp
public RepeatedField<int> CmdRecvStatus { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CqDiscardedCommandTicks"></a> CqDiscardedCommandTicks

```csharp
public uint CqDiscardedCommandTicks { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CqStarvedCommandTicks"></a> CqStarvedCommandTicks

```csharp
public uint CqStarvedCommandTicks { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_DeltaFrom"></a> DeltaFrom

```csharp
public int DeltaFrom { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_DevPadding"></a> DevPadding

```csharp
public ByteString DevPadding { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_EntityData"></a> EntityData

```csharp
public ByteString EntityData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasActiveSpawngroupHandle"></a> HasActiveSpawngroupHandle

```csharp
public bool HasActiveSpawngroupHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasBaseline"></a> HasBaseline

```csharp
public bool HasBaseline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasCqDiscardedCommandTicks"></a> HasCqDiscardedCommandTicks

```csharp
public bool HasCqDiscardedCommandTicks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasCqStarvedCommandTicks"></a> HasCqStarvedCommandTicks

```csharp
public bool HasCqStarvedCommandTicks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasDeltaFrom"></a> HasDeltaFrom

```csharp
public bool HasDeltaFrom { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasDevPadding"></a> HasDevPadding

```csharp
public bool HasDevPadding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasEntityData"></a> HasEntityData

```csharp
public bool HasEntityData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasHasPvsVisBitsDeprecated"></a> HasHasPvsVisBitsDeprecated

```csharp
public bool HasHasPvsVisBitsDeprecated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasLastCmdNumberExecuted"></a> HasLastCmdNumberExecuted

```csharp
public bool HasLastCmdNumberExecuted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasLastCmdNumberRecvDelta"></a> HasLastCmdNumberRecvDelta

```csharp
public bool HasLastCmdNumberRecvDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasLegacyIsDelta"></a> HasLegacyIsDelta

```csharp
public bool HasLegacyIsDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasMaxEntries"></a> HasMaxEntries

```csharp
public bool HasMaxEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasMaxSpawngroupCreationsequence"></a> HasMaxSpawngroupCreationsequence

```csharp
public bool HasMaxSpawngroupCreationsequence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasPendingFullFrame"></a> HasPendingFullFrame

```csharp
public bool HasPendingFullFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasPvsVisBitsDeprecated"></a> HasPvsVisBitsDeprecated

```csharp
public uint HasPvsVisBitsDeprecated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasSerializedEntities"></a> HasSerializedEntities

```csharp
public bool HasSerializedEntities { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasServerTick"></a> HasServerTick

```csharp
public bool HasServerTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasUpdateBaseline"></a> HasUpdateBaseline

```csharp
public bool HasUpdateBaseline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_HasUpdatedEntries"></a> HasUpdatedEntries

```csharp
public bool HasUpdatedEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LastCmdNumberExecuted"></a> LastCmdNumberExecuted

```csharp
public uint LastCmdNumberExecuted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LastCmdNumberRecvDelta"></a> LastCmdNumberRecvDelta

```csharp
public int LastCmdNumberRecvDelta { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_LegacyIsDelta"></a> LegacyIsDelta

```csharp
public bool LegacyIsDelta { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MaxEntries"></a> MaxEntries

```csharp
public int MaxEntries { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MaxSpawngroupCreationsequence"></a> MaxSpawngroupCreationsequence

```csharp
public uint MaxSpawngroupCreationsequence { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_NonTransmittedEntities"></a> NonTransmittedEntities

```csharp
public CSVCMsg_PacketEntities.Types.non_transmitted_entities_t NonTransmittedEntities { get; set; }
```

#### Property Value

 [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_OutofpvsEntityUpdates"></a> OutofpvsEntityUpdates

```csharp
public CSVCMsg_PacketEntities.Types.outofpvs_entity_updates_t OutofpvsEntityUpdates { get; set; }
```

#### Property Value

 [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[outofpvs\_entity\_updates\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.outofpvs\_entity\_updates\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_PacketEntities> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_PendingFullFrame"></a> PendingFullFrame

```csharp
public bool PendingFullFrame { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_SerializedEntities"></a> SerializedEntities

```csharp
public ByteString SerializedEntities { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ServerTick"></a> ServerTick

```csharp
public uint ServerTick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_UpdateBaseline"></a> UpdateBaseline

```csharp
public bool UpdateBaseline { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_UpdatedEntries"></a> UpdatedEntries

```csharp
public int UpdatedEntries { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearActiveSpawngroupHandle"></a> ClearActiveSpawngroupHandle\(\)

```csharp
public void ClearActiveSpawngroupHandle()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearBaseline"></a> ClearBaseline\(\)

```csharp
public void ClearBaseline()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearCqDiscardedCommandTicks"></a> ClearCqDiscardedCommandTicks\(\)

```csharp
public void ClearCqDiscardedCommandTicks()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearCqStarvedCommandTicks"></a> ClearCqStarvedCommandTicks\(\)

```csharp
public void ClearCqStarvedCommandTicks()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearDeltaFrom"></a> ClearDeltaFrom\(\)

```csharp
public void ClearDeltaFrom()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearDevPadding"></a> ClearDevPadding\(\)

```csharp
public void ClearDevPadding()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearEntityData"></a> ClearEntityData\(\)

```csharp
public void ClearEntityData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearHasPvsVisBitsDeprecated"></a> ClearHasPvsVisBitsDeprecated\(\)

```csharp
public void ClearHasPvsVisBitsDeprecated()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearLastCmdNumberExecuted"></a> ClearLastCmdNumberExecuted\(\)

```csharp
public void ClearLastCmdNumberExecuted()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearLastCmdNumberRecvDelta"></a> ClearLastCmdNumberRecvDelta\(\)

```csharp
public void ClearLastCmdNumberRecvDelta()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearLegacyIsDelta"></a> ClearLegacyIsDelta\(\)

```csharp
public void ClearLegacyIsDelta()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearMaxEntries"></a> ClearMaxEntries\(\)

```csharp
public void ClearMaxEntries()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearMaxSpawngroupCreationsequence"></a> ClearMaxSpawngroupCreationsequence\(\)

```csharp
public void ClearMaxSpawngroupCreationsequence()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearPendingFullFrame"></a> ClearPendingFullFrame\(\)

```csharp
public void ClearPendingFullFrame()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearSerializedEntities"></a> ClearSerializedEntities\(\)

```csharp
public void ClearSerializedEntities()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearServerTick"></a> ClearServerTick\(\)

```csharp
public void ClearServerTick()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearUpdateBaseline"></a> ClearUpdateBaseline\(\)

```csharp
public void ClearUpdateBaseline()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ClearUpdatedEntries"></a> ClearUpdatedEntries\(\)

```csharp
public void ClearUpdatedEntries()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_PacketEntities Clone()
```

#### Returns

 [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Equals_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_"></a> Equals\(CSVCMsg\_PacketEntities\)

```csharp
public bool Equals(CSVCMsg_PacketEntities other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_"></a> MergeFrom\(CSVCMsg\_PacketEntities\)

```csharp
public void MergeFrom(CSVCMsg_PacketEntities other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

