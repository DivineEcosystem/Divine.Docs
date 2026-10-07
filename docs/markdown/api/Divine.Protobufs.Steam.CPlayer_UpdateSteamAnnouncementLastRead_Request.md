# <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request"></a> Class CPlayer\_UpdateSteamAnnouncementLastRead\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_UpdateSteamAnnouncementLastRead_Request : IMessage<CPlayer_UpdateSteamAnnouncementLastRead_Request>, IEquatable<CPlayer_UpdateSteamAnnouncementLastRead_Request>, IDeepCloneable<CPlayer_UpdateSteamAnnouncementLastRead_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)

#### Implements

IMessage<CPlayer\_UpdateSteamAnnouncementLastRead\_Request\>, 
[IEquatable<CPlayer\_UpdateSteamAnnouncementLastRead\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_UpdateSteamAnnouncementLastRead\_Request\>, 
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
[EnumerableExtensions.In<CPlayer\_UpdateSteamAnnouncementLastRead\_Request\>\(CPlayer\_UpdateSteamAnnouncementLastRead\_Request, params CPlayer\_UpdateSteamAnnouncementLastRead\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request__ctor"></a> CPlayer\_UpdateSteamAnnouncementLastRead\_Request\(\)

```csharp
public CPlayer_UpdateSteamAnnouncementLastRead_Request()
```

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request__ctor_Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_"></a> CPlayer\_UpdateSteamAnnouncementLastRead\_Request\(CPlayer\_UpdateSteamAnnouncementLastRead\_Request\)

```csharp
public CPlayer_UpdateSteamAnnouncementLastRead_Request(CPlayer_UpdateSteamAnnouncementLastRead_Request other)
```

#### Parameters

`other` [CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_AnnouncementGidFieldNumber"></a> AnnouncementGidFieldNumber

```csharp
public const int AnnouncementGidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_TimePostedFieldNumber"></a> TimePostedFieldNumber

```csharp
public const int TimePostedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_AnnouncementGid"></a> AnnouncementGid

```csharp
public ulong AnnouncementGid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_HasAnnouncementGid"></a> HasAnnouncementGid

```csharp
public bool HasAnnouncementGid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_HasTimePosted"></a> HasTimePosted

```csharp
public bool HasTimePosted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_UpdateSteamAnnouncementLastRead_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_TimePosted"></a> TimePosted

```csharp
public uint TimePosted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_ClearAnnouncementGid"></a> ClearAnnouncementGid\(\)

```csharp
public void ClearAnnouncementGid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_ClearTimePosted"></a> ClearTimePosted\(\)

```csharp
public void ClearTimePosted()
```

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_Clone"></a> Clone\(\)

```csharp
public CPlayer_UpdateSteamAnnouncementLastRead_Request Clone()
```

#### Returns

 [CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_Equals_Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_"></a> Equals\(CPlayer\_UpdateSteamAnnouncementLastRead\_Request\)

```csharp
public bool Equals(CPlayer_UpdateSteamAnnouncementLastRead_Request other)
```

#### Parameters

`other` [CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_MergeFrom_Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_"></a> MergeFrom\(CPlayer\_UpdateSteamAnnouncementLastRead\_Request\)

```csharp
public void MergeFrom(CPlayer_UpdateSteamAnnouncementLastRead_Request other)
```

#### Parameters

`other` [CPlayer\_UpdateSteamAnnouncementLastRead\_Request](Divine.Protobufs.Steam.CPlayer\_UpdateSteamAnnouncementLastRead\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_UpdateSteamAnnouncementLastRead_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

