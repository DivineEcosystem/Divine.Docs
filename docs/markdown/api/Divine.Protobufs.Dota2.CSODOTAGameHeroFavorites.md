# <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites"></a> Class CSODOTAGameHeroFavorites

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAGameHeroFavorites : IMessage<CSODOTAGameHeroFavorites>, IEquatable<CSODOTAGameHeroFavorites>, IDeepCloneable<CSODOTAGameHeroFavorites>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)

#### Implements

IMessage<CSODOTAGameHeroFavorites\>, 
[IEquatable<CSODOTAGameHeroFavorites\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAGameHeroFavorites\>, 
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
[EnumerableExtensions.In<CSODOTAGameHeroFavorites\>\(CSODOTAGameHeroFavorites, params CSODOTAGameHeroFavorites\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites__ctor"></a> CSODOTAGameHeroFavorites\(\)

```csharp
public CSODOTAGameHeroFavorites()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites__ctor_Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_"></a> CSODOTAGameHeroFavorites\(CSODOTAGameHeroFavorites\)

```csharp
public CSODOTAGameHeroFavorites(CSODOTAGameHeroFavorites other)
```

#### Parameters

`other` [CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAGameHeroFavorites> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_Clone"></a> Clone\(\)

```csharp
public CSODOTAGameHeroFavorites Clone()
```

#### Returns

 [CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_Equals_Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_"></a> Equals\(CSODOTAGameHeroFavorites\)

```csharp
public bool Equals(CSODOTAGameHeroFavorites other)
```

#### Parameters

`other` [CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_MergeFrom_Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_"></a> MergeFrom\(CSODOTAGameHeroFavorites\)

```csharp
public void MergeFrom(CSODOTAGameHeroFavorites other)
```

#### Parameters

`other` [CSODOTAGameHeroFavorites](Divine.Protobufs.Dota2.CSODOTAGameHeroFavorites.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameHeroFavorites_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

