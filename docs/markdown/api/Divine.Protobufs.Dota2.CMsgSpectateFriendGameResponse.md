# <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse"></a> Class CMsgSpectateFriendGameResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectateFriendGameResponse : IMessage<CMsgSpectateFriendGameResponse>, IEquatable<CMsgSpectateFriendGameResponse>, IDeepCloneable<CMsgSpectateFriendGameResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)

#### Implements

IMessage<CMsgSpectateFriendGameResponse\>, 
[IEquatable<CMsgSpectateFriendGameResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectateFriendGameResponse\>, 
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
[EnumerableExtensions.In<CMsgSpectateFriendGameResponse\>\(CMsgSpectateFriendGameResponse, params CMsgSpectateFriendGameResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse__ctor"></a> CMsgSpectateFriendGameResponse\(\)

```csharp
public CMsgSpectateFriendGameResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse__ctor_Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_"></a> CMsgSpectateFriendGameResponse\(CMsgSpectateFriendGameResponse\)

```csharp
public CMsgSpectateFriendGameResponse(CMsgSpectateFriendGameResponse other)
```

#### Parameters

`other` [CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_ServerSteamidFieldNumber"></a> ServerSteamidFieldNumber

```csharp
public const int ServerSteamidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_WatchLiveResultFieldNumber"></a> WatchLiveResultFieldNumber

```csharp
public const int WatchLiveResultFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_HasServerSteamid"></a> HasServerSteamid

```csharp
public bool HasServerSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_HasWatchLiveResult"></a> HasWatchLiveResult

```csharp
public bool HasWatchLiveResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectateFriendGameResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_ServerSteamid"></a> ServerSteamid

```csharp
public ulong ServerSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_WatchLiveResult"></a> WatchLiveResult

```csharp
public CMsgSpectateFriendGameResponse.Types.EWatchLiveResult WatchLiveResult { get; set; }
```

#### Property Value

 [CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.Types.md).[EWatchLiveResult](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.Types.EWatchLiveResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_ClearServerSteamid"></a> ClearServerSteamid\(\)

```csharp
public void ClearServerSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_ClearWatchLiveResult"></a> ClearWatchLiveResult\(\)

```csharp
public void ClearWatchLiveResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_Clone"></a> Clone\(\)

```csharp
public CMsgSpectateFriendGameResponse Clone()
```

#### Returns

 [CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_Equals_Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_"></a> Equals\(CMsgSpectateFriendGameResponse\)

```csharp
public bool Equals(CMsgSpectateFriendGameResponse other)
```

#### Parameters

`other` [CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_"></a> MergeFrom\(CMsgSpectateFriendGameResponse\)

```csharp
public void MergeFrom(CMsgSpectateFriendGameResponse other)
```

#### Parameters

`other` [CMsgSpectateFriendGameResponse](Divine.Protobufs.Dota2.CMsgSpectateFriendGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGameResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

