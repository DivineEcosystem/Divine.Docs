# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse"></a> Class CMsgClientToGCCraftworksCraftRecipeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCraftworksCraftRecipeResponse : IMessage<CMsgClientToGCCraftworksCraftRecipeResponse>, IEquatable<CMsgClientToGCCraftworksCraftRecipeResponse>, IDeepCloneable<CMsgClientToGCCraftworksCraftRecipeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)

#### Implements

IMessage<CMsgClientToGCCraftworksCraftRecipeResponse\>, 
[IEquatable<CMsgClientToGCCraftworksCraftRecipeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCraftworksCraftRecipeResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCraftworksCraftRecipeResponse\>\(CMsgClientToGCCraftworksCraftRecipeResponse, params CMsgClientToGCCraftworksCraftRecipeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse__ctor"></a> CMsgClientToGCCraftworksCraftRecipeResponse\(\)

```csharp
public CMsgClientToGCCraftworksCraftRecipeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_"></a> CMsgClientToGCCraftworksCraftRecipeResponse\(CMsgClientToGCCraftworksCraftRecipeResponse\)

```csharp
public CMsgClientToGCCraftworksCraftRecipeResponse(CMsgClientToGCCraftworksCraftRecipeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCraftworksCraftRecipeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Response"></a> Response

```csharp
public CMsgClientToGCCraftworksCraftRecipeResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCraftworksCraftRecipeResponse Clone()
```

#### Returns

 [CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_"></a> Equals\(CMsgClientToGCCraftworksCraftRecipeResponse\)

```csharp
public bool Equals(CMsgClientToGCCraftworksCraftRecipeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_"></a> MergeFrom\(CMsgClientToGCCraftworksCraftRecipeResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCraftworksCraftRecipeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksCraftRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksCraftRecipeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksCraftRecipeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

