# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse"></a> Class CMsgClientToGCCraftworksGetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCraftworksGetUserDataResponse : IMessage<CMsgClientToGCCraftworksGetUserDataResponse>, IEquatable<CMsgClientToGCCraftworksGetUserDataResponse>, IDeepCloneable<CMsgClientToGCCraftworksGetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCCraftworksGetUserDataResponse\>, 
[IEquatable<CMsgClientToGCCraftworksGetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCraftworksGetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCraftworksGetUserDataResponse\>\(CMsgClientToGCCraftworksGetUserDataResponse, params CMsgClientToGCCraftworksGetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse__ctor"></a> CMsgClientToGCCraftworksGetUserDataResponse\(\)

```csharp
public CMsgClientToGCCraftworksGetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_"></a> CMsgClientToGCCraftworksGetUserDataResponse\(CMsgClientToGCCraftworksGetUserDataResponse\)

```csharp
public CMsgClientToGCCraftworksGetUserDataResponse(CMsgClientToGCCraftworksGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCraftworksGetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCCraftworksGetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_UserData"></a> UserData

```csharp
public CMsgCraftworksUserData UserData { get; set; }
```

#### Property Value

 [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCraftworksGetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_"></a> Equals\(CMsgClientToGCCraftworksGetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCCraftworksGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCCraftworksGetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCraftworksGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

