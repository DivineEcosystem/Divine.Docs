# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter"></a> Class CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter : IMessage<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter>, IEquatable<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter>, IDeepCloneable<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)

#### Implements

IMessage<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter\>, 
[IEquatable<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter\>\(CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter, params CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter__ctor"></a> LegacyDataCenter\(\)

```csharp
public LegacyDataCenter()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_"></a> LegacyDataCenter\(LegacyDataCenter\)

```csharp
public LegacyDataCenter(CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_BestDcPingMsFieldNumber"></a> BestDcPingMsFieldNumber

```csharp
public const int BestDcPingMsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_BestDcViaRelayPopIdFieldNumber"></a> BestDcViaRelayPopIdFieldNumber

```csharp
public const int BestDcViaRelayPopIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_DataCenterIdFieldNumber"></a> DataCenterIdFieldNumber

```csharp
public const int DataCenterIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_BestDcPingMs"></a> BestDcPingMs

```csharp
public uint BestDcPingMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_BestDcViaRelayPopId"></a> BestDcViaRelayPopId

```csharp
public uint BestDcViaRelayPopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_DataCenterId"></a> DataCenterId

```csharp
public uint DataCenterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_HasBestDcPingMs"></a> HasBestDcPingMs

```csharp
public bool HasBestDcPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_HasBestDcViaRelayPopId"></a> HasBestDcViaRelayPopId

```csharp
public bool HasBestDcViaRelayPopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_HasDataCenterId"></a> HasDataCenterId

```csharp
public bool HasDataCenterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_ClearBestDcPingMs"></a> ClearBestDcPingMs\(\)

```csharp
public void ClearBestDcPingMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_ClearBestDcViaRelayPopId"></a> ClearBestDcViaRelayPopId\(\)

```csharp
public void ClearBestDcViaRelayPopId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_ClearDataCenterId"></a> ClearDataCenterId\(\)

```csharp
public void ClearDataCenterId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter Clone()
```

#### Returns

 [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_"></a> Equals\(LegacyDataCenter\)

```csharp
public bool Equals(CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_"></a> MergeFrom\(LegacyDataCenter\)

```csharp
public void MergeFrom(CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Types_LegacyDataCenter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

