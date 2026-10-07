# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4"></a> Class CMsgSteamLearnMatchHeroesV4

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchHeroesV4 : IMessage<CMsgSteamLearnMatchHeroesV4>, IEquatable<CMsgSteamLearnMatchHeroesV4>, IDeepCloneable<CMsgSteamLearnMatchHeroesV4>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)

#### Implements

IMessage<CMsgSteamLearnMatchHeroesV4\>, 
[IEquatable<CMsgSteamLearnMatchHeroesV4\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchHeroesV4\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchHeroesV4\>\(CMsgSteamLearnMatchHeroesV4, params CMsgSteamLearnMatchHeroesV4\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4__ctor"></a> CMsgSteamLearnMatchHeroesV4\(\)

```csharp
public CMsgSteamLearnMatchHeroesV4()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_"></a> CMsgSteamLearnMatchHeroesV4\(CMsgSteamLearnMatchHeroesV4\)

```csharp
public CMsgSteamLearnMatchHeroesV4(CMsgSteamLearnMatchHeroesV4 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DireHeroIdsFieldNumber"></a> DireHeroIdsFieldNumber

```csharp
public const int DireHeroIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DireLanesFieldNumber"></a> DireLanesFieldNumber

```csharp
public const int DireLanesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DirePositionsFieldNumber"></a> DirePositionsFieldNumber

```csharp
public const int DirePositionsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantHeroIdsFieldNumber"></a> RadiantHeroIdsFieldNumber

```csharp
public const int RadiantHeroIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantLanesFieldNumber"></a> RadiantLanesFieldNumber

```csharp
public const int RadiantLanesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantPositionsFieldNumber"></a> RadiantPositionsFieldNumber

```csharp
public const int RadiantPositionsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DireHeroIds"></a> DireHeroIds

```csharp
public RepeatedField<int> DireHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DireLanes"></a> DireLanes

```csharp
public RepeatedField<uint> DireLanes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_DirePositions"></a> DirePositions

```csharp
public RepeatedField<uint> DirePositions { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchHeroesV4> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantHeroIds"></a> RadiantHeroIds

```csharp
public RepeatedField<int> RadiantHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantLanes"></a> RadiantLanes

```csharp
public RepeatedField<uint> RadiantLanes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_RadiantPositions"></a> RadiantPositions

```csharp
public RepeatedField<uint> RadiantPositions { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchHeroesV4 Clone()
```

#### Returns

 [CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_"></a> Equals\(CMsgSteamLearnMatchHeroesV4\)

```csharp
public bool Equals(CMsgSteamLearnMatchHeroesV4 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_"></a> MergeFrom\(CMsgSteamLearnMatchHeroesV4\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchHeroesV4 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV4](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV4.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV4_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

