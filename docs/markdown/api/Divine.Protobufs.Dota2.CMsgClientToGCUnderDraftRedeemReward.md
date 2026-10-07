# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward"></a> Class CMsgClientToGCUnderDraftRedeemReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftRedeemReward : IMessage<CMsgClientToGCUnderDraftRedeemReward>, IEquatable<CMsgClientToGCUnderDraftRedeemReward>, IDeepCloneable<CMsgClientToGCUnderDraftRedeemReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftRedeemReward\>, 
[IEquatable<CMsgClientToGCUnderDraftRedeemReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftRedeemReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftRedeemReward\>\(CMsgClientToGCUnderDraftRedeemReward, params CMsgClientToGCUnderDraftRedeemReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward__ctor"></a> CMsgClientToGCUnderDraftRedeemReward\(\)

```csharp
public CMsgClientToGCUnderDraftRedeemReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_"></a> CMsgClientToGCUnderDraftRedeemReward\(CMsgClientToGCUnderDraftRedeemReward\)

```csharp
public CMsgClientToGCUnderDraftRedeemReward(CMsgClientToGCUnderDraftRedeemReward other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftRedeemReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftRedeemReward Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_"></a> Equals\(CMsgClientToGCUnderDraftRedeemReward\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftRedeemReward other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_"></a> MergeFrom\(CMsgClientToGCUnderDraftRedeemReward\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftRedeemReward other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemReward](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

