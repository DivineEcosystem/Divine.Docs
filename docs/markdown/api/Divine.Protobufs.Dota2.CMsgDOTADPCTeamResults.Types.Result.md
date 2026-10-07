# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result"></a> Class CMsgDOTADPCTeamResults.Types.Result

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCTeamResults.Types.Result : IMessage<CMsgDOTADPCTeamResults.Types.Result>, IEquatable<CMsgDOTADPCTeamResults.Types.Result>, IDeepCloneable<CMsgDOTADPCTeamResults.Types.Result>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCTeamResults.Types.Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)

#### Implements

IMessage<CMsgDOTADPCTeamResults.Types.Result\>, 
[IEquatable<CMsgDOTADPCTeamResults.Types.Result\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCTeamResults.Types.Result\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCTeamResults.Types.Result\>\(CMsgDOTADPCTeamResults.Types.Result, params CMsgDOTADPCTeamResults.Types.Result\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result__ctor"></a> Result\(\)

```csharp
public Result()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_"></a> Result\(Result\)

```csharp
public Result(CMsgDOTADPCTeamResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_EarningsFieldNumber"></a> EarningsFieldNumber

```csharp
public const int EarningsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_StandingFieldNumber"></a> StandingFieldNumber

```csharp
public const int StandingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Earnings"></a> Earnings

```csharp
public uint Earnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_HasEarnings"></a> HasEarnings

```csharp
public bool HasEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_HasStanding"></a> HasStanding

```csharp
public bool HasStanding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCTeamResults.Types.Result> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Standing"></a> Standing

```csharp
public uint Standing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ClearEarnings"></a> ClearEarnings\(\)

```csharp
public void ClearEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ClearStanding"></a> ClearStanding\(\)

```csharp
public void ClearStanding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCTeamResults.Types.Result Clone()
```

#### Returns

 [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_"></a> Equals\(Result\)

```csharp
public bool Equals(CMsgDOTADPCTeamResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_"></a> MergeFrom\(Result\)

```csharp
public void MergeFrom(CMsgDOTADPCTeamResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Types_Result_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

