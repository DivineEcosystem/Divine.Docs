# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse"></a> Class CMsgClientToGCUnderDraftBuyResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftBuyResponse : IMessage<CMsgClientToGCUnderDraftBuyResponse>, IEquatable<CMsgClientToGCUnderDraftBuyResponse>, IDeepCloneable<CMsgClientToGCUnderDraftBuyResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftBuyResponse\>, 
[IEquatable<CMsgClientToGCUnderDraftBuyResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftBuyResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftBuyResponse\>\(CMsgClientToGCUnderDraftBuyResponse, params CMsgClientToGCUnderDraftBuyResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse__ctor"></a> CMsgClientToGCUnderDraftBuyResponse\(\)

```csharp
public CMsgClientToGCUnderDraftBuyResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_"></a> CMsgClientToGCUnderDraftBuyResponse\(CMsgClientToGCUnderDraftBuyResponse\)

```csharp
public CMsgClientToGCUnderDraftBuyResponse(CMsgClientToGCUnderDraftBuyResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_DraftDataFieldNumber"></a> DraftDataFieldNumber

```csharp
public const int DraftDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_DraftData"></a> DraftData

```csharp
public CMsgUnderDraftData DraftData { get; set; }
```

#### Property Value

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftBuyResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Result"></a> Result

```csharp
public EUnderDraftResponse Result { get; set; }
```

#### Property Value

 [EUnderDraftResponse](Divine.Protobufs.Dota2.EUnderDraftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftBuyResponse Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_"></a> Equals\(CMsgClientToGCUnderDraftBuyResponse\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftBuyResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_"></a> MergeFrom\(CMsgClientToGCUnderDraftBuyResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftBuyResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftBuyResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftBuyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftBuyResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

