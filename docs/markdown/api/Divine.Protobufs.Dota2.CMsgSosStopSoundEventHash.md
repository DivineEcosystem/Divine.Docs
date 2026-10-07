# <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash"></a> Class CMsgSosStopSoundEventHash

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSosStopSoundEventHash : IMessage<CMsgSosStopSoundEventHash>, IEquatable<CMsgSosStopSoundEventHash>, IDeepCloneable<CMsgSosStopSoundEventHash>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)

#### Implements

IMessage<CMsgSosStopSoundEventHash\>, 
[IEquatable<CMsgSosStopSoundEventHash\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSosStopSoundEventHash\>, 
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
[EnumerableExtensions.In<CMsgSosStopSoundEventHash\>\(CMsgSosStopSoundEventHash, params CMsgSosStopSoundEventHash\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash__ctor"></a> CMsgSosStopSoundEventHash\(\)

```csharp
public CMsgSosStopSoundEventHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash__ctor_Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_"></a> CMsgSosStopSoundEventHash\(CMsgSosStopSoundEventHash\)

```csharp
public CMsgSosStopSoundEventHash(CMsgSosStopSoundEventHash other)
```

#### Parameters

`other` [CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_SoundeventHashFieldNumber"></a> SoundeventHashFieldNumber

```csharp
public const int SoundeventHashFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_SourceEntityIndexFieldNumber"></a> SourceEntityIndexFieldNumber

```csharp
public const int SourceEntityIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_HasSoundeventHash"></a> HasSoundeventHash

```csharp
public bool HasSoundeventHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_HasSourceEntityIndex"></a> HasSourceEntityIndex

```csharp
public bool HasSourceEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSosStopSoundEventHash> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_SoundeventHash"></a> SoundeventHash

```csharp
public uint SoundeventHash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_SourceEntityIndex"></a> SourceEntityIndex

```csharp
public int SourceEntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_ClearSoundeventHash"></a> ClearSoundeventHash\(\)

```csharp
public void ClearSoundeventHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_ClearSourceEntityIndex"></a> ClearSourceEntityIndex\(\)

```csharp
public void ClearSourceEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_Clone"></a> Clone\(\)

```csharp
public CMsgSosStopSoundEventHash Clone()
```

#### Returns

 [CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_Equals_Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_"></a> Equals\(CMsgSosStopSoundEventHash\)

```csharp
public bool Equals(CMsgSosStopSoundEventHash other)
```

#### Parameters

`other` [CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_MergeFrom_Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_"></a> MergeFrom\(CMsgSosStopSoundEventHash\)

```csharp
public void MergeFrom(CMsgSosStopSoundEventHash other)
```

#### Parameters

`other` [CMsgSosStopSoundEventHash](Divine.Protobufs.Dota2.CMsgSosStopSoundEventHash.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSosStopSoundEventHash_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

