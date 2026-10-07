# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction"></a> Class CMsgClientToGCDevGrantEventAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevGrantEventAction : IMessage<CMsgClientToGCDevGrantEventAction>, IEquatable<CMsgClientToGCDevGrantEventAction>, IDeepCloneable<CMsgClientToGCDevGrantEventAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)

#### Implements

IMessage<CMsgClientToGCDevGrantEventAction\>, 
[IEquatable<CMsgClientToGCDevGrantEventAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevGrantEventAction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevGrantEventAction\>\(CMsgClientToGCDevGrantEventAction, params CMsgClientToGCDevGrantEventAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction__ctor"></a> CMsgClientToGCDevGrantEventAction\(\)

```csharp
public CMsgClientToGCDevGrantEventAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_"></a> CMsgClientToGCDevGrantEventAction\(CMsgClientToGCDevGrantEventAction\)

```csharp
public CMsgClientToGCDevGrantEventAction(CMsgClientToGCDevGrantEventAction other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ActionScoreFieldNumber"></a> ActionScoreFieldNumber

```csharp
public const int ActionScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ActionScore"></a> ActionScore

```csharp
public uint ActionScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_HasActionScore"></a> HasActionScore

```csharp
public bool HasActionScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevGrantEventAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ClearActionScore"></a> ClearActionScore\(\)

```csharp
public void ClearActionScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevGrantEventAction Clone()
```

#### Returns

 [CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_"></a> Equals\(CMsgClientToGCDevGrantEventAction\)

```csharp
public bool Equals(CMsgClientToGCDevGrantEventAction other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_"></a> MergeFrom\(CMsgClientToGCDevGrantEventAction\)

```csharp
public void MergeFrom(CMsgClientToGCDevGrantEventAction other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventAction](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

