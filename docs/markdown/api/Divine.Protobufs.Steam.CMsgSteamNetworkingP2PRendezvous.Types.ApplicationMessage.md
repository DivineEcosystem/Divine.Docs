# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage"></a> Class CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage : IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage>, IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage\>\(CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage, params CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage__ctor"></a> ApplicationMessage\(\)

```csharp
public ApplicationMessage()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_"></a> ApplicationMessage\(ApplicationMessage\)

```csharp
public ApplicationMessage(CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_LaneIdxFieldNumber"></a> LaneIdxFieldNumber

```csharp
public const int LaneIdxFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_MsgNumFieldNumber"></a> MsgNumFieldNumber

```csharp
public const int MsgNumFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_HasLaneIdx"></a> HasLaneIdx

```csharp
public bool HasLaneIdx { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_HasMsgNum"></a> HasMsgNum

```csharp
public bool HasMsgNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_LaneIdx"></a> LaneIdx

```csharp
public uint LaneIdx { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_MsgNum"></a> MsgNum

```csharp
public ulong MsgNum { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_ClearLaneIdx"></a> ClearLaneIdx\(\)

```csharp
public void ClearLaneIdx()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_ClearMsgNum"></a> ClearMsgNum\(\)

```csharp
public void ClearMsgNum()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_"></a> Equals\(ApplicationMessage\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_"></a> MergeFrom\(ApplicationMessage\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ApplicationMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

