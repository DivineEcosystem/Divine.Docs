# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll"></a> Class CDOTAClientMsg\_ChallengeReroll

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChallengeReroll : IMessage<CDOTAClientMsg_ChallengeReroll>, IEquatable<CDOTAClientMsg_ChallengeReroll>, IDeepCloneable<CDOTAClientMsg_ChallengeReroll>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)

#### Implements

IMessage<CDOTAClientMsg\_ChallengeReroll\>, 
[IEquatable<CDOTAClientMsg\_ChallengeReroll\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChallengeReroll\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChallengeReroll\>\(CDOTAClientMsg\_ChallengeReroll, params CDOTAClientMsg\_ChallengeReroll\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll__ctor"></a> CDOTAClientMsg\_ChallengeReroll\(\)

```csharp
public CDOTAClientMsg_ChallengeReroll()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_"></a> CDOTAClientMsg\_ChallengeReroll\(CDOTAClientMsg\_ChallengeReroll\)

```csharp
public CDOTAClientMsg_ChallengeReroll(CDOTAClientMsg_ChallengeReroll other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_SequenceIdFieldNumber"></a> SequenceIdFieldNumber

```csharp
public const int SequenceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HasSequenceId"></a> HasSequenceId

```csharp
public bool HasSequenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChallengeReroll> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_SequenceId"></a> SequenceId

```csharp
public uint SequenceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_ClearSequenceId"></a> ClearSequenceId\(\)

```csharp
public void ClearSequenceId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChallengeReroll Clone()
```

#### Returns

 [CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_"></a> Equals\(CDOTAClientMsg\_ChallengeReroll\)

```csharp
public bool Equals(CDOTAClientMsg_ChallengeReroll other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_"></a> MergeFrom\(CDOTAClientMsg\_ChallengeReroll\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChallengeReroll other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeReroll](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeReroll.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeReroll_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

