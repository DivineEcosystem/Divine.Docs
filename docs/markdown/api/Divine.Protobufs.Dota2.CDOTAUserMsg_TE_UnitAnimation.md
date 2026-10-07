# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation"></a> Class CDOTAUserMsg\_TE\_UnitAnimation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TE_UnitAnimation : IMessage<CDOTAUserMsg_TE_UnitAnimation>, IEquatable<CDOTAUserMsg_TE_UnitAnimation>, IDeepCloneable<CDOTAUserMsg_TE_UnitAnimation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)

#### Implements

IMessage<CDOTAUserMsg\_TE\_UnitAnimation\>, 
[IEquatable<CDOTAUserMsg\_TE\_UnitAnimation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TE\_UnitAnimation\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TE\_UnitAnimation\>\(CDOTAUserMsg\_TE\_UnitAnimation, params CDOTAUserMsg\_TE\_UnitAnimation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation__ctor"></a> CDOTAUserMsg\_TE\_UnitAnimation\(\)

```csharp
public CDOTAUserMsg_TE_UnitAnimation()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_"></a> CDOTAUserMsg\_TE\_UnitAnimation\(CDOTAUserMsg\_TE\_UnitAnimation\)

```csharp
public CDOTAUserMsg_TE_UnitAnimation(CDOTAUserMsg_TE_UnitAnimation other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ActivityFieldNumber"></a> ActivityFieldNumber

```csharp
public const int ActivityFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_CastpointFieldNumber"></a> CastpointFieldNumber

```csharp
public const int CastpointFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_LagCompensationTimeFieldNumber"></a> LagCompensationTimeFieldNumber

```csharp
public const int LagCompensationTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_PlaybackrateFieldNumber"></a> PlaybackrateFieldNumber

```csharp
public const int PlaybackrateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_SequenceVariantFieldNumber"></a> SequenceVariantFieldNumber

```csharp
public const int SequenceVariantFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Activity"></a> Activity

```csharp
public int Activity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Castpoint"></a> Castpoint

```csharp
public float Castpoint { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Entity"></a> Entity

```csharp
public uint Entity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasActivity"></a> HasActivity

```csharp
public bool HasActivity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasCastpoint"></a> HasCastpoint

```csharp
public bool HasCastpoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasLagCompensationTime"></a> HasLagCompensationTime

```csharp
public bool HasLagCompensationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasPlaybackrate"></a> HasPlaybackrate

```csharp
public bool HasPlaybackrate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasSequenceVariant"></a> HasSequenceVariant

```csharp
public bool HasSequenceVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_LagCompensationTime"></a> LagCompensationTime

```csharp
public float LagCompensationTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TE_UnitAnimation> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Playbackrate"></a> Playbackrate

```csharp
public float Playbackrate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_SequenceVariant"></a> SequenceVariant

```csharp
public int SequenceVariant { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Type"></a> Type

```csharp
public int Type { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearActivity"></a> ClearActivity\(\)

```csharp
public void ClearActivity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearCastpoint"></a> ClearCastpoint\(\)

```csharp
public void ClearCastpoint()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearLagCompensationTime"></a> ClearLagCompensationTime\(\)

```csharp
public void ClearLagCompensationTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearPlaybackrate"></a> ClearPlaybackrate\(\)

```csharp
public void ClearPlaybackrate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearSequenceVariant"></a> ClearSequenceVariant\(\)

```csharp
public void ClearSequenceVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TE_UnitAnimation Clone()
```

#### Returns

 [CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_"></a> Equals\(CDOTAUserMsg\_TE\_UnitAnimation\)

```csharp
public bool Equals(CDOTAUserMsg_TE_UnitAnimation other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_"></a> MergeFrom\(CDOTAUserMsg\_TE\_UnitAnimation\)

```csharp
public void MergeFrom(CDOTAUserMsg_TE_UnitAnimation other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimation](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

