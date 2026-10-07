# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData"></a> Class CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData : IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData>, IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData>, IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)

#### Implements

IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData\>, 
[IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData\>\(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData, params CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData__ctor"></a> RankedHeroData\(\)

```csharp
public RankedHeroData()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_"></a> RankedHeroData\(RankedHeroData\)

```csharp
public RankedHeroData(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_HeroDataFieldNumber"></a> HeroDataFieldNumber

```csharp
public const int HeroDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_RankFieldNumber"></a> RankFieldNumber

```csharp
public const int RankFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_HasRank"></a> HasRank

```csharp
public bool HasRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_HeroData"></a> HeroData

```csharp
public RepeatedField<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData> HeroData { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[HeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.HeroData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Rank"></a> Rank

```csharp
public uint Rank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_ClearRank"></a> ClearRank\(\)

```csharp
public void ClearRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData Clone()
```

#### Returns

 [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_"></a> Equals\(RankedHeroData\)

```csharp
public bool Equals(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_"></a> MergeFrom\(RankedHeroData\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Types_RankedHeroData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

