# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse"></a> Class CMsgClientToGCBingoGetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoGetUserDataResponse : IMessage<CMsgClientToGCBingoGetUserDataResponse>, IEquatable<CMsgClientToGCBingoGetUserDataResponse>, IDeepCloneable<CMsgClientToGCBingoGetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoGetUserDataResponse\>, 
[IEquatable<CMsgClientToGCBingoGetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoGetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoGetUserDataResponse\>\(CMsgClientToGCBingoGetUserDataResponse, params CMsgClientToGCBingoGetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse__ctor"></a> CMsgClientToGCBingoGetUserDataResponse\(\)

```csharp
public CMsgClientToGCBingoGetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_"></a> CMsgClientToGCBingoGetUserDataResponse\(CMsgClientToGCBingoGetUserDataResponse\)

```csharp
public CMsgClientToGCBingoGetUserDataResponse(CMsgClientToGCBingoGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoGetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoGetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_UserData"></a> UserData

```csharp
public CMsgBingoUserData UserData { get; set; }
```

#### Property Value

 [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoGetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_"></a> Equals\(CMsgClientToGCBingoGetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCBingoGetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

