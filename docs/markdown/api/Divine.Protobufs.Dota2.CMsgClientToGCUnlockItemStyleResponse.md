# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse"></a> Class CMsgClientToGCUnlockItemStyleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnlockItemStyleResponse : IMessage<CMsgClientToGCUnlockItemStyleResponse>, IEquatable<CMsgClientToGCUnlockItemStyleResponse>, IDeepCloneable<CMsgClientToGCUnlockItemStyleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)

#### Implements

IMessage<CMsgClientToGCUnlockItemStyleResponse\>, 
[IEquatable<CMsgClientToGCUnlockItemStyleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnlockItemStyleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnlockItemStyleResponse\>\(CMsgClientToGCUnlockItemStyleResponse, params CMsgClientToGCUnlockItemStyleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse__ctor"></a> CMsgClientToGCUnlockItemStyleResponse\(\)

```csharp
public CMsgClientToGCUnlockItemStyleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_"></a> CMsgClientToGCUnlockItemStyleResponse\(CMsgClientToGCUnlockItemStyleResponse\)

```csharp
public CMsgClientToGCUnlockItemStyleResponse(CMsgClientToGCUnlockItemStyleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_StyleIndexFieldNumber"></a> StyleIndexFieldNumber

```csharp
public const int StyleIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_StylePrereqFieldNumber"></a> StylePrereqFieldNumber

```csharp
public const int StylePrereqFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_HasStyleIndex"></a> HasStyleIndex

```csharp
public bool HasStyleIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_HasStylePrereq"></a> HasStylePrereq

```csharp
public bool HasStylePrereq { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnlockItemStyleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Response"></a> Response

```csharp
public CMsgClientToGCUnlockItemStyleResponse.Types.EUnlockStyle Response { get; set; }
```

#### Property Value

 [CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.Types.md).[EUnlockStyle](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.Types.EUnlockStyle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_StyleIndex"></a> StyleIndex

```csharp
public uint StyleIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_StylePrereq"></a> StylePrereq

```csharp
public uint StylePrereq { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ClearStyleIndex"></a> ClearStyleIndex\(\)

```csharp
public void ClearStyleIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ClearStylePrereq"></a> ClearStylePrereq\(\)

```csharp
public void ClearStylePrereq()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnlockItemStyleResponse Clone()
```

#### Returns

 [CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_"></a> Equals\(CMsgClientToGCUnlockItemStyleResponse\)

```csharp
public bool Equals(CMsgClientToGCUnlockItemStyleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_"></a> MergeFrom\(CMsgClientToGCUnlockItemStyleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnlockItemStyleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnlockItemStyleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnlockItemStyleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockItemStyleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

