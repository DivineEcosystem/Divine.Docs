# <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange"></a> Class CMsgDOTATournamentStateChange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournamentStateChange : IMessage<CMsgDOTATournamentStateChange>, IEquatable<CMsgDOTATournamentStateChange>, IDeepCloneable<CMsgDOTATournamentStateChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)

#### Implements

IMessage<CMsgDOTATournamentStateChange\>, 
[IEquatable<CMsgDOTATournamentStateChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournamentStateChange\>, 
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
[EnumerableExtensions.In<CMsgDOTATournamentStateChange\>\(CMsgDOTATournamentStateChange, params CMsgDOTATournamentStateChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange__ctor"></a> CMsgDOTATournamentStateChange\(\)

```csharp
public CMsgDOTATournamentStateChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange__ctor_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_"></a> CMsgDOTATournamentStateChange\(CMsgDOTATournamentStateChange\)

```csharp
public CMsgDOTATournamentStateChange(CMsgDOTATournamentStateChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_EventFieldNumber"></a> EventFieldNumber

```csharp
public const int EventFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_GameChangesFieldNumber"></a> GameChangesFieldNumber

```csharp
public const int GameChangesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_MergedTournamentIdsFieldNumber"></a> MergedTournamentIdsFieldNumber

```csharp
public const int MergedTournamentIdsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_NewTournamentIdFieldNumber"></a> NewTournamentIdFieldNumber

```csharp
public const int NewTournamentIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_NewTournamentStateFieldNumber"></a> NewTournamentStateFieldNumber

```csharp
public const int NewTournamentStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_StateSeqNumFieldNumber"></a> StateSeqNumFieldNumber

```csharp
public const int StateSeqNumFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_TeamChangesFieldNumber"></a> TeamChangesFieldNumber

```csharp
public const int TeamChangesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Event"></a> Event

```csharp
public ETournamentEvent Event { get; set; }
```

#### Property Value

 [ETournamentEvent](Divine.Protobufs.Dota2.ETournamentEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_GameChanges"></a> GameChanges

```csharp
public RepeatedField<CMsgDOTATournamentStateChange.Types.GameChange> GameChanges { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[GameChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.GameChange.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_HasEvent"></a> HasEvent

```csharp
public bool HasEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_HasNewTournamentId"></a> HasNewTournamentId

```csharp
public bool HasNewTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_HasNewTournamentState"></a> HasNewTournamentState

```csharp
public bool HasNewTournamentState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_HasStateSeqNum"></a> HasStateSeqNum

```csharp
public bool HasStateSeqNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_MergedTournamentIds"></a> MergedTournamentIds

```csharp
public RepeatedField<uint> MergedTournamentIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_NewTournamentId"></a> NewTournamentId

```csharp
public uint NewTournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_NewTournamentState"></a> NewTournamentState

```csharp
public ETournamentState NewTournamentState { get; set; }
```

#### Property Value

 [ETournamentState](Divine.Protobufs.Dota2.ETournamentState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournamentStateChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_StateSeqNum"></a> StateSeqNum

```csharp
public uint StateSeqNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_TeamChanges"></a> TeamChanges

```csharp
public RepeatedField<CMsgDOTATournamentStateChange.Types.TeamChange> TeamChanges { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_ClearEvent"></a> ClearEvent\(\)

```csharp
public void ClearEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_ClearNewTournamentId"></a> ClearNewTournamentId\(\)

```csharp
public void ClearNewTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_ClearNewTournamentState"></a> ClearNewTournamentState\(\)

```csharp
public void ClearNewTournamentState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_ClearStateSeqNum"></a> ClearStateSeqNum\(\)

```csharp
public void ClearStateSeqNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournamentStateChange Clone()
```

#### Returns

 [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Equals_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_"></a> Equals\(CMsgDOTATournamentStateChange\)

```csharp
public bool Equals(CMsgDOTATournamentStateChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_"></a> MergeFrom\(CMsgDOTATournamentStateChange\)

```csharp
public void MergeFrom(CMsgDOTATournamentStateChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

