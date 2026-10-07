# <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series"></a> Class CMsgLeagueWatchedGames.Types.Series

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeagueWatchedGames.Types.Series : IMessage<CMsgLeagueWatchedGames.Types.Series>, IEquatable<CMsgLeagueWatchedGames.Types.Series>, IDeepCloneable<CMsgLeagueWatchedGames.Types.Series>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeagueWatchedGames.Types.Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)

#### Implements

IMessage<CMsgLeagueWatchedGames.Types.Series\>, 
[IEquatable<CMsgLeagueWatchedGames.Types.Series\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeagueWatchedGames.Types.Series\>, 
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
[EnumerableExtensions.In<CMsgLeagueWatchedGames.Types.Series\>\(CMsgLeagueWatchedGames.Types.Series, params CMsgLeagueWatchedGames.Types.Series\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series__ctor"></a> Series\(\)

```csharp
public Series()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series__ctor_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_"></a> Series\(Series\)

```csharp
public Series(CMsgLeagueWatchedGames.Types.Series other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_GameFieldNumber"></a> GameFieldNumber

```csharp
public const int GameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Game"></a> Game

```csharp
public RepeatedField<uint> Game { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeagueWatchedGames.Types.Series> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Clone"></a> Clone\(\)

```csharp
public CMsgLeagueWatchedGames.Types.Series Clone()
```

#### Returns

 [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_Equals_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_"></a> Equals\(Series\)

```csharp
public bool Equals(CMsgLeagueWatchedGames.Types.Series other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_MergeFrom_Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_"></a> MergeFrom\(Series\)

```csharp
public void MergeFrom(CMsgLeagueWatchedGames.Types.Series other)
```

#### Parameters

`other` [CMsgLeagueWatchedGames](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.md).[Types](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.md).[Series](Divine.Protobufs.Dota2.CMsgLeagueWatchedGames.Types.Series.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueWatchedGames_Types_Series_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

