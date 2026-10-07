# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse"></a> Class CMsgClientToGCOrderStickerbookTeamPageResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOrderStickerbookTeamPageResponse : IMessage<CMsgClientToGCOrderStickerbookTeamPageResponse>, IEquatable<CMsgClientToGCOrderStickerbookTeamPageResponse>, IDeepCloneable<CMsgClientToGCOrderStickerbookTeamPageResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)

#### Implements

IMessage<CMsgClientToGCOrderStickerbookTeamPageResponse\>, 
[IEquatable<CMsgClientToGCOrderStickerbookTeamPageResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOrderStickerbookTeamPageResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOrderStickerbookTeamPageResponse\>\(CMsgClientToGCOrderStickerbookTeamPageResponse, params CMsgClientToGCOrderStickerbookTeamPageResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse__ctor"></a> CMsgClientToGCOrderStickerbookTeamPageResponse\(\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_"></a> CMsgClientToGCOrderStickerbookTeamPageResponse\(CMsgClientToGCOrderStickerbookTeamPageResponse\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageResponse(CMsgClientToGCOrderStickerbookTeamPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOrderStickerbookTeamPageResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Response"></a> Response

```csharp
public CMsgClientToGCOrderStickerbookTeamPageResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageResponse Clone()
```

#### Returns

 [CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_"></a> Equals\(CMsgClientToGCOrderStickerbookTeamPageResponse\)

```csharp
public bool Equals(CMsgClientToGCOrderStickerbookTeamPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_"></a> MergeFrom\(CMsgClientToGCOrderStickerbookTeamPageResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOrderStickerbookTeamPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

