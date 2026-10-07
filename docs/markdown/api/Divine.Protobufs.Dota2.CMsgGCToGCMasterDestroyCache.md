# <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache"></a> Class CMsgGCToGCMasterDestroyCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCMasterDestroyCache : IMessage<CMsgGCToGCMasterDestroyCache>, IEquatable<CMsgGCToGCMasterDestroyCache>, IDeepCloneable<CMsgGCToGCMasterDestroyCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)

#### Implements

IMessage<CMsgGCToGCMasterDestroyCache\>, 
[IEquatable<CMsgGCToGCMasterDestroyCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCMasterDestroyCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCMasterDestroyCache\>\(CMsgGCToGCMasterDestroyCache, params CMsgGCToGCMasterDestroyCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache__ctor"></a> CMsgGCToGCMasterDestroyCache\(\)

```csharp
public CMsgGCToGCMasterDestroyCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_"></a> CMsgGCToGCMasterDestroyCache\(CMsgGCToGCMasterDestroyCache\)

```csharp
public CMsgGCToGCMasterDestroyCache(CMsgGCToGCMasterDestroyCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_SoidIdFieldNumber"></a> SoidIdFieldNumber

```csharp
public const int SoidIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_SoidTypeFieldNumber"></a> SoidTypeFieldNumber

```csharp
public const int SoidTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_HasSoidId"></a> HasSoidId

```csharp
public bool HasSoidId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_HasSoidType"></a> HasSoidType

```csharp
public bool HasSoidType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCMasterDestroyCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_SoidId"></a> SoidId

```csharp
public ulong SoidId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_SoidType"></a> SoidType

```csharp
public uint SoidType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_ClearSoidId"></a> ClearSoidId\(\)

```csharp
public void ClearSoidId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_ClearSoidType"></a> ClearSoidType\(\)

```csharp
public void ClearSoidType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCMasterDestroyCache Clone()
```

#### Returns

 [CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_"></a> Equals\(CMsgGCToGCMasterDestroyCache\)

```csharp
public bool Equals(CMsgGCToGCMasterDestroyCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_"></a> MergeFrom\(CMsgGCToGCMasterDestroyCache\)

```csharp
public void MergeFrom(CMsgGCToGCMasterDestroyCache other)
```

#### Parameters

`other` [CMsgGCToGCMasterDestroyCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterDestroyCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterDestroyCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

