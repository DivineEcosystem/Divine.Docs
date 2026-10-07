# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest"></a> Class CMsgClientToGCSocialFeedPostMessageRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSocialFeedPostMessageRequest : IMessage<CMsgClientToGCSocialFeedPostMessageRequest>, IEquatable<CMsgClientToGCSocialFeedPostMessageRequest>, IDeepCloneable<CMsgClientToGCSocialFeedPostMessageRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)

#### Implements

IMessage<CMsgClientToGCSocialFeedPostMessageRequest\>, 
[IEquatable<CMsgClientToGCSocialFeedPostMessageRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSocialFeedPostMessageRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSocialFeedPostMessageRequest\>\(CMsgClientToGCSocialFeedPostMessageRequest, params CMsgClientToGCSocialFeedPostMessageRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest__ctor"></a> CMsgClientToGCSocialFeedPostMessageRequest\(\)

```csharp
public CMsgClientToGCSocialFeedPostMessageRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_"></a> CMsgClientToGCSocialFeedPostMessageRequest\(CMsgClientToGCSocialFeedPostMessageRequest\)

```csharp
public CMsgClientToGCSocialFeedPostMessageRequest(CMsgClientToGCSocialFeedPostMessageRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MatchTimestampFieldNumber"></a> MatchTimestampFieldNumber

```csharp
public const int MatchTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_HasMatchTimestamp"></a> HasMatchTimestamp

```csharp
public bool HasMatchTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MatchTimestamp"></a> MatchTimestamp

```csharp
public uint MatchTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSocialFeedPostMessageRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_ClearMatchTimestamp"></a> ClearMatchTimestamp\(\)

```csharp
public void ClearMatchTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSocialFeedPostMessageRequest Clone()
```

#### Returns

 [CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_"></a> Equals\(CMsgClientToGCSocialFeedPostMessageRequest\)

```csharp
public bool Equals(CMsgClientToGCSocialFeedPostMessageRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_"></a> MergeFrom\(CMsgClientToGCSocialFeedPostMessageRequest\)

```csharp
public void MergeFrom(CMsgClientToGCSocialFeedPostMessageRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostMessageRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostMessageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostMessageRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

