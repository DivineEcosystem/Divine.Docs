# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse"></a> Class CMsgHeroGlobalDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataResponse : IMessage<CMsgHeroGlobalDataResponse>, IEquatable<CMsgHeroGlobalDataResponse>, IDeepCloneable<CMsgHeroGlobalDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)

#### Implements

IMessage<CMsgHeroGlobalDataResponse\>, 
[IEquatable<CMsgHeroGlobalDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataResponse\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataResponse\>\(CMsgHeroGlobalDataResponse, params CMsgHeroGlobalDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse__ctor"></a> CMsgHeroGlobalDataResponse\(\)

```csharp
public CMsgHeroGlobalDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_"></a> CMsgHeroGlobalDataResponse\(CMsgHeroGlobalDataResponse\)

```csharp
public CMsgHeroGlobalDataResponse(CMsgHeroGlobalDataResponse other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_HeroDataPerChunkFieldNumber"></a> HeroDataPerChunkFieldNumber

```csharp
public const int HeroDataPerChunkFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_HeroDataPerChunk"></a> HeroDataPerChunk

```csharp
public RepeatedField<CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk> HeroDataPerChunk { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[HeroDataPerRankChunk](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.HeroDataPerRankChunk.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataResponse Clone()
```

#### Returns

 [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_"></a> Equals\(CMsgHeroGlobalDataResponse\)

```csharp
public bool Equals(CMsgHeroGlobalDataResponse other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_"></a> MergeFrom\(CMsgHeroGlobalDataResponse\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataResponse other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

