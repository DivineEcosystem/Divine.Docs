# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest"></a> Class CMsgGCToClientPollFileRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPollFileRequest : IMessage<CMsgGCToClientPollFileRequest>, IEquatable<CMsgGCToClientPollFileRequest>, IDeepCloneable<CMsgGCToClientPollFileRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)

#### Implements

IMessage<CMsgGCToClientPollFileRequest\>, 
[IEquatable<CMsgGCToClientPollFileRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPollFileRequest\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPollFileRequest\>\(CMsgGCToClientPollFileRequest, params CMsgGCToClientPollFileRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest__ctor"></a> CMsgGCToClientPollFileRequest\(\)

```csharp
public CMsgGCToClientPollFileRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_"></a> CMsgGCToClientPollFileRequest\(CMsgGCToClientPollFileRequest\)

```csharp
public CMsgGCToClientPollFileRequest(CMsgGCToClientPollFileRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_FileNameFieldNumber"></a> FileNameFieldNumber

```csharp
public const int FileNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_PollIdFieldNumber"></a> PollIdFieldNumber

```csharp
public const int PollIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_FileName"></a> FileName

```csharp
public string FileName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_HasFileName"></a> HasFileName

```csharp
public bool HasFileName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_HasPollId"></a> HasPollId

```csharp
public bool HasPollId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPollFileRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_PollId"></a> PollId

```csharp
public uint PollId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ClearFileName"></a> ClearFileName\(\)

```csharp
public void ClearFileName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ClearPollId"></a> ClearPollId\(\)

```csharp
public void ClearPollId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPollFileRequest Clone()
```

#### Returns

 [CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_"></a> Equals\(CMsgGCToClientPollFileRequest\)

```csharp
public bool Equals(CMsgGCToClientPollFileRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_"></a> MergeFrom\(CMsgGCToClientPollFileRequest\)

```csharp
public void MergeFrom(CMsgGCToClientPollFileRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollFileRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollFileRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollFileRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

