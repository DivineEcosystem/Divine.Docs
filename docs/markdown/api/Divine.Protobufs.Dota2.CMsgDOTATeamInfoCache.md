# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache"></a> Class CMsgDOTATeamInfoCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfoCache : IMessage<CMsgDOTATeamInfoCache>, IEquatable<CMsgDOTATeamInfoCache>, IDeepCloneable<CMsgDOTATeamInfoCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)

#### Implements

IMessage<CMsgDOTATeamInfoCache\>, 
[IEquatable<CMsgDOTATeamInfoCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfoCache\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfoCache\>\(CMsgDOTATeamInfoCache, params CMsgDOTATeamInfoCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache__ctor"></a> CMsgDOTATeamInfoCache\(\)

```csharp
public CMsgDOTATeamInfoCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_"></a> CMsgDOTATeamInfoCache\(CMsgDOTATeamInfoCache\)

```csharp
public CMsgDOTATeamInfoCache(CMsgDOTATeamInfoCache other)
```

#### Parameters

`other` [CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_CacheTimestampFieldNumber"></a> CacheTimestampFieldNumber

```csharp
public const int CacheTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_TeamListFieldNumber"></a> TeamListFieldNumber

```csharp
public const int TeamListFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_CacheTimestamp"></a> CacheTimestamp

```csharp
public uint CacheTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_HasCacheTimestamp"></a> HasCacheTimestamp

```csharp
public bool HasCacheTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfoCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_TeamList"></a> TeamList

```csharp
public CMsgDOTATeamInfoList TeamList { get; set; }
```

#### Property Value

 [CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_ClearCacheTimestamp"></a> ClearCacheTimestamp\(\)

```csharp
public void ClearCacheTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfoCache Clone()
```

#### Returns

 [CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_"></a> Equals\(CMsgDOTATeamInfoCache\)

```csharp
public bool Equals(CMsgDOTATeamInfoCache other)
```

#### Parameters

`other` [CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_"></a> MergeFrom\(CMsgDOTATeamInfoCache\)

```csharp
public void MergeFrom(CMsgDOTATeamInfoCache other)
```

#### Parameters

`other` [CMsgDOTATeamInfoCache](Divine.Protobufs.Dota2.CMsgDOTATeamInfoCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

