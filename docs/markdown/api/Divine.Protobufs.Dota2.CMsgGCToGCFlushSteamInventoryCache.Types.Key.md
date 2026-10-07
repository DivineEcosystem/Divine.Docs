# <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key"></a> Class CMsgGCToGCFlushSteamInventoryCache.Types.Key

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCFlushSteamInventoryCache.Types.Key : IMessage<CMsgGCToGCFlushSteamInventoryCache.Types.Key>, IEquatable<CMsgGCToGCFlushSteamInventoryCache.Types.Key>, IDeepCloneable<CMsgGCToGCFlushSteamInventoryCache.Types.Key>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCFlushSteamInventoryCache.Types.Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)

#### Implements

IMessage<CMsgGCToGCFlushSteamInventoryCache.Types.Key\>, 
[IEquatable<CMsgGCToGCFlushSteamInventoryCache.Types.Key\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCFlushSteamInventoryCache.Types.Key\>, 
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
[EnumerableExtensions.In<CMsgGCToGCFlushSteamInventoryCache.Types.Key\>\(CMsgGCToGCFlushSteamInventoryCache.Types.Key, params CMsgGCToGCFlushSteamInventoryCache.Types.Key\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key__ctor"></a> Key\(\)

```csharp
public Key()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key__ctor_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_"></a> Key\(Key\)

```csharp
public Key(CMsgGCToGCFlushSteamInventoryCache.Types.Key other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_ContextidFieldNumber"></a> ContextidFieldNumber

```csharp
public const int ContextidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Contextid"></a> Contextid

```csharp
public ulong Contextid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_HasContextid"></a> HasContextid

```csharp
public bool HasContextid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCFlushSteamInventoryCache.Types.Key> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_ClearContextid"></a> ClearContextid\(\)

```csharp
public void ClearContextid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCFlushSteamInventoryCache.Types.Key Clone()
```

#### Returns

 [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_Equals_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_"></a> Equals\(Key\)

```csharp
public bool Equals(CMsgGCToGCFlushSteamInventoryCache.Types.Key other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_"></a> MergeFrom\(Key\)

```csharp
public void MergeFrom(CMsgGCToGCFlushSteamInventoryCache.Types.Key other)
```

#### Parameters

`other` [CMsgGCToGCFlushSteamInventoryCache](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.md).[Key](Divine.Protobufs.Dota2.CMsgGCToGCFlushSteamInventoryCache.Types.Key.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCFlushSteamInventoryCache_Types_Key_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

