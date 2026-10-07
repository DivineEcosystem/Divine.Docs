# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator"></a> Class CProtoItemSocket\_Spectator

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Spectator : IMessage<CProtoItemSocket_Spectator>, IEquatable<CProtoItemSocket_Spectator>, IDeepCloneable<CProtoItemSocket_Spectator>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)

#### Implements

IMessage<CProtoItemSocket\_Spectator\>, 
[IEquatable<CProtoItemSocket\_Spectator\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Spectator\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Spectator\>\(CProtoItemSocket\_Spectator, params CProtoItemSocket\_Spectator\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator__ctor"></a> CProtoItemSocket\_Spectator\(\)

```csharp
public CProtoItemSocket_Spectator()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_"></a> CProtoItemSocket\_Spectator\(CProtoItemSocket\_Spectator\)

```csharp
public CProtoItemSocket_Spectator(CProtoItemSocket_Spectator other)
```

#### Parameters

`other` [CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_CorporationIdFieldNumber"></a> CorporationIdFieldNumber

```csharp
public const int CorporationIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_GamesViewedFieldNumber"></a> GamesViewedFieldNumber

```csharp
public const int GamesViewedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_CorporationId"></a> CorporationId

```csharp
public uint CorporationId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_GamesViewed"></a> GamesViewed

```csharp
public uint GamesViewed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_HasCorporationId"></a> HasCorporationId

```csharp
public bool HasCorporationId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_HasGamesViewed"></a> HasGamesViewed

```csharp
public bool HasGamesViewed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Spectator> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_ClearCorporationId"></a> ClearCorporationId\(\)

```csharp
public void ClearCorporationId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_ClearGamesViewed"></a> ClearGamesViewed\(\)

```csharp
public void ClearGamesViewed()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Spectator Clone()
```

#### Returns

 [CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_"></a> Equals\(CProtoItemSocket\_Spectator\)

```csharp
public bool Equals(CProtoItemSocket_Spectator other)
```

#### Parameters

`other` [CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_"></a> MergeFrom\(CProtoItemSocket\_Spectator\)

```csharp
public void MergeFrom(CProtoItemSocket_Spectator other)
```

#### Parameters

`other` [CProtoItemSocket\_Spectator](Divine.Protobufs.Dota2.CProtoItemSocket\_Spectator.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Spectator_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

