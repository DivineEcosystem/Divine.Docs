# <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache"></a> Class CMsgGCToGCMasterSubscribeToCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCMasterSubscribeToCache : IMessage<CMsgGCToGCMasterSubscribeToCache>, IEquatable<CMsgGCToGCMasterSubscribeToCache>, IDeepCloneable<CMsgGCToGCMasterSubscribeToCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

#### Implements

IMessage<CMsgGCToGCMasterSubscribeToCache\>, 
[IEquatable<CMsgGCToGCMasterSubscribeToCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCMasterSubscribeToCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCMasterSubscribeToCache\>\(CMsgGCToGCMasterSubscribeToCache, params CMsgGCToGCMasterSubscribeToCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache__ctor"></a> CMsgGCToGCMasterSubscribeToCache\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_"></a> CMsgGCToGCMasterSubscribeToCache\(CMsgGCToGCMasterSubscribeToCache\)

```csharp
public CMsgGCToGCMasterSubscribeToCache(CMsgGCToGCMasterSubscribeToCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SoidIdFieldNumber"></a> SoidIdFieldNumber

```csharp
public const int SoidIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SoidTypeFieldNumber"></a> SoidTypeFieldNumber

```csharp
public const int SoidTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SteamIdsFieldNumber"></a> SteamIdsFieldNumber

```csharp
public const int SteamIdsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_HasSoidId"></a> HasSoidId

```csharp
public bool HasSoidId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_HasSoidType"></a> HasSoidType

```csharp
public bool HasSoidType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCMasterSubscribeToCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SoidId"></a> SoidId

```csharp
public ulong SoidId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SoidType"></a> SoidType

```csharp
public uint SoidType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_SteamIds"></a> SteamIds

```csharp
public RepeatedField<ulong> SteamIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_ClearSoidId"></a> ClearSoidId\(\)

```csharp
public void ClearSoidId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_ClearSoidType"></a> ClearSoidType\(\)

```csharp
public void ClearSoidType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCache Clone()
```

#### Returns

 [CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_"></a> Equals\(CMsgGCToGCMasterSubscribeToCache\)

```csharp
public bool Equals(CMsgGCToGCMasterSubscribeToCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_"></a> MergeFrom\(CMsgGCToGCMasterSubscribeToCache\)

```csharp
public void MergeFrom(CMsgGCToGCMasterSubscribeToCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

