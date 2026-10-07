# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard"></a> Class CMsgClientToGCBingoDevRerollCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoDevRerollCard : IMessage<CMsgClientToGCBingoDevRerollCard>, IEquatable<CMsgClientToGCBingoDevRerollCard>, IDeepCloneable<CMsgClientToGCBingoDevRerollCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)

#### Implements

IMessage<CMsgClientToGCBingoDevRerollCard\>, 
[IEquatable<CMsgClientToGCBingoDevRerollCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoDevRerollCard\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoDevRerollCard\>\(CMsgClientToGCBingoDevRerollCard, params CMsgClientToGCBingoDevRerollCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard__ctor"></a> CMsgClientToGCBingoDevRerollCard\(\)

```csharp
public CMsgClientToGCBingoDevRerollCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_"></a> CMsgClientToGCBingoDevRerollCard\(CMsgClientToGCBingoDevRerollCard\)

```csharp
public CMsgClientToGCBingoDevRerollCard(CMsgClientToGCBingoDevRerollCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoDevRerollCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoDevRerollCard Clone()
```

#### Returns

 [CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_"></a> Equals\(CMsgClientToGCBingoDevRerollCard\)

```csharp
public bool Equals(CMsgClientToGCBingoDevRerollCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_"></a> MergeFrom\(CMsgClientToGCBingoDevRerollCard\)

```csharp
public void MergeFrom(CMsgClientToGCBingoDevRerollCard other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevRerollCard](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevRerollCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevRerollCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

