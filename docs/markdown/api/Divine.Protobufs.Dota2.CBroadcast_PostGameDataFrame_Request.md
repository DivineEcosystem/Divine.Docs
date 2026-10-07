# <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request"></a> Class CBroadcast\_PostGameDataFrame\_Request

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBroadcast_PostGameDataFrame_Request : IMessage<CBroadcast_PostGameDataFrame_Request>, IEquatable<CBroadcast_PostGameDataFrame_Request>, IDeepCloneable<CBroadcast_PostGameDataFrame_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)

#### Implements

IMessage<CBroadcast\_PostGameDataFrame\_Request\>, 
[IEquatable<CBroadcast\_PostGameDataFrame\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBroadcast\_PostGameDataFrame\_Request\>, 
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
[EnumerableExtensions.In<CBroadcast\_PostGameDataFrame\_Request\>\(CBroadcast\_PostGameDataFrame\_Request, params CBroadcast\_PostGameDataFrame\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request__ctor"></a> CBroadcast\_PostGameDataFrame\_Request\(\)

```csharp
public CBroadcast_PostGameDataFrame_Request()
```

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request__ctor_Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_"></a> CBroadcast\_PostGameDataFrame\_Request\(CBroadcast\_PostGameDataFrame\_Request\)

```csharp
public CBroadcast_PostGameDataFrame_Request(CBroadcast_PostGameDataFrame_Request other)
```

#### Parameters

`other` [CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_BroadcastIdFieldNumber"></a> BroadcastIdFieldNumber

```csharp
public const int BroadcastIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_FrameDataFieldNumber"></a> FrameDataFieldNumber

```csharp
public const int FrameDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_BroadcastId"></a> BroadcastId

```csharp
public ulong BroadcastId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_FrameData"></a> FrameData

```csharp
public ByteString FrameData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_HasBroadcastId"></a> HasBroadcastId

```csharp
public bool HasBroadcastId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_HasFrameData"></a> HasFrameData

```csharp
public bool HasFrameData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Parser"></a> Parser

```csharp
public static MessageParser<CBroadcast_PostGameDataFrame_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)\>

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_ClearBroadcastId"></a> ClearBroadcastId\(\)

```csharp
public void ClearBroadcastId()
```

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_ClearFrameData"></a> ClearFrameData\(\)

```csharp
public void ClearFrameData()
```

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Clone"></a> Clone\(\)

```csharp
public CBroadcast_PostGameDataFrame_Request Clone()
```

#### Returns

 [CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_Equals_Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_"></a> Equals\(CBroadcast\_PostGameDataFrame\_Request\)

```csharp
public bool Equals(CBroadcast_PostGameDataFrame_Request other)
```

#### Parameters

`other` [CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_MergeFrom_Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_"></a> MergeFrom\(CBroadcast\_PostGameDataFrame\_Request\)

```csharp
public void MergeFrom(CBroadcast_PostGameDataFrame_Request other)
```

#### Parameters

`other` [CBroadcast\_PostGameDataFrame\_Request](Divine.Protobufs.Dota2.CBroadcast\_PostGameDataFrame\_Request.md)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBroadcast_PostGameDataFrame_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

