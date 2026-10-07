# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse"></a> Class CMsgClientToGCRequestAccountGuildEventDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestAccountGuildEventDataResponse : IMessage<CMsgClientToGCRequestAccountGuildEventDataResponse>, IEquatable<CMsgClientToGCRequestAccountGuildEventDataResponse>, IDeepCloneable<CMsgClientToGCRequestAccountGuildEventDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestAccountGuildEventDataResponse\>, 
[IEquatable<CMsgClientToGCRequestAccountGuildEventDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestAccountGuildEventDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestAccountGuildEventDataResponse\>\(CMsgClientToGCRequestAccountGuildEventDataResponse, params CMsgClientToGCRequestAccountGuildEventDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse__ctor"></a> CMsgClientToGCRequestAccountGuildEventDataResponse\(\)

```csharp
public CMsgClientToGCRequestAccountGuildEventDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_"></a> CMsgClientToGCRequestAccountGuildEventDataResponse\(CMsgClientToGCRequestAccountGuildEventDataResponse\)

```csharp
public CMsgClientToGCRequestAccountGuildEventDataResponse(CMsgClientToGCRequestAccountGuildEventDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_EventDataFieldNumber"></a> EventDataFieldNumber

```csharp
public const int EventDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_EventData"></a> EventData

```csharp
public CMsgAccountGuildEventData EventData { get; set; }
```

#### Property Value

 [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestAccountGuildEventDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestAccountGuildEventDataResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestAccountGuildEventDataResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_"></a> Equals\(CMsgClientToGCRequestAccountGuildEventDataResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestAccountGuildEventDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_"></a> MergeFrom\(CMsgClientToGCRequestAccountGuildEventDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestAccountGuildEventDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

