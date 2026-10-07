# <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache"></a> Class CMsgGCToGCFlushSteamInventoryCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCFlushSteamInventoryCache : IMessage<CMsgGCToGCFlushSteamInventoryCache>, IEquatable<CMsgGCToGCFlushSteamInventoryCache>, IDeepCloneable<CMsgGCToGCFlushSteamInventoryCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)

#### Implements

IMessage<CMsgGCToGCFlushSteamInventoryCache\>, 
[IEquatable<CMsgGCToGCFlushSteamInventoryCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCFlushSteamInventoryCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCFlushSteamInventoryCache\>\(CMsgGCToGCFlushSteamInventoryCache, params CMsgGCToGCFlushSteamInventoryCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache__ctor"></a> CMsgGCToGCFlushSteamInventoryCache\(\)

```csharp
public CMsgGCToGCFlushSteamInventoryCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_"></a> CMsgGCToGCFlushSteamInventoryCache\(CMsgGCToGCFlushSteamInventoryCache\)

```csharp
public CMsgGCToGCFlushSteamInventoryCache(CMsgGCToGCFlushSteamInventoryCache other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Keys"></a> Keys

```csharp
public RepeatedField<CMsgGCToGCFlushSteamInventoryCache.Types.Key> Keys { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCFlushSteamInventoryCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCFlushSteamInventoryCache Clone()
```

#### Returns

 [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_"></a> Equals\(CMsgGCToGCFlushSteamInventoryCache\)

```csharp
public bool Equals(CMsgGCToGCFlushSteamInventoryCache other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_"></a> MergeFrom\(CMsgGCToGCFlushSteamInventoryCache\)

```csharp
public void MergeFrom(CMsgGCToGCFlushSteamInventoryCache other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

