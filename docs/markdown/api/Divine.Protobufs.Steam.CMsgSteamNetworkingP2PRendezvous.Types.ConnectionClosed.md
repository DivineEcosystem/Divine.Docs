# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed"></a> Class CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed : IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed>, IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed\>\(CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed, params CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed__ctor"></a> ConnectionClosed\(\)

```csharp
public ConnectionClosed()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_"></a> ConnectionClosed\(ConnectionClosed\)

```csharp
public ConnectionClosed(CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_DebugFieldNumber"></a> DebugFieldNumber

```csharp
public const int DebugFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_ReasonCodeFieldNumber"></a> ReasonCodeFieldNumber

```csharp
public const int ReasonCodeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Debug"></a> Debug

```csharp
public string Debug { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_HasDebug"></a> HasDebug

```csharp
public bool HasDebug { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_HasReasonCode"></a> HasReasonCode

```csharp
public bool HasReasonCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_ReasonCode"></a> ReasonCode

```csharp
public uint ReasonCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_ClearDebug"></a> ClearDebug\(\)

```csharp
public void ClearDebug()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_ClearReasonCode"></a> ClearReasonCode\(\)

```csharp
public void ClearReasonCode()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_"></a> Equals\(ConnectionClosed\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_"></a> MergeFrom\(ConnectionClosed\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectionClosed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

