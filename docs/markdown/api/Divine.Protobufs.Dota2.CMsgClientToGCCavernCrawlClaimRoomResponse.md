# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse"></a> Class CMsgClientToGCCavernCrawlClaimRoomResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlClaimRoomResponse : IMessage<CMsgClientToGCCavernCrawlClaimRoomResponse>, IEquatable<CMsgClientToGCCavernCrawlClaimRoomResponse>, IDeepCloneable<CMsgClientToGCCavernCrawlClaimRoomResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlClaimRoomResponse\>, 
[IEquatable<CMsgClientToGCCavernCrawlClaimRoomResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlClaimRoomResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlClaimRoomResponse\>\(CMsgClientToGCCavernCrawlClaimRoomResponse, params CMsgClientToGCCavernCrawlClaimRoomResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse__ctor"></a> CMsgClientToGCCavernCrawlClaimRoomResponse\(\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoomResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_"></a> CMsgClientToGCCavernCrawlClaimRoomResponse\(CMsgClientToGCCavernCrawlClaimRoomResponse\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoomResponse(CMsgClientToGCCavernCrawlClaimRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlClaimRoomResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Result"></a> Result

```csharp
public CMsgClientToGCCavernCrawlClaimRoomResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoomResponse Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_"></a> Equals\(CMsgClientToGCCavernCrawlClaimRoomResponse\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlClaimRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_"></a> MergeFrom\(CMsgClientToGCCavernCrawlClaimRoomResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlClaimRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoomResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoomResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

