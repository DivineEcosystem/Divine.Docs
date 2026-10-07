# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility"></a> Class CDOTAUserMsg\_ProjectionAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ProjectionAbility : IMessage<CDOTAUserMsg_ProjectionAbility>, IEquatable<CDOTAUserMsg_ProjectionAbility>, IDeepCloneable<CDOTAUserMsg_ProjectionAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)

#### Implements

IMessage<CDOTAUserMsg\_ProjectionAbility\>, 
[IEquatable<CDOTAUserMsg\_ProjectionAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ProjectionAbility\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ProjectionAbility\>\(CDOTAUserMsg\_ProjectionAbility, params CDOTAUserMsg\_ProjectionAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility__ctor"></a> CDOTAUserMsg\_ProjectionAbility\(\)

```csharp
public CDOTAUserMsg_ProjectionAbility()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_"></a> CDOTAUserMsg\_ProjectionAbility\(CDOTAUserMsg\_ProjectionAbility\)

```csharp
public CDOTAUserMsg_ProjectionAbility(CDOTAUserMsg_ProjectionAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_CasterEntIndexFieldNumber"></a> CasterEntIndexFieldNumber

```csharp
public const int CasterEntIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_CasterTeamFieldNumber"></a> CasterTeamFieldNumber

```csharp
public const int CasterTeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ChannelEndFieldNumber"></a> ChannelEndFieldNumber

```csharp
public const int ChannelEndFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_EndTimeFieldNumber"></a> EndTimeFieldNumber

```csharp
public const int EndTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_TrackCasterOnlyFieldNumber"></a> TrackCasterOnlyFieldNumber

```csharp
public const int TrackCasterOnlyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_VictimEntIndexFieldNumber"></a> VictimEntIndexFieldNumber

```csharp
public const int VictimEntIndexFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_CasterEntIndex"></a> CasterEntIndex

```csharp
public int CasterEntIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_CasterTeam"></a> CasterTeam

```csharp
public int CasterTeam { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ChannelEnd"></a> ChannelEnd

```csharp
public bool ChannelEnd { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_EndTime"></a> EndTime

```csharp
public float EndTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasCasterEntIndex"></a> HasCasterEntIndex

```csharp
public bool HasCasterEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasCasterTeam"></a> HasCasterTeam

```csharp
public bool HasCasterTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasChannelEnd"></a> HasChannelEnd

```csharp
public bool HasChannelEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasEndTime"></a> HasEndTime

```csharp
public bool HasEndTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasTrackCasterOnly"></a> HasTrackCasterOnly

```csharp
public bool HasTrackCasterOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_HasVictimEntIndex"></a> HasVictimEntIndex

```csharp
public bool HasVictimEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ProjectionAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_TrackCasterOnly"></a> TrackCasterOnly

```csharp
public bool TrackCasterOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_VictimEntIndex"></a> VictimEntIndex

```csharp
public int VictimEntIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearCasterEntIndex"></a> ClearCasterEntIndex\(\)

```csharp
public void ClearCasterEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearCasterTeam"></a> ClearCasterTeam\(\)

```csharp
public void ClearCasterTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearChannelEnd"></a> ClearChannelEnd\(\)

```csharp
public void ClearChannelEnd()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearEndTime"></a> ClearEndTime\(\)

```csharp
public void ClearEndTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearTrackCasterOnly"></a> ClearTrackCasterOnly\(\)

```csharp
public void ClearTrackCasterOnly()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ClearVictimEntIndex"></a> ClearVictimEntIndex\(\)

```csharp
public void ClearVictimEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ProjectionAbility Clone()
```

#### Returns

 [CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_"></a> Equals\(CDOTAUserMsg\_ProjectionAbility\)

```csharp
public bool Equals(CDOTAUserMsg_ProjectionAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_"></a> MergeFrom\(CDOTAUserMsg\_ProjectionAbility\)

```csharp
public void MergeFrom(CDOTAUserMsg_ProjectionAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

