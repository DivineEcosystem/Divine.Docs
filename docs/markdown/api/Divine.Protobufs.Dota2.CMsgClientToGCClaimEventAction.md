# <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction"></a> Class CMsgClientToGCClaimEventAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCClaimEventAction : IMessage<CMsgClientToGCClaimEventAction>, IEquatable<CMsgClientToGCClaimEventAction>, IDeepCloneable<CMsgClientToGCClaimEventAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)

#### Implements

IMessage<CMsgClientToGCClaimEventAction\>, 
[IEquatable<CMsgClientToGCClaimEventAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCClaimEventAction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCClaimEventAction\>\(CMsgClientToGCClaimEventAction, params CMsgClientToGCClaimEventAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction__ctor"></a> CMsgClientToGCClaimEventAction\(\)

```csharp
public CMsgClientToGCClaimEventAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_"></a> CMsgClientToGCClaimEventAction\(CMsgClientToGCClaimEventAction\)

```csharp
public CMsgClientToGCClaimEventAction(CMsgClientToGCClaimEventAction other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClaimDataFieldNumber"></a> ClaimDataFieldNumber

```csharp
public const int ClaimDataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ConsumeItemIdFieldNumber"></a> ConsumeItemIdFieldNumber

```csharp
public const int ConsumeItemIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ScoreModeFieldNumber"></a> ScoreModeFieldNumber

```csharp
public const int ScoreModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_SuppressRewardsFieldNumber"></a> SuppressRewardsFieldNumber

```csharp
public const int SuppressRewardsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClaimData"></a> ClaimData

```csharp
public ByteString ClaimData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ConsumeItemId"></a> ConsumeItemId

```csharp
public ulong ConsumeItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasClaimData"></a> HasClaimData

```csharp
public bool HasClaimData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasConsumeItemId"></a> HasConsumeItemId

```csharp
public bool HasConsumeItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasScoreMode"></a> HasScoreMode

```csharp
public bool HasScoreMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_HasSuppressRewards"></a> HasSuppressRewards

```csharp
public bool HasSuppressRewards { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCClaimEventAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ScoreMode"></a> ScoreMode

```csharp
public EEventActionScoreMode ScoreMode { get; set; }
```

#### Property Value

 [EEventActionScoreMode](Divine.Protobufs.Dota2.EEventActionScoreMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_SuppressRewards"></a> SuppressRewards

```csharp
public bool SuppressRewards { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearClaimData"></a> ClearClaimData\(\)

```csharp
public void ClearClaimData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearConsumeItemId"></a> ClearConsumeItemId\(\)

```csharp
public void ClearConsumeItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearScoreMode"></a> ClearScoreMode\(\)

```csharp
public void ClearScoreMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ClearSuppressRewards"></a> ClearSuppressRewards\(\)

```csharp
public void ClearSuppressRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCClaimEventAction Clone()
```

#### Returns

 [CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_"></a> Equals\(CMsgClientToGCClaimEventAction\)

```csharp
public bool Equals(CMsgClientToGCClaimEventAction other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_"></a> MergeFrom\(CMsgClientToGCClaimEventAction\)

```csharp
public void MergeFrom(CMsgClientToGCClaimEventAction other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventAction](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

