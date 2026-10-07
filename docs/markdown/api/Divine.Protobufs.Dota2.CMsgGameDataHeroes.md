# <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes"></a> Class CMsgGameDataHeroes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataHeroes : IMessage<CMsgGameDataHeroes>, IEquatable<CMsgGameDataHeroes>, IDeepCloneable<CMsgGameDataHeroes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)

#### Implements

IMessage<CMsgGameDataHeroes\>, 
[IEquatable<CMsgGameDataHeroes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataHeroes\>, 
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
[EnumerableExtensions.In<CMsgGameDataHeroes\>\(CMsgGameDataHeroes, params CMsgGameDataHeroes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes__ctor"></a> CMsgGameDataHeroes\(\)

```csharp
public CMsgGameDataHeroes()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes__ctor_Divine_Protobufs_Dota2_CMsgGameDataHeroes_"></a> CMsgGameDataHeroes\(CMsgGameDataHeroes\)

```csharp
public CMsgGameDataHeroes(CMsgGameDataHeroes other)
```

#### Parameters

`other` [CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_HeroesFieldNumber"></a> HeroesFieldNumber

```csharp
public const int HeroesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Heroes"></a> Heroes

```csharp
public RepeatedField<CMsgGameDataHero> Heroes { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataHeroes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataHeroes Clone()
```

#### Returns

 [CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_Equals_Divine_Protobufs_Dota2_CMsgGameDataHeroes_"></a> Equals\(CMsgGameDataHeroes\)

```csharp
public bool Equals(CMsgGameDataHeroes other)
```

#### Parameters

`other` [CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataHeroes_"></a> MergeFrom\(CMsgGameDataHeroes\)

```csharp
public void MergeFrom(CMsgGameDataHeroes other)
```

#### Parameters

`other` [CMsgGameDataHeroes](Divine.Protobufs.Dota2.CMsgGameDataHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

