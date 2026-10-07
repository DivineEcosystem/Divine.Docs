# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk"></a> Class CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk : IMessage<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk>, IEquatable<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk>, IDeepCloneable<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)

#### Implements

IMessage<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk\>, 
[IEquatable<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk\>\(CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk, params CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk__ctor"></a> HeroDataPerRankChunk\(\)

```csharp
public HeroDataPerRankChunk()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_"></a> HeroDataPerRankChunk\(HeroDataPerRankChunk\)

```csharp
public HeroDataPerRankChunk(CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_GraphDataFieldNumber"></a> GraphDataFieldNumber

```csharp
public const int GraphDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_HeroAveragesFieldNumber"></a> HeroAveragesFieldNumber

```csharp
public const int HeroAveragesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_RankChunkFieldNumber"></a> RankChunkFieldNumber

```csharp
public const int RankChunkFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_TalentWinRatesFieldNumber"></a> TalentWinRatesFieldNumber

```csharp
public const int TalentWinRatesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_WeekDataFieldNumber"></a> WeekDataFieldNumber

```csharp
public const int WeekDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_GraphData"></a> GraphData

```csharp
public RepeatedField<CMsgHeroGlobalDataResponse.Types.GraphData> GraphData { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.GraphData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_HasRankChunk"></a> HasRankChunk

```csharp
public bool HasRankChunk { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_HeroAverages"></a> HeroAverages

```csharp
public CMsgGlobalHeroAverages HeroAverages { get; set; }
```

#### Property Value

 [CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_RankChunk"></a> RankChunk

```csharp
public uint RankChunk { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_TalentWinRates"></a> TalentWinRates

```csharp
public RepeatedField<CMsgTalentWinRates> TalentWinRates { get; }
```

#### Property Value

 RepeatedField<[CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_WeekData"></a> WeekData

```csharp
public RepeatedField<CMsgHeroGlobalDataResponse.Types.WeekData> WeekData { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_ClearRankChunk"></a> ClearRankChunk\(\)

```csharp
public void ClearRankChunk()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk Clone()
```

#### Returns

 [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_"></a> Equals\(HeroDataPerRankChunk\)

```csharp
public bool Equals(CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_"></a> MergeFrom\(HeroDataPerRankChunk\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_HeroDataPerRankChunk_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

