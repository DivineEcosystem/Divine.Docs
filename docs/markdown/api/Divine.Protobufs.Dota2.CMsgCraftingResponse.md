# <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse"></a> Class CMsgCraftingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCraftingResponse : IMessage<CMsgCraftingResponse>, IEquatable<CMsgCraftingResponse>, IDeepCloneable<CMsgCraftingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)

#### Implements

IMessage<CMsgCraftingResponse\>, 
[IEquatable<CMsgCraftingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCraftingResponse\>, 
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
[EnumerableExtensions.In<CMsgCraftingResponse\>\(CMsgCraftingResponse, params CMsgCraftingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse__ctor"></a> CMsgCraftingResponse\(\)

```csharp
public CMsgCraftingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse__ctor_Divine_Protobufs_Dota2_CMsgCraftingResponse_"></a> CMsgCraftingResponse\(CMsgCraftingResponse\)

```csharp
public CMsgCraftingResponse(CMsgCraftingResponse other)
```

#### Parameters

`other` [CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCraftingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgCraftingResponse Clone()
```

#### Returns

 [CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_Equals_Divine_Protobufs_Dota2_CMsgCraftingResponse_"></a> Equals\(CMsgCraftingResponse\)

```csharp
public bool Equals(CMsgCraftingResponse other)
```

#### Parameters

`other` [CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgCraftingResponse_"></a> MergeFrom\(CMsgCraftingResponse\)

```csharp
public void MergeFrom(CMsgCraftingResponse other)
```

#### Parameters

`other` [CMsgCraftingResponse](Divine.Protobufs.Dota2.CMsgCraftingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

