# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot"></a> Class CMsgClientToGCPurchaseFilteredPlayerSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPurchaseFilteredPlayerSlot : IMessage<CMsgClientToGCPurchaseFilteredPlayerSlot>, IEquatable<CMsgClientToGCPurchaseFilteredPlayerSlot>, IDeepCloneable<CMsgClientToGCPurchaseFilteredPlayerSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)

#### Implements

IMessage<CMsgClientToGCPurchaseFilteredPlayerSlot\>, 
[IEquatable<CMsgClientToGCPurchaseFilteredPlayerSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPurchaseFilteredPlayerSlot\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPurchaseFilteredPlayerSlot\>\(CMsgClientToGCPurchaseFilteredPlayerSlot, params CMsgClientToGCPurchaseFilteredPlayerSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot__ctor"></a> CMsgClientToGCPurchaseFilteredPlayerSlot\(\)

```csharp
public CMsgClientToGCPurchaseFilteredPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_"></a> CMsgClientToGCPurchaseFilteredPlayerSlot\(CMsgClientToGCPurchaseFilteredPlayerSlot\)

```csharp
public CMsgClientToGCPurchaseFilteredPlayerSlot(CMsgClientToGCPurchaseFilteredPlayerSlot other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_AdditionalSlotsCurrentFieldNumber"></a> AdditionalSlotsCurrentFieldNumber

```csharp
public const int AdditionalSlotsCurrentFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_AdditionalSlotsCurrent"></a> AdditionalSlotsCurrent

```csharp
public int AdditionalSlotsCurrent { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_HasAdditionalSlotsCurrent"></a> HasAdditionalSlotsCurrent

```csharp
public bool HasAdditionalSlotsCurrent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPurchaseFilteredPlayerSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_ClearAdditionalSlotsCurrent"></a> ClearAdditionalSlotsCurrent\(\)

```csharp
public void ClearAdditionalSlotsCurrent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPurchaseFilteredPlayerSlot Clone()
```

#### Returns

 [CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_"></a> Equals\(CMsgClientToGCPurchaseFilteredPlayerSlot\)

```csharp
public bool Equals(CMsgClientToGCPurchaseFilteredPlayerSlot other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_"></a> MergeFrom\(CMsgClientToGCPurchaseFilteredPlayerSlot\)

```csharp
public void MergeFrom(CMsgClientToGCPurchaseFilteredPlayerSlot other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseFilteredPlayerSlot](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseFilteredPlayerSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseFilteredPlayerSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

