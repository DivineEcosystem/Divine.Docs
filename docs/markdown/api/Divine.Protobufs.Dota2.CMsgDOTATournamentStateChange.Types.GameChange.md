# <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange"></a> Class CMsgDOTATournamentStateChange.Types.GameChange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournamentStateChange.Types.GameChange : IMessage<CMsgDOTATournamentStateChange.Types.GameChange>, IEquatable<CMsgDOTATournamentStateChange.Types.GameChange>, IDeepCloneable<CMsgDOTATournamentStateChange.Types.GameChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournamentStateChange.Types.GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)

#### Implements

IMessage<CMsgDOTATournamentStateChange.Types.GameChange\>, 
[IEquatable<CMsgDOTATournamentStateChange.Types.GameChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournamentStateChange.Types.GameChange\>, 
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
[EnumerableExtensions.In<CMsgDOTATournamentStateChange.Types.GameChange\>\(CMsgDOTATournamentStateChange.Types.GameChange, params CMsgDOTATournamentStateChange.Types.GameChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange__ctor"></a> GameChange\(\)

```csharp
public GameChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange__ctor_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_"></a> GameChange\(GameChange\)

```csharp
public GameChange(CMsgDOTATournamentStateChange.Types.GameChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_NewStateFieldNumber"></a> NewStateFieldNumber

```csharp
public const int NewStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_HasNewState"></a> HasNewState

```csharp
public bool HasNewState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_NewState"></a> NewState

```csharp
public ETournamentGameState NewState { get; set; }
```

#### Property Value

 [ETournamentGameState](Divine.Protobufs.Dota2.ETournamentGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournamentStateChange.Types.GameChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_ClearNewState"></a> ClearNewState\(\)

```csharp
public void ClearNewState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournamentStateChange.Types.GameChange Clone()
```

#### Returns

 [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_Equals_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_"></a> Equals\(GameChange\)

```csharp
public bool Equals(CMsgDOTATournamentStateChange.Types.GameChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_"></a> MergeFrom\(GameChange\)

```csharp
public void MergeFrom(CMsgDOTATournamentStateChange.Types.GameChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_GameChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

