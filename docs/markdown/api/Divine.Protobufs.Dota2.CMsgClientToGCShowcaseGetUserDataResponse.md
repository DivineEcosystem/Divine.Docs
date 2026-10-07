# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse"></a> Class CMsgClientToGCShowcaseGetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseGetUserDataResponse : IMessage<CMsgClientToGCShowcaseGetUserDataResponse>, IEquatable<CMsgClientToGCShowcaseGetUserDataResponse>, IDeepCloneable<CMsgClientToGCShowcaseGetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseGetUserDataResponse\>, 
[IEquatable<CMsgClientToGCShowcaseGetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseGetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseGetUserDataResponse\>\(CMsgClientToGCShowcaseGetUserDataResponse, params CMsgClientToGCShowcaseGetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse__ctor"></a> CMsgClientToGCShowcaseGetUserDataResponse\(\)

```csharp
public CMsgClientToGCShowcaseGetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_"></a> CMsgClientToGCShowcaseGetUserDataResponse\(CMsgClientToGCShowcaseGetUserDataResponse\)

```csharp
public CMsgClientToGCShowcaseGetUserDataResponse(CMsgClientToGCShowcaseGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_ShowcaseFieldNumber"></a> ShowcaseFieldNumber

```csharp
public const int ShowcaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseGetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseGetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Showcase"></a> Showcase

```csharp
public CMsgShowcase Showcase { get; set; }
```

#### Property Value

 [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseGetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_"></a> Equals\(CMsgClientToGCShowcaseGetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseGetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseGetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

