# <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse"></a> Class CMsgGCToClientJoinPartyFromBeaconResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientJoinPartyFromBeaconResponse : IMessage<CMsgGCToClientJoinPartyFromBeaconResponse>, IEquatable<CMsgGCToClientJoinPartyFromBeaconResponse>, IDeepCloneable<CMsgGCToClientJoinPartyFromBeaconResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)

#### Implements

IMessage<CMsgGCToClientJoinPartyFromBeaconResponse\>, 
[IEquatable<CMsgGCToClientJoinPartyFromBeaconResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientJoinPartyFromBeaconResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientJoinPartyFromBeaconResponse\>\(CMsgGCToClientJoinPartyFromBeaconResponse, params CMsgGCToClientJoinPartyFromBeaconResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse__ctor"></a> CMsgGCToClientJoinPartyFromBeaconResponse\(\)

```csharp
public CMsgGCToClientJoinPartyFromBeaconResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_"></a> CMsgGCToClientJoinPartyFromBeaconResponse\(CMsgGCToClientJoinPartyFromBeaconResponse\)

```csharp
public CMsgGCToClientJoinPartyFromBeaconResponse(CMsgGCToClientJoinPartyFromBeaconResponse other)
```

#### Parameters

`other` [CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientJoinPartyFromBeaconResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Response"></a> Response

```csharp
public CMsgGCToClientJoinPartyFromBeaconResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientJoinPartyFromBeaconResponse Clone()
```

#### Returns

 [CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_"></a> Equals\(CMsgGCToClientJoinPartyFromBeaconResponse\)

```csharp
public bool Equals(CMsgGCToClientJoinPartyFromBeaconResponse other)
```

#### Parameters

`other` [CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_"></a> MergeFrom\(CMsgGCToClientJoinPartyFromBeaconResponse\)

```csharp
public void MergeFrom(CMsgGCToClientJoinPartyFromBeaconResponse other)
```

#### Parameters

`other` [CMsgGCToClientJoinPartyFromBeaconResponse](Divine.Protobufs.Dota2.CMsgGCToClientJoinPartyFromBeaconResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientJoinPartyFromBeaconResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

