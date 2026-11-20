# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem"></a> Class CDOTAClientMsg\_BrewmasterAssignScepterItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_BrewmasterAssignScepterItem : IMessage<CDOTAClientMsg_BrewmasterAssignScepterItem>, IEquatable<CDOTAClientMsg_BrewmasterAssignScepterItem>, IDeepCloneable<CDOTAClientMsg_BrewmasterAssignScepterItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)

#### Implements

IMessage<CDOTAClientMsg\_BrewmasterAssignScepterItem\>, 
[IEquatable<CDOTAClientMsg\_BrewmasterAssignScepterItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_BrewmasterAssignScepterItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_BrewmasterAssignScepterItem\>\(CDOTAClientMsg\_BrewmasterAssignScepterItem, params CDOTAClientMsg\_BrewmasterAssignScepterItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem__ctor"></a> CDOTAClientMsg\_BrewmasterAssignScepterItem\(\)

```csharp
public CDOTAClientMsg_BrewmasterAssignScepterItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_"></a> CDOTAClientMsg\_BrewmasterAssignScepterItem\(CDOTAClientMsg\_BrewmasterAssignScepterItem\)

```csharp
public CDOTAClientMsg_BrewmasterAssignScepterItem(CDOTAClientMsg_BrewmasterAssignScepterItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_BrewlingFieldNumber"></a> BrewlingFieldNumber

```csharp
public const int BrewlingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_ItemEntindexFieldNumber"></a> ItemEntindexFieldNumber

```csharp
public const int ItemEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Brewling"></a> Brewling

```csharp
public int Brewling { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_HasBrewling"></a> HasBrewling

```csharp
public bool HasBrewling { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_HasItemEntindex"></a> HasItemEntindex

```csharp
public bool HasItemEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_ItemEntindex"></a> ItemEntindex

```csharp
public int ItemEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_BrewmasterAssignScepterItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_ClearBrewling"></a> ClearBrewling\(\)

```csharp
public void ClearBrewling()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_ClearItemEntindex"></a> ClearItemEntindex\(\)

```csharp
public void ClearItemEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_BrewmasterAssignScepterItem Clone()
```

#### Returns

 [CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_"></a> Equals\(CDOTAClientMsg\_BrewmasterAssignScepterItem\)

```csharp
public bool Equals(CDOTAClientMsg_BrewmasterAssignScepterItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_"></a> MergeFrom\(CDOTAClientMsg\_BrewmasterAssignScepterItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_BrewmasterAssignScepterItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_BrewmasterAssignScepterItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_BrewmasterAssignScepterItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BrewmasterAssignScepterItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

