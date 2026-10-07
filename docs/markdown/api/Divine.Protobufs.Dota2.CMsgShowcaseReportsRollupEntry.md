# <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry"></a> Class CMsgShowcaseReportsRollupEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseReportsRollupEntry : IMessage<CMsgShowcaseReportsRollupEntry>, IEquatable<CMsgShowcaseReportsRollupEntry>, IDeepCloneable<CMsgShowcaseReportsRollupEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)

#### Implements

IMessage<CMsgShowcaseReportsRollupEntry\>, 
[IEquatable<CMsgShowcaseReportsRollupEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseReportsRollupEntry\>, 
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
[EnumerableExtensions.In<CMsgShowcaseReportsRollupEntry\>\(CMsgShowcaseReportsRollupEntry, params CMsgShowcaseReportsRollupEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry__ctor"></a> CMsgShowcaseReportsRollupEntry\(\)

```csharp
public CMsgShowcaseReportsRollupEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry__ctor_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_"></a> CMsgShowcaseReportsRollupEntry\(CMsgShowcaseReportsRollupEntry\)

```csharp
public CMsgShowcaseReportsRollupEntry(CMsgShowcaseReportsRollupEntry other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ReportCountFieldNumber"></a> ReportCountFieldNumber

```csharp
public const int ReportCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_HasReportCount"></a> HasReportCount

```csharp
public bool HasReportCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseReportsRollupEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ReportCount"></a> ReportCount

```csharp
public uint ReportCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ClearReportCount"></a> ClearReportCount\(\)

```csharp
public void ClearReportCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseReportsRollupEntry Clone()
```

#### Returns

 [CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_Equals_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_"></a> Equals\(CMsgShowcaseReportsRollupEntry\)

```csharp
public bool Equals(CMsgShowcaseReportsRollupEntry other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_"></a> MergeFrom\(CMsgShowcaseReportsRollupEntry\)

```csharp
public void MergeFrom(CMsgShowcaseReportsRollupEntry other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

