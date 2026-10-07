# <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse"></a> Class CMsgSpectatorLobbyListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectatorLobbyListResponse : IMessage<CMsgSpectatorLobbyListResponse>, IEquatable<CMsgSpectatorLobbyListResponse>, IDeepCloneable<CMsgSpectatorLobbyListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)

#### Implements

IMessage<CMsgSpectatorLobbyListResponse\>, 
[IEquatable<CMsgSpectatorLobbyListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectatorLobbyListResponse\>, 
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
[EnumerableExtensions.In<CMsgSpectatorLobbyListResponse\>\(CMsgSpectatorLobbyListResponse, params CMsgSpectatorLobbyListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse__ctor"></a> CMsgSpectatorLobbyListResponse\(\)

```csharp
public CMsgSpectatorLobbyListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse__ctor_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_"></a> CMsgSpectatorLobbyListResponse\(CMsgSpectatorLobbyListResponse\)

```csharp
public CMsgSpectatorLobbyListResponse(CMsgSpectatorLobbyListResponse other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_LobbiesFieldNumber"></a> LobbiesFieldNumber

```csharp
public const int LobbiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Lobbies"></a> Lobbies

```csharp
public RepeatedField<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby> Lobbies { get; }
```

#### Property Value

 RepeatedField<[CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectatorLobbyListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgSpectatorLobbyListResponse Clone()
```

#### Returns

 [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Equals_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_"></a> Equals\(CMsgSpectatorLobbyListResponse\)

```csharp
public bool Equals(CMsgSpectatorLobbyListResponse other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_"></a> MergeFrom\(CMsgSpectatorLobbyListResponse\)

```csharp
public void MergeFrom(CMsgSpectatorLobbyListResponse other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

