# <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse"></a> Class CMsgFriendPracticeLobbyListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFriendPracticeLobbyListResponse : IMessage<CMsgFriendPracticeLobbyListResponse>, IEquatable<CMsgFriendPracticeLobbyListResponse>, IDeepCloneable<CMsgFriendPracticeLobbyListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)

#### Implements

IMessage<CMsgFriendPracticeLobbyListResponse\>, 
[IEquatable<CMsgFriendPracticeLobbyListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFriendPracticeLobbyListResponse\>, 
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
[EnumerableExtensions.In<CMsgFriendPracticeLobbyListResponse\>\(CMsgFriendPracticeLobbyListResponse, params CMsgFriendPracticeLobbyListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse__ctor"></a> CMsgFriendPracticeLobbyListResponse\(\)

```csharp
public CMsgFriendPracticeLobbyListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse__ctor_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_"></a> CMsgFriendPracticeLobbyListResponse\(CMsgFriendPracticeLobbyListResponse\)

```csharp
public CMsgFriendPracticeLobbyListResponse(CMsgFriendPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_LobbiesFieldNumber"></a> LobbiesFieldNumber

```csharp
public const int LobbiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Lobbies"></a> Lobbies

```csharp
public RepeatedField<CMsgPracticeLobbyListResponseEntry> Lobbies { get; }
```

#### Property Value

 RepeatedField<[CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFriendPracticeLobbyListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgFriendPracticeLobbyListResponse Clone()
```

#### Returns

 [CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_Equals_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_"></a> Equals\(CMsgFriendPracticeLobbyListResponse\)

```csharp
public bool Equals(CMsgFriendPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_"></a> MergeFrom\(CMsgFriendPracticeLobbyListResponse\)

```csharp
public void MergeFrom(CMsgFriendPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

