# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed"></a> Class CMsgSteamSockets\_UDP\_ConnectionClosed

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_ConnectionClosed : IMessage<CMsgSteamSockets_UDP_ConnectionClosed>, IEquatable<CMsgSteamSockets_UDP_ConnectionClosed>, IDeepCloneable<CMsgSteamSockets_UDP_ConnectionClosed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_ConnectionClosed\>, 
[IEquatable<CMsgSteamSockets\_UDP\_ConnectionClosed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_ConnectionClosed\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_ConnectionClosed\>\(CMsgSteamSockets\_UDP\_ConnectionClosed, params CMsgSteamSockets\_UDP\_ConnectionClosed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed__ctor"></a> CMsgSteamSockets\_UDP\_ConnectionClosed\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectionClosed()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_"></a> CMsgSteamSockets\_UDP\_ConnectionClosed\(CMsgSteamSockets\_UDP\_ConnectionClosed\)

```csharp
public CMsgSteamSockets_UDP_ConnectionClosed(CMsgSteamSockets_UDP_ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_DebugFieldNumber"></a> DebugFieldNumber

```csharp
public const int DebugFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ReasonCodeFieldNumber"></a> ReasonCodeFieldNumber

```csharp
public const int ReasonCodeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ToConnectionIdFieldNumber"></a> ToConnectionIdFieldNumber

```csharp
public const int ToConnectionIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Debug"></a> Debug

```csharp
public string Debug { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_HasDebug"></a> HasDebug

```csharp
public bool HasDebug { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_HasReasonCode"></a> HasReasonCode

```csharp
public bool HasReasonCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_HasToConnectionId"></a> HasToConnectionId

```csharp
public bool HasToConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_ConnectionClosed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ReasonCode"></a> ReasonCode

```csharp
public uint ReasonCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ToConnectionId"></a> ToConnectionId

```csharp
public uint ToConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ClearDebug"></a> ClearDebug\(\)

```csharp
public void ClearDebug()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ClearReasonCode"></a> ClearReasonCode\(\)

```csharp
public void ClearReasonCode()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ClearToConnectionId"></a> ClearToConnectionId\(\)

```csharp
public void ClearToConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectionClosed Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_"></a> Equals\(CMsgSteamSockets\_UDP\_ConnectionClosed\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_ConnectionClosed\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_ConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectionClosed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

