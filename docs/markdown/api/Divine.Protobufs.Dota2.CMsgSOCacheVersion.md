# <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion"></a> Class CMsgSOCacheVersion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheVersion : IMessage<CMsgSOCacheVersion>, IEquatable<CMsgSOCacheVersion>, IDeepCloneable<CMsgSOCacheVersion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)

#### Implements

IMessage<CMsgSOCacheVersion\>, 
[IEquatable<CMsgSOCacheVersion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheVersion\>, 
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
[EnumerableExtensions.In<CMsgSOCacheVersion\>\(CMsgSOCacheVersion, params CMsgSOCacheVersion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion__ctor"></a> CMsgSOCacheVersion\(\)

```csharp
public CMsgSOCacheVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion__ctor_Divine_Protobufs_Dota2_CMsgSOCacheVersion_"></a> CMsgSOCacheVersion\(CMsgSOCacheVersion\)

```csharp
public CMsgSOCacheVersion(CMsgSOCacheVersion other)
```

#### Parameters

`other` [CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheVersion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheVersion Clone()
```

#### Returns

 [CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_Equals_Divine_Protobufs_Dota2_CMsgSOCacheVersion_"></a> Equals\(CMsgSOCacheVersion\)

```csharp
public bool Equals(CMsgSOCacheVersion other)
```

#### Parameters

`other` [CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheVersion_"></a> MergeFrom\(CMsgSOCacheVersion\)

```csharp
public void MergeFrom(CMsgSOCacheVersion other)
```

#### Parameters

`other` [CMsgSOCacheVersion](Divine.Protobufs.Dota2.CMsgSOCacheVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheVersion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

