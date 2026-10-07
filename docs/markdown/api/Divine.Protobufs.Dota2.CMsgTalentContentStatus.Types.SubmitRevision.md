# <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision"></a> Class CMsgTalentContentStatus.Types.SubmitRevision

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTalentContentStatus.Types.SubmitRevision : IMessage<CMsgTalentContentStatus.Types.SubmitRevision>, IEquatable<CMsgTalentContentStatus.Types.SubmitRevision>, IDeepCloneable<CMsgTalentContentStatus.Types.SubmitRevision>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTalentContentStatus.Types.SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)

#### Implements

IMessage<CMsgTalentContentStatus.Types.SubmitRevision\>, 
[IEquatable<CMsgTalentContentStatus.Types.SubmitRevision\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTalentContentStatus.Types.SubmitRevision\>, 
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
[EnumerableExtensions.In<CMsgTalentContentStatus.Types.SubmitRevision\>\(CMsgTalentContentStatus.Types.SubmitRevision, params CMsgTalentContentStatus.Types.SubmitRevision\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision__ctor"></a> SubmitRevision\(\)

```csharp
public SubmitRevision()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision__ctor_Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_"></a> SubmitRevision\(SubmitRevision\)

```csharp
public SubmitRevision(CMsgTalentContentStatus.Types.SubmitRevision other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_RevisionNumberFieldNumber"></a> RevisionNumberFieldNumber

```csharp
public const int RevisionNumberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ZipFileFieldNumber"></a> ZipFileFieldNumber

```csharp
public const int ZipFileFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_HasRevisionNumber"></a> HasRevisionNumber

```csharp
public bool HasRevisionNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_HasZipFile"></a> HasZipFile

```csharp
public bool HasZipFile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTalentContentStatus.Types.SubmitRevision> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_RevisionNumber"></a> RevisionNumber

```csharp
public uint RevisionNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ZipFile"></a> ZipFile

```csharp
public string ZipFile { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ClearRevisionNumber"></a> ClearRevisionNumber\(\)

```csharp
public void ClearRevisionNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ClearZipFile"></a> ClearZipFile\(\)

```csharp
public void ClearZipFile()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Clone"></a> Clone\(\)

```csharp
public CMsgTalentContentStatus.Types.SubmitRevision Clone()
```

#### Returns

 [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_Equals_Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_"></a> Equals\(SubmitRevision\)

```csharp
public bool Equals(CMsgTalentContentStatus.Types.SubmitRevision other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_MergeFrom_Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_"></a> MergeFrom\(SubmitRevision\)

```csharp
public void MergeFrom(CMsgTalentContentStatus.Types.SubmitRevision other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[SubmitRevision](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.SubmitRevision.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Types_SubmitRevision_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

