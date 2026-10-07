# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies"></a> Class CMsgHeroGlobalDataHeroesAlliesAndEnemies

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataHeroesAlliesAndEnemies : IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies>, IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies>, IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)

#### Implements

IMessage<CMsgHeroGlobalDataHeroesAlliesAndEnemies\>, 
[IEquatable<CMsgHeroGlobalDataHeroesAlliesAndEnemies\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataHeroesAlliesAndEnemies\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataHeroesAlliesAndEnemies\>\(CMsgHeroGlobalDataHeroesAlliesAndEnemies, params CMsgHeroGlobalDataHeroesAlliesAndEnemies\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies__ctor"></a> CMsgHeroGlobalDataHeroesAlliesAndEnemies\(\)

```csharp
public CMsgHeroGlobalDataHeroesAlliesAndEnemies()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_"></a> CMsgHeroGlobalDataHeroesAlliesAndEnemies\(CMsgHeroGlobalDataHeroesAlliesAndEnemies\)

```csharp
public CMsgHeroGlobalDataHeroesAlliesAndEnemies(CMsgHeroGlobalDataHeroesAlliesAndEnemies other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_RankedHeroDataFieldNumber"></a> RankedHeroDataFieldNumber

```csharp
public const int RankedHeroDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataHeroesAlliesAndEnemies> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_RankedHeroData"></a> RankedHeroData

```csharp
public RepeatedField<CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData> RankedHeroData { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.md).[RankedHeroData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.Types.RankedHeroData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataHeroesAlliesAndEnemies Clone()
```

#### Returns

 [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_"></a> Equals\(CMsgHeroGlobalDataHeroesAlliesAndEnemies\)

```csharp
public bool Equals(CMsgHeroGlobalDataHeroesAlliesAndEnemies other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_"></a> MergeFrom\(CMsgHeroGlobalDataHeroesAlliesAndEnemies\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataHeroesAlliesAndEnemies other)
```

#### Parameters

`other` [CMsgHeroGlobalDataHeroesAlliesAndEnemies](Divine.Protobufs.Dota2.CMsgHeroGlobalDataHeroesAlliesAndEnemies.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataHeroesAlliesAndEnemies_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

