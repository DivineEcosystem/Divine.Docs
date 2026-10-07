# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData"></a> Class CMsgDOTARealtimeGameStats.Types.GraphData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.GraphData : IMessage<CMsgDOTARealtimeGameStats.Types.GraphData>, IEquatable<CMsgDOTARealtimeGameStats.Types.GraphData>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.GraphData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.GraphData\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.GraphData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.GraphData\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.GraphData\>\(CMsgDOTARealtimeGameStats.Types.GraphData, params CMsgDOTARealtimeGameStats.Types.GraphData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData__ctor"></a> GraphData\(\)

```csharp
public GraphData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_"></a> GraphData\(GraphData\)

```csharp
public GraphData(CMsgDOTARealtimeGameStats.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphGoldFieldNumber"></a> GraphGoldFieldNumber

```csharp
public const int GraphGoldFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphKillFieldNumber"></a> GraphKillFieldNumber

```csharp
public const int GraphKillFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphRaxFieldNumber"></a> GraphRaxFieldNumber

```csharp
public const int GraphRaxFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphTowerFieldNumber"></a> GraphTowerFieldNumber

```csharp
public const int GraphTowerFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphXpFieldNumber"></a> GraphXpFieldNumber

```csharp
public const int GraphXpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_TeamLocStatsFieldNumber"></a> TeamLocStatsFieldNumber

```csharp
public const int TeamLocStatsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphGold"></a> GraphGold

```csharp
public RepeatedField<int> GraphGold { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphKill"></a> GraphKill

```csharp
public RepeatedField<int> GraphKill { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphRax"></a> GraphRax

```csharp
public RepeatedField<int> GraphRax { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphTower"></a> GraphTower

```csharp
public RepeatedField<int> GraphTower { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GraphXp"></a> GraphXp

```csharp
public RepeatedField<int> GraphXp { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.GraphData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_TeamLocStats"></a> TeamLocStats

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats> TeamLocStats { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.md).[TeamLocationStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.Types.TeamLocationStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.GraphData Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_"></a> Equals\(GraphData\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_"></a> MergeFrom\(GraphData\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_GraphData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

