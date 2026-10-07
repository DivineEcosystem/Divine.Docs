# <a id="Divine_Protobufs_Dota2_CMsgSortItems"></a> Class CMsgSortItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSortItems : IMessage<CMsgSortItems>, IEquatable<CMsgSortItems>, IDeepCloneable<CMsgSortItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)

#### Implements

IMessage<CMsgSortItems\>, 
[IEquatable<CMsgSortItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSortItems\>, 
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
[EnumerableExtensions.In<CMsgSortItems\>\(CMsgSortItems, params CMsgSortItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSortItems__ctor"></a> CMsgSortItems\(\)

```csharp
public CMsgSortItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgSortItems__ctor_Divine_Protobufs_Dota2_CMsgSortItems_"></a> CMsgSortItems\(CMsgSortItems\)

```csharp
public CMsgSortItems(CMsgSortItems other)
```

#### Parameters

`other` [CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_SortTypeFieldNumber"></a> SortTypeFieldNumber

```csharp
public const int SortTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_HasSortType"></a> HasSortType

```csharp
public bool HasSortType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSortItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_SortType"></a> SortType

```csharp
public uint SortType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_ClearSortType"></a> ClearSortType\(\)

```csharp
public void ClearSortType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_Clone"></a> Clone\(\)

```csharp
public CMsgSortItems Clone()
```

#### Returns

 [CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_Equals_Divine_Protobufs_Dota2_CMsgSortItems_"></a> Equals\(CMsgSortItems\)

```csharp
public bool Equals(CMsgSortItems other)
```

#### Parameters

`other` [CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_MergeFrom_Divine_Protobufs_Dota2_CMsgSortItems_"></a> MergeFrom\(CMsgSortItems\)

```csharp
public void MergeFrom(CMsgSortItems other)
```

#### Parameters

`other` [CMsgSortItems](Divine.Protobufs.Dota2.CMsgSortItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSortItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

