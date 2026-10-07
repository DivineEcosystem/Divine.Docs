# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction"></a> Class CDOTAClientMsg\_QuickBuyAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_QuickBuyAction : IMessage<CDOTAClientMsg_QuickBuyAction>, IEquatable<CDOTAClientMsg_QuickBuyAction>, IDeepCloneable<CDOTAClientMsg_QuickBuyAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)

#### Implements

IMessage<CDOTAClientMsg\_QuickBuyAction\>, 
[IEquatable<CDOTAClientMsg\_QuickBuyAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_QuickBuyAction\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_QuickBuyAction\>\(CDOTAClientMsg\_QuickBuyAction, params CDOTAClientMsg\_QuickBuyAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction__ctor"></a> CDOTAClientMsg\_QuickBuyAction\(\)

```csharp
public CDOTAClientMsg_QuickBuyAction()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_"></a> CDOTAClientMsg\_QuickBuyAction\(CDOTAClientMsg\_QuickBuyAction\)

```csharp
public CDOTAClientMsg_QuickBuyAction(CDOTAClientMsg_QuickBuyAction other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_DisableBuybackProtectionForPurchaseFieldNumber"></a> DisableBuybackProtectionForPurchaseFieldNumber

```csharp
public const int DisableBuybackProtectionForPurchaseFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_NewSlotIndexFieldNumber"></a> NewSlotIndexFieldNumber

```csharp
public const int NewSlotIndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_OldSlotAbilityIdsFieldNumber"></a> OldSlotAbilityIdsFieldNumber

```csharp
public const int OldSlotAbilityIdsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_PurchaserEntindexFieldNumber"></a> PurchaserEntindexFieldNumber

```csharp
public const int PurchaserEntindexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_SlotIndexFieldNumber"></a> SlotIndexFieldNumber

```csharp
public const int SlotIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_TopLevelItemFieldNumber"></a> TopLevelItemFieldNumber

```csharp
public const int TopLevelItemFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Action"></a> Action

```csharp
public CDOTAClientMsg_QuickBuyAction.Types.EActionType Action { get; set; }
```

#### Property Value

 [CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.Types.md).[EActionType](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.Types.EActionType.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_DisableBuybackProtectionForPurchase"></a> DisableBuybackProtectionForPurchase

```csharp
public bool DisableBuybackProtectionForPurchase { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasDisableBuybackProtectionForPurchase"></a> HasDisableBuybackProtectionForPurchase

```csharp
public bool HasDisableBuybackProtectionForPurchase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasNewSlotIndex"></a> HasNewSlotIndex

```csharp
public bool HasNewSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasPurchaserEntindex"></a> HasPurchaserEntindex

```csharp
public bool HasPurchaserEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasSlotIndex"></a> HasSlotIndex

```csharp
public bool HasSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_HasTopLevelItem"></a> HasTopLevelItem

```csharp
public bool HasTopLevelItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_NewSlotIndex"></a> NewSlotIndex

```csharp
public int NewSlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_OldSlotAbilityIds"></a> OldSlotAbilityIds

```csharp
public RepeatedField<int> OldSlotAbilityIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_QuickBuyAction> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_PurchaserEntindex"></a> PurchaserEntindex

```csharp
public int PurchaserEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_SlotIndex"></a> SlotIndex

```csharp
public int SlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_TopLevelItem"></a> TopLevelItem

```csharp
public bool TopLevelItem { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearDisableBuybackProtectionForPurchase"></a> ClearDisableBuybackProtectionForPurchase\(\)

```csharp
public void ClearDisableBuybackProtectionForPurchase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearNewSlotIndex"></a> ClearNewSlotIndex\(\)

```csharp
public void ClearNewSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearPurchaserEntindex"></a> ClearPurchaserEntindex\(\)

```csharp
public void ClearPurchaserEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearSlotIndex"></a> ClearSlotIndex\(\)

```csharp
public void ClearSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ClearTopLevelItem"></a> ClearTopLevelItem\(\)

```csharp
public void ClearTopLevelItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_QuickBuyAction Clone()
```

#### Returns

 [CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_"></a> Equals\(CDOTAClientMsg\_QuickBuyAction\)

```csharp
public bool Equals(CDOTAClientMsg_QuickBuyAction other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_"></a> MergeFrom\(CDOTAClientMsg\_QuickBuyAction\)

```csharp
public void MergeFrom(CDOTAClientMsg_QuickBuyAction other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAction](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAction.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

