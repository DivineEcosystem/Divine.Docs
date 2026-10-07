# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute"></a> Class CMsgClientToGCRemoveItemAttribute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRemoveItemAttribute : IMessage<CMsgClientToGCRemoveItemAttribute>, IEquatable<CMsgClientToGCRemoveItemAttribute>, IDeepCloneable<CMsgClientToGCRemoveItemAttribute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)

#### Implements

IMessage<CMsgClientToGCRemoveItemAttribute\>, 
[IEquatable<CMsgClientToGCRemoveItemAttribute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRemoveItemAttribute\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRemoveItemAttribute\>\(CMsgClientToGCRemoveItemAttribute, params CMsgClientToGCRemoveItemAttribute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute__ctor"></a> CMsgClientToGCRemoveItemAttribute\(\)

```csharp
public CMsgClientToGCRemoveItemAttribute()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_"></a> CMsgClientToGCRemoveItemAttribute\(CMsgClientToGCRemoveItemAttribute\)

```csharp
public CMsgClientToGCRemoveItemAttribute(CMsgClientToGCRemoveItemAttribute other)
```

#### Parameters

`other` [CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRemoveItemAttribute> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRemoveItemAttribute Clone()
```

#### Returns

 [CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_"></a> Equals\(CMsgClientToGCRemoveItemAttribute\)

```csharp
public bool Equals(CMsgClientToGCRemoveItemAttribute other)
```

#### Parameters

`other` [CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_"></a> MergeFrom\(CMsgClientToGCRemoveItemAttribute\)

```csharp
public void MergeFrom(CMsgClientToGCRemoveItemAttribute other)
```

#### Parameters

`other` [CMsgClientToGCRemoveItemAttribute](Divine.Protobufs.Dota2.CMsgClientToGCRemoveItemAttribute.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveItemAttribute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

