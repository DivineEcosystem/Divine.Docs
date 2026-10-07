# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse"></a> Class CMsgGCToGCGetUserSessionServerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGetUserSessionServerResponse : IMessage<CMsgGCToGCGetUserSessionServerResponse>, IEquatable<CMsgGCToGCGetUserSessionServerResponse>, IDeepCloneable<CMsgGCToGCGetUserSessionServerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)

#### Implements

IMessage<CMsgGCToGCGetUserSessionServerResponse\>, 
[IEquatable<CMsgGCToGCGetUserSessionServerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGetUserSessionServerResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGetUserSessionServerResponse\>\(CMsgGCToGCGetUserSessionServerResponse, params CMsgGCToGCGetUserSessionServerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse__ctor"></a> CMsgGCToGCGetUserSessionServerResponse\(\)

```csharp
public CMsgGCToGCGetUserSessionServerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_"></a> CMsgGCToGCGetUserSessionServerResponse\(CMsgGCToGCGetUserSessionServerResponse\)

```csharp
public CMsgGCToGCGetUserSessionServerResponse(CMsgGCToGCGetUserSessionServerResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_IsOnlineFieldNumber"></a> IsOnlineFieldNumber

```csharp
public const int IsOnlineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_HasIsOnline"></a> HasIsOnline

```csharp
public bool HasIsOnline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_IsOnline"></a> IsOnline

```csharp
public bool IsOnline { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGetUserSessionServerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_ClearIsOnline"></a> ClearIsOnline\(\)

```csharp
public void ClearIsOnline()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGetUserSessionServerResponse Clone()
```

#### Returns

 [CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_"></a> Equals\(CMsgGCToGCGetUserSessionServerResponse\)

```csharp
public bool Equals(CMsgGCToGCGetUserSessionServerResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_"></a> MergeFrom\(CMsgGCToGCGetUserSessionServerResponse\)

```csharp
public void MergeFrom(CMsgGCToGCGetUserSessionServerResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserSessionServerResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserSessionServerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserSessionServerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

