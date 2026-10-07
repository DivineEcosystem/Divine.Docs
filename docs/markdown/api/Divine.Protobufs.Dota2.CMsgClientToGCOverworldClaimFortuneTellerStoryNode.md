# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode"></a> Class CMsgClientToGCOverworldClaimFortuneTellerStoryNode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimFortuneTellerStoryNode : IMessage<CMsgClientToGCOverworldClaimFortuneTellerStoryNode>, IEquatable<CMsgClientToGCOverworldClaimFortuneTellerStoryNode>, IDeepCloneable<CMsgClientToGCOverworldClaimFortuneTellerStoryNode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimFortuneTellerStoryNode\>, 
[IEquatable<CMsgClientToGCOverworldClaimFortuneTellerStoryNode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimFortuneTellerStoryNode\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimFortuneTellerStoryNode\>\(CMsgClientToGCOverworldClaimFortuneTellerStoryNode, params CMsgClientToGCOverworldClaimFortuneTellerStoryNode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode__ctor"></a> CMsgClientToGCOverworldClaimFortuneTellerStoryNode\(\)

```csharp
public CMsgClientToGCOverworldClaimFortuneTellerStoryNode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_"></a> CMsgClientToGCOverworldClaimFortuneTellerStoryNode\(CMsgClientToGCOverworldClaimFortuneTellerStoryNode\)

```csharp
public CMsgClientToGCOverworldClaimFortuneTellerStoryNode(CMsgClientToGCOverworldClaimFortuneTellerStoryNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_StoryNodeIdFieldNumber"></a> StoryNodeIdFieldNumber

```csharp
public const int StoryNodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_HasStoryNodeId"></a> HasStoryNodeId

```csharp
public bool HasStoryNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimFortuneTellerStoryNode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_StoryNodeId"></a> StoryNodeId

```csharp
public uint StoryNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_ClearStoryNodeId"></a> ClearStoryNodeId\(\)

```csharp
public void ClearStoryNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimFortuneTellerStoryNode Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_"></a> Equals\(CMsgClientToGCOverworldClaimFortuneTellerStoryNode\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimFortuneTellerStoryNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_"></a> MergeFrom\(CMsgClientToGCOverworldClaimFortuneTellerStoryNode\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimFortuneTellerStoryNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneTellerStoryNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneTellerStoryNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneTellerStoryNode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

