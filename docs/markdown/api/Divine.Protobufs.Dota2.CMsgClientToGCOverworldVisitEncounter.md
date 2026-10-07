# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter"></a> Class CMsgClientToGCOverworldVisitEncounter

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldVisitEncounter : IMessage<CMsgClientToGCOverworldVisitEncounter>, IEquatable<CMsgClientToGCOverworldVisitEncounter>, IDeepCloneable<CMsgClientToGCOverworldVisitEncounter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)

#### Implements

IMessage<CMsgClientToGCOverworldVisitEncounter\>, 
[IEquatable<CMsgClientToGCOverworldVisitEncounter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldVisitEncounter\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldVisitEncounter\>\(CMsgClientToGCOverworldVisitEncounter, params CMsgClientToGCOverworldVisitEncounter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter__ctor"></a> CMsgClientToGCOverworldVisitEncounter\(\)

```csharp
public CMsgClientToGCOverworldVisitEncounter()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_"></a> CMsgClientToGCOverworldVisitEncounter\(CMsgClientToGCOverworldVisitEncounter\)

```csharp
public CMsgClientToGCOverworldVisitEncounter(CMsgClientToGCOverworldVisitEncounter other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldVisitEncounter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldVisitEncounter Clone()
```

#### Returns

 [CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_"></a> Equals\(CMsgClientToGCOverworldVisitEncounter\)

```csharp
public bool Equals(CMsgClientToGCOverworldVisitEncounter other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_"></a> MergeFrom\(CMsgClientToGCOverworldVisitEncounter\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldVisitEncounter other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounter](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounter.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

