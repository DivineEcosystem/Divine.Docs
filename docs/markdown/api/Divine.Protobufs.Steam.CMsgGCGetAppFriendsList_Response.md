# <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response"></a> Class CMsgGCGetAppFriendsList\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetAppFriendsList_Response : IMessage<CMsgGCGetAppFriendsList_Response>, IEquatable<CMsgGCGetAppFriendsList_Response>, IDeepCloneable<CMsgGCGetAppFriendsList_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)

#### Implements

IMessage<CMsgGCGetAppFriendsList\_Response\>, 
[IEquatable<CMsgGCGetAppFriendsList\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetAppFriendsList\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCGetAppFriendsList\_Response\>\(CMsgGCGetAppFriendsList\_Response, params CMsgGCGetAppFriendsList\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response__ctor"></a> CMsgGCGetAppFriendsList\_Response\(\)

```csharp
public CMsgGCGetAppFriendsList_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response__ctor_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_"></a> CMsgGCGetAppFriendsList\_Response\(CMsgGCGetAppFriendsList\_Response\)

```csharp
public CMsgGCGetAppFriendsList_Response(CMsgGCGetAppFriendsList_Response other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_FriendshipTimestampsFieldNumber"></a> FriendshipTimestampsFieldNumber

```csharp
public const int FriendshipTimestampsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_LastPlaytimesFieldNumber"></a> LastPlaytimesFieldNumber

```csharp
public const int LastPlaytimesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_SteamidsFieldNumber"></a> SteamidsFieldNumber

```csharp
public const int SteamidsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_FriendshipTimestamps"></a> FriendshipTimestamps

```csharp
public RepeatedField<uint> FriendshipTimestamps { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_LastPlaytimes"></a> LastPlaytimes

```csharp
public RepeatedField<uint> LastPlaytimes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetAppFriendsList_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Steamids"></a> Steamids

```csharp
public RepeatedField<ulong> Steamids { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetAppFriendsList_Response Clone()
```

#### Returns

 [CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_Equals_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_"></a> Equals\(CMsgGCGetAppFriendsList\_Response\)

```csharp
public bool Equals(CMsgGCGetAppFriendsList_Response other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_"></a> MergeFrom\(CMsgGCGetAppFriendsList\_Response\)

```csharp
public void MergeFrom(CMsgGCGetAppFriendsList_Response other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList\_Response](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

