# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse"></a> Class CMsgClientToGCUnderDraftRerollResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftRerollResponse : IMessage<CMsgClientToGCUnderDraftRerollResponse>, IEquatable<CMsgClientToGCUnderDraftRerollResponse>, IDeepCloneable<CMsgClientToGCUnderDraftRerollResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftRerollResponse\>, 
[IEquatable<CMsgClientToGCUnderDraftRerollResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftRerollResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftRerollResponse\>\(CMsgClientToGCUnderDraftRerollResponse, params CMsgClientToGCUnderDraftRerollResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse__ctor"></a> CMsgClientToGCUnderDraftRerollResponse\(\)

```csharp
public CMsgClientToGCUnderDraftRerollResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_"></a> CMsgClientToGCUnderDraftRerollResponse\(CMsgClientToGCUnderDraftRerollResponse\)

```csharp
public CMsgClientToGCUnderDraftRerollResponse(CMsgClientToGCUnderDraftRerollResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_DraftDataFieldNumber"></a> DraftDataFieldNumber

```csharp
public const int DraftDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_DraftData"></a> DraftData

```csharp
public CMsgUnderDraftData DraftData { get; set; }
```

#### Property Value

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftRerollResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Result"></a> Result

```csharp
public EUnderDraftResponse Result { get; set; }
```

#### Property Value

 [EUnderDraftResponse](Divine.Protobufs.Dota2.EUnderDraftResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftRerollResponse Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_"></a> Equals\(CMsgClientToGCUnderDraftRerollResponse\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftRerollResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_"></a> MergeFrom\(CMsgClientToGCUnderDraftRerollResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftRerollResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRerollResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRerollResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRerollResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

