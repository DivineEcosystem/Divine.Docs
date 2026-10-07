# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse"></a> Class CMsgClientToGCMonsterHunterFeedbackResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterFeedbackResponse : IMessage<CMsgClientToGCMonsterHunterFeedbackResponse>, IEquatable<CMsgClientToGCMonsterHunterFeedbackResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterFeedbackResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterFeedbackResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterFeedbackResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterFeedbackResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterFeedbackResponse\>\(CMsgClientToGCMonsterHunterFeedbackResponse, params CMsgClientToGCMonsterHunterFeedbackResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse__ctor"></a> CMsgClientToGCMonsterHunterFeedbackResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterFeedbackResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_"></a> CMsgClientToGCMonsterHunterFeedbackResponse\(CMsgClientToGCMonsterHunterFeedbackResponse\)

```csharp
public CMsgClientToGCMonsterHunterFeedbackResponse(CMsgClientToGCMonsterHunterFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterFeedbackResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterFeedbackResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterFeedbackResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_"></a> Equals\(CMsgClientToGCMonsterHunterFeedbackResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterFeedbackResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterFeedbackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterFeedbackResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

