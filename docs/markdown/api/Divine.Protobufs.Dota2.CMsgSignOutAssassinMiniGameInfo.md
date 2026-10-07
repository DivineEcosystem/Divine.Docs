# <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo"></a> Class CMsgSignOutAssassinMiniGameInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutAssassinMiniGameInfo : IMessage<CMsgSignOutAssassinMiniGameInfo>, IEquatable<CMsgSignOutAssassinMiniGameInfo>, IDeepCloneable<CMsgSignOutAssassinMiniGameInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)

#### Implements

IMessage<CMsgSignOutAssassinMiniGameInfo\>, 
[IEquatable<CMsgSignOutAssassinMiniGameInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutAssassinMiniGameInfo\>, 
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
[EnumerableExtensions.In<CMsgSignOutAssassinMiniGameInfo\>\(CMsgSignOutAssassinMiniGameInfo, params CMsgSignOutAssassinMiniGameInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo__ctor"></a> CMsgSignOutAssassinMiniGameInfo\(\)

```csharp
public CMsgSignOutAssassinMiniGameInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo__ctor_Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_"></a> CMsgSignOutAssassinMiniGameInfo\(CMsgSignOutAssassinMiniGameInfo\)

```csharp
public CMsgSignOutAssassinMiniGameInfo(CMsgSignOutAssassinMiniGameInfo other)
```

#### Parameters

`other` [CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ArcanaOwnersFieldNumber"></a> ArcanaOwnersFieldNumber

```csharp
public const int ArcanaOwnersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_AssassinWonFieldNumber"></a> AssassinWonFieldNumber

```csharp
public const int AssassinWonFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ContractCompletedFieldNumber"></a> ContractCompletedFieldNumber

```csharp
public const int ContractCompletedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ContractCompleteTimeFieldNumber"></a> ContractCompleteTimeFieldNumber

```csharp
public const int ContractCompleteTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_LosingPlayersFieldNumber"></a> LosingPlayersFieldNumber

```csharp
public const int LosingPlayersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_PaIsRadiantFieldNumber"></a> PaIsRadiantFieldNumber

```csharp
public const int PaIsRadiantFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_TargetHeroIdFieldNumber"></a> TargetHeroIdFieldNumber

```csharp
public const int TargetHeroIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_WinningPlayersFieldNumber"></a> WinningPlayersFieldNumber

```csharp
public const int WinningPlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ArcanaOwners"></a> ArcanaOwners

```csharp
public RepeatedField<ulong> ArcanaOwners { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_AssassinWon"></a> AssassinWon

```csharp
public bool AssassinWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ContractCompleted"></a> ContractCompleted

```csharp
public bool ContractCompleted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ContractCompleteTime"></a> ContractCompleteTime

```csharp
public float ContractCompleteTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_HasAssassinWon"></a> HasAssassinWon

```csharp
public bool HasAssassinWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_HasContractCompleted"></a> HasContractCompleted

```csharp
public bool HasContractCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_HasContractCompleteTime"></a> HasContractCompleteTime

```csharp
public bool HasContractCompleteTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_HasPaIsRadiant"></a> HasPaIsRadiant

```csharp
public bool HasPaIsRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_HasTargetHeroId"></a> HasTargetHeroId

```csharp
public bool HasTargetHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_LosingPlayers"></a> LosingPlayers

```csharp
public RepeatedField<ulong> LosingPlayers { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_PaIsRadiant"></a> PaIsRadiant

```csharp
public bool PaIsRadiant { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutAssassinMiniGameInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_TargetHeroId"></a> TargetHeroId

```csharp
public int TargetHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_WinningPlayers"></a> WinningPlayers

```csharp
public RepeatedField<ulong> WinningPlayers { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ClearAssassinWon"></a> ClearAssassinWon\(\)

```csharp
public void ClearAssassinWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ClearContractCompleted"></a> ClearContractCompleted\(\)

```csharp
public void ClearContractCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ClearContractCompleteTime"></a> ClearContractCompleteTime\(\)

```csharp
public void ClearContractCompleteTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ClearPaIsRadiant"></a> ClearPaIsRadiant\(\)

```csharp
public void ClearPaIsRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ClearTargetHeroId"></a> ClearTargetHeroId\(\)

```csharp
public void ClearTargetHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutAssassinMiniGameInfo Clone()
```

#### Returns

 [CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_Equals_Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_"></a> Equals\(CMsgSignOutAssassinMiniGameInfo\)

```csharp
public bool Equals(CMsgSignOutAssassinMiniGameInfo other)
```

#### Parameters

`other` [CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_"></a> MergeFrom\(CMsgSignOutAssassinMiniGameInfo\)

```csharp
public void MergeFrom(CMsgSignOutAssassinMiniGameInfo other)
```

#### Parameters

`other` [CMsgSignOutAssassinMiniGameInfo](Divine.Protobufs.Dota2.CMsgSignOutAssassinMiniGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutAssassinMiniGameInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

