# <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue"></a> Class CProtoItemHeroStatue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemHeroStatue : IMessage<CProtoItemHeroStatue>, IEquatable<CProtoItemHeroStatue>, IDeepCloneable<CProtoItemHeroStatue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)

#### Implements

IMessage<CProtoItemHeroStatue\>, 
[IEquatable<CProtoItemHeroStatue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemHeroStatue\>, 
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
[EnumerableExtensions.In<CProtoItemHeroStatue\>\(CProtoItemHeroStatue, params CProtoItemHeroStatue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue__ctor"></a> CProtoItemHeroStatue\(\)

```csharp
public CProtoItemHeroStatue()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue__ctor_Divine_Protobufs_Dota2_CProtoItemHeroStatue_"></a> CProtoItemHeroStatue\(CProtoItemHeroStatue\)

```csharp
public CProtoItemHeroStatue(CProtoItemHeroStatue other)
```

#### Parameters

`other` [CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_CycleFieldNumber"></a> CycleFieldNumber

```csharp
public const int CycleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_InscriptionFieldNumber"></a> InscriptionFieldNumber

```csharp
public const int InscriptionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_SequenceNameFieldNumber"></a> SequenceNameFieldNumber

```csharp
public const int SequenceNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_StatusEffectIndexFieldNumber"></a> StatusEffectIndexFieldNumber

```csharp
public const int StatusEffectIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_StyleFieldNumber"></a> StyleFieldNumber

```csharp
public const int StyleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_TournamentDropFieldNumber"></a> TournamentDropFieldNumber

```csharp
public const int TournamentDropFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_WearableFieldNumber"></a> WearableFieldNumber

```csharp
public const int WearableFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Cycle"></a> Cycle

```csharp
public float Cycle { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasCycle"></a> HasCycle

```csharp
public bool HasCycle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasInscription"></a> HasInscription

```csharp
public bool HasInscription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasSequenceName"></a> HasSequenceName

```csharp
public bool HasSequenceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasStatusEffectIndex"></a> HasStatusEffectIndex

```csharp
public bool HasStatusEffectIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HasTournamentDrop"></a> HasTournamentDrop

```csharp
public bool HasTournamentDrop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Inscription"></a> Inscription

```csharp
public string Inscription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemHeroStatue> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_SequenceName"></a> SequenceName

```csharp
public string SequenceName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_StatusEffectIndex"></a> StatusEffectIndex

```csharp
public uint StatusEffectIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Style"></a> Style

```csharp
public RepeatedField<uint> Style { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_TournamentDrop"></a> TournamentDrop

```csharp
public bool TournamentDrop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Wearable"></a> Wearable

```csharp
public RepeatedField<uint> Wearable { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearCycle"></a> ClearCycle\(\)

```csharp
public void ClearCycle()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearInscription"></a> ClearInscription\(\)

```csharp
public void ClearInscription()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearSequenceName"></a> ClearSequenceName\(\)

```csharp
public void ClearSequenceName()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearStatusEffectIndex"></a> ClearStatusEffectIndex\(\)

```csharp
public void ClearStatusEffectIndex()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ClearTournamentDrop"></a> ClearTournamentDrop\(\)

```csharp
public void ClearTournamentDrop()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Clone"></a> Clone\(\)

```csharp
public CProtoItemHeroStatue Clone()
```

#### Returns

 [CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_Equals_Divine_Protobufs_Dota2_CProtoItemHeroStatue_"></a> Equals\(CProtoItemHeroStatue\)

```csharp
public bool Equals(CProtoItemHeroStatue other)
```

#### Parameters

`other` [CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_MergeFrom_Divine_Protobufs_Dota2_CProtoItemHeroStatue_"></a> MergeFrom\(CProtoItemHeroStatue\)

```csharp
public void MergeFrom(CProtoItemHeroStatue other)
```

#### Parameters

`other` [CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemHeroStatue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

