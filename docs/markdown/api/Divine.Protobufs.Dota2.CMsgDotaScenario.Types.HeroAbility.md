# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility"></a> Class CMsgDotaScenario.Types.HeroAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.HeroAbility : IMessage<CMsgDotaScenario.Types.HeroAbility>, IEquatable<CMsgDotaScenario.Types.HeroAbility>, IDeepCloneable<CMsgDotaScenario.Types.HeroAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)

#### Implements

IMessage<CMsgDotaScenario.Types.HeroAbility\>, 
[IEquatable<CMsgDotaScenario.Types.HeroAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.HeroAbility\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.HeroAbility\>\(CMsgDotaScenario.Types.HeroAbility, params CMsgDotaScenario.Types.HeroAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility__ctor"></a> HeroAbility\(\)

```csharp
public HeroAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_"></a> HeroAbility\(HeroAbility\)

```csharp
public HeroAbility(CMsgDotaScenario.Types.HeroAbility other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_TomeUpgradedFieldNumber"></a> TomeUpgradedFieldNumber

```csharp
public const int TomeUpgradedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_HasTomeUpgraded"></a> HasTomeUpgraded

```csharp
public bool HasTomeUpgraded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Level"></a> Level

```csharp
public int Level { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.HeroAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_TomeUpgraded"></a> TomeUpgraded

```csharp
public bool TomeUpgraded { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_ClearTomeUpgraded"></a> ClearTomeUpgraded\(\)

```csharp
public void ClearTomeUpgraded()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.HeroAbility Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_"></a> Equals\(HeroAbility\)

```csharp
public bool Equals(CMsgDotaScenario.Types.HeroAbility other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_"></a> MergeFrom\(HeroAbility\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.HeroAbility other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroAbility](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroAbility.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

