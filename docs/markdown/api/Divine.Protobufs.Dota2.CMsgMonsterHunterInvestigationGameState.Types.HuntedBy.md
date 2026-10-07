# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy"></a> Class CMsgMonsterHunterInvestigationGameState.Types.HuntedBy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterInvestigationGameState.Types.HuntedBy : IMessage<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy>, IEquatable<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy>, IDeepCloneable<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterInvestigationGameState.Types.HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)

#### Implements

IMessage<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy\>, 
[IEquatable<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy\>\(CMsgMonsterHunterInvestigationGameState.Types.HuntedBy, params CMsgMonsterHunterInvestigationGameState.Types.HuntedBy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy__ctor"></a> HuntedBy\(\)

```csharp
public HuntedBy()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_"></a> HuntedBy\(HuntedBy\)

```csharp
public HuntedBy(CMsgMonsterHunterInvestigationGameState.Types.HuntedBy other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HuntRewardsFieldNumber"></a> HuntRewardsFieldNumber

```csharp
public const int HuntRewardsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_PersonaIdFieldNumber"></a> PersonaIdFieldNumber

```csharp
public const int PersonaIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_SuccessStateFieldNumber"></a> SuccessStateFieldNumber

```csharp
public const int SuccessStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HasPersonaId"></a> HasPersonaId

```csharp
public bool HasPersonaId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HasSuccessState"></a> HasSuccessState

```csharp
public bool HasSuccessState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_HuntRewards"></a> HuntRewards

```csharp
public CMsgMonsterHunterMaterialQuantity HuntRewards { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_PersonaId"></a> PersonaId

```csharp
public int PersonaId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_SuccessState"></a> SuccessState

```csharp
public bool SuccessState { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_ClearPersonaId"></a> ClearPersonaId\(\)

```csharp
public void ClearPersonaId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_ClearSuccessState"></a> ClearSuccessState\(\)

```csharp
public void ClearSuccessState()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterInvestigationGameState.Types.HuntedBy Clone()
```

#### Returns

 [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_"></a> Equals\(HuntedBy\)

```csharp
public bool Equals(CMsgMonsterHunterInvestigationGameState.Types.HuntedBy other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_"></a> MergeFrom\(HuntedBy\)

```csharp
public void MergeFrom(CMsgMonsterHunterInvestigationGameState.Types.HuntedBy other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Types_HuntedBy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

