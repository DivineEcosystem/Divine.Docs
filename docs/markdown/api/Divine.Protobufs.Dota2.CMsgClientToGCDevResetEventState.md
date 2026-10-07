# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState"></a> Class CMsgClientToGCDevResetEventState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevResetEventState : IMessage<CMsgClientToGCDevResetEventState>, IEquatable<CMsgClientToGCDevResetEventState>, IDeepCloneable<CMsgClientToGCDevResetEventState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)

#### Implements

IMessage<CMsgClientToGCDevResetEventState\>, 
[IEquatable<CMsgClientToGCDevResetEventState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevResetEventState\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevResetEventState\>\(CMsgClientToGCDevResetEventState, params CMsgClientToGCDevResetEventState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState__ctor"></a> CMsgClientToGCDevResetEventState\(\)

```csharp
public CMsgClientToGCDevResetEventState()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_"></a> CMsgClientToGCDevResetEventState\(CMsgClientToGCDevResetEventState\)

```csharp
public CMsgClientToGCDevResetEventState(CMsgClientToGCDevResetEventState other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_RemoveAuditFieldNumber"></a> RemoveAuditFieldNumber

```csharp
public const int RemoveAuditFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_HasRemoveAudit"></a> HasRemoveAudit

```csharp
public bool HasRemoveAudit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevResetEventState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_RemoveAudit"></a> RemoveAudit

```csharp
public bool RemoveAudit { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_ClearRemoveAudit"></a> ClearRemoveAudit\(\)

```csharp
public void ClearRemoveAudit()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevResetEventState Clone()
```

#### Returns

 [CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_"></a> Equals\(CMsgClientToGCDevResetEventState\)

```csharp
public bool Equals(CMsgClientToGCDevResetEventState other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_"></a> MergeFrom\(CMsgClientToGCDevResetEventState\)

```csharp
public void MergeFrom(CMsgClientToGCDevResetEventState other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventState](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventState.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

