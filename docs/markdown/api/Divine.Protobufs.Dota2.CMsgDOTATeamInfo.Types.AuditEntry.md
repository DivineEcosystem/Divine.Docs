# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry"></a> Class CMsgDOTATeamInfo.Types.AuditEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.AuditEntry : IMessage<CMsgDOTATeamInfo.Types.AuditEntry>, IEquatable<CMsgDOTATeamInfo.Types.AuditEntry>, IDeepCloneable<CMsgDOTATeamInfo.Types.AuditEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.AuditEntry\>, 
[IEquatable<CMsgDOTATeamInfo.Types.AuditEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.AuditEntry\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.AuditEntry\>\(CMsgDOTATeamInfo.Types.AuditEntry, params CMsgDOTATeamInfo.Types.AuditEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry__ctor"></a> AuditEntry\(\)

```csharp
public AuditEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_"></a> AuditEntry\(AuditEntry\)

```csharp
public AuditEntry(CMsgDOTATeamInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.AuditEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.AuditEntry Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_"></a> Equals\(AuditEntry\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_"></a> MergeFrom\(AuditEntry\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_AuditEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

