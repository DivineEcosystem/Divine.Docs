# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems"></a> Class CMsgGCToGCGrantAccountRolledItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGrantAccountRolledItems : IMessage<CMsgGCToGCGrantAccountRolledItems>, IEquatable<CMsgGCToGCGrantAccountRolledItems>, IDeepCloneable<CMsgGCToGCGrantAccountRolledItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)

#### Implements

IMessage<CMsgGCToGCGrantAccountRolledItems\>, 
[IEquatable<CMsgGCToGCGrantAccountRolledItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGrantAccountRolledItems\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGrantAccountRolledItems\>\(CMsgGCToGCGrantAccountRolledItems, params CMsgGCToGCGrantAccountRolledItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems__ctor"></a> CMsgGCToGCGrantAccountRolledItems\(\)

```csharp
public CMsgGCToGCGrantAccountRolledItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_"></a> CMsgGCToGCGrantAccountRolledItems\(CMsgGCToGCGrantAccountRolledItems\)

```csharp
public CMsgGCToGCGrantAccountRolledItems(CMsgGCToGCGrantAccountRolledItems other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Items"></a> Items

```csharp
public RepeatedField<CMsgGCToGCGrantAccountRolledItems.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGrantAccountRolledItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGrantAccountRolledItems Clone()
```

#### Returns

 [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_"></a> Equals\(CMsgGCToGCGrantAccountRolledItems\)

```csharp
public bool Equals(CMsgGCToGCGrantAccountRolledItems other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_"></a> MergeFrom\(CMsgGCToGCGrantAccountRolledItems\)

```csharp
public void MergeFrom(CMsgGCToGCGrantAccountRolledItems other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

