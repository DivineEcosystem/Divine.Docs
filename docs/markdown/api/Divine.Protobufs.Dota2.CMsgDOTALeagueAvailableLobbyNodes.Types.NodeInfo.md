# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo"></a> Class CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo : IMessage<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo>, IEquatable<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo>, IDeepCloneable<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)

#### Implements

IMessage<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo\>, 
[IEquatable<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo\>\(CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo, params CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo__ctor"></a> NodeInfo\(\)

```csharp
public NodeInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_"></a> NodeInfo\(NodeInfo\)

```csharp
public NodeInfo(CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeGroupNameFieldNumber"></a> NodeGroupNameFieldNumber

```csharp
public const int NodeGroupNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeNameFieldNumber"></a> NodeNameFieldNumber

```csharp
public const int NodeNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_TeamId1FieldNumber"></a> TeamId1FieldNumber

```csharp
public const int TeamId1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_TeamId2FieldNumber"></a> TeamId2FieldNumber

```csharp
public const int TeamId2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_HasNodeGroupName"></a> HasNodeGroupName

```csharp
public bool HasNodeGroupName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_HasNodeName"></a> HasNodeName

```csharp
public bool HasNodeName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_HasTeamId1"></a> HasTeamId1

```csharp
public bool HasTeamId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_HasTeamId2"></a> HasTeamId2

```csharp
public bool HasTeamId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeGroupName"></a> NodeGroupName

```csharp
public string NodeGroupName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_NodeName"></a> NodeName

```csharp
public string NodeName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_TeamId1"></a> TeamId1

```csharp
public uint TeamId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_TeamId2"></a> TeamId2

```csharp
public uint TeamId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ClearNodeGroupName"></a> ClearNodeGroupName\(\)

```csharp
public void ClearNodeGroupName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ClearNodeName"></a> ClearNodeName\(\)

```csharp
public void ClearNodeName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ClearTeamId1"></a> ClearTeamId1\(\)

```csharp
public void ClearTeamId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ClearTeamId2"></a> ClearTeamId2\(\)

```csharp
public void ClearTeamId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo Clone()
```

#### Returns

 [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_"></a> Equals\(NodeInfo\)

```csharp
public bool Equals(CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_"></a> MergeFrom\(NodeInfo\)

```csharp
public void MergeFrom(CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Types_NodeInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

