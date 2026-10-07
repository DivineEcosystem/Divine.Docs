# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer"></a> Class CMsgSteamDatagramNoSessionRelayToPeer

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramNoSessionRelayToPeer : IMessage<CMsgSteamDatagramNoSessionRelayToPeer>, IEquatable<CMsgSteamDatagramNoSessionRelayToPeer>, IDeepCloneable<CMsgSteamDatagramNoSessionRelayToPeer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)

#### Implements

IMessage<CMsgSteamDatagramNoSessionRelayToPeer\>, 
[IEquatable<CMsgSteamDatagramNoSessionRelayToPeer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramNoSessionRelayToPeer\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramNoSessionRelayToPeer\>\(CMsgSteamDatagramNoSessionRelayToPeer, params CMsgSteamDatagramNoSessionRelayToPeer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer__ctor"></a> CMsgSteamDatagramNoSessionRelayToPeer\(\)

```csharp
public CMsgSteamDatagramNoSessionRelayToPeer()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_"></a> CMsgSteamDatagramNoSessionRelayToPeer\(CMsgSteamDatagramNoSessionRelayToPeer\)

```csharp
public CMsgSteamDatagramNoSessionRelayToPeer(CMsgSteamDatagramNoSessionRelayToPeer other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_FromRelaySessionIdFieldNumber"></a> FromRelaySessionIdFieldNumber

```csharp
public const int FromRelaySessionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_KludgePadFieldNumber"></a> KludgePadFieldNumber

```csharp
public const int KludgePadFieldNumber = 99
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_LegacyRelaySessionIdFieldNumber"></a> LegacyRelaySessionIdFieldNumber

```csharp
public const int LegacyRelaySessionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_FromRelaySessionId"></a> FromRelaySessionId

```csharp
public uint FromRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_HasFromRelaySessionId"></a> HasFromRelaySessionId

```csharp
public bool HasFromRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_HasKludgePad"></a> HasKludgePad

```csharp
public bool HasKludgePad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_HasLegacyRelaySessionId"></a> HasLegacyRelaySessionId

```csharp
public bool HasLegacyRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_KludgePad"></a> KludgePad

```csharp
public ulong KludgePad { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_LegacyRelaySessionId"></a> LegacyRelaySessionId

```csharp
public uint LegacyRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramNoSessionRelayToPeer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_ClearFromRelaySessionId"></a> ClearFromRelaySessionId\(\)

```csharp
public void ClearFromRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_ClearKludgePad"></a> ClearKludgePad\(\)

```csharp
public void ClearKludgePad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_ClearLegacyRelaySessionId"></a> ClearLegacyRelaySessionId\(\)

```csharp
public void ClearLegacyRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramNoSessionRelayToPeer Clone()
```

#### Returns

 [CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_"></a> Equals\(CMsgSteamDatagramNoSessionRelayToPeer\)

```csharp
public bool Equals(CMsgSteamDatagramNoSessionRelayToPeer other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_"></a> MergeFrom\(CMsgSteamDatagramNoSessionRelayToPeer\)

```csharp
public void MergeFrom(CMsgSteamDatagramNoSessionRelayToPeer other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToPeer](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToPeer.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToPeer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

