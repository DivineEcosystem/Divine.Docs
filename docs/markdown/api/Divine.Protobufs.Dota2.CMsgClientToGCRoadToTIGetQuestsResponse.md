# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse"></a> Class CMsgClientToGCRoadToTIGetQuestsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRoadToTIGetQuestsResponse : IMessage<CMsgClientToGCRoadToTIGetQuestsResponse>, IEquatable<CMsgClientToGCRoadToTIGetQuestsResponse>, IDeepCloneable<CMsgClientToGCRoadToTIGetQuestsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)

#### Implements

IMessage<CMsgClientToGCRoadToTIGetQuestsResponse\>, 
[IEquatable<CMsgClientToGCRoadToTIGetQuestsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRoadToTIGetQuestsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRoadToTIGetQuestsResponse\>\(CMsgClientToGCRoadToTIGetQuestsResponse, params CMsgClientToGCRoadToTIGetQuestsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse__ctor"></a> CMsgClientToGCRoadToTIGetQuestsResponse\(\)

```csharp
public CMsgClientToGCRoadToTIGetQuestsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_"></a> CMsgClientToGCRoadToTIGetQuestsResponse\(CMsgClientToGCRoadToTIGetQuestsResponse\)

```csharp
public CMsgClientToGCRoadToTIGetQuestsResponse(CMsgClientToGCRoadToTIGetQuestsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_QuestDataFieldNumber"></a> QuestDataFieldNumber

```csharp
public const int QuestDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRoadToTIGetQuestsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_QuestData"></a> QuestData

```csharp
public CMsgRoadToTIUserData QuestData { get; set; }
```

#### Property Value

 [CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Response"></a> Response

```csharp
public CMsgClientToGCRoadToTIGetQuestsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRoadToTIGetQuestsResponse Clone()
```

#### Returns

 [CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_"></a> Equals\(CMsgClientToGCRoadToTIGetQuestsResponse\)

```csharp
public bool Equals(CMsgClientToGCRoadToTIGetQuestsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_"></a> MergeFrom\(CMsgClientToGCRoadToTIGetQuestsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRoadToTIGetQuestsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuestsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuestsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuestsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

