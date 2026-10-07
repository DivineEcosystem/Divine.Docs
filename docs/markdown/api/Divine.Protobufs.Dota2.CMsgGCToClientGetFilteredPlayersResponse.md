# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse"></a> Class CMsgGCToClientGetFilteredPlayersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGetFilteredPlayersResponse : IMessage<CMsgGCToClientGetFilteredPlayersResponse>, IEquatable<CMsgGCToClientGetFilteredPlayersResponse>, IDeepCloneable<CMsgGCToClientGetFilteredPlayersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)

#### Implements

IMessage<CMsgGCToClientGetFilteredPlayersResponse\>, 
[IEquatable<CMsgGCToClientGetFilteredPlayersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGetFilteredPlayersResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGetFilteredPlayersResponse\>\(CMsgGCToClientGetFilteredPlayersResponse, params CMsgGCToClientGetFilteredPlayersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse__ctor"></a> CMsgGCToClientGetFilteredPlayersResponse\(\)

```csharp
public CMsgGCToClientGetFilteredPlayersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_"></a> CMsgGCToClientGetFilteredPlayersResponse\(CMsgGCToClientGetFilteredPlayersResponse\)

```csharp
public CMsgGCToClientGetFilteredPlayersResponse(CMsgGCToClientGetFilteredPlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_AdditionalSlotsFieldNumber"></a> AdditionalSlotsFieldNumber

```csharp
public const int AdditionalSlotsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_BaseSlotsFieldNumber"></a> BaseSlotsFieldNumber

```csharp
public const int BaseSlotsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_FilteredPlayersFieldNumber"></a> FilteredPlayersFieldNumber

```csharp
public const int FilteredPlayersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_NextSlotCostFieldNumber"></a> NextSlotCostFieldNumber

```csharp
public const int NextSlotCostFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_AdditionalSlots"></a> AdditionalSlots

```csharp
public int AdditionalSlots { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_BaseSlots"></a> BaseSlots

```csharp
public int BaseSlots { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_FilteredPlayers"></a> FilteredPlayers

```csharp
public RepeatedField<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry> FilteredPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_HasAdditionalSlots"></a> HasAdditionalSlots

```csharp
public bool HasAdditionalSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_HasBaseSlots"></a> HasBaseSlots

```csharp
public bool HasBaseSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_HasNextSlotCost"></a> HasNextSlotCost

```csharp
public bool HasNextSlotCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_NextSlotCost"></a> NextSlotCost

```csharp
public int NextSlotCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGetFilteredPlayersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Result"></a> Result

```csharp
public CMsgGCToClientGetFilteredPlayersResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ClearAdditionalSlots"></a> ClearAdditionalSlots\(\)

```csharp
public void ClearAdditionalSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ClearBaseSlots"></a> ClearBaseSlots\(\)

```csharp
public void ClearBaseSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ClearNextSlotCost"></a> ClearNextSlotCost\(\)

```csharp
public void ClearNextSlotCost()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGetFilteredPlayersResponse Clone()
```

#### Returns

 [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_"></a> Equals\(CMsgGCToClientGetFilteredPlayersResponse\)

```csharp
public bool Equals(CMsgGCToClientGetFilteredPlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_"></a> MergeFrom\(CMsgGCToClientGetFilteredPlayersResponse\)

```csharp
public void MergeFrom(CMsgGCToClientGetFilteredPlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

