# <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby"></a> Class CMsgInviteToLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInviteToLobby : IMessage<CMsgInviteToLobby>, IEquatable<CMsgInviteToLobby>, IDeepCloneable<CMsgInviteToLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)

#### Implements

IMessage<CMsgInviteToLobby\>, 
[IEquatable<CMsgInviteToLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInviteToLobby\>, 
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
[EnumerableExtensions.In<CMsgInviteToLobby\>\(CMsgInviteToLobby, params CMsgInviteToLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby__ctor"></a> CMsgInviteToLobby\(\)

```csharp
public CMsgInviteToLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby__ctor_Divine_Protobufs_Dota2_CMsgInviteToLobby_"></a> CMsgInviteToLobby\(CMsgInviteToLobby\)

```csharp
public CMsgInviteToLobby(CMsgInviteToLobby other)
```

#### Parameters

`other` [CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInviteToLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_Clone"></a> Clone\(\)

```csharp
public CMsgInviteToLobby Clone()
```

#### Returns

 [CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_Equals_Divine_Protobufs_Dota2_CMsgInviteToLobby_"></a> Equals\(CMsgInviteToLobby\)

```csharp
public bool Equals(CMsgInviteToLobby other)
```

#### Parameters

`other` [CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_MergeFrom_Divine_Protobufs_Dota2_CMsgInviteToLobby_"></a> MergeFrom\(CMsgInviteToLobby\)

```csharp
public void MergeFrom(CMsgInviteToLobby other)
```

#### Parameters

`other` [CMsgInviteToLobby](Divine.Protobufs.Dota2.CMsgInviteToLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

