# <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache"></a> Class CMsgGCToGCDirtySDOCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCDirtySDOCache : IMessage<CMsgGCToGCDirtySDOCache>, IEquatable<CMsgGCToGCDirtySDOCache>, IDeepCloneable<CMsgGCToGCDirtySDOCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)

#### Implements

IMessage<CMsgGCToGCDirtySDOCache\>, 
[IEquatable<CMsgGCToGCDirtySDOCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCDirtySDOCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCDirtySDOCache\>\(CMsgGCToGCDirtySDOCache, params CMsgGCToGCDirtySDOCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache__ctor"></a> CMsgGCToGCDirtySDOCache\(\)

```csharp
public CMsgGCToGCDirtySDOCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_"></a> CMsgGCToGCDirtySDOCache\(CMsgGCToGCDirtySDOCache\)

```csharp
public CMsgGCToGCDirtySDOCache(CMsgGCToGCDirtySDOCache other)
```

#### Parameters

`other` [CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_KeyUint64FieldNumber"></a> KeyUint64FieldNumber

```csharp
public const int KeyUint64FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_SdoTypeFieldNumber"></a> SdoTypeFieldNumber

```csharp
public const int SdoTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_HasKeyUint64"></a> HasKeyUint64

```csharp
public bool HasKeyUint64 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_HasSdoType"></a> HasSdoType

```csharp
public bool HasSdoType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_KeyUint64"></a> KeyUint64

```csharp
public ulong KeyUint64 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCDirtySDOCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_SdoType"></a> SdoType

```csharp
public uint SdoType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_ClearKeyUint64"></a> ClearKeyUint64\(\)

```csharp
public void ClearKeyUint64()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_ClearSdoType"></a> ClearSdoType\(\)

```csharp
public void ClearSdoType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCDirtySDOCache Clone()
```

#### Returns

 [CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_"></a> Equals\(CMsgGCToGCDirtySDOCache\)

```csharp
public bool Equals(CMsgGCToGCDirtySDOCache other)
```

#### Parameters

`other` [CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_"></a> MergeFrom\(CMsgGCToGCDirtySDOCache\)

```csharp
public void MergeFrom(CMsgGCToGCDirtySDOCache other)
```

#### Parameters

`other` [CMsgGCToGCDirtySDOCache](Divine.Protobufs.Dota2.CMsgGCToGCDirtySDOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCDirtySDOCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

