# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction"></a> Class CMsgDOTAClaimEventAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventAction : IMessage<CMsgDOTAClaimEventAction>, IEquatable<CMsgDOTAClaimEventAction>, IDeepCloneable<CMsgDOTAClaimEventAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)

#### Implements

IMessage<CMsgDOTAClaimEventAction\>, 
[IEquatable<CMsgDOTAClaimEventAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventAction\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventAction\>\(CMsgDOTAClaimEventAction, params CMsgDOTAClaimEventAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction__ctor"></a> CMsgDOTAClaimEventAction\(\)

```csharp
public CMsgDOTAClaimEventAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_"></a> CMsgDOTAClaimEventAction\(CMsgDOTAClaimEventAction\)

```csharp
public CMsgDOTAClaimEventAction(CMsgDOTAClaimEventAction other)
```

#### Parameters

`other` [CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ScoreModeFieldNumber"></a> ScoreModeFieldNumber

```csharp
public const int ScoreModeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_SuppressRewardsFieldNumber"></a> SuppressRewardsFieldNumber

```csharp
public const int SuppressRewardsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Data"></a> Data

```csharp
public CMsgDOTAClaimEventActionData Data { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_HasScoreMode"></a> HasScoreMode

```csharp
public bool HasScoreMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_HasSuppressRewards"></a> HasSuppressRewards

```csharp
public bool HasSuppressRewards { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ScoreMode"></a> ScoreMode

```csharp
public EEventActionScoreMode ScoreMode { get; set; }
```

#### Property Value

 [EEventActionScoreMode](Divine.Protobufs.Dota2.EEventActionScoreMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_SuppressRewards"></a> SuppressRewards

```csharp
public bool SuppressRewards { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ClearScoreMode"></a> ClearScoreMode\(\)

```csharp
public void ClearScoreMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ClearSuppressRewards"></a> ClearSuppressRewards\(\)

```csharp
public void ClearSuppressRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventAction Clone()
```

#### Returns

 [CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_"></a> Equals\(CMsgDOTAClaimEventAction\)

```csharp
public bool Equals(CMsgDOTAClaimEventAction other)
```

#### Parameters

`other` [CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_"></a> MergeFrom\(CMsgDOTAClaimEventAction\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventAction other)
```

#### Parameters

`other` [CMsgDOTAClaimEventAction](Divine.Protobufs.Dota2.CMsgDOTAClaimEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

