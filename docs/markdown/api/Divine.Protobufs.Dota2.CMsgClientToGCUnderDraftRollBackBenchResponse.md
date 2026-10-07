# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse"></a> Class CMsgClientToGCUnderDraftRollBackBenchResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftRollBackBenchResponse : IMessage<CMsgClientToGCUnderDraftRollBackBenchResponse>, IEquatable<CMsgClientToGCUnderDraftRollBackBenchResponse>, IDeepCloneable<CMsgClientToGCUnderDraftRollBackBenchResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftRollBackBenchResponse\>, 
[IEquatable<CMsgClientToGCUnderDraftRollBackBenchResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftRollBackBenchResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftRollBackBenchResponse\>\(CMsgClientToGCUnderDraftRollBackBenchResponse, params CMsgClientToGCUnderDraftRollBackBenchResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse__ctor"></a> CMsgClientToGCUnderDraftRollBackBenchResponse\(\)

```csharp
public CMsgClientToGCUnderDraftRollBackBenchResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_"></a> CMsgClientToGCUnderDraftRollBackBenchResponse\(CMsgClientToGCUnderDraftRollBackBenchResponse\)

```csharp
public CMsgClientToGCUnderDraftRollBackBenchResponse(CMsgClientToGCUnderDraftRollBackBenchResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_DraftDataFieldNumber"></a> DraftDataFieldNumber

```csharp
public const int DraftDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_DraftData"></a> DraftData

```csharp
public CMsgUnderDraftData DraftData { get; set; }
```

#### Property Value

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftRollBackBenchResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Result"></a> Result

```csharp
public EUnderDraftResponse Result { get; set; }
```

#### Property Value

 [EUnderDraftResponse](Divine.Protobufs.Dota2.EUnderDraftResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftRollBackBenchResponse Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_"></a> Equals\(CMsgClientToGCUnderDraftRollBackBenchResponse\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftRollBackBenchResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_"></a> MergeFrom\(CMsgClientToGCUnderDraftRollBackBenchResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftRollBackBenchResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRollBackBenchResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRollBackBenchResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRollBackBenchResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

