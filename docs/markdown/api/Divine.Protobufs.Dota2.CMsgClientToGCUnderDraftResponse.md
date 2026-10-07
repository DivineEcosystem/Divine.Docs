# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse"></a> Class CMsgClientToGCUnderDraftResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftResponse : IMessage<CMsgClientToGCUnderDraftResponse>, IEquatable<CMsgClientToGCUnderDraftResponse>, IDeepCloneable<CMsgClientToGCUnderDraftResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftResponse\>, 
[IEquatable<CMsgClientToGCUnderDraftResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftResponse\>\(CMsgClientToGCUnderDraftResponse, params CMsgClientToGCUnderDraftResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse__ctor"></a> CMsgClientToGCUnderDraftResponse\(\)

```csharp
public CMsgClientToGCUnderDraftResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_"></a> CMsgClientToGCUnderDraftResponse\(CMsgClientToGCUnderDraftResponse\)

```csharp
public CMsgClientToGCUnderDraftResponse(CMsgClientToGCUnderDraftResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_DraftDataFieldNumber"></a> DraftDataFieldNumber

```csharp
public const int DraftDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_DraftData"></a> DraftData

```csharp
public CMsgUnderDraftData DraftData { get; set; }
```

#### Property Value

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Result"></a> Result

```csharp
public EUnderDraftResponse Result { get; set; }
```

#### Property Value

 [EUnderDraftResponse](Divine.Protobufs.Dota2.EUnderDraftResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftResponse Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_"></a> Equals\(CMsgClientToGCUnderDraftResponse\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_"></a> MergeFrom\(CMsgClientToGCUnderDraftResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

