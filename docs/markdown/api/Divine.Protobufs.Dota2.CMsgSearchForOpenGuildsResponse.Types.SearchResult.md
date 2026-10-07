# <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult"></a> Class CMsgSearchForOpenGuildsResponse.Types.SearchResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSearchForOpenGuildsResponse.Types.SearchResult : IMessage<CMsgSearchForOpenGuildsResponse.Types.SearchResult>, IEquatable<CMsgSearchForOpenGuildsResponse.Types.SearchResult>, IDeepCloneable<CMsgSearchForOpenGuildsResponse.Types.SearchResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSearchForOpenGuildsResponse.Types.SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)

#### Implements

IMessage<CMsgSearchForOpenGuildsResponse.Types.SearchResult\>, 
[IEquatable<CMsgSearchForOpenGuildsResponse.Types.SearchResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSearchForOpenGuildsResponse.Types.SearchResult\>, 
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
[EnumerableExtensions.In<CMsgSearchForOpenGuildsResponse.Types.SearchResult\>\(CMsgSearchForOpenGuildsResponse.Types.SearchResult, params CMsgSearchForOpenGuildsResponse.Types.SearchResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult__ctor"></a> SearchResult\(\)

```csharp
public SearchResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult__ctor_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_"></a> SearchResult\(SearchResult\)

```csharp
public SearchResult(CMsgSearchForOpenGuildsResponse.Types.SearchResult other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_GuildSummaryFieldNumber"></a> GuildSummaryFieldNumber

```csharp
public const int GuildSummaryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_GuildSummary"></a> GuildSummary

```csharp
public CMsgGuildSummary GuildSummary { get; set; }
```

#### Property Value

 [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSearchForOpenGuildsResponse.Types.SearchResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_Clone"></a> Clone\(\)

```csharp
public CMsgSearchForOpenGuildsResponse.Types.SearchResult Clone()
```

#### Returns

 [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_Equals_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_"></a> Equals\(SearchResult\)

```csharp
public bool Equals(CMsgSearchForOpenGuildsResponse.Types.SearchResult other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_MergeFrom_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_"></a> MergeFrom\(SearchResult\)

```csharp
public void MergeFrom(CMsgSearchForOpenGuildsResponse.Types.SearchResult other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Types_SearchResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

