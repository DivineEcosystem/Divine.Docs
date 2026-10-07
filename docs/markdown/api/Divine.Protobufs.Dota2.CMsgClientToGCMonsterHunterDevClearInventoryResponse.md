# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse"></a> Class CMsgClientToGCMonsterHunterDevClearInventoryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevClearInventoryResponse : IMessage<CMsgClientToGCMonsterHunterDevClearInventoryResponse>, IEquatable<CMsgClientToGCMonsterHunterDevClearInventoryResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterDevClearInventoryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevClearInventoryResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevClearInventoryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevClearInventoryResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevClearInventoryResponse\>\(CMsgClientToGCMonsterHunterDevClearInventoryResponse, params CMsgClientToGCMonsterHunterDevClearInventoryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse__ctor"></a> CMsgClientToGCMonsterHunterDevClearInventoryResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventoryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_"></a> CMsgClientToGCMonsterHunterDevClearInventoryResponse\(CMsgClientToGCMonsterHunterDevClearInventoryResponse\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventoryResponse(CMsgClientToGCMonsterHunterDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevClearInventoryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterDevClearInventoryResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventoryResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_"></a> Equals\(CMsgClientToGCMonsterHunterDevClearInventoryResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevClearInventoryResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventoryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

