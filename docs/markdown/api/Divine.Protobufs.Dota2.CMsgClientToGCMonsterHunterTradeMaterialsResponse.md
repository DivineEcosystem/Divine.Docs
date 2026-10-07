# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse"></a> Class CMsgClientToGCMonsterHunterTradeMaterialsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterTradeMaterialsResponse : IMessage<CMsgClientToGCMonsterHunterTradeMaterialsResponse>, IEquatable<CMsgClientToGCMonsterHunterTradeMaterialsResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterTradeMaterialsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterTradeMaterialsResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterTradeMaterialsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterTradeMaterialsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterTradeMaterialsResponse\>\(CMsgClientToGCMonsterHunterTradeMaterialsResponse, params CMsgClientToGCMonsterHunterTradeMaterialsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse__ctor"></a> CMsgClientToGCMonsterHunterTradeMaterialsResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterialsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_"></a> CMsgClientToGCMonsterHunterTradeMaterialsResponse\(CMsgClientToGCMonsterHunterTradeMaterialsResponse\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterialsResponse(CMsgClientToGCMonsterHunterTradeMaterialsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_MaterialsReceivedFieldNumber"></a> MaterialsReceivedFieldNumber

```csharp
public const int MaterialsReceivedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_MaterialsReceived"></a> MaterialsReceived

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialsReceived { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterTradeMaterialsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterTradeMaterialsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterialsResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_"></a> Equals\(CMsgClientToGCMonsterHunterTradeMaterialsResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterTradeMaterialsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterTradeMaterialsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterTradeMaterialsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterialsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterialsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterialsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

