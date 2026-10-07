# <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse"></a> Class CMsgGCToClientManageFavoritesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientManageFavoritesResponse : IMessage<CMsgGCToClientManageFavoritesResponse>, IEquatable<CMsgGCToClientManageFavoritesResponse>, IDeepCloneable<CMsgGCToClientManageFavoritesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)

#### Implements

IMessage<CMsgGCToClientManageFavoritesResponse\>, 
[IEquatable<CMsgGCToClientManageFavoritesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientManageFavoritesResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientManageFavoritesResponse\>\(CMsgGCToClientManageFavoritesResponse, params CMsgGCToClientManageFavoritesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse__ctor"></a> CMsgGCToClientManageFavoritesResponse\(\)

```csharp
public CMsgGCToClientManageFavoritesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_"></a> CMsgGCToClientManageFavoritesResponse\(CMsgGCToClientManageFavoritesResponse\)

```csharp
public CMsgGCToClientManageFavoritesResponse(CMsgGCToClientManageFavoritesResponse other)
```

#### Parameters

`other` [CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_DebugMessageFieldNumber"></a> DebugMessageFieldNumber

```csharp
public const int DebugMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_PlayerFieldNumber"></a> PlayerFieldNumber

```csharp
public const int PlayerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_DebugMessage"></a> DebugMessage

```csharp
public string DebugMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_HasDebugMessage"></a> HasDebugMessage

```csharp
public bool HasDebugMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientManageFavoritesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Player"></a> Player

```csharp
public CMsgPartySearchPlayer Player { get; set; }
```

#### Property Value

 [CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Response"></a> Response

```csharp
public CMsgGCToClientManageFavoritesResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_ClearDebugMessage"></a> ClearDebugMessage\(\)

```csharp
public void ClearDebugMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientManageFavoritesResponse Clone()
```

#### Returns

 [CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_"></a> Equals\(CMsgGCToClientManageFavoritesResponse\)

```csharp
public bool Equals(CMsgGCToClientManageFavoritesResponse other)
```

#### Parameters

`other` [CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_"></a> MergeFrom\(CMsgGCToClientManageFavoritesResponse\)

```csharp
public void MergeFrom(CMsgGCToClientManageFavoritesResponse other)
```

#### Parameters

`other` [CMsgGCToClientManageFavoritesResponse](Divine.Protobufs.Dota2.CMsgGCToClientManageFavoritesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientManageFavoritesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

