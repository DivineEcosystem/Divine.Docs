# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse"></a> Class CMsgClientToGCRoadToTIGetActiveQuestResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRoadToTIGetActiveQuestResponse : IMessage<CMsgClientToGCRoadToTIGetActiveQuestResponse>, IEquatable<CMsgClientToGCRoadToTIGetActiveQuestResponse>, IDeepCloneable<CMsgClientToGCRoadToTIGetActiveQuestResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)

#### Implements

IMessage<CMsgClientToGCRoadToTIGetActiveQuestResponse\>, 
[IEquatable<CMsgClientToGCRoadToTIGetActiveQuestResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRoadToTIGetActiveQuestResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRoadToTIGetActiveQuestResponse\>\(CMsgClientToGCRoadToTIGetActiveQuestResponse, params CMsgClientToGCRoadToTIGetActiveQuestResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse__ctor"></a> CMsgClientToGCRoadToTIGetActiveQuestResponse\(\)

```csharp
public CMsgClientToGCRoadToTIGetActiveQuestResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_"></a> CMsgClientToGCRoadToTIGetActiveQuestResponse\(CMsgClientToGCRoadToTIGetActiveQuestResponse\)

```csharp
public CMsgClientToGCRoadToTIGetActiveQuestResponse(CMsgClientToGCRoadToTIGetActiveQuestResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_QuestDataFieldNumber"></a> QuestDataFieldNumber

```csharp
public const int QuestDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRoadToTIGetActiveQuestResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_QuestData"></a> QuestData

```csharp
public CMsgRoadToTIAssignedQuest QuestData { get; set; }
```

#### Property Value

 [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Response"></a> Response

```csharp
public CMsgClientToGCRoadToTIGetActiveQuestResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRoadToTIGetActiveQuestResponse Clone()
```

#### Returns

 [CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_"></a> Equals\(CMsgClientToGCRoadToTIGetActiveQuestResponse\)

```csharp
public bool Equals(CMsgClientToGCRoadToTIGetActiveQuestResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_"></a> MergeFrom\(CMsgClientToGCRoadToTIGetActiveQuestResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRoadToTIGetActiveQuestResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetActiveQuestResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetActiveQuestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetActiveQuestResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

