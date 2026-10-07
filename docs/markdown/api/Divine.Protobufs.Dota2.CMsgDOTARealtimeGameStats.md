# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats"></a> Class CMsgDOTARealtimeGameStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats : IMessage<CMsgDOTARealtimeGameStats>, IEquatable<CMsgDOTARealtimeGameStats>, IDeepCloneable<CMsgDOTARealtimeGameStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats\>, 
[IEquatable<CMsgDOTARealtimeGameStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats\>\(CMsgDOTARealtimeGameStats, params CMsgDOTARealtimeGameStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats__ctor"></a> CMsgDOTARealtimeGameStats\(\)

```csharp
public CMsgDOTARealtimeGameStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_"></a> CMsgDOTARealtimeGameStats\(CMsgDOTARealtimeGameStats\)

```csharp
public CMsgDOTARealtimeGameStats(CMsgDOTARealtimeGameStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_BuildingsFieldNumber"></a> BuildingsFieldNumber

```csharp
public const int BuildingsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_DeltaFrameFieldNumber"></a> DeltaFrameFieldNumber

```csharp
public const int DeltaFrameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_GraphDataFieldNumber"></a> GraphDataFieldNumber

```csharp
public const int GraphDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_MatchFieldNumber"></a> MatchFieldNumber

```csharp
public const int MatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Buildings"></a> Buildings

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.BuildingDetails> Buildings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[BuildingDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.BuildingDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_DeltaFrame"></a> DeltaFrame

```csharp
public bool DeltaFrame { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_GraphData"></a> GraphData

```csharp
public CMsgDOTARealtimeGameStats.Types.GraphData GraphData { get; set; }
```

#### Property Value

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_HasDeltaFrame"></a> HasDeltaFrame

```csharp
public bool HasDeltaFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Match"></a> Match

```csharp
public CMsgDOTARealtimeGameStats.Types.MatchDetails Match { get; set; }
```

#### Property Value

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.TeamDetails> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.TeamDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_ClearDeltaFrame"></a> ClearDeltaFrame\(\)

```csharp
public void ClearDeltaFrame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_"></a> Equals\(CMsgDOTARealtimeGameStats\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_"></a> MergeFrom\(CMsgDOTARealtimeGameStats\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

