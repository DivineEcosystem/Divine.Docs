# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse"></a> Class CMsgGCGetHeroTimedStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroTimedStatsResponse : IMessage<CMsgGCGetHeroTimedStatsResponse>, IEquatable<CMsgGCGetHeroTimedStatsResponse>, IDeepCloneable<CMsgGCGetHeroTimedStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)

#### Implements

IMessage<CMsgGCGetHeroTimedStatsResponse\>, 
[IEquatable<CMsgGCGetHeroTimedStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroTimedStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroTimedStatsResponse\>\(CMsgGCGetHeroTimedStatsResponse, params CMsgGCGetHeroTimedStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse__ctor"></a> CMsgGCGetHeroTimedStatsResponse\(\)

```csharp
public CMsgGCGetHeroTimedStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_"></a> CMsgGCGetHeroTimedStatsResponse\(CMsgGCGetHeroTimedStatsResponse\)

```csharp
public CMsgGCGetHeroTimedStatsResponse(CMsgGCGetHeroTimedStatsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_RankChunkedStatsFieldNumber"></a> RankChunkedStatsFieldNumber

```csharp
public const int RankChunkedStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroTimedStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_RankChunkedStats"></a> RankChunkedStats

```csharp
public RepeatedField<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats> RankChunkedStats { get; }
```

#### Property Value

 RepeatedField<[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroTimedStatsResponse Clone()
```

#### Returns

 [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_"></a> Equals\(CMsgGCGetHeroTimedStatsResponse\)

```csharp
public bool Equals(CMsgGCGetHeroTimedStatsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_"></a> MergeFrom\(CMsgGCGetHeroTimedStatsResponse\)

```csharp
public void MergeFrom(CMsgGCGetHeroTimedStatsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

