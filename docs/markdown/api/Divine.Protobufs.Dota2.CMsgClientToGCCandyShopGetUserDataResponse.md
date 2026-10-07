# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse"></a> Class CMsgClientToGCCandyShopGetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopGetUserDataResponse : IMessage<CMsgClientToGCCandyShopGetUserDataResponse>, IEquatable<CMsgClientToGCCandyShopGetUserDataResponse>, IDeepCloneable<CMsgClientToGCCandyShopGetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCCandyShopGetUserDataResponse\>, 
[IEquatable<CMsgClientToGCCandyShopGetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopGetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopGetUserDataResponse\>\(CMsgClientToGCCandyShopGetUserDataResponse, params CMsgClientToGCCandyShopGetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse__ctor"></a> CMsgClientToGCCandyShopGetUserDataResponse\(\)

```csharp
public CMsgClientToGCCandyShopGetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_"></a> CMsgClientToGCCandyShopGetUserDataResponse\(CMsgClientToGCCandyShopGetUserDataResponse\)

```csharp
public CMsgClientToGCCandyShopGetUserDataResponse(CMsgClientToGCCandyShopGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopGetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCCandyShopGetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_UserData"></a> UserData

```csharp
public CMsgCandyShopUserData UserData { get; set; }
```

#### Property Value

 [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopGetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_"></a> Equals\(CMsgClientToGCCandyShopGetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCCandyShopGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCCandyShopGetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

