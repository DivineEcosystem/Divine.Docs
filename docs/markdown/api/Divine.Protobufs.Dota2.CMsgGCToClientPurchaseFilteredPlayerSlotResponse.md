# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse"></a> Class CMsgGCToClientPurchaseFilteredPlayerSlotResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPurchaseFilteredPlayerSlotResponse : IMessage<CMsgGCToClientPurchaseFilteredPlayerSlotResponse>, IEquatable<CMsgGCToClientPurchaseFilteredPlayerSlotResponse>, IDeepCloneable<CMsgGCToClientPurchaseFilteredPlayerSlotResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)

#### Implements

IMessage<CMsgGCToClientPurchaseFilteredPlayerSlotResponse\>, 
[IEquatable<CMsgGCToClientPurchaseFilteredPlayerSlotResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPurchaseFilteredPlayerSlotResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPurchaseFilteredPlayerSlotResponse\>\(CMsgGCToClientPurchaseFilteredPlayerSlotResponse, params CMsgGCToClientPurchaseFilteredPlayerSlotResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse__ctor"></a> CMsgGCToClientPurchaseFilteredPlayerSlotResponse\(\)

```csharp
public CMsgGCToClientPurchaseFilteredPlayerSlotResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_"></a> CMsgGCToClientPurchaseFilteredPlayerSlotResponse\(CMsgGCToClientPurchaseFilteredPlayerSlotResponse\)

```csharp
public CMsgGCToClientPurchaseFilteredPlayerSlotResponse(CMsgGCToClientPurchaseFilteredPlayerSlotResponse other)
```

#### Parameters

`other` [CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_AdditionalSlotsFieldNumber"></a> AdditionalSlotsFieldNumber

```csharp
public const int AdditionalSlotsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_NextSlotCostFieldNumber"></a> NextSlotCostFieldNumber

```csharp
public const int NextSlotCostFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_AdditionalSlots"></a> AdditionalSlots

```csharp
public int AdditionalSlots { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_HasAdditionalSlots"></a> HasAdditionalSlots

```csharp
public bool HasAdditionalSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_HasNextSlotCost"></a> HasNextSlotCost

```csharp
public bool HasNextSlotCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_NextSlotCost"></a> NextSlotCost

```csharp
public int NextSlotCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPurchaseFilteredPlayerSlotResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Result"></a> Result

```csharp
public CMsgGCToClientPurchaseFilteredPlayerSlotResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_ClearAdditionalSlots"></a> ClearAdditionalSlots\(\)

```csharp
public void ClearAdditionalSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_ClearNextSlotCost"></a> ClearNextSlotCost\(\)

```csharp
public void ClearNextSlotCost()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPurchaseFilteredPlayerSlotResponse Clone()
```

#### Returns

 [CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_"></a> Equals\(CMsgGCToClientPurchaseFilteredPlayerSlotResponse\)

```csharp
public bool Equals(CMsgGCToClientPurchaseFilteredPlayerSlotResponse other)
```

#### Parameters

`other` [CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_"></a> MergeFrom\(CMsgGCToClientPurchaseFilteredPlayerSlotResponse\)

```csharp
public void MergeFrom(CMsgGCToClientPurchaseFilteredPlayerSlotResponse other)
```

#### Parameters

`other` [CMsgGCToClientPurchaseFilteredPlayerSlotResponse](Divine.Protobufs.Dota2.CMsgGCToClientPurchaseFilteredPlayerSlotResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPurchaseFilteredPlayerSlotResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

