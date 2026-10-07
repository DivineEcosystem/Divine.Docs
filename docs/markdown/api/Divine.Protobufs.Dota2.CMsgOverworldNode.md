# <a id="Divine_Protobufs_Dota2_CMsgOverworldNode"></a> Class CMsgOverworldNode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldNode : IMessage<CMsgOverworldNode>, IEquatable<CMsgOverworldNode>, IDeepCloneable<CMsgOverworldNode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)

#### Implements

IMessage<CMsgOverworldNode\>, 
[IEquatable<CMsgOverworldNode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldNode\>, 
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
[EnumerableExtensions.In<CMsgOverworldNode\>\(CMsgOverworldNode, params CMsgOverworldNode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode__ctor"></a> CMsgOverworldNode\(\)

```csharp
public CMsgOverworldNode()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode__ctor_Divine_Protobufs_Dota2_CMsgOverworldNode_"></a> CMsgOverworldNode\(CMsgOverworldNode\)

```csharp
public CMsgOverworldNode(CMsgOverworldNode other)
```

#### Parameters

`other` [CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeEncounterDataFieldNumber"></a> NodeEncounterDataFieldNumber

```csharp
public const int NodeEncounterDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeStateFieldNumber"></a> NodeStateFieldNumber

```csharp
public const int NodeStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_HasNodeState"></a> HasNodeState

```csharp
public bool HasNodeState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeEncounterData"></a> NodeEncounterData

```csharp
public CMsgOverworldEncounterData NodeEncounterData { get; set; }
```

#### Property Value

 [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_NodeState"></a> NodeState

```csharp
public EOverworldNodeState NodeState { get; set; }
```

#### Property Value

 [EOverworldNodeState](Divine.Protobufs.Dota2.EOverworldNodeState.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldNode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_ClearNodeState"></a> ClearNodeState\(\)

```csharp
public void ClearNodeState()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldNode Clone()
```

#### Returns

 [CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_Equals_Divine_Protobufs_Dota2_CMsgOverworldNode_"></a> Equals\(CMsgOverworldNode\)

```csharp
public bool Equals(CMsgOverworldNode other)
```

#### Parameters

`other` [CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldNode_"></a> MergeFrom\(CMsgOverworldNode\)

```csharp
public void MergeFrom(CMsgOverworldNode other)
```

#### Parameters

`other` [CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldNode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

