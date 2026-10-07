# <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated"></a> Class CMsgGCToClientEventPointsUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientEventPointsUpdated : IMessage<CMsgGCToClientEventPointsUpdated>, IEquatable<CMsgGCToClientEventPointsUpdated>, IDeepCloneable<CMsgGCToClientEventPointsUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)

#### Implements

IMessage<CMsgGCToClientEventPointsUpdated\>, 
[IEquatable<CMsgGCToClientEventPointsUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientEventPointsUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientEventPointsUpdated\>\(CMsgGCToClientEventPointsUpdated, params CMsgGCToClientEventPointsUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated__ctor"></a> CMsgGCToClientEventPointsUpdated\(\)

```csharp
public CMsgGCToClientEventPointsUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_"></a> CMsgGCToClientEventPointsUpdated\(CMsgGCToClientEventPointsUpdated\)

```csharp
public CMsgGCToClientEventPointsUpdated(CMsgGCToClientEventPointsUpdated other)
```

#### Parameters

`other` [CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_EventPoints"></a> EventPoints

```csharp
public CMsgUserEventPoints EventPoints { get; set; }
```

#### Property Value

 [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientEventPointsUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientEventPointsUpdated Clone()
```

#### Returns

 [CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_"></a> Equals\(CMsgGCToClientEventPointsUpdated\)

```csharp
public bool Equals(CMsgGCToClientEventPointsUpdated other)
```

#### Parameters

`other` [CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_"></a> MergeFrom\(CMsgGCToClientEventPointsUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientEventPointsUpdated other)
```

#### Parameters

`other` [CMsgGCToClientEventPointsUpdated](Divine.Protobufs.Dota2.CMsgGCToClientEventPointsUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientEventPointsUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

