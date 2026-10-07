# <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse"></a> Class CMsgGCToGCMasterSubscribeToCacheResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCMasterSubscribeToCacheResponse : IMessage<CMsgGCToGCMasterSubscribeToCacheResponse>, IEquatable<CMsgGCToGCMasterSubscribeToCacheResponse>, IDeepCloneable<CMsgGCToGCMasterSubscribeToCacheResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)

#### Implements

IMessage<CMsgGCToGCMasterSubscribeToCacheResponse\>, 
[IEquatable<CMsgGCToGCMasterSubscribeToCacheResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCMasterSubscribeToCacheResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCMasterSubscribeToCacheResponse\>\(CMsgGCToGCMasterSubscribeToCacheResponse, params CMsgGCToGCMasterSubscribeToCacheResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse__ctor"></a> CMsgGCToGCMasterSubscribeToCacheResponse\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_"></a> CMsgGCToGCMasterSubscribeToCacheResponse\(CMsgGCToGCMasterSubscribeToCacheResponse\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheResponse(CMsgGCToGCMasterSubscribeToCacheResponse other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCMasterSubscribeToCacheResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheResponse Clone()
```

#### Returns

 [CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_"></a> Equals\(CMsgGCToGCMasterSubscribeToCacheResponse\)

```csharp
public bool Equals(CMsgGCToGCMasterSubscribeToCacheResponse other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_"></a> MergeFrom\(CMsgGCToGCMasterSubscribeToCacheResponse\)

```csharp
public void MergeFrom(CMsgGCToGCMasterSubscribeToCacheResponse other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheResponse](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

