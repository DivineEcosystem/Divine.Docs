# <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest"></a> Class CMsgPrivateMetadataKeyRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPrivateMetadataKeyRequest : IMessage<CMsgPrivateMetadataKeyRequest>, IEquatable<CMsgPrivateMetadataKeyRequest>, IDeepCloneable<CMsgPrivateMetadataKeyRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)

#### Implements

IMessage<CMsgPrivateMetadataKeyRequest\>, 
[IEquatable<CMsgPrivateMetadataKeyRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPrivateMetadataKeyRequest\>, 
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
[EnumerableExtensions.In<CMsgPrivateMetadataKeyRequest\>\(CMsgPrivateMetadataKeyRequest, params CMsgPrivateMetadataKeyRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest__ctor"></a> CMsgPrivateMetadataKeyRequest\(\)

```csharp
public CMsgPrivateMetadataKeyRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest__ctor_Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_"></a> CMsgPrivateMetadataKeyRequest\(CMsgPrivateMetadataKeyRequest\)

```csharp
public CMsgPrivateMetadataKeyRequest(CMsgPrivateMetadataKeyRequest other)
```

#### Parameters

`other` [CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPrivateMetadataKeyRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_Clone"></a> Clone\(\)

```csharp
public CMsgPrivateMetadataKeyRequest Clone()
```

#### Returns

 [CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_Equals_Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_"></a> Equals\(CMsgPrivateMetadataKeyRequest\)

```csharp
public bool Equals(CMsgPrivateMetadataKeyRequest other)
```

#### Parameters

`other` [CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_"></a> MergeFrom\(CMsgPrivateMetadataKeyRequest\)

```csharp
public void MergeFrom(CMsgPrivateMetadataKeyRequest other)
```

#### Parameters

`other` [CMsgPrivateMetadataKeyRequest](Divine.Protobufs.Dota2.CMsgPrivateMetadataKeyRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateMetadataKeyRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

