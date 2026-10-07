# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails"></a> Class CMsgDOTALeagueNode.Types.MatchDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNode.Types.MatchDetails : IMessage<CMsgDOTALeagueNode.Types.MatchDetails>, IEquatable<CMsgDOTALeagueNode.Types.MatchDetails>, IDeepCloneable<CMsgDOTALeagueNode.Types.MatchDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNode.Types.MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)

#### Implements

IMessage<CMsgDOTALeagueNode.Types.MatchDetails\>, 
[IEquatable<CMsgDOTALeagueNode.Types.MatchDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNode.Types.MatchDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNode.Types.MatchDetails\>\(CMsgDOTALeagueNode.Types.MatchDetails, params CMsgDOTALeagueNode.Types.MatchDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails__ctor"></a> MatchDetails\(\)

```csharp
public MatchDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_"></a> MatchDetails\(MatchDetails\)

```csharp
public MatchDetails(CMsgDOTALeagueNode.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_WinningTeamIdFieldNumber"></a> WinningTeamIdFieldNumber

```csharp
public const int WinningTeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_HasWinningTeamId"></a> HasWinningTeamId

```csharp
public bool HasWinningTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNode.Types.MatchDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_WinningTeamId"></a> WinningTeamId

```csharp
public uint WinningTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_ClearWinningTeamId"></a> ClearWinningTeamId\(\)

```csharp
public void ClearWinningTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNode.Types.MatchDetails Clone()
```

#### Returns

 [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_"></a> Equals\(MatchDetails\)

```csharp
public bool Equals(CMsgDOTALeagueNode.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_"></a> MergeFrom\(MatchDetails\)

```csharp
public void MergeFrom(CMsgDOTALeagueNode.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_MatchDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

