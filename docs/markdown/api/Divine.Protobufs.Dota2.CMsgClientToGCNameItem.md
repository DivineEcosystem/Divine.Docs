# <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem"></a> Class CMsgClientToGCNameItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCNameItem : IMessage<CMsgClientToGCNameItem>, IEquatable<CMsgClientToGCNameItem>, IDeepCloneable<CMsgClientToGCNameItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)

#### Implements

IMessage<CMsgClientToGCNameItem\>, 
[IEquatable<CMsgClientToGCNameItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCNameItem\>, 
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
[EnumerableExtensions.In<CMsgClientToGCNameItem\>\(CMsgClientToGCNameItem, params CMsgClientToGCNameItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem__ctor"></a> CMsgClientToGCNameItem\(\)

```csharp
public CMsgClientToGCNameItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem__ctor_Divine_Protobufs_Dota2_CMsgClientToGCNameItem_"></a> CMsgClientToGCNameItem\(CMsgClientToGCNameItem\)

```csharp
public CMsgClientToGCNameItem(CMsgClientToGCNameItem other)
```

#### Parameters

`other` [CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_SubjectItemIdFieldNumber"></a> SubjectItemIdFieldNumber

```csharp
public const int SubjectItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ToolItemIdFieldNumber"></a> ToolItemIdFieldNumber

```csharp
public const int ToolItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_HasSubjectItemId"></a> HasSubjectItemId

```csharp
public bool HasSubjectItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_HasToolItemId"></a> HasToolItemId

```csharp
public bool HasToolItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCNameItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_SubjectItemId"></a> SubjectItemId

```csharp
public ulong SubjectItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ToolItemId"></a> ToolItemId

```csharp
public ulong ToolItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ClearSubjectItemId"></a> ClearSubjectItemId\(\)

```csharp
public void ClearSubjectItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ClearToolItemId"></a> ClearToolItemId\(\)

```csharp
public void ClearToolItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCNameItem Clone()
```

#### Returns

 [CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_Equals_Divine_Protobufs_Dota2_CMsgClientToGCNameItem_"></a> Equals\(CMsgClientToGCNameItem\)

```csharp
public bool Equals(CMsgClientToGCNameItem other)
```

#### Parameters

`other` [CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCNameItem_"></a> MergeFrom\(CMsgClientToGCNameItem\)

```csharp
public void MergeFrom(CMsgClientToGCNameItem other)
```

#### Parameters

`other` [CMsgClientToGCNameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

