# <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData"></a> Class CMsgGCEconSQLWorkItemEmbeddedRollbackData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCEconSQLWorkItemEmbeddedRollbackData : IMessage<CMsgGCEconSQLWorkItemEmbeddedRollbackData>, IEquatable<CMsgGCEconSQLWorkItemEmbeddedRollbackData>, IDeepCloneable<CMsgGCEconSQLWorkItemEmbeddedRollbackData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)

#### Implements

IMessage<CMsgGCEconSQLWorkItemEmbeddedRollbackData\>, 
[IEquatable<CMsgGCEconSQLWorkItemEmbeddedRollbackData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCEconSQLWorkItemEmbeddedRollbackData\>, 
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
[EnumerableExtensions.In<CMsgGCEconSQLWorkItemEmbeddedRollbackData\>\(CMsgGCEconSQLWorkItemEmbeddedRollbackData, params CMsgGCEconSQLWorkItemEmbeddedRollbackData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData__ctor"></a> CMsgGCEconSQLWorkItemEmbeddedRollbackData\(\)

```csharp
public CMsgGCEconSQLWorkItemEmbeddedRollbackData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData__ctor_Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_"></a> CMsgGCEconSQLWorkItemEmbeddedRollbackData\(CMsgGCEconSQLWorkItemEmbeddedRollbackData\)

```csharp
public CMsgGCEconSQLWorkItemEmbeddedRollbackData(CMsgGCEconSQLWorkItemEmbeddedRollbackData other)
```

#### Parameters

`other` [CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_DeletedItemIdFieldNumber"></a> DeletedItemIdFieldNumber

```csharp
public const int DeletedItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ExpectedAuditActionFieldNumber"></a> ExpectedAuditActionFieldNumber

```csharp
public const int ExpectedAuditActionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_NewAuditActionFieldNumber"></a> NewAuditActionFieldNumber

```csharp
public const int NewAuditActionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_OldAuditActionFieldNumber"></a> OldAuditActionFieldNumber

```csharp
public const int OldAuditActionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_DeletedItemId"></a> DeletedItemId

```csharp
public ulong DeletedItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ExpectedAuditAction"></a> ExpectedAuditAction

```csharp
public uint ExpectedAuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_HasDeletedItemId"></a> HasDeletedItemId

```csharp
public bool HasDeletedItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_HasExpectedAuditAction"></a> HasExpectedAuditAction

```csharp
public bool HasExpectedAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_HasNewAuditAction"></a> HasNewAuditAction

```csharp
public bool HasNewAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_HasOldAuditAction"></a> HasOldAuditAction

```csharp
public bool HasOldAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_NewAuditAction"></a> NewAuditAction

```csharp
public uint NewAuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_OldAuditAction"></a> OldAuditAction

```csharp
public uint OldAuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCEconSQLWorkItemEmbeddedRollbackData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ClearDeletedItemId"></a> ClearDeletedItemId\(\)

```csharp
public void ClearDeletedItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ClearExpectedAuditAction"></a> ClearExpectedAuditAction\(\)

```csharp
public void ClearExpectedAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ClearNewAuditAction"></a> ClearNewAuditAction\(\)

```csharp
public void ClearNewAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ClearOldAuditAction"></a> ClearOldAuditAction\(\)

```csharp
public void ClearOldAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_Clone"></a> Clone\(\)

```csharp
public CMsgGCEconSQLWorkItemEmbeddedRollbackData Clone()
```

#### Returns

 [CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_Equals_Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_"></a> Equals\(CMsgGCEconSQLWorkItemEmbeddedRollbackData\)

```csharp
public bool Equals(CMsgGCEconSQLWorkItemEmbeddedRollbackData other)
```

#### Parameters

`other` [CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_MergeFrom_Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_"></a> MergeFrom\(CMsgGCEconSQLWorkItemEmbeddedRollbackData\)

```csharp
public void MergeFrom(CMsgGCEconSQLWorkItemEmbeddedRollbackData other)
```

#### Parameters

`other` [CMsgGCEconSQLWorkItemEmbeddedRollbackData](Divine.Protobufs.Dota2.CMsgGCEconSQLWorkItemEmbeddedRollbackData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCEconSQLWorkItemEmbeddedRollbackData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

