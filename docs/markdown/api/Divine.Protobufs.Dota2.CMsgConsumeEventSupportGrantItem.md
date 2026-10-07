# <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem"></a> Class CMsgConsumeEventSupportGrantItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConsumeEventSupportGrantItem : IMessage<CMsgConsumeEventSupportGrantItem>, IEquatable<CMsgConsumeEventSupportGrantItem>, IDeepCloneable<CMsgConsumeEventSupportGrantItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)

#### Implements

IMessage<CMsgConsumeEventSupportGrantItem\>, 
[IEquatable<CMsgConsumeEventSupportGrantItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConsumeEventSupportGrantItem\>, 
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
[EnumerableExtensions.In<CMsgConsumeEventSupportGrantItem\>\(CMsgConsumeEventSupportGrantItem, params CMsgConsumeEventSupportGrantItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem__ctor"></a> CMsgConsumeEventSupportGrantItem\(\)

```csharp
public CMsgConsumeEventSupportGrantItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem__ctor_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_"></a> CMsgConsumeEventSupportGrantItem\(CMsgConsumeEventSupportGrantItem\)

```csharp
public CMsgConsumeEventSupportGrantItem(CMsgConsumeEventSupportGrantItem other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConsumeEventSupportGrantItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_Clone"></a> Clone\(\)

```csharp
public CMsgConsumeEventSupportGrantItem Clone()
```

#### Returns

 [CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_Equals_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_"></a> Equals\(CMsgConsumeEventSupportGrantItem\)

```csharp
public bool Equals(CMsgConsumeEventSupportGrantItem other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_MergeFrom_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_"></a> MergeFrom\(CMsgConsumeEventSupportGrantItem\)

```csharp
public void MergeFrom(CMsgConsumeEventSupportGrantItem other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItem](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

