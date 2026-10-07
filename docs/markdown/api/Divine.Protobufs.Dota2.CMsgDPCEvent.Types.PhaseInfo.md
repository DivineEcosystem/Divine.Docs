# <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo"></a> Class CMsgDPCEvent.Types.PhaseInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDPCEvent.Types.PhaseInfo : IMessage<CMsgDPCEvent.Types.PhaseInfo>, IEquatable<CMsgDPCEvent.Types.PhaseInfo>, IDeepCloneable<CMsgDPCEvent.Types.PhaseInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDPCEvent.Types.PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)

#### Implements

IMessage<CMsgDPCEvent.Types.PhaseInfo\>, 
[IEquatable<CMsgDPCEvent.Types.PhaseInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDPCEvent.Types.PhaseInfo\>, 
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
[EnumerableExtensions.In<CMsgDPCEvent.Types.PhaseInfo\>\(CMsgDPCEvent.Types.PhaseInfo, params CMsgDPCEvent.Types.PhaseInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo__ctor"></a> PhaseInfo\(\)

```csharp
public PhaseInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo__ctor_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_"></a> PhaseInfo\(PhaseInfo\)

```csharp
public PhaseInfo(CMsgDPCEvent.Types.PhaseInfo other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_NodeGroupIdFieldNumber"></a> NodeGroupIdFieldNumber

```csharp
public const int NodeGroupIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_PhaseFieldNumber"></a> PhaseFieldNumber

```csharp
public const int PhaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_HasNodeGroupId"></a> HasNodeGroupId

```csharp
public bool HasNodeGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_HasPhase"></a> HasPhase

```csharp
public bool HasPhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_NodeGroupId"></a> NodeGroupId

```csharp
public uint NodeGroupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDPCEvent.Types.PhaseInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Phase"></a> Phase

```csharp
public CMsgDPCEvent.Types.ELeagueEventPhase Phase { get; set; }
```

#### Property Value

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[ELeagueEventPhase](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.ELeagueEventPhase.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_ClearNodeGroupId"></a> ClearNodeGroupId\(\)

```csharp
public void ClearNodeGroupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_ClearPhase"></a> ClearPhase\(\)

```csharp
public void ClearPhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDPCEvent.Types.PhaseInfo Clone()
```

#### Returns

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_Equals_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_"></a> Equals\(PhaseInfo\)

```csharp
public bool Equals(CMsgDPCEvent.Types.PhaseInfo other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_"></a> MergeFrom\(PhaseInfo\)

```csharp
public void MergeFrom(CMsgDPCEvent.Types.PhaseInfo other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_PhaseInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

