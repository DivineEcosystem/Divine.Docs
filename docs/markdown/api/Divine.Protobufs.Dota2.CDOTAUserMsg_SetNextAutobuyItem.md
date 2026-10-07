# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem"></a> Class CDOTAUserMsg\_SetNextAutobuyItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SetNextAutobuyItem : IMessage<CDOTAUserMsg_SetNextAutobuyItem>, IEquatable<CDOTAUserMsg_SetNextAutobuyItem>, IDeepCloneable<CDOTAUserMsg_SetNextAutobuyItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)

#### Implements

IMessage<CDOTAUserMsg\_SetNextAutobuyItem\>, 
[IEquatable<CDOTAUserMsg\_SetNextAutobuyItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SetNextAutobuyItem\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SetNextAutobuyItem\>\(CDOTAUserMsg\_SetNextAutobuyItem, params CDOTAUserMsg\_SetNextAutobuyItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem__ctor"></a> CDOTAUserMsg\_SetNextAutobuyItem\(\)

```csharp
public CDOTAUserMsg_SetNextAutobuyItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_"></a> CDOTAUserMsg\_SetNextAutobuyItem\(CDOTAUserMsg\_SetNextAutobuyItem\)

```csharp
public CDOTAUserMsg_SetNextAutobuyItem(CDOTAUserMsg_SetNextAutobuyItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SetNextAutobuyItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SetNextAutobuyItem Clone()
```

#### Returns

 [CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_"></a> Equals\(CDOTAUserMsg\_SetNextAutobuyItem\)

```csharp
public bool Equals(CDOTAUserMsg_SetNextAutobuyItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_"></a> MergeFrom\(CDOTAUserMsg\_SetNextAutobuyItem\)

```csharp
public void MergeFrom(CDOTAUserMsg_SetNextAutobuyItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_SetNextAutobuyItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_SetNextAutobuyItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SetNextAutobuyItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

