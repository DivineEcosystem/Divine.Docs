# <a id="Divine_Protobufs_Dota2_CMsgDOTALeague"></a> Class CMsgDOTALeague

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeague : IMessage<CMsgDOTALeague>, IEquatable<CMsgDOTALeague>, IDeepCloneable<CMsgDOTALeague>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)

#### Implements

IMessage<CMsgDOTALeague\>, 
[IEquatable<CMsgDOTALeague\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeague\>, 
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
[EnumerableExtensions.In<CMsgDOTALeague\>\(CMsgDOTALeague, params CMsgDOTALeague\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague__ctor"></a> CMsgDOTALeague\(\)

```csharp
public CMsgDOTALeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague__ctor_Divine_Protobufs_Dota2_CMsgDOTALeague_"></a> CMsgDOTALeague\(CMsgDOTALeague\)

```csharp
public CMsgDOTALeague(CMsgDOTALeague other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_AdminsFieldNumber"></a> AdminsFieldNumber

```csharp
public const int AdminsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_InfoFieldNumber"></a> InfoFieldNumber

```csharp
public const int InfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_NodeGroupsFieldNumber"></a> NodeGroupsFieldNumber

```csharp
public const int NodeGroupsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_PrizePoolFieldNumber"></a> PrizePoolFieldNumber

```csharp
public const int PrizePoolFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_RegisteredPlayersFieldNumber"></a> RegisteredPlayersFieldNumber

```csharp
public const int RegisteredPlayersFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_SeriesInfosFieldNumber"></a> SeriesInfosFieldNumber

```csharp
public const int SeriesInfosFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_StreamsFieldNumber"></a> StreamsFieldNumber

```csharp
public const int StreamsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Admins"></a> Admins

```csharp
public RepeatedField<CMsgDOTALeague.Types.Admin> Admins { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Admin](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Admin.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Info"></a> Info

```csharp
public CMsgDOTALeague.Types.Info Info { get; set; }
```

#### Property Value

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Info](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Info.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_NodeGroups"></a> NodeGroups

```csharp
public RepeatedField<CMsgDOTALeagueNodeGroup> NodeGroups { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeague> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_PrizePool"></a> PrizePool

```csharp
public CMsgDOTALeague.Types.PrizePool PrizePool { get; set; }
```

#### Property Value

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_RegisteredPlayers"></a> RegisteredPlayers

```csharp
public RepeatedField<CMsgDOTALeague.Types.Player> RegisteredPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_SeriesInfos"></a> SeriesInfos

```csharp
public RepeatedField<CMsgDOTALeague.Types.SeriesInfo> SeriesInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Streams"></a> Streams

```csharp
public RepeatedField<CMsgDOTALeague.Types.Stream> Streams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeague Clone()
```

#### Returns

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Equals_Divine_Protobufs_Dota2_CMsgDOTALeague_"></a> Equals\(CMsgDOTALeague\)

```csharp
public bool Equals(CMsgDOTALeague other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeague_"></a> MergeFrom\(CMsgDOTALeague\)

```csharp
public void MergeFrom(CMsgDOTALeague other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

