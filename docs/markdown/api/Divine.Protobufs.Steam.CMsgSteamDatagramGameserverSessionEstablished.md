# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished"></a> Class CMsgSteamDatagramGameserverSessionEstablished

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameserverSessionEstablished : IMessage<CMsgSteamDatagramGameserverSessionEstablished>, IEquatable<CMsgSteamDatagramGameserverSessionEstablished>, IDeepCloneable<CMsgSteamDatagramGameserverSessionEstablished>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)

#### Implements

IMessage<CMsgSteamDatagramGameserverSessionEstablished\>, 
[IEquatable<CMsgSteamDatagramGameserverSessionEstablished\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameserverSessionEstablished\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameserverSessionEstablished\>\(CMsgSteamDatagramGameserverSessionEstablished, params CMsgSteamDatagramGameserverSessionEstablished\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished__ctor"></a> CMsgSteamDatagramGameserverSessionEstablished\(\)

```csharp
public CMsgSteamDatagramGameserverSessionEstablished()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_"></a> CMsgSteamDatagramGameserverSessionEstablished\(CMsgSteamDatagramGameserverSessionEstablished\)

```csharp
public CMsgSteamDatagramGameserverSessionEstablished(CMsgSteamDatagramGameserverSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_DummyLegacyIdentityBinaryFieldNumber"></a> DummyLegacyIdentityBinaryFieldNumber

```csharp
public const int DummyLegacyIdentityBinaryFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_GameserverIdentityStringFieldNumber"></a> GameserverIdentityStringFieldNumber

```csharp
public const int GameserverIdentityStringFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_LegacyGameserverSteamidFieldNumber"></a> LegacyGameserverSteamidFieldNumber

```csharp
public const int LegacyGameserverSteamidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_SeqNumR2CFieldNumber"></a> SeqNumR2CFieldNumber

```csharp
public const int SeqNumR2CFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_DummyLegacyIdentityBinary"></a> DummyLegacyIdentityBinary

```csharp
public ByteString DummyLegacyIdentityBinary { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_GameserverIdentityString"></a> GameserverIdentityString

```csharp
public string GameserverIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasDummyLegacyIdentityBinary"></a> HasDummyLegacyIdentityBinary

```csharp
public bool HasDummyLegacyIdentityBinary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasGameserverIdentityString"></a> HasGameserverIdentityString

```csharp
public bool HasGameserverIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasLegacyGameserverSteamid"></a> HasLegacyGameserverSteamid

```csharp
public bool HasLegacyGameserverSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_HasSeqNumR2C"></a> HasSeqNumR2C

```csharp
public bool HasSeqNumR2C { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_LegacyGameserverSteamid"></a> LegacyGameserverSteamid

```csharp
public ulong LegacyGameserverSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameserverSessionEstablished> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_SeqNumR2C"></a> SeqNumR2C

```csharp
public uint SeqNumR2C { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearDummyLegacyIdentityBinary"></a> ClearDummyLegacyIdentityBinary\(\)

```csharp
public void ClearDummyLegacyIdentityBinary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearGameserverIdentityString"></a> ClearGameserverIdentityString\(\)

```csharp
public void ClearGameserverIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearLegacyGameserverSteamid"></a> ClearLegacyGameserverSteamid\(\)

```csharp
public void ClearLegacyGameserverSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ClearSeqNumR2C"></a> ClearSeqNumR2C\(\)

```csharp
public void ClearSeqNumR2C()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameserverSessionEstablished Clone()
```

#### Returns

 [CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_"></a> Equals\(CMsgSteamDatagramGameserverSessionEstablished\)

```csharp
public bool Equals(CMsgSteamDatagramGameserverSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_"></a> MergeFrom\(CMsgSteamDatagramGameserverSessionEstablished\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameserverSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionEstablished.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionEstablished_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

