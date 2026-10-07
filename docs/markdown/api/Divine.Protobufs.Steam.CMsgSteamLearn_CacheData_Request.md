# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request"></a> Class CMsgSteamLearn\_CacheData\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_CacheData_Request : IMessage<CMsgSteamLearn_CacheData_Request>, IEquatable<CMsgSteamLearn_CacheData_Request>, IDeepCloneable<CMsgSteamLearn_CacheData_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)

#### Implements

IMessage<CMsgSteamLearn\_CacheData\_Request\>, 
[IEquatable<CMsgSteamLearn\_CacheData\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_CacheData\_Request\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_CacheData\_Request\>\(CMsgSteamLearn\_CacheData\_Request, params CMsgSteamLearn\_CacheData\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request__ctor"></a> CMsgSteamLearn\_CacheData\_Request\(\)

```csharp
public CMsgSteamLearn_CacheData_Request()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_"></a> CMsgSteamLearn\_CacheData\_Request\(CMsgSteamLearn\_CacheData\_Request\)

```csharp
public CMsgSteamLearn_CacheData_Request(CMsgSteamLearn_CacheData_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_AccessTokenFieldNumber"></a> AccessTokenFieldNumber

```csharp
public const int AccessTokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_AccessToken"></a> AccessToken

```csharp
public string AccessToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Data"></a> Data

```csharp
public CMsgSteamLearnData Data { get; set; }
```

#### Property Value

 [CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_HasAccessToken"></a> HasAccessToken

```csharp
public bool HasAccessToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_CacheData_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_ClearAccessToken"></a> ClearAccessToken\(\)

```csharp
public void ClearAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_CacheData_Request Clone()
```

#### Returns

 [CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_"></a> Equals\(CMsgSteamLearn\_CacheData\_Request\)

```csharp
public bool Equals(CMsgSteamLearn_CacheData_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_"></a> MergeFrom\(CMsgSteamLearn\_CacheData\_Request\)

```csharp
public void MergeFrom(CMsgSteamLearn_CacheData_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

