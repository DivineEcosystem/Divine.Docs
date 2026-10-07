# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse"></a> Class CMsgClientToGCCavernCrawlUseItemOnRoomResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlUseItemOnRoomResponse : IMessage<CMsgClientToGCCavernCrawlUseItemOnRoomResponse>, IEquatable<CMsgClientToGCCavernCrawlUseItemOnRoomResponse>, IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnRoomResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlUseItemOnRoomResponse\>, 
[IEquatable<CMsgClientToGCCavernCrawlUseItemOnRoomResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnRoomResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlUseItemOnRoomResponse\>\(CMsgClientToGCCavernCrawlUseItemOnRoomResponse, params CMsgClientToGCCavernCrawlUseItemOnRoomResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse__ctor"></a> CMsgClientToGCCavernCrawlUseItemOnRoomResponse\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoomResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_"></a> CMsgClientToGCCavernCrawlUseItemOnRoomResponse\(CMsgClientToGCCavernCrawlUseItemOnRoomResponse\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoomResponse(CMsgClientToGCCavernCrawlUseItemOnRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlUseItemOnRoomResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Result"></a> Result

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoomResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoomResponse Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_"></a> Equals\(CMsgClientToGCCavernCrawlUseItemOnRoomResponse\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlUseItemOnRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_"></a> MergeFrom\(CMsgClientToGCCavernCrawlUseItemOnRoomResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlUseItemOnRoomResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoomResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoomResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoomResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

