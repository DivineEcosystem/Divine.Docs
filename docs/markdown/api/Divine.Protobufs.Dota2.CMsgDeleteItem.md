# <a id="Divine_Protobufs_Dota2_CMsgDeleteItem"></a> Class CMsgDeleteItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDeleteItem : IMessage<CMsgDeleteItem>, IEquatable<CMsgDeleteItem>, IDeepCloneable<CMsgDeleteItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)

#### Implements

IMessage<CMsgDeleteItem\>, 
[IEquatable<CMsgDeleteItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDeleteItem\>, 
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
[EnumerableExtensions.In<CMsgDeleteItem\>\(CMsgDeleteItem, params CMsgDeleteItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem__ctor"></a> CMsgDeleteItem\(\)

```csharp
public CMsgDeleteItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem__ctor_Divine_Protobufs_Dota2_CMsgDeleteItem_"></a> CMsgDeleteItem\(CMsgDeleteItem\)

```csharp
public CMsgDeleteItem(CMsgDeleteItem other)
```

#### Parameters

`other` [CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDeleteItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_Clone"></a> Clone\(\)

```csharp
public CMsgDeleteItem Clone()
```

#### Returns

 [CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_Equals_Divine_Protobufs_Dota2_CMsgDeleteItem_"></a> Equals\(CMsgDeleteItem\)

```csharp
public bool Equals(CMsgDeleteItem other)
```

#### Parameters

`other` [CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_MergeFrom_Divine_Protobufs_Dota2_CMsgDeleteItem_"></a> MergeFrom\(CMsgDeleteItem\)

```csharp
public void MergeFrom(CMsgDeleteItem other)
```

#### Parameters

`other` [CMsgDeleteItem](Divine.Protobufs.Dota2.CMsgDeleteItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDeleteItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

