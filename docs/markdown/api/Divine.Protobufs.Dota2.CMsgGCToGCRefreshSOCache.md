# <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache"></a> Class CMsgGCToGCRefreshSOCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCRefreshSOCache : IMessage<CMsgGCToGCRefreshSOCache>, IEquatable<CMsgGCToGCRefreshSOCache>, IDeepCloneable<CMsgGCToGCRefreshSOCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)

#### Implements

IMessage<CMsgGCToGCRefreshSOCache\>, 
[IEquatable<CMsgGCToGCRefreshSOCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCRefreshSOCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCRefreshSOCache\>\(CMsgGCToGCRefreshSOCache, params CMsgGCToGCRefreshSOCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache__ctor"></a> CMsgGCToGCRefreshSOCache\(\)

```csharp
public CMsgGCToGCRefreshSOCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_"></a> CMsgGCToGCRefreshSOCache\(CMsgGCToGCRefreshSOCache\)

```csharp
public CMsgGCToGCRefreshSOCache(CMsgGCToGCRefreshSOCache other)
```

#### Parameters

`other` [CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_ReloadFieldNumber"></a> ReloadFieldNumber

```csharp
public const int ReloadFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_HasReload"></a> HasReload

```csharp
public bool HasReload { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCRefreshSOCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Reload"></a> Reload

```csharp
public bool Reload { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_ClearReload"></a> ClearReload\(\)

```csharp
public void ClearReload()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCRefreshSOCache Clone()
```

#### Returns

 [CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_"></a> Equals\(CMsgGCToGCRefreshSOCache\)

```csharp
public bool Equals(CMsgGCToGCRefreshSOCache other)
```

#### Parameters

`other` [CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_"></a> MergeFrom\(CMsgGCToGCRefreshSOCache\)

```csharp
public void MergeFrom(CMsgGCToGCRefreshSOCache other)
```

#### Parameters

`other` [CMsgGCToGCRefreshSOCache](Divine.Protobufs.Dota2.CMsgGCToGCRefreshSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCRefreshSOCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

