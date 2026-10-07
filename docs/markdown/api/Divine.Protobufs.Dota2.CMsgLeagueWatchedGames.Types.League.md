# <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League"></a> Class CMsgLeagueWatchedGames.Types.League

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeagueWatchedGames.Types.League : IMessage<CMsgLeagueWatchedGames.Types.League>, IEquatable<CMsgLeagueWatchedGames.Types.League>, IDeepCloneable<CMsgLeagueWatchedGames.Types.League>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeagueWatchedGames.Types.League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)

#### Implements

IMessage<CMsgLeagueWatchedGames.Types.League\>, 
[IEquatable<CMsgLeagueWatchedGames.Types.League\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeagueWatchedGames.Types.League\>, 
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
[EnumerableExtensions.In<CMsgLeagueWatchedGames.Types.League\>\(CMsgLeagueWatchedGames.Types.League, params CMsgLeagueWatchedGames.Types.League\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League__ctor"></a> League\(\)

```csharp
public League()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League__ctor_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_"></a> League\(League\)

```csharp
public League(CMsgLeagueWatchedGames.Types.League other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_SeriesFieldNumber"></a> SeriesFieldNumber

```csharp
public const int SeriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeagueWatchedGames.Types.League> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Series"></a> Series

```csharp
public RepeatedField<CMsgLeagueWatchedGames.Types.Series> Series { get; }
```

#### Property Value

 RepeatedField<[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Clone"></a> Clone\(\)

```csharp
public CMsgLeagueWatchedGames.Types.League Clone()
```

#### Returns

 [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_Equals_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_"></a> Equals\(League\)

```csharp
public bool Equals(CMsgLeagueWatchedGames.Types.League other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_MergeFrom_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_"></a> MergeFrom\(League\)

```csharp
public void MergeFrom(CMsgLeagueWatchedGames.Types.League other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[League](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.League.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_League_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

