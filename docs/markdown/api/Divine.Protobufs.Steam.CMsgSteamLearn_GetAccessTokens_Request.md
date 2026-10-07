# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request"></a> Class CMsgSteamLearn\_GetAccessTokens\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_GetAccessTokens_Request : IMessage<CMsgSteamLearn_GetAccessTokens_Request>, IEquatable<CMsgSteamLearn_GetAccessTokens_Request>, IDeepCloneable<CMsgSteamLearn_GetAccessTokens_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)

#### Implements

IMessage<CMsgSteamLearn\_GetAccessTokens\_Request\>, 
[IEquatable<CMsgSteamLearn\_GetAccessTokens\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_GetAccessTokens\_Request\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_GetAccessTokens\_Request\>\(CMsgSteamLearn\_GetAccessTokens\_Request, params CMsgSteamLearn\_GetAccessTokens\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request__ctor"></a> CMsgSteamLearn\_GetAccessTokens\_Request\(\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Request()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_"></a> CMsgSteamLearn\_GetAccessTokens\_Request\(CMsgSteamLearn\_GetAccessTokens\_Request\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Request(CMsgSteamLearn_GetAccessTokens_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_GetAccessTokens_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Request Clone()
```

#### Returns

 [CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_"></a> Equals\(CMsgSteamLearn\_GetAccessTokens\_Request\)

```csharp
public bool Equals(CMsgSteamLearn_GetAccessTokens_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_"></a> MergeFrom\(CMsgSteamLearn\_GetAccessTokens\_Request\)

```csharp
public void MergeFrom(CMsgSteamLearn_GetAccessTokens_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

