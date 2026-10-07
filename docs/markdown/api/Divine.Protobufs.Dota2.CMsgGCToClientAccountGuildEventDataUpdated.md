# <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated"></a> Class CMsgGCToClientAccountGuildEventDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientAccountGuildEventDataUpdated : IMessage<CMsgGCToClientAccountGuildEventDataUpdated>, IEquatable<CMsgGCToClientAccountGuildEventDataUpdated>, IDeepCloneable<CMsgGCToClientAccountGuildEventDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientAccountGuildEventDataUpdated\>, 
[IEquatable<CMsgGCToClientAccountGuildEventDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientAccountGuildEventDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientAccountGuildEventDataUpdated\>\(CMsgGCToClientAccountGuildEventDataUpdated, params CMsgGCToClientAccountGuildEventDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated__ctor"></a> CMsgGCToClientAccountGuildEventDataUpdated\(\)

```csharp
public CMsgGCToClientAccountGuildEventDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_"></a> CMsgGCToClientAccountGuildEventDataUpdated\(CMsgGCToClientAccountGuildEventDataUpdated\)

```csharp
public CMsgGCToClientAccountGuildEventDataUpdated(CMsgGCToClientAccountGuildEventDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ContractsUpdatedFieldNumber"></a> ContractsUpdatedFieldNumber

```csharp
public const int ContractsUpdatedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_GuildEventDataFieldNumber"></a> GuildEventDataFieldNumber

```csharp
public const int GuildEventDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_UpdateFlagsFieldNumber"></a> UpdateFlagsFieldNumber

```csharp
public const int UpdateFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ContractsUpdated"></a> ContractsUpdated

```csharp
public bool ContractsUpdated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_GuildEventData"></a> GuildEventData

```csharp
public CMsgAccountGuildEventData GuildEventData { get; set; }
```

#### Property Value

 [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_HasContractsUpdated"></a> HasContractsUpdated

```csharp
public bool HasContractsUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_HasUpdateFlags"></a> HasUpdateFlags

```csharp
public bool HasUpdateFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientAccountGuildEventDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_UpdateFlags"></a> UpdateFlags

```csharp
public uint UpdateFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ClearContractsUpdated"></a> ClearContractsUpdated\(\)

```csharp
public void ClearContractsUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ClearUpdateFlags"></a> ClearUpdateFlags\(\)

```csharp
public void ClearUpdateFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientAccountGuildEventDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_"></a> Equals\(CMsgGCToClientAccountGuildEventDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientAccountGuildEventDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_"></a> MergeFrom\(CMsgGCToClientAccountGuildEventDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientAccountGuildEventDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientAccountGuildEventDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientAccountGuildEventDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAccountGuildEventDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

