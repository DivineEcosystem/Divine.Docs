# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated"></a> Class CMsgGCToClientGuildUnderDraftGoldUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGuildUnderDraftGoldUpdated : IMessage<CMsgGCToClientGuildUnderDraftGoldUpdated>, IEquatable<CMsgGCToClientGuildUnderDraftGoldUpdated>, IDeepCloneable<CMsgGCToClientGuildUnderDraftGoldUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)

#### Implements

IMessage<CMsgGCToClientGuildUnderDraftGoldUpdated\>, 
[IEquatable<CMsgGCToClientGuildUnderDraftGoldUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGuildUnderDraftGoldUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGuildUnderDraftGoldUpdated\>\(CMsgGCToClientGuildUnderDraftGoldUpdated, params CMsgGCToClientGuildUnderDraftGoldUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated__ctor"></a> CMsgGCToClientGuildUnderDraftGoldUpdated\(\)

```csharp
public CMsgGCToClientGuildUnderDraftGoldUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_"></a> CMsgGCToClientGuildUnderDraftGoldUpdated\(CMsgGCToClientGuildUnderDraftGoldUpdated\)

```csharp
public CMsgGCToClientGuildUnderDraftGoldUpdated(CMsgGCToClientGuildUnderDraftGoldUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGuildUnderDraftGoldUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGuildUnderDraftGoldUpdated Clone()
```

#### Returns

 [CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_"></a> Equals\(CMsgGCToClientGuildUnderDraftGoldUpdated\)

```csharp
public bool Equals(CMsgGCToClientGuildUnderDraftGoldUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_"></a> MergeFrom\(CMsgGCToClientGuildUnderDraftGoldUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientGuildUnderDraftGoldUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildUnderDraftGoldUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildUnderDraftGoldUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildUnderDraftGoldUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

