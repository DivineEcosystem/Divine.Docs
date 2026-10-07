# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection"></a> Class CMsgSteamSockets\_UDP\_NoConnection

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_NoConnection : IMessage<CMsgSteamSockets_UDP_NoConnection>, IEquatable<CMsgSteamSockets_UDP_NoConnection>, IDeepCloneable<CMsgSteamSockets_UDP_NoConnection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_NoConnection\>, 
[IEquatable<CMsgSteamSockets\_UDP\_NoConnection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_NoConnection\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_NoConnection\>\(CMsgSteamSockets\_UDP\_NoConnection, params CMsgSteamSockets\_UDP\_NoConnection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection__ctor"></a> CMsgSteamSockets\_UDP\_NoConnection\(\)

```csharp
public CMsgSteamSockets_UDP_NoConnection()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_"></a> CMsgSteamSockets\_UDP\_NoConnection\(CMsgSteamSockets\_UDP\_NoConnection\)

```csharp
public CMsgSteamSockets_UDP_NoConnection(CMsgSteamSockets_UDP_NoConnection other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_ToConnectionIdFieldNumber"></a> ToConnectionIdFieldNumber

```csharp
public const int ToConnectionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_HasToConnectionId"></a> HasToConnectionId

```csharp
public bool HasToConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_NoConnection> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_ToConnectionId"></a> ToConnectionId

```csharp
public uint ToConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_ClearToConnectionId"></a> ClearToConnectionId\(\)

```csharp
public void ClearToConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_NoConnection Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_"></a> Equals\(CMsgSteamSockets\_UDP\_NoConnection\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_NoConnection other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_NoConnection\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_NoConnection other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_NoConnection](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_NoConnection.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_NoConnection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

