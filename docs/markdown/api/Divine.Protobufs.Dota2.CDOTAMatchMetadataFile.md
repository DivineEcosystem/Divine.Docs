# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile"></a> Class CDOTAMatchMetadataFile

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadataFile : IMessage<CDOTAMatchMetadataFile>, IEquatable<CDOTAMatchMetadataFile>, IDeepCloneable<CDOTAMatchMetadataFile>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)

#### Implements

IMessage<CDOTAMatchMetadataFile\>, 
[IEquatable<CDOTAMatchMetadataFile\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadataFile\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadataFile\>\(CDOTAMatchMetadataFile, params CDOTAMatchMetadataFile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile__ctor"></a> CDOTAMatchMetadataFile\(\)

```csharp
public CDOTAMatchMetadataFile()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_"></a> CDOTAMatchMetadataFile\(CDOTAMatchMetadataFile\)

```csharp
public CDOTAMatchMetadataFile(CDOTAMatchMetadataFile other)
```

#### Parameters

`other` [CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_MetadataFieldNumber"></a> MetadataFieldNumber

```csharp
public const int MetadataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_PrivateMetadataFieldNumber"></a> PrivateMetadataFieldNumber

```csharp
public const int PrivateMetadataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_HasPrivateMetadata"></a> HasPrivateMetadata

```csharp
public bool HasPrivateMetadata { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Metadata"></a> Metadata

```csharp
public CDOTAMatchMetadata Metadata { get; set; }
```

#### Property Value

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadataFile> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_PrivateMetadata"></a> PrivateMetadata

```csharp
public ByteString PrivateMetadata { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_ClearPrivateMetadata"></a> ClearPrivateMetadata\(\)

```csharp
public void ClearPrivateMetadata()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadataFile Clone()
```

#### Returns

 [CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_"></a> Equals\(CDOTAMatchMetadataFile\)

```csharp
public bool Equals(CDOTAMatchMetadataFile other)
```

#### Parameters

`other` [CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_"></a> MergeFrom\(CDOTAMatchMetadataFile\)

```csharp
public void MergeFrom(CDOTAMatchMetadataFile other)
```

#### Parameters

`other` [CDOTAMatchMetadataFile](Divine.Protobufs.Dota2.CDOTAMatchMetadataFile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadataFile_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

