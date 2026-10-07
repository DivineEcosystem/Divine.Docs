# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem"></a> Class CMsgShowcaseItem\_EconItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_EconItem : IMessage<CMsgShowcaseItem_EconItem>, IEquatable<CMsgShowcaseItem_EconItem>, IDeepCloneable<CMsgShowcaseItem_EconItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)

#### Implements

IMessage<CMsgShowcaseItem\_EconItem\>, 
[IEquatable<CMsgShowcaseItem\_EconItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_EconItem\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_EconItem\>\(CMsgShowcaseItem\_EconItem, params CMsgShowcaseItem\_EconItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem__ctor"></a> CMsgShowcaseItem\_EconItem\(\)

```csharp
public CMsgShowcaseItem_EconItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_"></a> CMsgShowcaseItem\_EconItem\(CMsgShowcaseItem\_EconItem\)

```csharp
public CMsgShowcaseItem_EconItem(CMsgShowcaseItem_EconItem other)
```

#### Parameters

`other` [CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_RefFieldNumber"></a> RefFieldNumber

```csharp
public const int RefFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Data"></a> Data

```csharp
public CMsgShowcaseItem_EconItem.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_EconItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Ref"></a> Ref

```csharp
public CMsgShowcaseEconItemReference Ref { get; set; }
```

#### Property Value

 [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_EconItem Clone()
```

#### Returns

 [CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_"></a> Equals\(CMsgShowcaseItem\_EconItem\)

```csharp
public bool Equals(CMsgShowcaseItem_EconItem other)
```

#### Parameters

`other` [CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_"></a> MergeFrom\(CMsgShowcaseItem\_EconItem\)

```csharp
public void MergeFrom(CMsgShowcaseItem_EconItem other)
```

#### Parameters

`other` [CMsgShowcaseItem\_EconItem](Divine.Protobufs.Dota2.CMsgShowcaseItem\_EconItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_EconItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

