# <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse"></a> Class CMsgSearchForOpenGuildsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSearchForOpenGuildsResponse : IMessage<CMsgSearchForOpenGuildsResponse>, IEquatable<CMsgSearchForOpenGuildsResponse>, IDeepCloneable<CMsgSearchForOpenGuildsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)

#### Implements

IMessage<CMsgSearchForOpenGuildsResponse\>, 
[IEquatable<CMsgSearchForOpenGuildsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSearchForOpenGuildsResponse\>, 
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
[EnumerableExtensions.In<CMsgSearchForOpenGuildsResponse\>\(CMsgSearchForOpenGuildsResponse, params CMsgSearchForOpenGuildsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse__ctor"></a> CMsgSearchForOpenGuildsResponse\(\)

```csharp
public CMsgSearchForOpenGuildsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse__ctor_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_"></a> CMsgSearchForOpenGuildsResponse\(CMsgSearchForOpenGuildsResponse\)

```csharp
public CMsgSearchForOpenGuildsResponse(CMsgSearchForOpenGuildsResponse other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_SearchResultsFieldNumber"></a> SearchResultsFieldNumber

```csharp
public const int SearchResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_UseWhitelistFieldNumber"></a> UseWhitelistFieldNumber

```csharp
public const int UseWhitelistFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_HasUseWhitelist"></a> HasUseWhitelist

```csharp
public bool HasUseWhitelist { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSearchForOpenGuildsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Result"></a> Result

```csharp
public CMsgSearchForOpenGuildsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_SearchResults"></a> SearchResults

```csharp
public RepeatedField<CMsgSearchForOpenGuildsResponse.Types.SearchResult> SearchResults { get; }
```

#### Property Value

 RepeatedField<[CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.md).[SearchResult](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.Types.SearchResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_UseWhitelist"></a> UseWhitelist

```csharp
public bool UseWhitelist { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_ClearUseWhitelist"></a> ClearUseWhitelist\(\)

```csharp
public void ClearUseWhitelist()
```

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgSearchForOpenGuildsResponse Clone()
```

#### Returns

 [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_Equals_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_"></a> Equals\(CMsgSearchForOpenGuildsResponse\)

```csharp
public bool Equals(CMsgSearchForOpenGuildsResponse other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_"></a> MergeFrom\(CMsgSearchForOpenGuildsResponse\)

```csharp
public void MergeFrom(CMsgSearchForOpenGuildsResponse other)
```

#### Parameters

`other` [CMsgSearchForOpenGuildsResponse](Divine.Protobufs.Dota2.CMsgSearchForOpenGuildsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSearchForOpenGuildsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

