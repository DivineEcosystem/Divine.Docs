# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply"></a> Class CMsgSteamDatagramClientPingSampleReply

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramClientPingSampleReply : IMessage<CMsgSteamDatagramClientPingSampleReply>, IEquatable<CMsgSteamDatagramClientPingSampleReply>, IDeepCloneable<CMsgSteamDatagramClientPingSampleReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)

#### Implements

IMessage<CMsgSteamDatagramClientPingSampleReply\>, 
[IEquatable<CMsgSteamDatagramClientPingSampleReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramClientPingSampleReply\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramClientPingSampleReply\>\(CMsgSteamDatagramClientPingSampleReply, params CMsgSteamDatagramClientPingSampleReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply__ctor"></a> CMsgSteamDatagramClientPingSampleReply\(\)

```csharp
public CMsgSteamDatagramClientPingSampleReply()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_"></a> CMsgSteamDatagramClientPingSampleReply\(CMsgSteamDatagramClientPingSampleReply\)

```csharp
public CMsgSteamDatagramClientPingSampleReply(CMsgSteamDatagramClientPingSampleReply other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_LegacyDataCentersFieldNumber"></a> LegacyDataCentersFieldNumber

```csharp
public const int LegacyDataCentersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_PopsFieldNumber"></a> PopsFieldNumber

```csharp
public const int PopsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_RelayOverrideActiveFieldNumber"></a> RelayOverrideActiveFieldNumber

```csharp
public const int RelayOverrideActiveFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_TosFieldNumber"></a> TosFieldNumber

```csharp
public const int TosFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_HasRelayOverrideActive"></a> HasRelayOverrideActive

```csharp
public bool HasRelayOverrideActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_LegacyDataCenters"></a> LegacyDataCenters

```csharp
public RepeatedField<CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter> LegacyDataCenters { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[LegacyDataCenter](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.LegacyDataCenter.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramClientPingSampleReply> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Pops"></a> Pops

```csharp
public RepeatedField<CMsgSteamDatagramClientPingSampleReply.Types.POP> Pops { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.md).[POP](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.Types.POP.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_RelayOverrideActive"></a> RelayOverrideActive

```csharp
public bool RelayOverrideActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Tos"></a> Tos

```csharp
public CMsgTOSTreatment Tos { get; set; }
```

#### Property Value

 [CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_ClearRelayOverrideActive"></a> ClearRelayOverrideActive\(\)

```csharp
public void ClearRelayOverrideActive()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramClientPingSampleReply Clone()
```

#### Returns

 [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_"></a> Equals\(CMsgSteamDatagramClientPingSampleReply\)

```csharp
public bool Equals(CMsgSteamDatagramClientPingSampleReply other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_"></a> MergeFrom\(CMsgSteamDatagramClientPingSampleReply\)

```csharp
public void MergeFrom(CMsgSteamDatagramClientPingSampleReply other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleReply](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

