# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse"></a> Class CMsgClientToGCCavernCrawlUseItemOnPathResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlUseItemOnPathResponse : IMessage<CMsgClientToGCCavernCrawlUseItemOnPathResponse>, IEquatable<CMsgClientToGCCavernCrawlUseItemOnPathResponse>, IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnPathResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlUseItemOnPathResponse\>, 
[IEquatable<CMsgClientToGCCavernCrawlUseItemOnPathResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnPathResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlUseItemOnPathResponse\>\(CMsgClientToGCCavernCrawlUseItemOnPathResponse, params CMsgClientToGCCavernCrawlUseItemOnPathResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse__ctor"></a> CMsgClientToGCCavernCrawlUseItemOnPathResponse\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPathResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_"></a> CMsgClientToGCCavernCrawlUseItemOnPathResponse\(CMsgClientToGCCavernCrawlUseItemOnPathResponse\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPathResponse(CMsgClientToGCCavernCrawlUseItemOnPathResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlUseItemOnPathResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Result"></a> Result

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPathResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPathResponse Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_"></a> Equals\(CMsgClientToGCCavernCrawlUseItemOnPathResponse\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlUseItemOnPathResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_"></a> MergeFrom\(CMsgClientToGCCavernCrawlUseItemOnPathResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlUseItemOnPathResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPathResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPathResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPathResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

