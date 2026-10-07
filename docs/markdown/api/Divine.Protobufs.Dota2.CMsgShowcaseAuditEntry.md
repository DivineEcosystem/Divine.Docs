# <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry"></a> Class CMsgShowcaseAuditEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseAuditEntry : IMessage<CMsgShowcaseAuditEntry>, IEquatable<CMsgShowcaseAuditEntry>, IDeepCloneable<CMsgShowcaseAuditEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)

#### Implements

IMessage<CMsgShowcaseAuditEntry\>, 
[IEquatable<CMsgShowcaseAuditEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseAuditEntry\>, 
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
[EnumerableExtensions.In<CMsgShowcaseAuditEntry\>\(CMsgShowcaseAuditEntry, params CMsgShowcaseAuditEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry__ctor"></a> CMsgShowcaseAuditEntry\(\)

```csharp
public CMsgShowcaseAuditEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry__ctor_Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_"></a> CMsgShowcaseAuditEntry\(CMsgShowcaseAuditEntry\)

```csharp
public CMsgShowcaseAuditEntry(CMsgShowcaseAuditEntry other)
```

#### Parameters

`other` [CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_AuditAction"></a> AuditAction

```csharp
public EShowcaseAuditAction AuditAction { get; set; }
```

#### Property Value

 [EShowcaseAuditAction](Divine.Protobufs.Dota2.EShowcaseAuditAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseAuditEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseAuditEntry Clone()
```

#### Returns

 [CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_Equals_Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_"></a> Equals\(CMsgShowcaseAuditEntry\)

```csharp
public bool Equals(CMsgShowcaseAuditEntry other)
```

#### Parameters

`other` [CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_"></a> MergeFrom\(CMsgShowcaseAuditEntry\)

```csharp
public void MergeFrom(CMsgShowcaseAuditEntry other)
```

#### Parameters

`other` [CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAuditEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

