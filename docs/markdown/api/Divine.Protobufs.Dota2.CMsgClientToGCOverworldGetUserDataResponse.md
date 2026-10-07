# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse"></a> Class CMsgClientToGCOverworldGetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGetUserDataResponse : IMessage<CMsgClientToGCOverworldGetUserDataResponse>, IEquatable<CMsgClientToGCOverworldGetUserDataResponse>, IDeepCloneable<CMsgClientToGCOverworldGetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldGetUserDataResponse\>, 
[IEquatable<CMsgClientToGCOverworldGetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGetUserDataResponse\>\(CMsgClientToGCOverworldGetUserDataResponse, params CMsgClientToGCOverworldGetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse__ctor"></a> CMsgClientToGCOverworldGetUserDataResponse\(\)

```csharp
public CMsgClientToGCOverworldGetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_"></a> CMsgClientToGCOverworldGetUserDataResponse\(CMsgClientToGCOverworldGetUserDataResponse\)

```csharp
public CMsgClientToGCOverworldGetUserDataResponse(CMsgClientToGCOverworldGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldGetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_UserData"></a> UserData

```csharp
public CMsgOverworldUserData UserData { get; set; }
```

#### Property Value

 [CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_"></a> Equals\(CMsgClientToGCOverworldGetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCOverworldGetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

