# <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction"></a> Class CMsgClientToGCItemBattlerGameAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCItemBattlerGameAction : IMessage<CMsgClientToGCItemBattlerGameAction>, IEquatable<CMsgClientToGCItemBattlerGameAction>, IDeepCloneable<CMsgClientToGCItemBattlerGameAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)

#### Implements

IMessage<CMsgClientToGCItemBattlerGameAction\>, 
[IEquatable<CMsgClientToGCItemBattlerGameAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCItemBattlerGameAction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCItemBattlerGameAction\>\(CMsgClientToGCItemBattlerGameAction, params CMsgClientToGCItemBattlerGameAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction__ctor"></a> CMsgClientToGCItemBattlerGameAction\(\)

```csharp
public CMsgClientToGCItemBattlerGameAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_"></a> CMsgClientToGCItemBattlerGameAction\(CMsgClientToGCItemBattlerGameAction\)

```csharp
public CMsgClientToGCItemBattlerGameAction(CMsgClientToGCItemBattlerGameAction other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ChoiceIndexFieldNumber"></a> ChoiceIndexFieldNumber

```csharp
public const int ChoiceIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemContainerIdFieldNumber"></a> ItemContainerIdFieldNumber

```csharp
public const int ItemContainerIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemInstanceIdFieldNumber"></a> ItemInstanceIdFieldNumber

```csharp
public const int ItemInstanceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemPositionXFieldNumber"></a> ItemPositionXFieldNumber

```csharp
public const int ItemPositionXFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemPositionYFieldNumber"></a> ItemPositionYFieldNumber

```csharp
public const int ItemPositionYFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Action"></a> Action

```csharp
public CMsgClientToGCItemBattlerGameAction.Types.EAction Action { get; set; }
```

#### Property Value

 [CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.Types.md).[EAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.Types.EAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ChoiceIndex"></a> ChoiceIndex

```csharp
public uint ChoiceIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasChoiceIndex"></a> HasChoiceIndex

```csharp
public bool HasChoiceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasItemContainerId"></a> HasItemContainerId

```csharp
public bool HasItemContainerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasItemInstanceId"></a> HasItemInstanceId

```csharp
public bool HasItemInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasItemPositionX"></a> HasItemPositionX

```csharp
public bool HasItemPositionX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_HasItemPositionY"></a> HasItemPositionY

```csharp
public bool HasItemPositionY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemContainerId"></a> ItemContainerId

```csharp
public uint ItemContainerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemInstanceId"></a> ItemInstanceId

```csharp
public uint ItemInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemPositionX"></a> ItemPositionX

```csharp
public uint ItemPositionX { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ItemPositionY"></a> ItemPositionY

```csharp
public uint ItemPositionY { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCItemBattlerGameAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearChoiceIndex"></a> ClearChoiceIndex\(\)

```csharp
public void ClearChoiceIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearItemContainerId"></a> ClearItemContainerId\(\)

```csharp
public void ClearItemContainerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearItemInstanceId"></a> ClearItemInstanceId\(\)

```csharp
public void ClearItemInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearItemPositionX"></a> ClearItemPositionX\(\)

```csharp
public void ClearItemPositionX()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ClearItemPositionY"></a> ClearItemPositionY\(\)

```csharp
public void ClearItemPositionY()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCItemBattlerGameAction Clone()
```

#### Returns

 [CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_"></a> Equals\(CMsgClientToGCItemBattlerGameAction\)

```csharp
public bool Equals(CMsgClientToGCItemBattlerGameAction other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_"></a> MergeFrom\(CMsgClientToGCItemBattlerGameAction\)

```csharp
public void MergeFrom(CMsgClientToGCItemBattlerGameAction other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameAction](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

