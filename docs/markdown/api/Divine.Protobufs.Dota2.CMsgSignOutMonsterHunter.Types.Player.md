# <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player"></a> Class CMsgSignOutMonsterHunter.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMonsterHunter.Types.Player : IMessage<CMsgSignOutMonsterHunter.Types.Player>, IEquatable<CMsgSignOutMonsterHunter.Types.Player>, IDeepCloneable<CMsgSignOutMonsterHunter.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMonsterHunter.Types.Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)

#### Implements

IMessage<CMsgSignOutMonsterHunter.Types.Player\>, 
[IEquatable<CMsgSignOutMonsterHunter.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMonsterHunter.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgSignOutMonsterHunter.Types.Player\>\(CMsgSignOutMonsterHunter.Types.Player, params CMsgSignOutMonsterHunter.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgSignOutMonsterHunter.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_CodexUpdateDataFieldNumber"></a> CodexUpdateDataFieldNumber

```csharp
public const int CodexUpdateDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_InvestigationGameStateFieldNumber"></a> InvestigationGameStateFieldNumber

```csharp
public const int InvestigationGameStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_CodexUpdateData"></a> CodexUpdateData

```csharp
public CMsgMonsterHunterCodexUpdateData CodexUpdateData { get; set; }
```

#### Property Value

 [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_InvestigationGameState"></a> InvestigationGameState

```csharp
public CMsgMonsterHunterInvestigationGameState InvestigationGameState { get; set; }
```

#### Property Value

 [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMonsterHunter.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMonsterHunter.Types.Player Clone()
```

#### Returns

 [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgSignOutMonsterHunter.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgSignOutMonsterHunter.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

