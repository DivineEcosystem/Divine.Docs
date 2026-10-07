# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree"></a> Class CMsgBotWorldState.Types.EventTree

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.EventTree : IMessage<CMsgBotWorldState.Types.EventTree>, IEquatable<CMsgBotWorldState.Types.EventTree>, IDeepCloneable<CMsgBotWorldState.Types.EventTree>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)

#### Implements

IMessage<CMsgBotWorldState.Types.EventTree\>, 
[IEquatable<CMsgBotWorldState.Types.EventTree\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.EventTree\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.EventTree\>\(CMsgBotWorldState.Types.EventTree, params CMsgBotWorldState.Types.EventTree\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree__ctor"></a> EventTree\(\)

```csharp
public EventTree()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_"></a> EventTree\(EventTree\)

```csharp
public EventTree(CMsgBotWorldState.Types.EventTree other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_DelayedFieldNumber"></a> DelayedFieldNumber

```csharp
public const int DelayedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_DestroyedFieldNumber"></a> DestroyedFieldNumber

```csharp
public const int DestroyedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_RespawnedFieldNumber"></a> RespawnedFieldNumber

```csharp
public const int RespawnedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_TreeIdFieldNumber"></a> TreeIdFieldNumber

```csharp
public const int TreeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Delayed"></a> Delayed

```csharp
public bool Delayed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Destroyed"></a> Destroyed

```csharp
public bool Destroyed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_HasDelayed"></a> HasDelayed

```csharp
public bool HasDelayed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_HasDestroyed"></a> HasDestroyed

```csharp
public bool HasDestroyed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_HasRespawned"></a> HasRespawned

```csharp
public bool HasRespawned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_HasTreeId"></a> HasTreeId

```csharp
public bool HasTreeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.EventTree> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Respawned"></a> Respawned

```csharp
public bool Respawned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_TreeId"></a> TreeId

```csharp
public uint TreeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_ClearDelayed"></a> ClearDelayed\(\)

```csharp
public void ClearDelayed()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_ClearDestroyed"></a> ClearDestroyed\(\)

```csharp
public void ClearDestroyed()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_ClearRespawned"></a> ClearRespawned\(\)

```csharp
public void ClearRespawned()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_ClearTreeId"></a> ClearTreeId\(\)

```csharp
public void ClearTreeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.EventTree Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_"></a> Equals\(EventTree\)

```csharp
public bool Equals(CMsgBotWorldState.Types.EventTree other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_"></a> MergeFrom\(EventTree\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.EventTree other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventTree_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

