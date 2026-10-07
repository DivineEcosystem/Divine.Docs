# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse"></a> Class CMsgServerToGCCavernCrawlIsHeroActiveResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCavernCrawlIsHeroActiveResponse : IMessage<CMsgServerToGCCavernCrawlIsHeroActiveResponse>, IEquatable<CMsgServerToGCCavernCrawlIsHeroActiveResponse>, IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActiveResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)

#### Implements

IMessage<CMsgServerToGCCavernCrawlIsHeroActiveResponse\>, 
[IEquatable<CMsgServerToGCCavernCrawlIsHeroActiveResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActiveResponse\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCavernCrawlIsHeroActiveResponse\>\(CMsgServerToGCCavernCrawlIsHeroActiveResponse, params CMsgServerToGCCavernCrawlIsHeroActiveResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse__ctor"></a> CMsgServerToGCCavernCrawlIsHeroActiveResponse\(\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActiveResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_"></a> CMsgServerToGCCavernCrawlIsHeroActiveResponse\(CMsgServerToGCCavernCrawlIsHeroActiveResponse\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActiveResponse(CMsgServerToGCCavernCrawlIsHeroActiveResponse other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MapResultsFieldNumber"></a> MapResultsFieldNumber

```csharp
public const int MapResultsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_PotentialPlusShardWinningsFieldNumber"></a> PotentialPlusShardWinningsFieldNumber

```csharp
public const int PotentialPlusShardWinningsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_PotentialWinningsFieldNumber"></a> PotentialWinningsFieldNumber

```csharp
public const int PotentialWinningsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_HasPotentialPlusShardWinnings"></a> HasPotentialPlusShardWinnings

```csharp
public bool HasPotentialPlusShardWinnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_HasPotentialWinnings"></a> HasPotentialWinnings

```csharp
public bool HasPotentialWinnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MapResults"></a> MapResults

```csharp
public RepeatedField<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults> MapResults { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCavernCrawlIsHeroActiveResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_PotentialPlusShardWinnings"></a> PotentialPlusShardWinnings

```csharp
public uint PotentialPlusShardWinnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_PotentialWinnings"></a> PotentialWinnings

```csharp
public uint PotentialWinnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ClearPotentialPlusShardWinnings"></a> ClearPotentialPlusShardWinnings\(\)

```csharp
public void ClearPotentialPlusShardWinnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ClearPotentialWinnings"></a> ClearPotentialWinnings\(\)

```csharp
public void ClearPotentialWinnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActiveResponse Clone()
```

#### Returns

 [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_"></a> Equals\(CMsgServerToGCCavernCrawlIsHeroActiveResponse\)

```csharp
public bool Equals(CMsgServerToGCCavernCrawlIsHeroActiveResponse other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_"></a> MergeFrom\(CMsgServerToGCCavernCrawlIsHeroActiveResponse\)

```csharp
public void MergeFrom(CMsgServerToGCCavernCrawlIsHeroActiveResponse other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

