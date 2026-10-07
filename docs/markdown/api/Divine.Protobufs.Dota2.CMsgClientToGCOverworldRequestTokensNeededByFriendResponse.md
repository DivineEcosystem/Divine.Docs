# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse"></a> Class CMsgClientToGCOverworldRequestTokensNeededByFriendResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldRequestTokensNeededByFriendResponse : IMessage<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse>, IEquatable<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse>, IDeepCloneable<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\>, 
[IEquatable<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\>\(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse, params CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse__ctor"></a> CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\(\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriendResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_"></a> CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriendResponse(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_TokenQuantityFieldNumber"></a> TokenQuantityFieldNumber

```csharp
public const int TokenQuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldRequestTokensNeededByFriendResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_TokenQuantity"></a> TokenQuantity

```csharp
public CMsgOverworldTokenQuantity TokenQuantity { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriendResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_"></a> Equals\(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_"></a> MergeFrom\(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriendResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

