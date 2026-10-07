# <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache"></a> Class CMsgSerializedSOCache.Types.Cache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSerializedSOCache.Types.Cache : IMessage<CMsgSerializedSOCache.Types.Cache>, IEquatable<CMsgSerializedSOCache.Types.Cache>, IDeepCloneable<CMsgSerializedSOCache.Types.Cache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSerializedSOCache.Types.Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)

#### Implements

IMessage<CMsgSerializedSOCache.Types.Cache\>, 
[IEquatable<CMsgSerializedSOCache.Types.Cache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSerializedSOCache.Types.Cache\>, 
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
[EnumerableExtensions.In<CMsgSerializedSOCache.Types.Cache\>\(CMsgSerializedSOCache.Types.Cache, params CMsgSerializedSOCache.Types.Cache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache__ctor"></a> Cache\(\)

```csharp
public Cache()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache__ctor_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_"></a> Cache\(Cache\)

```csharp
public Cache(CMsgSerializedSOCache.Types.Cache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_TypeCachesFieldNumber"></a> TypeCachesFieldNumber

```csharp
public const int TypeCachesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_VersionsFieldNumber"></a> VersionsFieldNumber

```csharp
public const int VersionsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSerializedSOCache.Types.Cache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_TypeCaches"></a> TypeCaches

```csharp
public RepeatedField<CMsgSerializedSOCache.Types.TypeCache> TypeCaches { get; }
```

#### Property Value

 RepeatedField<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Versions"></a> Versions

```csharp
public RepeatedField<CMsgSerializedSOCache.Types.Cache.Types.Version> Versions { get; }
```

#### Property Value

 RepeatedField<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Clone"></a> Clone\(\)

```csharp
public CMsgSerializedSOCache.Types.Cache Clone()
```

#### Returns

 [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Equals_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_"></a> Equals\(Cache\)

```csharp
public bool Equals(CMsgSerializedSOCache.Types.Cache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_MergeFrom_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_"></a> MergeFrom\(Cache\)

```csharp
public void MergeFrom(CMsgSerializedSOCache.Types.Cache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

