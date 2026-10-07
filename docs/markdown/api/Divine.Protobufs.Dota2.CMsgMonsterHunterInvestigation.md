# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation"></a> Class CMsgMonsterHunterInvestigation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterInvestigation : IMessage<CMsgMonsterHunterInvestigation>, IEquatable<CMsgMonsterHunterInvestigation>, IDeepCloneable<CMsgMonsterHunterInvestigation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

#### Implements

IMessage<CMsgMonsterHunterInvestigation\>, 
[IEquatable<CMsgMonsterHunterInvestigation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterInvestigation\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterInvestigation\>\(CMsgMonsterHunterInvestigation, params CMsgMonsterHunterInvestigation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation__ctor"></a> CMsgMonsterHunterInvestigation\(\)

```csharp
public CMsgMonsterHunterInvestigation()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_"></a> CMsgMonsterHunterInvestigation\(CMsgMonsterHunterInvestigation\)

```csharp
public CMsgMonsterHunterInvestigation(CMsgMonsterHunterInvestigation other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HuntRewardsFieldNumber"></a> HuntRewardsFieldNumber

```csharp
public const int HuntRewardsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_MatchRewardsFieldNumber"></a> MatchRewardsFieldNumber

```csharp
public const int MatchRewardsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_PersonaIdFieldNumber"></a> PersonaIdFieldNumber

```csharp
public const int PersonaIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_SuccessStateFieldNumber"></a> SuccessStateFieldNumber

```csharp
public const int SuccessStateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HasPersonaId"></a> HasPersonaId

```csharp
public bool HasPersonaId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HasSuccessState"></a> HasSuccessState

```csharp
public bool HasSuccessState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_HuntRewards"></a> HuntRewards

```csharp
public CMsgMonsterHunterMaterialQuantity HuntRewards { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_MatchRewards"></a> MatchRewards

```csharp
public CMsgMonsterHunterMaterialQuantity MatchRewards { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterInvestigation> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_PersonaId"></a> PersonaId

```csharp
public int PersonaId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_SuccessState"></a> SuccessState

```csharp
public bool SuccessState { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_ClearPersonaId"></a> ClearPersonaId\(\)

```csharp
public void ClearPersonaId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_ClearSuccessState"></a> ClearSuccessState\(\)

```csharp
public void ClearSuccessState()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterInvestigation Clone()
```

#### Returns

 [CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_"></a> Equals\(CMsgMonsterHunterInvestigation\)

```csharp
public bool Equals(CMsgMonsterHunterInvestigation other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_"></a> MergeFrom\(CMsgMonsterHunterInvestigation\)

```csharp
public void MergeFrom(CMsgMonsterHunterInvestigation other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

