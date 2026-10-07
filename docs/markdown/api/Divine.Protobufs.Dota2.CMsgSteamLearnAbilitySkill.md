# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill"></a> Class CMsgSteamLearnAbilitySkill

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnAbilitySkill : IMessage<CMsgSteamLearnAbilitySkill>, IEquatable<CMsgSteamLearnAbilitySkill>, IDeepCloneable<CMsgSteamLearnAbilitySkill>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)

#### Implements

IMessage<CMsgSteamLearnAbilitySkill\>, 
[IEquatable<CMsgSteamLearnAbilitySkill\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnAbilitySkill\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnAbilitySkill\>\(CMsgSteamLearnAbilitySkill, params CMsgSteamLearnAbilitySkill\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill__ctor"></a> CMsgSteamLearnAbilitySkill\(\)

```csharp
public CMsgSteamLearnAbilitySkill()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_"></a> CMsgSteamLearnAbilitySkill\(CMsgSteamLearnAbilitySkill\)

```csharp
public CMsgSteamLearnAbilitySkill(CMsgSteamLearnAbilitySkill other)
```

#### Parameters

`other` [CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_IsUsingDotaPlusFieldNumber"></a> IsUsingDotaPlusFieldNumber

```csharp
public const int IsUsingDotaPlusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_SkilledAbilitiesFieldNumber"></a> SkilledAbilitiesFieldNumber

```csharp
public const int SkilledAbilitiesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_HasIsUsingDotaPlus"></a> HasIsUsingDotaPlus

```csharp
public bool HasIsUsingDotaPlus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_IsUsingDotaPlus"></a> IsUsingDotaPlus

```csharp
public bool IsUsingDotaPlus { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnAbilitySkill> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_SkilledAbilities"></a> SkilledAbilities

```csharp
public RepeatedField<int> SkilledAbilities { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_ClearIsUsingDotaPlus"></a> ClearIsUsingDotaPlus\(\)

```csharp
public void ClearIsUsingDotaPlus()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnAbilitySkill Clone()
```

#### Returns

 [CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_"></a> Equals\(CMsgSteamLearnAbilitySkill\)

```csharp
public bool Equals(CMsgSteamLearnAbilitySkill other)
```

#### Parameters

`other` [CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_"></a> MergeFrom\(CMsgSteamLearnAbilitySkill\)

```csharp
public void MergeFrom(CMsgSteamLearnAbilitySkill other)
```

#### Parameters

`other` [CMsgSteamLearnAbilitySkill](Divine.Protobufs.Dota2.CMsgSteamLearnAbilitySkill.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnAbilitySkill_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

