# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException"></a> Class CMsgSteamDatagramRouterPingReply.Types.RouteException

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramRouterPingReply.Types.RouteException : IMessage<CMsgSteamDatagramRouterPingReply.Types.RouteException>, IEquatable<CMsgSteamDatagramRouterPingReply.Types.RouteException>, IDeepCloneable<CMsgSteamDatagramRouterPingReply.Types.RouteException>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramRouterPingReply.Types.RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)

#### Implements

IMessage<CMsgSteamDatagramRouterPingReply.Types.RouteException\>, 
[IEquatable<CMsgSteamDatagramRouterPingReply.Types.RouteException\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramRouterPingReply.Types.RouteException\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramRouterPingReply.Types.RouteException\>\(CMsgSteamDatagramRouterPingReply.Types.RouteException, params CMsgSteamDatagramRouterPingReply.Types.RouteException\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException__ctor"></a> RouteException\(\)

```csharp
public RouteException()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_"></a> RouteException\(RouteException\)

```csharp
public RouteException(CMsgSteamDatagramRouterPingReply.Types.RouteException other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_DataCenterIdFieldNumber"></a> DataCenterIdFieldNumber

```csharp
public const int DataCenterIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_PenaltyFieldNumber"></a> PenaltyFieldNumber

```csharp
public const int PenaltyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_DataCenterId"></a> DataCenterId

```csharp
public uint DataCenterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_HasDataCenterId"></a> HasDataCenterId

```csharp
public bool HasDataCenterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_HasPenalty"></a> HasPenalty

```csharp
public bool HasPenalty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramRouterPingReply.Types.RouteException> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Penalty"></a> Penalty

```csharp
public uint Penalty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_ClearDataCenterId"></a> ClearDataCenterId\(\)

```csharp
public void ClearDataCenterId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_ClearPenalty"></a> ClearPenalty\(\)

```csharp
public void ClearPenalty()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramRouterPingReply.Types.RouteException Clone()
```

#### Returns

 [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_"></a> Equals\(RouteException\)

```csharp
public bool Equals(CMsgSteamDatagramRouterPingReply.Types.RouteException other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_"></a> MergeFrom\(RouteException\)

```csharp
public void MergeFrom(CMsgSteamDatagramRouterPingReply.Types.RouteException other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_RouteException_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

