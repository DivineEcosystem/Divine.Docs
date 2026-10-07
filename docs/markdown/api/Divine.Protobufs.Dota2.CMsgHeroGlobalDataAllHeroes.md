# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes"></a> Class CMsgHeroGlobalDataAllHeroes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataAllHeroes : IMessage<CMsgHeroGlobalDataAllHeroes>, IEquatable<CMsgHeroGlobalDataAllHeroes>, IDeepCloneable<CMsgHeroGlobalDataAllHeroes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)

#### Implements

IMessage<CMsgHeroGlobalDataAllHeroes\>, 
[IEquatable<CMsgHeroGlobalDataAllHeroes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataAllHeroes\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataAllHeroes\>\(CMsgHeroGlobalDataAllHeroes, params CMsgHeroGlobalDataAllHeroes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes__ctor"></a> CMsgHeroGlobalDataAllHeroes\(\)

```csharp
public CMsgHeroGlobalDataAllHeroes()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_"></a> CMsgHeroGlobalDataAllHeroes\(CMsgHeroGlobalDataAllHeroes\)

```csharp
public CMsgHeroGlobalDataAllHeroes(CMsgHeroGlobalDataAllHeroes other)
```

#### Parameters

`other` [CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_HeroesFieldNumber"></a> HeroesFieldNumber

```csharp
public const int HeroesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Heroes"></a> Heroes

```csharp
public RepeatedField<CMsgHeroGlobalDataResponse> Heroes { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataAllHeroes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataAllHeroes Clone()
```

#### Returns

 [CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_"></a> Equals\(CMsgHeroGlobalDataAllHeroes\)

```csharp
public bool Equals(CMsgHeroGlobalDataAllHeroes other)
```

#### Parameters

`other` [CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_"></a> MergeFrom\(CMsgHeroGlobalDataAllHeroes\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataAllHeroes other)
```

#### Parameters

`other` [CMsgHeroGlobalDataAllHeroes](Divine.Protobufs.Dota2.CMsgHeroGlobalDataAllHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataAllHeroes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

