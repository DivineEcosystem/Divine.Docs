# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse"></a> Class CMsgClientToGCRecycleMultipleItemsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecycleMultipleItemsResponse : IMessage<CMsgClientToGCRecycleMultipleItemsResponse>, IEquatable<CMsgClientToGCRecycleMultipleItemsResponse>, IDeepCloneable<CMsgClientToGCRecycleMultipleItemsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)

#### Implements

IMessage<CMsgClientToGCRecycleMultipleItemsResponse\>, 
[IEquatable<CMsgClientToGCRecycleMultipleItemsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecycleMultipleItemsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecycleMultipleItemsResponse\>\(CMsgClientToGCRecycleMultipleItemsResponse, params CMsgClientToGCRecycleMultipleItemsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse__ctor"></a> CMsgClientToGCRecycleMultipleItemsResponse\(\)

```csharp
public CMsgClientToGCRecycleMultipleItemsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_"></a> CMsgClientToGCRecycleMultipleItemsResponse\(CMsgClientToGCRecycleMultipleItemsResponse\)

```csharp
public CMsgClientToGCRecycleMultipleItemsResponse(CMsgClientToGCRecycleMultipleItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_ResponsesFieldNumber"></a> ResponsesFieldNumber

```csharp
public const int ResponsesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecycleMultipleItemsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Responses"></a> Responses

```csharp
public RepeatedField<CMsgClientToGCCreateStaticRecipeResponse> Responses { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecycleMultipleItemsResponse Clone()
```

#### Returns

 [CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_"></a> Equals\(CMsgClientToGCRecycleMultipleItemsResponse\)

```csharp
public bool Equals(CMsgClientToGCRecycleMultipleItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_"></a> MergeFrom\(CMsgClientToGCRecycleMultipleItemsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRecycleMultipleItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItemsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

