# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse"></a> Class CMsgClientToGCOverworldMoveToNodeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldMoveToNodeResponse : IMessage<CMsgClientToGCOverworldMoveToNodeResponse>, IEquatable<CMsgClientToGCOverworldMoveToNodeResponse>, IDeepCloneable<CMsgClientToGCOverworldMoveToNodeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldMoveToNodeResponse\>, 
[IEquatable<CMsgClientToGCOverworldMoveToNodeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldMoveToNodeResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldMoveToNodeResponse\>\(CMsgClientToGCOverworldMoveToNodeResponse, params CMsgClientToGCOverworldMoveToNodeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse__ctor"></a> CMsgClientToGCOverworldMoveToNodeResponse\(\)

```csharp
public CMsgClientToGCOverworldMoveToNodeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_"></a> CMsgClientToGCOverworldMoveToNodeResponse\(CMsgClientToGCOverworldMoveToNodeResponse\)

```csharp
public CMsgClientToGCOverworldMoveToNodeResponse(CMsgClientToGCOverworldMoveToNodeResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldMoveToNodeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldMoveToNodeResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldMoveToNodeResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_"></a> Equals\(CMsgClientToGCOverworldMoveToNodeResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldMoveToNodeResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_"></a> MergeFrom\(CMsgClientToGCOverworldMoveToNodeResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldMoveToNodeResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMoveToNodeResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMoveToNodeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMoveToNodeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

