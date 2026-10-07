# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard"></a> Class CMsgClientToGCBingoShuffleCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoShuffleCard : IMessage<CMsgClientToGCBingoShuffleCard>, IEquatable<CMsgClientToGCBingoShuffleCard>, IDeepCloneable<CMsgClientToGCBingoShuffleCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)

#### Implements

IMessage<CMsgClientToGCBingoShuffleCard\>, 
[IEquatable<CMsgClientToGCBingoShuffleCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoShuffleCard\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoShuffleCard\>\(CMsgClientToGCBingoShuffleCard, params CMsgClientToGCBingoShuffleCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard__ctor"></a> CMsgClientToGCBingoShuffleCard\(\)

```csharp
public CMsgClientToGCBingoShuffleCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_"></a> CMsgClientToGCBingoShuffleCard\(CMsgClientToGCBingoShuffleCard\)

```csharp
public CMsgClientToGCBingoShuffleCard(CMsgClientToGCBingoShuffleCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoShuffleCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoShuffleCard Clone()
```

#### Returns

 [CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_"></a> Equals\(CMsgClientToGCBingoShuffleCard\)

```csharp
public bool Equals(CMsgClientToGCBingoShuffleCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_"></a> MergeFrom\(CMsgClientToGCBingoShuffleCard\)

```csharp
public void MergeFrom(CMsgClientToGCBingoShuffleCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

