# <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache"></a> Class CMsgSerializedSOCache.Types.TypeCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSerializedSOCache.Types.TypeCache : IMessage<CMsgSerializedSOCache.Types.TypeCache>, IEquatable<CMsgSerializedSOCache.Types.TypeCache>, IDeepCloneable<CMsgSerializedSOCache.Types.TypeCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSerializedSOCache.Types.TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)

#### Implements

IMessage<CMsgSerializedSOCache.Types.TypeCache\>, 
[IEquatable<CMsgSerializedSOCache.Types.TypeCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSerializedSOCache.Types.TypeCache\>, 
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
[EnumerableExtensions.In<CMsgSerializedSOCache.Types.TypeCache\>\(CMsgSerializedSOCache.Types.TypeCache, params CMsgSerializedSOCache.Types.TypeCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache__ctor"></a> TypeCache\(\)

```csharp
public TypeCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache__ctor_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_"></a> TypeCache\(TypeCache\)

```csharp
public TypeCache(CMsgSerializedSOCache.Types.TypeCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ObjectsFieldNumber"></a> ObjectsFieldNumber

```csharp
public const int ObjectsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Objects"></a> Objects

```csharp
public RepeatedField<ByteString> Objects { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSerializedSOCache.Types.TypeCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Clone"></a> Clone\(\)

```csharp
public CMsgSerializedSOCache.Types.TypeCache Clone()
```

#### Returns

 [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_Equals_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_"></a> Equals\(TypeCache\)

```csharp
public bool Equals(CMsgSerializedSOCache.Types.TypeCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_MergeFrom_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_"></a> MergeFrom\(TypeCache\)

```csharp
public void MergeFrom(CMsgSerializedSOCache.Types.TypeCache other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[TypeCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.TypeCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_TypeCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

