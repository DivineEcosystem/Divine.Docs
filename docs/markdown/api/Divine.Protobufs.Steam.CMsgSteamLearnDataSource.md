# <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource"></a> Class CMsgSteamLearnDataSource

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnDataSource : IMessage<CMsgSteamLearnDataSource>, IEquatable<CMsgSteamLearnDataSource>, IDeepCloneable<CMsgSteamLearnDataSource>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)

#### Implements

IMessage<CMsgSteamLearnDataSource\>, 
[IEquatable<CMsgSteamLearnDataSource\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnDataSource\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnDataSource\>\(CMsgSteamLearnDataSource, params CMsgSteamLearnDataSource\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource__ctor"></a> CMsgSteamLearnDataSource\(\)

```csharp
public CMsgSteamLearnDataSource()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource__ctor_Divine_Protobufs_Steam_CMsgSteamLearnDataSource_"></a> CMsgSteamLearnDataSource\(CMsgSteamLearnDataSource\)

```csharp
public CMsgSteamLearnDataSource(CMsgSteamLearnDataSource other)
```

#### Parameters

`other` [CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_CacheDurationSecondsFieldNumber"></a> CacheDurationSecondsFieldNumber

```csharp
public const int CacheDurationSecondsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_SourceDescriptionFieldNumber"></a> SourceDescriptionFieldNumber

```csharp
public const int SourceDescriptionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_StructureCrcFieldNumber"></a> StructureCrcFieldNumber

```csharp
public const int StructureCrcFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_StructureFieldNumber"></a> StructureFieldNumber

```csharp
public const int StructureFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_CacheDurationSeconds"></a> CacheDurationSeconds

```csharp
public uint CacheDurationSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasCacheDurationSeconds"></a> HasCacheDurationSeconds

```csharp
public bool HasCacheDurationSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasSourceDescription"></a> HasSourceDescription

```csharp
public bool HasSourceDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasStructureCrc"></a> HasStructureCrc

```csharp
public bool HasStructureCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnDataSource> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_SourceDescription"></a> SourceDescription

```csharp
public string SourceDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Structure"></a> Structure

```csharp
public CMsgSteamLearnDataSourceDescObject Structure { get; set; }
```

#### Property Value

 [CMsgSteamLearnDataSourceDescObject](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescObject.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_StructureCrc"></a> StructureCrc

```csharp
public uint StructureCrc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearCacheDurationSeconds"></a> ClearCacheDurationSeconds\(\)

```csharp
public void ClearCacheDurationSeconds()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearSourceDescription"></a> ClearSourceDescription\(\)

```csharp
public void ClearSourceDescription()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearStructureCrc"></a> ClearStructureCrc\(\)

```csharp
public void ClearStructureCrc()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnDataSource Clone()
```

#### Returns

 [CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_Equals_Divine_Protobufs_Steam_CMsgSteamLearnDataSource_"></a> Equals\(CMsgSteamLearnDataSource\)

```csharp
public bool Equals(CMsgSteamLearnDataSource other)
```

#### Parameters

`other` [CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnDataSource_"></a> MergeFrom\(CMsgSteamLearnDataSource\)

```csharp
public void MergeFrom(CMsgSteamLearnDataSource other)
```

#### Parameters

`other` [CMsgSteamLearnDataSource](Divine.Protobufs.Steam.CMsgSteamLearnDataSource.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSource_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

