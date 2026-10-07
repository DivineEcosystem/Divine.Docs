# <a id="Divine_Protobufs_Dota2_CMsgEffectData"></a> Class CMsgEffectData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEffectData : IMessage<CMsgEffectData>, IEquatable<CMsgEffectData>, IDeepCloneable<CMsgEffectData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)

#### Implements

IMessage<CMsgEffectData\>, 
[IEquatable<CMsgEffectData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEffectData\>, 
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
[EnumerableExtensions.In<CMsgEffectData\>\(CMsgEffectData, params CMsgEffectData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEffectData__ctor"></a> CMsgEffectData\(\)

```csharp
public CMsgEffectData()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData__ctor_Divine_Protobufs_Dota2_CMsgEffectData_"></a> CMsgEffectData\(CMsgEffectData\)

```csharp
public CMsgEffectData(CMsgEffectData other)
```

#### Parameters

`other` [CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_AnglesFieldNumber"></a> AnglesFieldNumber

```csharp
public const int AnglesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_AttachmentindexFieldNumber"></a> AttachmentindexFieldNumber

```csharp
public const int AttachmentindexFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_AttachmentnameFieldNumber"></a> AttachmentnameFieldNumber

```csharp
public const int AttachmentnameFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_DamagetypeFieldNumber"></a> DamagetypeFieldNumber

```csharp
public const int DamagetypeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_EffectindexFieldNumber"></a> EffectindexFieldNumber

```csharp
public const int EffectindexFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_EffectnameFieldNumber"></a> EffectnameFieldNumber

```csharp
public const int EffectnameFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HitboxFieldNumber"></a> HitboxFieldNumber

```csharp
public const int HitboxFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_MagnitudeFieldNumber"></a> MagnitudeFieldNumber

```csharp
public const int MagnitudeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_MaterialFieldNumber"></a> MaterialFieldNumber

```csharp
public const int MaterialFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_NormalFieldNumber"></a> NormalFieldNumber

```csharp
public const int NormalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_OtherentityFieldNumber"></a> OtherentityFieldNumber

```csharp
public const int OtherentityFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_RadiusFieldNumber"></a> RadiusFieldNumber

```csharp
public const int RadiusFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_StartFieldNumber"></a> StartFieldNumber

```csharp
public const int StartFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_SurfacepropFieldNumber"></a> SurfacepropFieldNumber

```csharp
public const int SurfacepropFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Angles"></a> Angles

```csharp
public CMsgQAngle Angles { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Attachmentindex"></a> Attachmentindex

```csharp
public int Attachmentindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Attachmentname"></a> Attachmentname

```csharp
public uint Attachmentname { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Damagetype"></a> Damagetype

```csharp
public uint Damagetype { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Effectindex"></a> Effectindex

```csharp
public ulong Effectindex { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Effectname"></a> Effectname

```csharp
public uint Effectname { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Entity"></a> Entity

```csharp
public uint Entity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasAttachmentindex"></a> HasAttachmentindex

```csharp
public bool HasAttachmentindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasAttachmentname"></a> HasAttachmentname

```csharp
public bool HasAttachmentname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasDamagetype"></a> HasDamagetype

```csharp
public bool HasDamagetype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasEffectindex"></a> HasEffectindex

```csharp
public bool HasEffectindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasEffectname"></a> HasEffectname

```csharp
public bool HasEffectname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasHitbox"></a> HasHitbox

```csharp
public bool HasHitbox { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasMagnitude"></a> HasMagnitude

```csharp
public bool HasMagnitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasMaterial"></a> HasMaterial

```csharp
public bool HasMaterial { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasOtherentity"></a> HasOtherentity

```csharp
public bool HasOtherentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasRadius"></a> HasRadius

```csharp
public bool HasRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_HasSurfaceprop"></a> HasSurfaceprop

```csharp
public bool HasSurfaceprop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Hitbox"></a> Hitbox

```csharp
public uint Hitbox { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Material"></a> Material

```csharp
public uint Material { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Normal"></a> Normal

```csharp
public CMsgVector Normal { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Otherentity"></a> Otherentity

```csharp
public uint Otherentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEffectData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Radius"></a> Radius

```csharp
public float Radius { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Start"></a> Start

```csharp
public CMsgVector Start { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Surfaceprop"></a> Surfaceprop

```csharp
public uint Surfaceprop { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearAttachmentindex"></a> ClearAttachmentindex\(\)

```csharp
public void ClearAttachmentindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearAttachmentname"></a> ClearAttachmentname\(\)

```csharp
public void ClearAttachmentname()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearDamagetype"></a> ClearDamagetype\(\)

```csharp
public void ClearDamagetype()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearEffectindex"></a> ClearEffectindex\(\)

```csharp
public void ClearEffectindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearEffectname"></a> ClearEffectname\(\)

```csharp
public void ClearEffectname()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearHitbox"></a> ClearHitbox\(\)

```csharp
public void ClearHitbox()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearMagnitude"></a> ClearMagnitude\(\)

```csharp
public void ClearMagnitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearMaterial"></a> ClearMaterial\(\)

```csharp
public void ClearMaterial()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearOtherentity"></a> ClearOtherentity\(\)

```csharp
public void ClearOtherentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearRadius"></a> ClearRadius\(\)

```csharp
public void ClearRadius()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ClearSurfaceprop"></a> ClearSurfaceprop\(\)

```csharp
public void ClearSurfaceprop()
```

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Clone"></a> Clone\(\)

```csharp
public CMsgEffectData Clone()
```

#### Returns

 [CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_Equals_Divine_Protobufs_Dota2_CMsgEffectData_"></a> Equals\(CMsgEffectData\)

```csharp
public bool Equals(CMsgEffectData other)
```

#### Parameters

`other` [CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_MergeFrom_Divine_Protobufs_Dota2_CMsgEffectData_"></a> MergeFrom\(CMsgEffectData\)

```csharp
public void MergeFrom(CMsgEffectData other)
```

#### Parameters

`other` [CMsgEffectData](Divine.Protobufs.Dota2.CMsgEffectData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEffectData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

