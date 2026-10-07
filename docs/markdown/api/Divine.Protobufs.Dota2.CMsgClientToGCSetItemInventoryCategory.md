# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory"></a> Class CMsgClientToGCSetItemInventoryCategory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetItemInventoryCategory : IMessage<CMsgClientToGCSetItemInventoryCategory>, IEquatable<CMsgClientToGCSetItemInventoryCategory>, IDeepCloneable<CMsgClientToGCSetItemInventoryCategory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)

#### Implements

IMessage<CMsgClientToGCSetItemInventoryCategory\>, 
[IEquatable<CMsgClientToGCSetItemInventoryCategory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetItemInventoryCategory\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetItemInventoryCategory\>\(CMsgClientToGCSetItemInventoryCategory, params CMsgClientToGCSetItemInventoryCategory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory__ctor"></a> CMsgClientToGCSetItemInventoryCategory\(\)

```csharp
public CMsgClientToGCSetItemInventoryCategory()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_"></a> CMsgClientToGCSetItemInventoryCategory\(CMsgClientToGCSetItemInventoryCategory\)

```csharp
public CMsgClientToGCSetItemInventoryCategory(CMsgClientToGCSetItemInventoryCategory other)
```

#### Parameters

`other` [CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_AddCategoriesFieldNumber"></a> AddCategoriesFieldNumber

```csharp
public const int AddCategoriesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_RemoveCategoriesFieldNumber"></a> RemoveCategoriesFieldNumber

```csharp
public const int RemoveCategoriesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_SetToValueFieldNumber"></a> SetToValueFieldNumber

```csharp
public const int SetToValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_AddCategories"></a> AddCategories

```csharp
public uint AddCategories { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_HasAddCategories"></a> HasAddCategories

```csharp
public bool HasAddCategories { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_HasRemoveCategories"></a> HasRemoveCategories

```csharp
public bool HasRemoveCategories { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_HasSetToValue"></a> HasSetToValue

```csharp
public bool HasSetToValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetItemInventoryCategory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_RemoveCategories"></a> RemoveCategories

```csharp
public uint RemoveCategories { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_SetToValue"></a> SetToValue

```csharp
public uint SetToValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ClearAddCategories"></a> ClearAddCategories\(\)

```csharp
public void ClearAddCategories()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ClearRemoveCategories"></a> ClearRemoveCategories\(\)

```csharp
public void ClearRemoveCategories()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ClearSetToValue"></a> ClearSetToValue\(\)

```csharp
public void ClearSetToValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetItemInventoryCategory Clone()
```

#### Returns

 [CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_"></a> Equals\(CMsgClientToGCSetItemInventoryCategory\)

```csharp
public bool Equals(CMsgClientToGCSetItemInventoryCategory other)
```

#### Parameters

`other` [CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_"></a> MergeFrom\(CMsgClientToGCSetItemInventoryCategory\)

```csharp
public void MergeFrom(CMsgClientToGCSetItemInventoryCategory other)
```

#### Parameters

`other` [CMsgClientToGCSetItemInventoryCategory](Divine.Protobufs.Dota2.CMsgClientToGCSetItemInventoryCategory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemInventoryCategory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

