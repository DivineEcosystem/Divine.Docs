# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8"></a> Class CMsgSteamLearnMatchHeroV8

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchHeroV8 : IMessage<CMsgSteamLearnMatchHeroV8>, IEquatable<CMsgSteamLearnMatchHeroV8>, IDeepCloneable<CMsgSteamLearnMatchHeroV8>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)

#### Implements

IMessage<CMsgSteamLearnMatchHeroV8\>, 
[IEquatable<CMsgSteamLearnMatchHeroV8\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchHeroV8\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchHeroV8\>\(CMsgSteamLearnMatchHeroV8, params CMsgSteamLearnMatchHeroV8\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8__ctor"></a> CMsgSteamLearnMatchHeroV8\(\)

```csharp
public CMsgSteamLearnMatchHeroV8()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_"></a> CMsgSteamLearnMatchHeroV8\(CMsgSteamLearnMatchHeroV8\)

```csharp
public CMsgSteamLearnMatchHeroV8(CMsgSteamLearnMatchHeroV8 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_AlliedHeroesFieldNumber"></a> AlliedHeroesFieldNumber

```csharp
public const int AlliedHeroesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_EnemyHeroesFieldNumber"></a> EnemyHeroesFieldNumber

```csharp
public const int EnemyHeroesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_LaneFieldNumber"></a> LaneFieldNumber

```csharp
public const int LaneFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_AlliedHeroes"></a> AlliedHeroes

```csharp
public RepeatedField<uint> AlliedHeroes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_EnemyHeroes"></a> EnemyHeroes

```csharp
public RepeatedField<uint> EnemyHeroes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_HasLane"></a> HasLane

```csharp
public bool HasLane { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_HasPosition"></a> HasPosition

```csharp
public bool HasPosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Lane"></a> Lane

```csharp
public uint Lane { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchHeroV8> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Position"></a> Position

```csharp
public uint Position { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_ClearLane"></a> ClearLane\(\)

```csharp
public void ClearLane()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_ClearPosition"></a> ClearPosition\(\)

```csharp
public void ClearPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchHeroV8 Clone()
```

#### Returns

 [CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_"></a> Equals\(CMsgSteamLearnMatchHeroV8\)

```csharp
public bool Equals(CMsgSteamLearnMatchHeroV8 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_"></a> MergeFrom\(CMsgSteamLearnMatchHeroV8\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchHeroV8 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV8](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV8.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV8_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

