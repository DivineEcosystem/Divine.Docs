# <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache"></a> Class CMsgSerializedSOCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSerializedSOCache : IMessage<CMsgSerializedSOCache>, IEquatable<CMsgSerializedSOCache>, IDeepCloneable<CMsgSerializedSOCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)

#### Implements

IMessage<CMsgSerializedSOCache\>, 
[IEquatable<CMsgSerializedSOCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSerializedSOCache\>, 
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
[EnumerableExtensions.In<CMsgSerializedSOCache\>\(CMsgSerializedSOCache, params CMsgSerializedSOCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache__ctor"></a> CMsgSerializedSOCache\(\)

```csharp
public CMsgSerializedSOCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache__ctor_Divine_Protobufs_Dota2_CMsgSerializedSOCache_"></a> CMsgSerializedSOCache\(CMsgSerializedSOCache\)

```csharp
public CMsgSerializedSOCache(CMsgSerializedSOCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_CachesFieldNumber"></a> CachesFieldNumber

```csharp
public const int CachesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_FileVersionFieldNumber"></a> FileVersionFieldNumber

```csharp
public const int FileVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_GcSocacheFileVersionFieldNumber"></a> GcSocacheFileVersionFieldNumber

```csharp
public const int GcSocacheFileVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Caches"></a> Caches

```csharp
public RepeatedField<CMsgSerializedSOCache.Types.Cache> Caches { get; }
```

#### Property Value

 RepeatedField<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_FileVersion"></a> FileVersion

```csharp
public uint FileVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_GcSocacheFileVersion"></a> GcSocacheFileVersion

```csharp
public uint GcSocacheFileVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_HasFileVersion"></a> HasFileVersion

```csharp
public bool HasFileVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_HasGcSocacheFileVersion"></a> HasGcSocacheFileVersion

```csharp
public bool HasGcSocacheFileVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSerializedSOCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_ClearFileVersion"></a> ClearFileVersion\(\)

```csharp
public void ClearFileVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_ClearGcSocacheFileVersion"></a> ClearGcSocacheFileVersion\(\)

```csharp
public void ClearGcSocacheFileVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Clone"></a> Clone\(\)

```csharp
public CMsgSerializedSOCache Clone()
```

#### Returns

 [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Equals_Divine_Protobufs_Dota2_CMsgSerializedSOCache_"></a> Equals\(CMsgSerializedSOCache\)

```csharp
public bool Equals(CMsgSerializedSOCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_MergeFrom_Divine_Protobufs_Dota2_CMsgSerializedSOCache_"></a> MergeFrom\(CMsgSerializedSOCache\)

```csharp
public void MergeFrom(CMsgSerializedSOCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

