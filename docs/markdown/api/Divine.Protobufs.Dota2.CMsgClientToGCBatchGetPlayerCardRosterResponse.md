# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse"></a> Class CMsgClientToGCBatchGetPlayerCardRosterResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBatchGetPlayerCardRosterResponse : IMessage<CMsgClientToGCBatchGetPlayerCardRosterResponse>, IEquatable<CMsgClientToGCBatchGetPlayerCardRosterResponse>, IDeepCloneable<CMsgClientToGCBatchGetPlayerCardRosterResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)

#### Implements

IMessage<CMsgClientToGCBatchGetPlayerCardRosterResponse\>, 
[IEquatable<CMsgClientToGCBatchGetPlayerCardRosterResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBatchGetPlayerCardRosterResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBatchGetPlayerCardRosterResponse\>\(CMsgClientToGCBatchGetPlayerCardRosterResponse, params CMsgClientToGCBatchGetPlayerCardRosterResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse__ctor"></a> CMsgClientToGCBatchGetPlayerCardRosterResponse\(\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_"></a> CMsgClientToGCBatchGetPlayerCardRosterResponse\(CMsgClientToGCBatchGetPlayerCardRosterResponse\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterResponse(CMsgClientToGCBatchGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_ResponsesFieldNumber"></a> ResponsesFieldNumber

```csharp
public const int ResponsesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBatchGetPlayerCardRosterResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Responses"></a> Responses

```csharp
public RepeatedField<CMsgClientToGCBatchGetPlayerCardRosterResponse.Types.RosterResponse> Responses { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.Types.md).[RosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.Types.RosterResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterResponse Clone()
```

#### Returns

 [CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_"></a> Equals\(CMsgClientToGCBatchGetPlayerCardRosterResponse\)

```csharp
public bool Equals(CMsgClientToGCBatchGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_"></a> MergeFrom\(CMsgClientToGCBatchGetPlayerCardRosterResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBatchGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

