# <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails"></a> Class CMsgShowcaseAdminUserDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseAdminUserDetails : IMessage<CMsgShowcaseAdminUserDetails>, IEquatable<CMsgShowcaseAdminUserDetails>, IDeepCloneable<CMsgShowcaseAdminUserDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

#### Implements

IMessage<CMsgShowcaseAdminUserDetails\>, 
[IEquatable<CMsgShowcaseAdminUserDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseAdminUserDetails\>, 
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
[EnumerableExtensions.In<CMsgShowcaseAdminUserDetails\>\(CMsgShowcaseAdminUserDetails, params CMsgShowcaseAdminUserDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails__ctor"></a> CMsgShowcaseAdminUserDetails\(\)

```csharp
public CMsgShowcaseAdminUserDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails__ctor_Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_"></a> CMsgShowcaseAdminUserDetails\(CMsgShowcaseAdminUserDetails\)

```csharp
public CMsgShowcaseAdminUserDetails(CMsgShowcaseAdminUserDetails other)
```

#### Parameters

`other` [CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_AuditEntriesFieldNumber"></a> AuditEntriesFieldNumber

```csharp
public const int AuditEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_LockedUntilTimestampFieldNumber"></a> LockedUntilTimestampFieldNumber

```csharp
public const int LockedUntilTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_ReportsFieldNumber"></a> ReportsFieldNumber

```csharp
public const int ReportsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_AuditEntries"></a> AuditEntries

```csharp
public RepeatedField<CMsgShowcaseAuditEntry> AuditEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseAuditEntry](Divine.Protobufs.Dota2.CMsgShowcaseAuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_HasLockedUntilTimestamp"></a> HasLockedUntilTimestamp

```csharp
public bool HasLockedUntilTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_LockedUntilTimestamp"></a> LockedUntilTimestamp

```csharp
public uint LockedUntilTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseAdminUserDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Reports"></a> Reports

```csharp
public RepeatedField<CMsgShowcaseReport> Reports { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_ClearLockedUntilTimestamp"></a> ClearLockedUntilTimestamp\(\)

```csharp
public void ClearLockedUntilTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseAdminUserDetails Clone()
```

#### Returns

 [CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_Equals_Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_"></a> Equals\(CMsgShowcaseAdminUserDetails\)

```csharp
public bool Equals(CMsgShowcaseAdminUserDetails other)
```

#### Parameters

`other` [CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_"></a> MergeFrom\(CMsgShowcaseAdminUserDetails\)

```csharp
public void MergeFrom(CMsgShowcaseAdminUserDetails other)
```

#### Parameters

`other` [CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseAdminUserDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

