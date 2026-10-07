# <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response"></a> Class CPublishedFile\_RefreshVotingQueue\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_RefreshVotingQueue_Response : IMessage<CPublishedFile_RefreshVotingQueue_Response>, IEquatable<CPublishedFile_RefreshVotingQueue_Response>, IDeepCloneable<CPublishedFile_RefreshVotingQueue_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)

#### Implements

IMessage<CPublishedFile\_RefreshVotingQueue\_Response\>, 
[IEquatable<CPublishedFile\_RefreshVotingQueue\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_RefreshVotingQueue\_Response\>, 
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
[EnumerableExtensions.In<CPublishedFile\_RefreshVotingQueue\_Response\>\(CPublishedFile\_RefreshVotingQueue\_Response, params CPublishedFile\_RefreshVotingQueue\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response__ctor"></a> CPublishedFile\_RefreshVotingQueue\_Response\(\)

```csharp
public CPublishedFile_RefreshVotingQueue_Response()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response__ctor_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_"></a> CPublishedFile\_RefreshVotingQueue\_Response\(CPublishedFile\_RefreshVotingQueue\_Response\)

```csharp
public CPublishedFile_RefreshVotingQueue_Response(CPublishedFile_RefreshVotingQueue_Response other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_RefreshVotingQueue_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_RefreshVotingQueue_Response Clone()
```

#### Returns

 [CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_Equals_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_"></a> Equals\(CPublishedFile\_RefreshVotingQueue\_Response\)

```csharp
public bool Equals(CPublishedFile_RefreshVotingQueue_Response other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_"></a> MergeFrom\(CPublishedFile\_RefreshVotingQueue\_Response\)

```csharp
public void MergeFrom(CPublishedFile_RefreshVotingQueue_Response other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Response](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

