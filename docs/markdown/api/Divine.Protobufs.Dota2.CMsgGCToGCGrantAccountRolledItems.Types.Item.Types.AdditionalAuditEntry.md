# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry"></a> Class CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry : IMessage<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry>, IEquatable<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry>, IDeepCloneable<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)

#### Implements

IMessage<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry\>, 
[IEquatable<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry\>\(CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry, params CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry__ctor"></a> AdditionalAuditEntry\(\)

```csharp
public AdditionalAuditEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_"></a> AdditionalAuditEntry\(AdditionalAuditEntry\)

```csharp
public AdditionalAuditEntry(CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.md).[AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_OwnerAccountIdFieldNumber"></a> OwnerAccountIdFieldNumber

```csharp
public const int OwnerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_HasOwnerAccountId"></a> HasOwnerAccountId

```csharp
public bool HasOwnerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_OwnerAccountId"></a> OwnerAccountId

```csharp
public uint OwnerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.md).[AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_ClearOwnerAccountId"></a> ClearOwnerAccountId\(\)

```csharp
public void ClearOwnerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry Clone()
```

#### Returns

 [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.md).[AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_"></a> Equals\(AdditionalAuditEntry\)

```csharp
public bool Equals(CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.md).[AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_"></a> MergeFrom\(AdditionalAuditEntry\)

```csharp
public void MergeFrom(CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry other)
```

#### Parameters

`other` [CMsgGCToGCGrantAccountRolledItems](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.md).[AdditionalAuditEntry](Divine.Protobufs.Dota2.CMsgGCToGCGrantAccountRolledItems.Types.Item.Types.AdditionalAuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantAccountRolledItems_Types_Item_Types_AdditionalAuditEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

