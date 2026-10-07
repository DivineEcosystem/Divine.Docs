# <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node"></a> Class CMsgDOTATournament.Types.Node

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournament.Types.Node : IMessage<CMsgDOTATournament.Types.Node>, IEquatable<CMsgDOTATournament.Types.Node>, IDeepCloneable<CMsgDOTATournament.Types.Node>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournament.Types.Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)

#### Implements

IMessage<CMsgDOTATournament.Types.Node\>, 
[IEquatable<CMsgDOTATournament.Types.Node\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournament.Types.Node\>, 
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
[EnumerableExtensions.In<CMsgDOTATournament.Types.Node\>\(CMsgDOTATournament.Types.Node, params CMsgDOTATournament.Types.Node\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node__ctor"></a> Node\(\)

```csharp
public Node()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node__ctor_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_"></a> Node\(Node\)

```csharp
public Node(CMsgDOTATournament.Types.Node other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_NodeStateFieldNumber"></a> NodeStateFieldNumber

```csharp
public const int NodeStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_TeamIdxAFieldNumber"></a> TeamIdxAFieldNumber

```csharp
public const int TeamIdxAFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_TeamIdxBFieldNumber"></a> TeamIdxBFieldNumber

```csharp
public const int TeamIdxBFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_HasNodeState"></a> HasNodeState

```csharp
public bool HasNodeState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_HasTeamIdxA"></a> HasTeamIdxA

```csharp
public bool HasTeamIdxA { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_HasTeamIdxB"></a> HasTeamIdxB

```csharp
public bool HasTeamIdxB { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_NodeState"></a> NodeState

```csharp
public ETournamentNodeState NodeState { get; set; }
```

#### Property Value

 [ETournamentNodeState](Divine.Protobufs.Dota2.ETournamentNodeState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournament.Types.Node> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_TeamIdxA"></a> TeamIdxA

```csharp
public uint TeamIdxA { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_TeamIdxB"></a> TeamIdxB

```csharp
public uint TeamIdxB { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_ClearNodeState"></a> ClearNodeState\(\)

```csharp
public void ClearNodeState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_ClearTeamIdxA"></a> ClearTeamIdxA\(\)

```csharp
public void ClearTeamIdxA()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_ClearTeamIdxB"></a> ClearTeamIdxB\(\)

```csharp
public void ClearTeamIdxB()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournament.Types.Node Clone()
```

#### Returns

 [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_Equals_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_"></a> Equals\(Node\)

```csharp
public bool Equals(CMsgDOTATournament.Types.Node other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_"></a> MergeFrom\(Node\)

```csharp
public void MergeFrom(CMsgDOTATournament.Types.Node other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Node_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

