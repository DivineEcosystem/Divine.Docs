# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats"></a> Class CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats : IMessage<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats>, IEquatable<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats\>\(CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats, params CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats__ctor"></a> TeamLocationStats\(\)

```csharp
public TeamLocationStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_"></a> TeamLocationStats\(TeamLocationStats\)

```csharp
public TeamLocationStats(CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_LocStatsFieldNumber"></a> LocStatsFieldNumber

```csharp
public const int LocStatsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_LocStats"></a> LocStats

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.GraphData.Types.LocationStats> LocStats { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[LocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.LocationStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_"></a> Equals\(TeamLocationStats\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_"></a> MergeFrom\(TeamLocationStats\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Types_TeamLocationStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

