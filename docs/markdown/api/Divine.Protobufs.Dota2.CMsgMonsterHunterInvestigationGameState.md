# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState"></a> Class CMsgMonsterHunterInvestigationGameState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterInvestigationGameState : IMessage<CMsgMonsterHunterInvestigationGameState>, IEquatable<CMsgMonsterHunterInvestigationGameState>, IDeepCloneable<CMsgMonsterHunterInvestigationGameState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

#### Implements

IMessage<CMsgMonsterHunterInvestigationGameState\>, 
[IEquatable<CMsgMonsterHunterInvestigationGameState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterInvestigationGameState\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterInvestigationGameState\>\(CMsgMonsterHunterInvestigationGameState, params CMsgMonsterHunterInvestigationGameState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState__ctor"></a> CMsgMonsterHunterInvestigationGameState\(\)

```csharp
public CMsgMonsterHunterInvestigationGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_"></a> CMsgMonsterHunterInvestigationGameState\(CMsgMonsterHunterInvestigationGameState\)

```csharp
public CMsgMonsterHunterInvestigationGameState(CMsgMonsterHunterInvestigationGameState other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_HuntedByFieldNumber"></a> HuntedByFieldNumber

```csharp
public const int HuntedByFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_SelectedInvestigationFieldNumber"></a> SelectedInvestigationFieldNumber

```csharp
public const int SelectedInvestigationFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_HuntedBy"></a> HuntedBy

```csharp
public RepeatedField<CMsgMonsterHunterInvestigationGameState.Types.HuntedBy> HuntedBy { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.md).[HuntedBy](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.Types.HuntedBy.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterInvestigationGameState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_SelectedInvestigation"></a> SelectedInvestigation

```csharp
public CMsgMonsterHunterInvestigation SelectedInvestigation { get; set; }
```

#### Property Value

 [CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterInvestigationGameState Clone()
```

#### Returns

 [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_"></a> Equals\(CMsgMonsterHunterInvestigationGameState\)

```csharp
public bool Equals(CMsgMonsterHunterInvestigationGameState other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_"></a> MergeFrom\(CMsgMonsterHunterInvestigationGameState\)

```csharp
public void MergeFrom(CMsgMonsterHunterInvestigationGameState other)
```

#### Parameters

`other` [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterInvestigationGameState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

