# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry"></a> Class CMsgDotaFantasyCraftingDataCache.Types.CacheEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingDataCache.Types.CacheEntry : IMessage<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry>, IEquatable<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry>, IDeepCloneable<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingDataCache.Types.CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry\>, 
[IEquatable<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry\>\(CMsgDotaFantasyCraftingDataCache.Types.CacheEntry, params CMsgDotaFantasyCraftingDataCache.Types.CacheEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry__ctor"></a> CacheEntry\(\)

```csharp
public CacheEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_"></a> CacheEntry\(CacheEntry\)

```csharp
public CacheEntry(CMsgDotaFantasyCraftingDataCache.Types.CacheEntry other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_CacheDataFieldNumber"></a> CacheDataFieldNumber

```csharp
public const int CacheDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_CacheData"></a> CacheData

```csharp
public CMsgGCToClientFantasyCraftingDataUpdated CacheData { get; set; }
```

#### Property Value

 [CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingDataCache.Types.CacheEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingDataCache.Types.CacheEntry Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_"></a> Equals\(CacheEntry\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingDataCache.Types.CacheEntry other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_"></a> MergeFrom\(CacheEntry\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingDataCache.Types.CacheEntry other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingDataCache](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.md).[CacheEntry](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingDataCache.Types.CacheEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingDataCache_Types_CacheEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

