# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse"></a> Class CMsgClientToGCShowcaseModerationGetQueueResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseModerationGetQueueResponse : IMessage<CMsgClientToGCShowcaseModerationGetQueueResponse>, IEquatable<CMsgClientToGCShowcaseModerationGetQueueResponse>, IDeepCloneable<CMsgClientToGCShowcaseModerationGetQueueResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseModerationGetQueueResponse\>, 
[IEquatable<CMsgClientToGCShowcaseModerationGetQueueResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseModerationGetQueueResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseModerationGetQueueResponse\>\(CMsgClientToGCShowcaseModerationGetQueueResponse, params CMsgClientToGCShowcaseModerationGetQueueResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse__ctor"></a> CMsgClientToGCShowcaseModerationGetQueueResponse\(\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueueResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_"></a> CMsgClientToGCShowcaseModerationGetQueueResponse\(CMsgClientToGCShowcaseModerationGetQueueResponse\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueueResponse(CMsgClientToGCShowcaseModerationGetQueueResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_ShowcasesFieldNumber"></a> ShowcasesFieldNumber

```csharp
public const int ShowcasesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseModerationGetQueueResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseModerationGetQueueResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Showcases"></a> Showcases

```csharp
public RepeatedField<CMsgShowcaseModerationInfo> Showcases { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueueResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_"></a> Equals\(CMsgClientToGCShowcaseModerationGetQueueResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseModerationGetQueueResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseModerationGetQueueResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseModerationGetQueueResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueueResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueueResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueueResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

