# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip"></a> Class CDOTAMatchMetadata.Types.Tip

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Tip : IMessage<CDOTAMatchMetadata.Types.Tip>, IEquatable<CDOTAMatchMetadata.Types.Tip>, IDeepCloneable<CDOTAMatchMetadata.Types.Tip>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Tip\>, 
[IEquatable<CDOTAMatchMetadata.Types.Tip\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Tip\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Tip\>\(CDOTAMatchMetadata.Types.Tip, params CDOTAMatchMetadata.Types.Tip\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip__ctor"></a> Tip\(\)

```csharp
public Tip()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_"></a> Tip\(Tip\)

```csharp
public Tip(CDOTAMatchMetadata.Types.Tip other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_SourcePlayerSlotFieldNumber"></a> SourcePlayerSlotFieldNumber

```csharp
public const int SourcePlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_TargetPlayerSlotFieldNumber"></a> TargetPlayerSlotFieldNumber

```csharp
public const int TargetPlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_TipAmountFieldNumber"></a> TipAmountFieldNumber

```csharp
public const int TipAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_HasSourcePlayerSlot"></a> HasSourcePlayerSlot

```csharp
public bool HasSourcePlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_HasTargetPlayerSlot"></a> HasTargetPlayerSlot

```csharp
public bool HasTargetPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_HasTipAmount"></a> HasTipAmount

```csharp
public bool HasTipAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Tip> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_SourcePlayerSlot"></a> SourcePlayerSlot

```csharp
public uint SourcePlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_TargetPlayerSlot"></a> TargetPlayerSlot

```csharp
public uint TargetPlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_TipAmount"></a> TipAmount

```csharp
public uint TipAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_ClearSourcePlayerSlot"></a> ClearSourcePlayerSlot\(\)

```csharp
public void ClearSourcePlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_ClearTargetPlayerSlot"></a> ClearTargetPlayerSlot\(\)

```csharp
public void ClearTargetPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_ClearTipAmount"></a> ClearTipAmount\(\)

```csharp
public void ClearTipAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Tip Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_"></a> Equals\(Tip\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Tip other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_"></a> MergeFrom\(Tip\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Tip other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Tip_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

