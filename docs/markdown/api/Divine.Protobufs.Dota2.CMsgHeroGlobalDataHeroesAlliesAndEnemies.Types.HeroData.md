# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData"></a> Class CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData : IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData>, IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData>, IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)

#### Implements

IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData\>, 
[IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData\>\(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData, params CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData__ctor"></a> HeroData\(\)

```csharp
public HeroData()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_"></a> HeroData\(HeroData\)

```csharp
public HeroData(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_AllyWinRateFieldNumber"></a> AllyWinRateFieldNumber

```csharp
public const int AllyWinRateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_EnemyWinRateFieldNumber"></a> EnemyWinRateFieldNumber

```csharp
public const int EnemyWinRateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_FirstOtherHeroIdFieldNumber"></a> FirstOtherHeroIdFieldNumber

```csharp
public const int FirstOtherHeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_WinRateFieldNumber"></a> WinRateFieldNumber

```csharp
public const int WinRateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_AllyWinRate"></a> AllyWinRate

```csharp
public RepeatedField<uint> AllyWinRate { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_EnemyWinRate"></a> EnemyWinRate

```csharp
public RepeatedField<uint> EnemyWinRate { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_FirstOtherHeroId"></a> FirstOtherHeroId

```csharp
public int FirstOtherHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_HasFirstOtherHeroId"></a> HasFirstOtherHeroId

```csharp
public bool HasFirstOtherHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_HasWinRate"></a> HasWinRate

```csharp
public bool HasWinRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_WinRate"></a> WinRate

```csharp
public uint WinRate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_ClearFirstOtherHeroId"></a> ClearFirstOtherHeroId\(\)

```csharp
public void ClearFirstOtherHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_ClearWinRate"></a> ClearWinRate\(\)

```csharp
public void ClearWinRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData Clone()
```

#### Returns

 [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_"></a> Equals\(HeroData\)

```csharp
public bool Equals(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_"></a> MergeFrom\(HeroData\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_HeroData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

