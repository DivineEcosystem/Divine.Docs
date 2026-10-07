# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode"></a> Class CMsgClientToGCOverworldDevResetNode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevResetNode : IMessage<CMsgClientToGCOverworldDevResetNode>, IEquatable<CMsgClientToGCOverworldDevResetNode>, IDeepCloneable<CMsgClientToGCOverworldDevResetNode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevResetNode\>, 
[IEquatable<CMsgClientToGCOverworldDevResetNode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevResetNode\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevResetNode\>\(CMsgClientToGCOverworldDevResetNode, params CMsgClientToGCOverworldDevResetNode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode__ctor"></a> CMsgClientToGCOverworldDevResetNode\(\)

```csharp
public CMsgClientToGCOverworldDevResetNode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_"></a> CMsgClientToGCOverworldDevResetNode\(CMsgClientToGCOverworldDevResetNode\)

```csharp
public CMsgClientToGCOverworldDevResetNode(CMsgClientToGCOverworldDevResetNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevResetNode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevResetNode Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_"></a> Equals\(CMsgClientToGCOverworldDevResetNode\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevResetNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_"></a> MergeFrom\(CMsgClientToGCOverworldDevResetNode\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevResetNode other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetNode](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetNode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

