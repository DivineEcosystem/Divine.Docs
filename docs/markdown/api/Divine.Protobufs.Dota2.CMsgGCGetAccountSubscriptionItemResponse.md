# <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse"></a> Class CMsgGCGetAccountSubscriptionItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetAccountSubscriptionItemResponse : IMessage<CMsgGCGetAccountSubscriptionItemResponse>, IEquatable<CMsgGCGetAccountSubscriptionItemResponse>, IDeepCloneable<CMsgGCGetAccountSubscriptionItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)

#### Implements

IMessage<CMsgGCGetAccountSubscriptionItemResponse\>, 
[IEquatable<CMsgGCGetAccountSubscriptionItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetAccountSubscriptionItemResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetAccountSubscriptionItemResponse\>\(CMsgGCGetAccountSubscriptionItemResponse, params CMsgGCGetAccountSubscriptionItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse__ctor"></a> CMsgGCGetAccountSubscriptionItemResponse\(\)

```csharp
public CMsgGCGetAccountSubscriptionItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse__ctor_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_"></a> CMsgGCGetAccountSubscriptionItemResponse\(CMsgGCGetAccountSubscriptionItemResponse\)

```csharp
public CMsgGCGetAccountSubscriptionItemResponse(CMsgGCGetAccountSubscriptionItemResponse other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetAccountSubscriptionItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetAccountSubscriptionItemResponse Clone()
```

#### Returns

 [CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_Equals_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_"></a> Equals\(CMsgGCGetAccountSubscriptionItemResponse\)

```csharp
public bool Equals(CMsgGCGetAccountSubscriptionItemResponse other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_"></a> MergeFrom\(CMsgGCGetAccountSubscriptionItemResponse\)

```csharp
public void MergeFrom(CMsgGCGetAccountSubscriptionItemResponse other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItemResponse](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

