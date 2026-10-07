# <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated"></a> Class CMsgGCToClientActiveGuildChallengeUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientActiveGuildChallengeUpdated : IMessage<CMsgGCToClientActiveGuildChallengeUpdated>, IEquatable<CMsgGCToClientActiveGuildChallengeUpdated>, IDeepCloneable<CMsgGCToClientActiveGuildChallengeUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)

#### Implements

IMessage<CMsgGCToClientActiveGuildChallengeUpdated\>, 
[IEquatable<CMsgGCToClientActiveGuildChallengeUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientActiveGuildChallengeUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientActiveGuildChallengeUpdated\>\(CMsgGCToClientActiveGuildChallengeUpdated, params CMsgGCToClientActiveGuildChallengeUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated__ctor"></a> CMsgGCToClientActiveGuildChallengeUpdated\(\)

```csharp
public CMsgGCToClientActiveGuildChallengeUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_"></a> CMsgGCToClientActiveGuildChallengeUpdated\(CMsgGCToClientActiveGuildChallengeUpdated\)

```csharp
public CMsgGCToClientActiveGuildChallengeUpdated(CMsgGCToClientActiveGuildChallengeUpdated other)
```

#### Parameters

`other` [CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_ActiveChallengeFieldNumber"></a> ActiveChallengeFieldNumber

```csharp
public const int ActiveChallengeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_ActiveChallenge"></a> ActiveChallenge

```csharp
public CMsgGuildChallenge ActiveChallenge { get; set; }
```

#### Property Value

 [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientActiveGuildChallengeUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientActiveGuildChallengeUpdated Clone()
```

#### Returns

 [CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_"></a> Equals\(CMsgGCToClientActiveGuildChallengeUpdated\)

```csharp
public bool Equals(CMsgGCToClientActiveGuildChallengeUpdated other)
```

#### Parameters

`other` [CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_"></a> MergeFrom\(CMsgGCToClientActiveGuildChallengeUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientActiveGuildChallengeUpdated other)
```

#### Parameters

`other` [CMsgGCToClientActiveGuildChallengeUpdated](Divine.Protobufs.Dota2.CMsgGCToClientActiveGuildChallengeUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientActiveGuildChallengeUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

