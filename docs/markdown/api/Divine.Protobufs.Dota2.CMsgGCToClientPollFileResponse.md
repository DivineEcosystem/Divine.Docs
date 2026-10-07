# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse"></a> Class CMsgGCToClientPollFileResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPollFileResponse : IMessage<CMsgGCToClientPollFileResponse>, IEquatable<CMsgGCToClientPollFileResponse>, IDeepCloneable<CMsgGCToClientPollFileResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)

#### Implements

IMessage<CMsgGCToClientPollFileResponse\>, 
[IEquatable<CMsgGCToClientPollFileResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPollFileResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPollFileResponse\>\(CMsgGCToClientPollFileResponse, params CMsgGCToClientPollFileResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse__ctor"></a> CMsgGCToClientPollFileResponse\(\)

```csharp
public CMsgGCToClientPollFileResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_"></a> CMsgGCToClientPollFileResponse\(CMsgGCToClientPollFileResponse\)

```csharp
public CMsgGCToClientPollFileResponse(CMsgGCToClientPollFileResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_FileCrcFieldNumber"></a> FileCrcFieldNumber

```csharp
public const int FileCrcFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_FileSizeFieldNumber"></a> FileSizeFieldNumber

```csharp
public const int FileSizeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_PollIdFieldNumber"></a> PollIdFieldNumber

```csharp
public const int PollIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_FileCrc"></a> FileCrc

```csharp
public uint FileCrc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_FileSize"></a> FileSize

```csharp
public uint FileSize { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_HasFileCrc"></a> HasFileCrc

```csharp
public bool HasFileCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_HasFileSize"></a> HasFileSize

```csharp
public bool HasFileSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_HasPollId"></a> HasPollId

```csharp
public bool HasPollId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPollFileResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_PollId"></a> PollId

```csharp
public uint PollId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_ClearFileCrc"></a> ClearFileCrc\(\)

```csharp
public void ClearFileCrc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_ClearFileSize"></a> ClearFileSize\(\)

```csharp
public void ClearFileSize()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_ClearPollId"></a> ClearPollId\(\)

```csharp
public void ClearPollId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPollFileResponse Clone()
```

#### Returns

 [CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_"></a> Equals\(CMsgGCToClientPollFileResponse\)

```csharp
public bool Equals(CMsgGCToClientPollFileResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_"></a> MergeFrom\(CMsgGCToClientPollFileResponse\)

```csharp
public void MergeFrom(CMsgGCToClientPollFileResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollFileResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollFileResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

