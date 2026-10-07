# <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response"></a> Class CPlayer\_GetNewSteamAnnouncementState\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetNewSteamAnnouncementState_Response : IMessage<CPlayer_GetNewSteamAnnouncementState_Response>, IEquatable<CPlayer_GetNewSteamAnnouncementState_Response>, IDeepCloneable<CPlayer_GetNewSteamAnnouncementState_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)

#### Implements

IMessage<CPlayer\_GetNewSteamAnnouncementState\_Response\>, 
[IEquatable<CPlayer\_GetNewSteamAnnouncementState\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetNewSteamAnnouncementState\_Response\>, 
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
[EnumerableExtensions.In<CPlayer\_GetNewSteamAnnouncementState\_Response\>\(CPlayer\_GetNewSteamAnnouncementState\_Response, params CPlayer\_GetNewSteamAnnouncementState\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response__ctor"></a> CPlayer\_GetNewSteamAnnouncementState\_Response\(\)

```csharp
public CPlayer_GetNewSteamAnnouncementState_Response()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response__ctor_Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_"></a> CPlayer\_GetNewSteamAnnouncementState\_Response\(CPlayer\_GetNewSteamAnnouncementState\_Response\)

```csharp
public CPlayer_GetNewSteamAnnouncementState_Response(CPlayer_GetNewSteamAnnouncementState_Response other)
```

#### Parameters

`other` [CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementGidFieldNumber"></a> AnnouncementGidFieldNumber

```csharp
public const int AnnouncementGidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementHeadlineFieldNumber"></a> AnnouncementHeadlineFieldNumber

```csharp
public const int AnnouncementHeadlineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementUrlFieldNumber"></a> AnnouncementUrlFieldNumber

```csharp
public const int AnnouncementUrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_TimePostedFieldNumber"></a> TimePostedFieldNumber

```csharp
public const int TimePostedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementGid"></a> AnnouncementGid

```csharp
public ulong AnnouncementGid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementHeadline"></a> AnnouncementHeadline

```csharp
public string AnnouncementHeadline { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_AnnouncementUrl"></a> AnnouncementUrl

```csharp
public string AnnouncementUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_HasAnnouncementGid"></a> HasAnnouncementGid

```csharp
public bool HasAnnouncementGid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_HasAnnouncementHeadline"></a> HasAnnouncementHeadline

```csharp
public bool HasAnnouncementHeadline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_HasAnnouncementUrl"></a> HasAnnouncementUrl

```csharp
public bool HasAnnouncementUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_HasTimePosted"></a> HasTimePosted

```csharp
public bool HasTimePosted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetNewSteamAnnouncementState_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_State"></a> State

```csharp
public int State { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_TimePosted"></a> TimePosted

```csharp
public uint TimePosted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ClearAnnouncementGid"></a> ClearAnnouncementGid\(\)

```csharp
public void ClearAnnouncementGid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ClearAnnouncementHeadline"></a> ClearAnnouncementHeadline\(\)

```csharp
public void ClearAnnouncementHeadline()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ClearAnnouncementUrl"></a> ClearAnnouncementUrl\(\)

```csharp
public void ClearAnnouncementUrl()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ClearTimePosted"></a> ClearTimePosted\(\)

```csharp
public void ClearTimePosted()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetNewSteamAnnouncementState_Response Clone()
```

#### Returns

 [CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_Equals_Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_"></a> Equals\(CPlayer\_GetNewSteamAnnouncementState\_Response\)

```csharp
public bool Equals(CPlayer_GetNewSteamAnnouncementState_Response other)
```

#### Parameters

`other` [CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_"></a> MergeFrom\(CPlayer\_GetNewSteamAnnouncementState\_Response\)

```csharp
public void MergeFrom(CPlayer_GetNewSteamAnnouncementState_Response other)
```

#### Parameters

`other` [CPlayer\_GetNewSteamAnnouncementState\_Response](Divine.Protobufs.Steam.CPlayer\_GetNewSteamAnnouncementState\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNewSteamAnnouncementState_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

