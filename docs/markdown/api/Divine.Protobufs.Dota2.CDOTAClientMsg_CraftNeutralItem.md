# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem"></a> Class CDOTAClientMsg\_CraftNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_CraftNeutralItem : IMessage<CDOTAClientMsg_CraftNeutralItem>, IEquatable<CDOTAClientMsg_CraftNeutralItem>, IDeepCloneable<CDOTAClientMsg_CraftNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)

#### Implements

IMessage<CDOTAClientMsg\_CraftNeutralItem\>, 
[IEquatable<CDOTAClientMsg\_CraftNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_CraftNeutralItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_CraftNeutralItem\>\(CDOTAClientMsg\_CraftNeutralItem, params CDOTAClientMsg\_CraftNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem__ctor"></a> CDOTAClientMsg\_CraftNeutralItem\(\)

```csharp
public CDOTAClientMsg_CraftNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_"></a> CDOTAClientMsg\_CraftNeutralItem\(CDOTAClientMsg\_CraftNeutralItem\)

```csharp
public CDOTAClientMsg_CraftNeutralItem(CDOTAClientMsg_CraftNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_CraftNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_CraftNeutralItem Clone()
```

#### Returns

 [CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_"></a> Equals\(CDOTAClientMsg\_CraftNeutralItem\)

```csharp
public bool Equals(CDOTAClientMsg_CraftNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_"></a> MergeFrom\(CDOTAClientMsg\_CraftNeutralItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_CraftNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_CraftNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_CraftNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CraftNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

