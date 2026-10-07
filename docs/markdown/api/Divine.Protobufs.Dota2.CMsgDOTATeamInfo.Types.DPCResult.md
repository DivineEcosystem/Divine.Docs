# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult"></a> Class CMsgDOTATeamInfo.Types.DPCResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.DPCResult : IMessage<CMsgDOTATeamInfo.Types.DPCResult>, IEquatable<CMsgDOTATeamInfo.Types.DPCResult>, IDeepCloneable<CMsgDOTATeamInfo.Types.DPCResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.DPCResult\>, 
[IEquatable<CMsgDOTATeamInfo.Types.DPCResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.DPCResult\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.DPCResult\>\(CMsgDOTATeamInfo.Types.DPCResult, params CMsgDOTATeamInfo.Types.DPCResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult__ctor"></a> DPCResult\(\)

```csharp
public DPCResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_"></a> DPCResult\(DPCResult\)

```csharp
public DPCResult(CMsgDOTATeamInfo.Types.DPCResult other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_EarningsFieldNumber"></a> EarningsFieldNumber

```csharp
public const int EarningsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_StandingFieldNumber"></a> StandingFieldNumber

```csharp
public const int StandingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Earnings"></a> Earnings

```csharp
public uint Earnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_HasEarnings"></a> HasEarnings

```csharp
public bool HasEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_HasStanding"></a> HasStanding

```csharp
public bool HasStanding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.DPCResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Standing"></a> Standing

```csharp
public uint Standing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ClearEarnings"></a> ClearEarnings\(\)

```csharp
public void ClearEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ClearStanding"></a> ClearStanding\(\)

```csharp
public void ClearStanding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.DPCResult Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_"></a> Equals\(DPCResult\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.DPCResult other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_"></a> MergeFrom\(DPCResult\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.DPCResult other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_DPCResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

