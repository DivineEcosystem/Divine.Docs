# <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames"></a> Class CMsgGCToClientTopWeekendTourneyGames

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientTopWeekendTourneyGames : IMessage<CMsgGCToClientTopWeekendTourneyGames>, IEquatable<CMsgGCToClientTopWeekendTourneyGames>, IDeepCloneable<CMsgGCToClientTopWeekendTourneyGames>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)

#### Implements

IMessage<CMsgGCToClientTopWeekendTourneyGames\>, 
[IEquatable<CMsgGCToClientTopWeekendTourneyGames\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientTopWeekendTourneyGames\>, 
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
[EnumerableExtensions.In<CMsgGCToClientTopWeekendTourneyGames\>\(CMsgGCToClientTopWeekendTourneyGames, params CMsgGCToClientTopWeekendTourneyGames\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames__ctor"></a> CMsgGCToClientTopWeekendTourneyGames\(\)

```csharp
public CMsgGCToClientTopWeekendTourneyGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames__ctor_Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_"></a> CMsgGCToClientTopWeekendTourneyGames\(CMsgGCToClientTopWeekendTourneyGames\)

```csharp
public CMsgGCToClientTopWeekendTourneyGames(CMsgGCToClientTopWeekendTourneyGames other)
```

#### Parameters

`other` [CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_LiveGamesFieldNumber"></a> LiveGamesFieldNumber

```csharp
public const int LiveGamesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_LiveGames"></a> LiveGames

```csharp
public RepeatedField<CSourceTVGameSmall> LiveGames { get; }
```

#### Property Value

 RepeatedField<[CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientTopWeekendTourneyGames> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientTopWeekendTourneyGames Clone()
```

#### Returns

 [CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_Equals_Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_"></a> Equals\(CMsgGCToClientTopWeekendTourneyGames\)

```csharp
public bool Equals(CMsgGCToClientTopWeekendTourneyGames other)
```

#### Parameters

`other` [CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_"></a> MergeFrom\(CMsgGCToClientTopWeekendTourneyGames\)

```csharp
public void MergeFrom(CMsgGCToClientTopWeekendTourneyGames other)
```

#### Parameters

`other` [CMsgGCToClientTopWeekendTourneyGames](Divine.Protobufs.Dota2.CMsgGCToClientTopWeekendTourneyGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopWeekendTourneyGames_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

