# <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse"></a> Class CMsgGCHAppCheersGetAllowedTypesResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAppCheersGetAllowedTypesResponse : IMessage<CMsgGCHAppCheersGetAllowedTypesResponse>, IEquatable<CMsgGCHAppCheersGetAllowedTypesResponse>, IDeepCloneable<CMsgGCHAppCheersGetAllowedTypesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)

#### Implements

IMessage<CMsgGCHAppCheersGetAllowedTypesResponse\>, 
[IEquatable<CMsgGCHAppCheersGetAllowedTypesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAppCheersGetAllowedTypesResponse\>, 
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
[EnumerableExtensions.In<CMsgGCHAppCheersGetAllowedTypesResponse\>\(CMsgGCHAppCheersGetAllowedTypesResponse, params CMsgGCHAppCheersGetAllowedTypesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse__ctor"></a> CMsgGCHAppCheersGetAllowedTypesResponse\(\)

```csharp
public CMsgGCHAppCheersGetAllowedTypesResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse__ctor_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_"></a> CMsgGCHAppCheersGetAllowedTypesResponse\(CMsgGCHAppCheersGetAllowedTypesResponse\)

```csharp
public CMsgGCHAppCheersGetAllowedTypesResponse(CMsgGCHAppCheersGetAllowedTypesResponse other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CacheDurationFieldNumber"></a> CacheDurationFieldNumber

```csharp
public const int CacheDurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CheerRemapsFieldNumber"></a> CheerRemapsFieldNumber

```csharp
public const int CheerRemapsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CheerTypesValidAllUsersFieldNumber"></a> CheerTypesValidAllUsersFieldNumber

```csharp
public const int CheerTypesValidAllUsersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CacheDuration"></a> CacheDuration

```csharp
public uint CacheDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CheerRemaps"></a> CheerRemaps

```csharp
public RepeatedField<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps> CheerRemaps { get; }
```

#### Property Value

 RepeatedField<[CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CheerTypesValidAllUsers"></a> CheerTypesValidAllUsers

```csharp
public RepeatedField<uint> CheerTypesValidAllUsers { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_HasCacheDuration"></a> HasCacheDuration

```csharp
public bool HasCacheDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAppCheersGetAllowedTypesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_ClearCacheDuration"></a> ClearCacheDuration\(\)

```csharp
public void ClearCacheDuration()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAppCheersGetAllowedTypesResponse Clone()
```

#### Returns

 [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Equals_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_"></a> Equals\(CMsgGCHAppCheersGetAllowedTypesResponse\)

```csharp
public bool Equals(CMsgGCHAppCheersGetAllowedTypesResponse other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_"></a> MergeFrom\(CMsgGCHAppCheersGetAllowedTypesResponse\)

```csharp
public void MergeFrom(CMsgGCHAppCheersGetAllowedTypesResponse other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

