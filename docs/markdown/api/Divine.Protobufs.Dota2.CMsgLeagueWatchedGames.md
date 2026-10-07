# <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames"></a> Class CMsgLeagueWatchedGames

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeagueWatchedGames : IMessage<CMsgLeagueWatchedGames>, IEquatable<CMsgLeagueWatchedGames>, IDeepCloneable<CMsgLeagueWatchedGames>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)

#### Implements

IMessage<CMsgLeagueWatchedGames\>, 
[IEquatable<CMsgLeagueWatchedGames\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeagueWatchedGames\>, 
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
[EnumerableExtensions.In<CMsgLeagueWatchedGames\>\(CMsgLeagueWatchedGames, params CMsgLeagueWatchedGames\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames__ctor"></a> CMsgLeagueWatchedGames\(\)

```csharp
public CMsgLeagueWatchedGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames__ctor_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_"></a> CMsgLeagueWatchedGames\(CMsgLeagueWatchedGames\)

```csharp
public CMsgLeagueWatchedGames(CMsgLeagueWatchedGames other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_LeaguesFieldNumber"></a> LeaguesFieldNumber

```csharp
public const int LeaguesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Leagues"></a> Leagues

```csharp
public RepeatedField<CMsgLeagueWatchedGames.Types.League> Leagues { get; }
```

#### Property Value

 RepeatedField<[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeagueWatchedGames> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Clone"></a> Clone\(\)

```csharp
public CMsgLeagueWatchedGames Clone()
```

#### Returns

 [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Equals_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_"></a> Equals\(CMsgLeagueWatchedGames\)

```csharp
public bool Equals(CMsgLeagueWatchedGames other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_MergeFrom_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_"></a> MergeFrom\(CMsgLeagueWatchedGames\)

```csharp
public void MergeFrom(CMsgLeagueWatchedGames other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

