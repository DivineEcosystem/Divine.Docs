# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary"></a> Class CMsgSteamDatagramClientSwitchedPrimary

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramClientSwitchedPrimary : IMessage<CMsgSteamDatagramClientSwitchedPrimary>, IEquatable<CMsgSteamDatagramClientSwitchedPrimary>, IDeepCloneable<CMsgSteamDatagramClientSwitchedPrimary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)

#### Implements

IMessage<CMsgSteamDatagramClientSwitchedPrimary\>, 
[IEquatable<CMsgSteamDatagramClientSwitchedPrimary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramClientSwitchedPrimary\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramClientSwitchedPrimary\>\(CMsgSteamDatagramClientSwitchedPrimary, params CMsgSteamDatagramClientSwitchedPrimary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary__ctor"></a> CMsgSteamDatagramClientSwitchedPrimary\(\)

```csharp
public CMsgSteamDatagramClientSwitchedPrimary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_"></a> CMsgSteamDatagramClientSwitchedPrimary\(CMsgSteamDatagramClientSwitchedPrimary\)

```csharp
public CMsgSteamDatagramClientSwitchedPrimary(CMsgSteamDatagramClientSwitchedPrimary other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromActivePacketsRecvFieldNumber"></a> FromActivePacketsRecvFieldNumber

```csharp
public const int FromActivePacketsRecvFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromActiveTimeFieldNumber"></a> FromActiveTimeFieldNumber

```csharp
public const int FromActiveTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromDroppedReasonFieldNumber"></a> FromDroppedReasonFieldNumber

```csharp
public const int FromDroppedReasonFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromIpFieldNumber"></a> FromIpFieldNumber

```csharp
public const int FromIpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromPortFieldNumber"></a> FromPortFieldNumber

```csharp
public const int FromPortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromQualityNowFieldNumber"></a> FromQualityNowFieldNumber

```csharp
public const int FromQualityNowFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromQualityThenFieldNumber"></a> FromQualityThenFieldNumber

```csharp
public const int FromQualityThenFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromRouterClusterFieldNumber"></a> FromRouterClusterFieldNumber

```csharp
public const int FromRouterClusterFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_GapMsFieldNumber"></a> GapMsFieldNumber

```csharp
public const int GapMsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ToQualityNowFieldNumber"></a> ToQualityNowFieldNumber

```csharp
public const int ToQualityNowFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ToQualityThenFieldNumber"></a> ToQualityThenFieldNumber

```csharp
public const int ToQualityThenFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromActivePacketsRecv"></a> FromActivePacketsRecv

```csharp
public uint FromActivePacketsRecv { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromActiveTime"></a> FromActiveTime

```csharp
public uint FromActiveTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromDroppedReason"></a> FromDroppedReason

```csharp
public string FromDroppedReason { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromIp"></a> FromIp

```csharp
public uint FromIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromPort"></a> FromPort

```csharp
public uint FromPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromQualityNow"></a> FromQualityNow

```csharp
public CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality FromQualityNow { get; set; }
```

#### Property Value

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromQualityThen"></a> FromQualityThen

```csharp
public CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality FromQualityThen { get; set; }
```

#### Property Value

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_FromRouterCluster"></a> FromRouterCluster

```csharp
public uint FromRouterCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_GapMs"></a> GapMs

```csharp
public uint GapMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromActivePacketsRecv"></a> HasFromActivePacketsRecv

```csharp
public bool HasFromActivePacketsRecv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromActiveTime"></a> HasFromActiveTime

```csharp
public bool HasFromActiveTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromDroppedReason"></a> HasFromDroppedReason

```csharp
public bool HasFromDroppedReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromIp"></a> HasFromIp

```csharp
public bool HasFromIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromPort"></a> HasFromPort

```csharp
public bool HasFromPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasFromRouterCluster"></a> HasFromRouterCluster

```csharp
public bool HasFromRouterCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_HasGapMs"></a> HasGapMs

```csharp
public bool HasGapMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramClientSwitchedPrimary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ToQualityNow"></a> ToQualityNow

```csharp
public CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality ToQualityNow { get; set; }
```

#### Property Value

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ToQualityThen"></a> ToQualityThen

```csharp
public CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality ToQualityThen { get; set; }
```

#### Property Value

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromActivePacketsRecv"></a> ClearFromActivePacketsRecv\(\)

```csharp
public void ClearFromActivePacketsRecv()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromActiveTime"></a> ClearFromActiveTime\(\)

```csharp
public void ClearFromActiveTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromDroppedReason"></a> ClearFromDroppedReason\(\)

```csharp
public void ClearFromDroppedReason()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromIp"></a> ClearFromIp\(\)

```csharp
public void ClearFromIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromPort"></a> ClearFromPort\(\)

```csharp
public void ClearFromPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearFromRouterCluster"></a> ClearFromRouterCluster\(\)

```csharp
public void ClearFromRouterCluster()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ClearGapMs"></a> ClearGapMs\(\)

```csharp
public void ClearGapMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramClientSwitchedPrimary Clone()
```

#### Returns

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_"></a> Equals\(CMsgSteamDatagramClientSwitchedPrimary\)

```csharp
public bool Equals(CMsgSteamDatagramClientSwitchedPrimary other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_"></a> MergeFrom\(CMsgSteamDatagramClientSwitchedPrimary\)

```csharp
public void MergeFrom(CMsgSteamDatagramClientSwitchedPrimary other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

