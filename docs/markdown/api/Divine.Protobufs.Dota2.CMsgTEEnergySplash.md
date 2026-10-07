# <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash"></a> Class CMsgTEEnergySplash

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEEnergySplash : IMessage<CMsgTEEnergySplash>, IEquatable<CMsgTEEnergySplash>, IDeepCloneable<CMsgTEEnergySplash>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)

#### Implements

IMessage<CMsgTEEnergySplash\>, 
[IEquatable<CMsgTEEnergySplash\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEEnergySplash\>, 
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
[EnumerableExtensions.In<CMsgTEEnergySplash\>\(CMsgTEEnergySplash, params CMsgTEEnergySplash\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash__ctor"></a> CMsgTEEnergySplash\(\)

```csharp
public CMsgTEEnergySplash()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash__ctor_Divine_Protobufs_Dota2_CMsgTEEnergySplash_"></a> CMsgTEEnergySplash\(CMsgTEEnergySplash\)

```csharp
public CMsgTEEnergySplash(CMsgTEEnergySplash other)
```

#### Parameters

`other` [CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_DirFieldNumber"></a> DirFieldNumber

```csharp
public const int DirFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_ExplosiveFieldNumber"></a> ExplosiveFieldNumber

```csharp
public const int ExplosiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_PosFieldNumber"></a> PosFieldNumber

```csharp
public const int PosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Dir"></a> Dir

```csharp
public CMsgVector Dir { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Explosive"></a> Explosive

```csharp
public bool Explosive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_HasExplosive"></a> HasExplosive

```csharp
public bool HasExplosive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEEnergySplash> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Pos"></a> Pos

```csharp
public CMsgVector Pos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_ClearExplosive"></a> ClearExplosive\(\)

```csharp
public void ClearExplosive()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Clone"></a> Clone\(\)

```csharp
public CMsgTEEnergySplash Clone()
```

#### Returns

 [CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_Equals_Divine_Protobufs_Dota2_CMsgTEEnergySplash_"></a> Equals\(CMsgTEEnergySplash\)

```csharp
public bool Equals(CMsgTEEnergySplash other)
```

#### Parameters

`other` [CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_MergeFrom_Divine_Protobufs_Dota2_CMsgTEEnergySplash_"></a> MergeFrom\(CMsgTEEnergySplash\)

```csharp
public void MergeFrom(CMsgTEEnergySplash other)
```

#### Parameters

`other` [CMsgTEEnergySplash](Divine.Protobufs.Dota2.CMsgTEEnergySplash.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEEnergySplash_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

