# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry"></a> Class CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry : IMessage<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry>, IEquatable<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry>, IDeepCloneable<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)

#### Implements

IMessage<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry\>, 
[IEquatable<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry\>\(CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry, params CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry__ctor"></a> LogEntry\(\)

```csharp
public LogEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_"></a> LogEntry\(LogEntry\)

```csharp
public LogEntry(CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_EventPoints"></a> EventPoints

```csharp
public int EventPoints { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_HasEventPoints"></a> HasEventPoints

```csharp
public bool HasEventPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_ClearEventPoints"></a> ClearEventPoints\(\)

```csharp
public void ClearEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry Clone()
```

#### Returns

 [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_"></a> Equals\(LogEntry\)

```csharp
public bool Equals(CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_"></a> MergeFrom\(LogEntry\)

```csharp
public void MergeFrom(CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Types_LogEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

