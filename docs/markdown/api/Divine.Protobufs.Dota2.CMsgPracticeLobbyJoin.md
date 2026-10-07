# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin"></a> Class CMsgPracticeLobbyJoin

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyJoin : IMessage<CMsgPracticeLobbyJoin>, IEquatable<CMsgPracticeLobbyJoin>, IDeepCloneable<CMsgPracticeLobbyJoin>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)

#### Implements

IMessage<CMsgPracticeLobbyJoin\>, 
[IEquatable<CMsgPracticeLobbyJoin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyJoin\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyJoin\>\(CMsgPracticeLobbyJoin, params CMsgPracticeLobbyJoin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin__ctor"></a> CMsgPracticeLobbyJoin\(\)

```csharp
public CMsgPracticeLobbyJoin()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_"></a> CMsgPracticeLobbyJoin\(CMsgPracticeLobbyJoin\)

```csharp
public CMsgPracticeLobbyJoin(CMsgPracticeLobbyJoin other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_CustomGameCrcFieldNumber"></a> CustomGameCrcFieldNumber

```csharp
public const int CustomGameCrcFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_CustomGameTimestampFieldNumber"></a> CustomGameTimestampFieldNumber

```csharp
public const int CustomGameTimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_PassKeyFieldNumber"></a> PassKeyFieldNumber

```csharp
public const int PassKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_CustomGameCrc"></a> CustomGameCrc

```csharp
public ulong CustomGameCrc { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_CustomGameTimestamp"></a> CustomGameTimestamp

```csharp
public uint CustomGameTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_HasCustomGameCrc"></a> HasCustomGameCrc

```csharp
public bool HasCustomGameCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_HasCustomGameTimestamp"></a> HasCustomGameTimestamp

```csharp
public bool HasCustomGameTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_HasPassKey"></a> HasPassKey

```csharp
public bool HasPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyJoin> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_PassKey"></a> PassKey

```csharp
public string PassKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClearCustomGameCrc"></a> ClearCustomGameCrc\(\)

```csharp
public void ClearCustomGameCrc()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClearCustomGameTimestamp"></a> ClearCustomGameTimestamp\(\)

```csharp
public void ClearCustomGameTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ClearPassKey"></a> ClearPassKey\(\)

```csharp
public void ClearPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyJoin Clone()
```

#### Returns

 [CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_"></a> Equals\(CMsgPracticeLobbyJoin\)

```csharp
public bool Equals(CMsgPracticeLobbyJoin other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_"></a> MergeFrom\(CMsgPracticeLobbyJoin\)

```csharp
public void MergeFrom(CMsgPracticeLobbyJoin other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoin](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoin.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoin_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

