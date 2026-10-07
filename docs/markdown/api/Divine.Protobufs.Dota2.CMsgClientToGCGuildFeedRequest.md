# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest"></a> Class CMsgClientToGCGuildFeedRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGuildFeedRequest : IMessage<CMsgClientToGCGuildFeedRequest>, IEquatable<CMsgClientToGCGuildFeedRequest>, IDeepCloneable<CMsgClientToGCGuildFeedRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)

#### Implements

IMessage<CMsgClientToGCGuildFeedRequest\>, 
[IEquatable<CMsgClientToGCGuildFeedRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGuildFeedRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGuildFeedRequest\>\(CMsgClientToGCGuildFeedRequest, params CMsgClientToGCGuildFeedRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest__ctor"></a> CMsgClientToGCGuildFeedRequest\(\)

```csharp
public CMsgClientToGCGuildFeedRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_"></a> CMsgClientToGCGuildFeedRequest\(CMsgClientToGCGuildFeedRequest\)

```csharp
public CMsgClientToGCGuildFeedRequest(CMsgClientToGCGuildFeedRequest other)
```

#### Parameters

`other` [CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_LastSeenIdFieldNumber"></a> LastSeenIdFieldNumber

```csharp
public const int LastSeenIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_HasLastSeenId"></a> HasLastSeenId

```csharp
public bool HasLastSeenId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_LastSeenId"></a> LastSeenId

```csharp
public ulong LastSeenId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGuildFeedRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_ClearLastSeenId"></a> ClearLastSeenId\(\)

```csharp
public void ClearLastSeenId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGuildFeedRequest Clone()
```

#### Returns

 [CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_"></a> Equals\(CMsgClientToGCGuildFeedRequest\)

```csharp
public bool Equals(CMsgClientToGCGuildFeedRequest other)
```

#### Parameters

`other` [CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_"></a> MergeFrom\(CMsgClientToGCGuildFeedRequest\)

```csharp
public void MergeFrom(CMsgClientToGCGuildFeedRequest other)
```

#### Parameters

`other` [CMsgClientToGCGuildFeedRequest](Divine.Protobufs.Dota2.CMsgClientToGCGuildFeedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGuildFeedRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

