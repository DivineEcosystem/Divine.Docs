# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions"></a> Class CMsgClientToGCDevDeleteEventActions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevDeleteEventActions : IMessage<CMsgClientToGCDevDeleteEventActions>, IEquatable<CMsgClientToGCDevDeleteEventActions>, IDeepCloneable<CMsgClientToGCDevDeleteEventActions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)

#### Implements

IMessage<CMsgClientToGCDevDeleteEventActions\>, 
[IEquatable<CMsgClientToGCDevDeleteEventActions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevDeleteEventActions\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevDeleteEventActions\>\(CMsgClientToGCDevDeleteEventActions, params CMsgClientToGCDevDeleteEventActions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions__ctor"></a> CMsgClientToGCDevDeleteEventActions\(\)

```csharp
public CMsgClientToGCDevDeleteEventActions()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_"></a> CMsgClientToGCDevDeleteEventActions\(CMsgClientToGCDevDeleteEventActions\)

```csharp
public CMsgClientToGCDevDeleteEventActions(CMsgClientToGCDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_EndActionIdFieldNumber"></a> EndActionIdFieldNumber

```csharp
public const int EndActionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_RemoveAuditFieldNumber"></a> RemoveAuditFieldNumber

```csharp
public const int RemoveAuditFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_StartActionIdFieldNumber"></a> StartActionIdFieldNumber

```csharp
public const int StartActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_EndActionId"></a> EndActionId

```csharp
public uint EndActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_HasEndActionId"></a> HasEndActionId

```csharp
public bool HasEndActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_HasRemoveAudit"></a> HasRemoveAudit

```csharp
public bool HasRemoveAudit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_HasStartActionId"></a> HasStartActionId

```csharp
public bool HasStartActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevDeleteEventActions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_RemoveAudit"></a> RemoveAudit

```csharp
public bool RemoveAudit { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_StartActionId"></a> StartActionId

```csharp
public uint StartActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_ClearEndActionId"></a> ClearEndActionId\(\)

```csharp
public void ClearEndActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_ClearRemoveAudit"></a> ClearRemoveAudit\(\)

```csharp
public void ClearRemoveAudit()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_ClearStartActionId"></a> ClearStartActionId\(\)

```csharp
public void ClearStartActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevDeleteEventActions Clone()
```

#### Returns

 [CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_"></a> Equals\(CMsgClientToGCDevDeleteEventActions\)

```csharp
public bool Equals(CMsgClientToGCDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_"></a> MergeFrom\(CMsgClientToGCDevDeleteEventActions\)

```csharp
public void MergeFrom(CMsgClientToGCDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActions.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

