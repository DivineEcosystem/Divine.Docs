# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse"></a> Class CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse : IMessage<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse>, IEquatable<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\>\(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse, params CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse__ctor"></a> CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_"></a> CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\)

```csharp
public CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_TokenQuantityFieldNumber"></a> TokenQuantityFieldNumber

```csharp
public const int TokenQuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_TokenQuantity"></a> TokenQuantity

```csharp
public CMsgMonsterHunterMaterialQuantity TokenQuantity { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_"></a> Equals\(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterRequestMaterialsNeededByFriendResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

