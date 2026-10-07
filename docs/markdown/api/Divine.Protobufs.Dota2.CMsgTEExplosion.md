# <a id="Divine_Protobufs_Dota2_CMsgTEExplosion"></a> Class CMsgTEExplosion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEExplosion : IMessage<CMsgTEExplosion>, IEquatable<CMsgTEExplosion>, IDeepCloneable<CMsgTEExplosion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)

#### Implements

IMessage<CMsgTEExplosion\>, 
[IEquatable<CMsgTEExplosion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEExplosion\>, 
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
[EnumerableExtensions.In<CMsgTEExplosion\>\(CMsgTEExplosion, params CMsgTEExplosion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion__ctor"></a> CMsgTEExplosion\(\)

```csharp
public CMsgTEExplosion()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion__ctor_Divine_Protobufs_Dota2_CMsgTEExplosion_"></a> CMsgTEExplosion\(CMsgTEExplosion\)

```csharp
public CMsgTEExplosion(CMsgTEExplosion other)
```

#### Parameters

`other` [CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_AffectRagdollsFieldNumber"></a> AffectRagdollsFieldNumber

```csharp
public const int AffectRagdollsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_CreateDebrisFieldNumber"></a> CreateDebrisFieldNumber

```csharp
public const int CreateDebrisFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_DebrisOriginFieldNumber"></a> DebrisOriginFieldNumber

```csharp
public const int DebrisOriginFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_DebrisSurfacepropFieldNumber"></a> DebrisSurfacepropFieldNumber

```csharp
public const int DebrisSurfacepropFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ExplosionTypeFieldNumber"></a> ExplosionTypeFieldNumber

```csharp
public const int ExplosionTypeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ExplosionTypeNameFieldNumber"></a> ExplosionTypeNameFieldNumber

```csharp
public const int ExplosionTypeNameFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_MagnitudeFieldNumber"></a> MagnitudeFieldNumber

```csharp
public const int MagnitudeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_NormalFieldNumber"></a> NormalFieldNumber

```csharp
public const int NormalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_RadiusFieldNumber"></a> RadiusFieldNumber

```csharp
public const int RadiusFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_SoundNameFieldNumber"></a> SoundNameFieldNumber

```csharp
public const int SoundNameFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_AffectRagdolls"></a> AffectRagdolls

```csharp
public bool AffectRagdolls { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_CreateDebris"></a> CreateDebris

```csharp
public bool CreateDebris { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_DebrisOrigin"></a> DebrisOrigin

```csharp
public CMsgVector DebrisOrigin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_DebrisSurfaceprop"></a> DebrisSurfaceprop

```csharp
public uint DebrisSurfaceprop { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ExplosionType"></a> ExplosionType

```csharp
public uint ExplosionType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ExplosionTypeName"></a> ExplosionTypeName

```csharp
public uint ExplosionTypeName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasAffectRagdolls"></a> HasAffectRagdolls

```csharp
public bool HasAffectRagdolls { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasCreateDebris"></a> HasCreateDebris

```csharp
public bool HasCreateDebris { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasDebrisSurfaceprop"></a> HasDebrisSurfaceprop

```csharp
public bool HasDebrisSurfaceprop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasExplosionType"></a> HasExplosionType

```csharp
public bool HasExplosionType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasExplosionTypeName"></a> HasExplosionTypeName

```csharp
public bool HasExplosionTypeName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasMagnitude"></a> HasMagnitude

```csharp
public bool HasMagnitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasRadius"></a> HasRadius

```csharp
public bool HasRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_HasSoundName"></a> HasSoundName

```csharp
public bool HasSoundName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Magnitude"></a> Magnitude

```csharp
public uint Magnitude { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Normal"></a> Normal

```csharp
public CMsgVector Normal { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEExplosion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Radius"></a> Radius

```csharp
public uint Radius { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_SoundName"></a> SoundName

```csharp
public string SoundName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearAffectRagdolls"></a> ClearAffectRagdolls\(\)

```csharp
public void ClearAffectRagdolls()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearCreateDebris"></a> ClearCreateDebris\(\)

```csharp
public void ClearCreateDebris()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearDebrisSurfaceprop"></a> ClearDebrisSurfaceprop\(\)

```csharp
public void ClearDebrisSurfaceprop()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearExplosionType"></a> ClearExplosionType\(\)

```csharp
public void ClearExplosionType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearExplosionTypeName"></a> ClearExplosionTypeName\(\)

```csharp
public void ClearExplosionTypeName()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearMagnitude"></a> ClearMagnitude\(\)

```csharp
public void ClearMagnitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearRadius"></a> ClearRadius\(\)

```csharp
public void ClearRadius()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ClearSoundName"></a> ClearSoundName\(\)

```csharp
public void ClearSoundName()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Clone"></a> Clone\(\)

```csharp
public CMsgTEExplosion Clone()
```

#### Returns

 [CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_Equals_Divine_Protobufs_Dota2_CMsgTEExplosion_"></a> Equals\(CMsgTEExplosion\)

```csharp
public bool Equals(CMsgTEExplosion other)
```

#### Parameters

`other` [CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_MergeFrom_Divine_Protobufs_Dota2_CMsgTEExplosion_"></a> MergeFrom\(CMsgTEExplosion\)

```csharp
public void MergeFrom(CMsgTEExplosion other)
```

#### Parameters

`other` [CMsgTEExplosion](Divine.Protobufs.Dota2.CMsgTEExplosion.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEExplosion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

