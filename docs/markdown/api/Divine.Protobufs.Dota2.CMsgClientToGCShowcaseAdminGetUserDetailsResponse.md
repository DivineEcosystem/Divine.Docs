# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse"></a> Class CMsgClientToGCShowcaseAdminGetUserDetailsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminGetUserDetailsResponse : IMessage<CMsgClientToGCShowcaseAdminGetUserDetailsResponse>, IEquatable<CMsgClientToGCShowcaseAdminGetUserDetailsResponse>, IDeepCloneable<CMsgClientToGCShowcaseAdminGetUserDetailsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminGetUserDetailsResponse\>, 
[IEquatable<CMsgClientToGCShowcaseAdminGetUserDetailsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminGetUserDetailsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminGetUserDetailsResponse\>\(CMsgClientToGCShowcaseAdminGetUserDetailsResponse, params CMsgClientToGCShowcaseAdminGetUserDetailsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse__ctor"></a> CMsgClientToGCShowcaseAdminGetUserDetailsResponse\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetailsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_"></a> CMsgClientToGCShowcaseAdminGetUserDetailsResponse\(CMsgClientToGCShowcaseAdminGetUserDetailsResponse\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetailsResponse(CMsgClientToGCShowcaseAdminGetUserDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_UserDetailsFieldNumber"></a> UserDetailsFieldNumber

```csharp
public const int UserDetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminGetUserDetailsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetailsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_UserDetails"></a> UserDetails

```csharp
public CMsgShowcaseAdminUserDetails UserDetails { get; set; }
```

#### Property Value

 [CMsgShowcaseAdminUserDetails](Divine.Protobufs.Dota2.CMsgShowcaseAdminUserDetails.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetailsResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_"></a> Equals\(CMsgClientToGCShowcaseAdminGetUserDetailsResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminGetUserDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminGetUserDetailsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminGetUserDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetailsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

