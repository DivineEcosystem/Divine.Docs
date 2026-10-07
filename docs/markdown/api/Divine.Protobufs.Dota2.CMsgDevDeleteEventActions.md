# <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions"></a> Class CMsgDevDeleteEventActions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDevDeleteEventActions : IMessage<CMsgDevDeleteEventActions>, IEquatable<CMsgDevDeleteEventActions>, IDeepCloneable<CMsgDevDeleteEventActions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)

#### Implements

IMessage<CMsgDevDeleteEventActions\>, 
[IEquatable<CMsgDevDeleteEventActions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDevDeleteEventActions\>, 
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
[EnumerableExtensions.In<CMsgDevDeleteEventActions\>\(CMsgDevDeleteEventActions, params CMsgDevDeleteEventActions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions__ctor"></a> CMsgDevDeleteEventActions\(\)

```csharp
public CMsgDevDeleteEventActions()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions__ctor_Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_"></a> CMsgDevDeleteEventActions\(CMsgDevDeleteEventActions\)

```csharp
public CMsgDevDeleteEventActions(CMsgDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_EndActionIdFieldNumber"></a> EndActionIdFieldNumber

```csharp
public const int EndActionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_RemoveAuditFieldNumber"></a> RemoveAuditFieldNumber

```csharp
public const int RemoveAuditFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_StartActionIdFieldNumber"></a> StartActionIdFieldNumber

```csharp
public const int StartActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_EndActionId"></a> EndActionId

```csharp
public uint EndActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_HasEndActionId"></a> HasEndActionId

```csharp
public bool HasEndActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_HasRemoveAudit"></a> HasRemoveAudit

```csharp
public bool HasRemoveAudit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_HasStartActionId"></a> HasStartActionId

```csharp
public bool HasStartActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDevDeleteEventActions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_RemoveAudit"></a> RemoveAudit

```csharp
public bool RemoveAudit { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_StartActionId"></a> StartActionId

```csharp
public uint StartActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_ClearEndActionId"></a> ClearEndActionId\(\)

```csharp
public void ClearEndActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_ClearRemoveAudit"></a> ClearRemoveAudit\(\)

```csharp
public void ClearRemoveAudit()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_ClearStartActionId"></a> ClearStartActionId\(\)

```csharp
public void ClearStartActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_Clone"></a> Clone\(\)

```csharp
public CMsgDevDeleteEventActions Clone()
```

#### Returns

 [CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_Equals_Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_"></a> Equals\(CMsgDevDeleteEventActions\)

```csharp
public bool Equals(CMsgDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_MergeFrom_Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_"></a> MergeFrom\(CMsgDevDeleteEventActions\)

```csharp
public void MergeFrom(CMsgDevDeleteEventActions other)
```

#### Parameters

`other` [CMsgDevDeleteEventActions](Divine.Protobufs.Dota2.CMsgDevDeleteEventActions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevDeleteEventActions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

