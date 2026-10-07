# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData"></a> Class CMsgClientToGCBingoGetStatsData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoGetStatsData : IMessage<CMsgClientToGCBingoGetStatsData>, IEquatable<CMsgClientToGCBingoGetStatsData>, IDeepCloneable<CMsgClientToGCBingoGetStatsData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)

#### Implements

IMessage<CMsgClientToGCBingoGetStatsData\>, 
[IEquatable<CMsgClientToGCBingoGetStatsData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoGetStatsData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoGetStatsData\>\(CMsgClientToGCBingoGetStatsData, params CMsgClientToGCBingoGetStatsData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData__ctor"></a> CMsgClientToGCBingoGetStatsData\(\)

```csharp
public CMsgClientToGCBingoGetStatsData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_"></a> CMsgClientToGCBingoGetStatsData\(CMsgClientToGCBingoGetStatsData\)

```csharp
public CMsgClientToGCBingoGetStatsData(CMsgClientToGCBingoGetStatsData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoGetStatsData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoGetStatsData Clone()
```

#### Returns

 [CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_"></a> Equals\(CMsgClientToGCBingoGetStatsData\)

```csharp
public bool Equals(CMsgClientToGCBingoGetStatsData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_"></a> MergeFrom\(CMsgClientToGCBingoGetStatsData\)

```csharp
public void MergeFrom(CMsgClientToGCBingoGetStatsData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

