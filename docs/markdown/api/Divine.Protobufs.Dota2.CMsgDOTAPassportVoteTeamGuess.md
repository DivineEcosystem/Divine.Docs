# <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess"></a> Class CMsgDOTAPassportVoteTeamGuess

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPassportVoteTeamGuess : IMessage<CMsgDOTAPassportVoteTeamGuess>, IEquatable<CMsgDOTAPassportVoteTeamGuess>, IDeepCloneable<CMsgDOTAPassportVoteTeamGuess>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)

#### Implements

IMessage<CMsgDOTAPassportVoteTeamGuess\>, 
[IEquatable<CMsgDOTAPassportVoteTeamGuess\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPassportVoteTeamGuess\>, 
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
[EnumerableExtensions.In<CMsgDOTAPassportVoteTeamGuess\>\(CMsgDOTAPassportVoteTeamGuess, params CMsgDOTAPassportVoteTeamGuess\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess__ctor"></a> CMsgDOTAPassportVoteTeamGuess\(\)

```csharp
public CMsgDOTAPassportVoteTeamGuess()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess__ctor_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_"></a> CMsgDOTAPassportVoteTeamGuess\(CMsgDOTAPassportVoteTeamGuess\)

```csharp
public CMsgDOTAPassportVoteTeamGuess(CMsgDOTAPassportVoteTeamGuess other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_RunnerupIdFieldNumber"></a> RunnerupIdFieldNumber

```csharp
public const int RunnerupIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_WinnerIdFieldNumber"></a> WinnerIdFieldNumber

```csharp
public const int WinnerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_HasRunnerupId"></a> HasRunnerupId

```csharp
public bool HasRunnerupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_HasWinnerId"></a> HasWinnerId

```csharp
public bool HasWinnerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPassportVoteTeamGuess> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_RunnerupId"></a> RunnerupId

```csharp
public uint RunnerupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_WinnerId"></a> WinnerId

```csharp
public uint WinnerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_ClearRunnerupId"></a> ClearRunnerupId\(\)

```csharp
public void ClearRunnerupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_ClearWinnerId"></a> ClearWinnerId\(\)

```csharp
public void ClearWinnerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPassportVoteTeamGuess Clone()
```

#### Returns

 [CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_Equals_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_"></a> Equals\(CMsgDOTAPassportVoteTeamGuess\)

```csharp
public bool Equals(CMsgDOTAPassportVoteTeamGuess other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_"></a> MergeFrom\(CMsgDOTAPassportVoteTeamGuess\)

```csharp
public void MergeFrom(CMsgDOTAPassportVoteTeamGuess other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteTeamGuess_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

