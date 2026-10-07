# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache"></a> Class CMsgDotaFantasyCraftingDataCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingDataCache : IMessage<CMsgDotaFantasyCraftingDataCache>, IEquatable<CMsgDotaFantasyCraftingDataCache>, IDeepCloneable<CMsgDotaFantasyCraftingDataCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingDataCache\>, 
[IEquatable<CMsgDotaFantasyCraftingDataCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingDataCache\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingDataCache\>\(CMsgDotaFantasyCraftingDataCache, params CMsgDotaFantasyCraftingDataCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache__ctor"></a> CMsgDotaFantasyCraftingDataCache\(\)

```csharp
public CMsgDotaFantasyCraftingDataCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_"></a> CMsgDotaFantasyCraftingDataCache\(CMsgDotaFantasyCraftingDataCache\)

```csharp
public CMsgDotaFantasyCraftingDataCache(CMsgDotaFantasyCraftingDataCache other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_CacheEntriesFieldNumber"></a> CacheEntriesFieldNumber

```csharp
public const int CacheEntriesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_CacheEntries"></a> CacheEntries

```csharp
public RepeatedField<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry> CacheEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingDataCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingDataCache Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_"></a> Equals\(CMsgDotaFantasyCraftingDataCache\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingDataCache other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_"></a> MergeFrom\(CMsgDotaFantasyCraftingDataCache\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingDataCache other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

