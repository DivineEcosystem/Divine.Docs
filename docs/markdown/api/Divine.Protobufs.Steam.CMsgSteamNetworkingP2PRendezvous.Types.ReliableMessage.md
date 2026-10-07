# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage"></a> Class CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage : IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage>, IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage\>\(CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage, params CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage__ctor"></a> ReliableMessage\(\)

```csharp
public ReliableMessage()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_"></a> ReliableMessage\(ReliableMessage\)

```csharp
public ReliableMessage(CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_IceFieldNumber"></a> IceFieldNumber

```csharp
public const int IceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Ice"></a> Ice

```csharp
public CMsgICERendezvous Ice { get; set; }
```

#### Property Value

 [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_"></a> Equals\(ReliableMessage\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_"></a> MergeFrom\(ReliableMessage\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ReliableMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

