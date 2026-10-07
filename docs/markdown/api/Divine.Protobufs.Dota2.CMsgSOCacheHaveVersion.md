# <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion"></a> Class CMsgSOCacheHaveVersion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheHaveVersion : IMessage<CMsgSOCacheHaveVersion>, IEquatable<CMsgSOCacheHaveVersion>, IDeepCloneable<CMsgSOCacheHaveVersion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)

#### Implements

IMessage<CMsgSOCacheHaveVersion\>, 
[IEquatable<CMsgSOCacheHaveVersion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheHaveVersion\>, 
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
[EnumerableExtensions.In<CMsgSOCacheHaveVersion\>\(CMsgSOCacheHaveVersion, params CMsgSOCacheHaveVersion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion__ctor"></a> CMsgSOCacheHaveVersion\(\)

```csharp
public CMsgSOCacheHaveVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion__ctor_Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_"></a> CMsgSOCacheHaveVersion\(CMsgSOCacheHaveVersion\)

```csharp
public CMsgSOCacheHaveVersion(CMsgSOCacheHaveVersion other)
```

#### Parameters

`other` [CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_CachedFileVersionFieldNumber"></a> CachedFileVersionFieldNumber

```csharp
public const int CachedFileVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_SoidFieldNumber"></a> SoidFieldNumber

```csharp
public const int SoidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_CachedFileVersion"></a> CachedFileVersion

```csharp
public uint CachedFileVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_HasCachedFileVersion"></a> HasCachedFileVersion

```csharp
public bool HasCachedFileVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheHaveVersion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Soid"></a> Soid

```csharp
public CMsgSOIDOwner Soid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ClearCachedFileVersion"></a> ClearCachedFileVersion\(\)

```csharp
public void ClearCachedFileVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheHaveVersion Clone()
```

#### Returns

 [CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_Equals_Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_"></a> Equals\(CMsgSOCacheHaveVersion\)

```csharp
public bool Equals(CMsgSOCacheHaveVersion other)
```

#### Parameters

`other` [CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_"></a> MergeFrom\(CMsgSOCacheHaveVersion\)

```csharp
public void MergeFrom(CMsgSOCacheHaveVersion other)
```

#### Parameters

`other` [CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheHaveVersion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

