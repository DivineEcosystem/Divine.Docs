# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse"></a> Class CMsgClientToGCOverworldFeedbackResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldFeedbackResponse : IMessage<CMsgClientToGCOverworldFeedbackResponse>, IEquatable<CMsgClientToGCOverworldFeedbackResponse>, IDeepCloneable<CMsgClientToGCOverworldFeedbackResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldFeedbackResponse\>, 
[IEquatable<CMsgClientToGCOverworldFeedbackResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldFeedbackResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldFeedbackResponse\>\(CMsgClientToGCOverworldFeedbackResponse, params CMsgClientToGCOverworldFeedbackResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse__ctor"></a> CMsgClientToGCOverworldFeedbackResponse\(\)

```csharp
public CMsgClientToGCOverworldFeedbackResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_"></a> CMsgClientToGCOverworldFeedbackResponse\(CMsgClientToGCOverworldFeedbackResponse\)

```csharp
public CMsgClientToGCOverworldFeedbackResponse(CMsgClientToGCOverworldFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldFeedbackResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldFeedbackResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldFeedbackResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_"></a> Equals\(CMsgClientToGCOverworldFeedbackResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_"></a> MergeFrom\(CMsgClientToGCOverworldFeedbackResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldFeedbackResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldFeedbackResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldFeedbackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldFeedbackResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

