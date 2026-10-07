# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem"></a> Class CDOTAClientMsg\_DemoHero.Types.PreviewItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_DemoHero.Types.PreviewItem : IMessage<CDOTAClientMsg_DemoHero.Types.PreviewItem>, IEquatable<CDOTAClientMsg_DemoHero.Types.PreviewItem>, IDeepCloneable<CDOTAClientMsg_DemoHero.Types.PreviewItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_DemoHero.Types.PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)

#### Implements

IMessage<CDOTAClientMsg\_DemoHero.Types.PreviewItem\>, 
[IEquatable<CDOTAClientMsg\_DemoHero.Types.PreviewItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_DemoHero.Types.PreviewItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_DemoHero.Types.PreviewItem\>\(CDOTAClientMsg\_DemoHero.Types.PreviewItem, params CDOTAClientMsg\_DemoHero.Types.PreviewItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem__ctor"></a> PreviewItem\(\)

```csharp
public PreviewItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_"></a> PreviewItem\(PreviewItem\)

```csharp
public PreviewItem(CDOTAClientMsg_DemoHero.Types.PreviewItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ItemStyleFieldNumber"></a> ItemStyleFieldNumber

```csharp
public const int ItemStyleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_HasItemStyle"></a> HasItemStyle

```csharp
public bool HasItemStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ItemStyle"></a> ItemStyle

```csharp
public uint ItemStyle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_DemoHero.Types.PreviewItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ClearItemStyle"></a> ClearItemStyle\(\)

```csharp
public void ClearItemStyle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_DemoHero.Types.PreviewItem Clone()
```

#### Returns

 [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_"></a> Equals\(PreviewItem\)

```csharp
public bool Equals(CDOTAClientMsg_DemoHero.Types.PreviewItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_"></a> MergeFrom\(PreviewItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_DemoHero.Types.PreviewItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Types_PreviewItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

