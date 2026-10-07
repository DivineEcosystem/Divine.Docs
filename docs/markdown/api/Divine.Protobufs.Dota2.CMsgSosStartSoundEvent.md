# <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent"></a> Class CMsgSosStartSoundEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSosStartSoundEvent : IMessage<CMsgSosStartSoundEvent>, IEquatable<CMsgSosStartSoundEvent>, IDeepCloneable<CMsgSosStartSoundEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)

#### Implements

IMessage<CMsgSosStartSoundEvent\>, 
[IEquatable<CMsgSosStartSoundEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSosStartSoundEvent\>, 
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
[EnumerableExtensions.In<CMsgSosStartSoundEvent\>\(CMsgSosStartSoundEvent, params CMsgSosStartSoundEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent__ctor"></a> CMsgSosStartSoundEvent\(\)

```csharp
public CMsgSosStartSoundEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent__ctor_Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_"></a> CMsgSosStartSoundEvent\(CMsgSosStartSoundEvent\)

```csharp
public CMsgSosStartSoundEvent(CMsgSosStartSoundEvent other)
```

#### Parameters

`other` [CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_PackedParamsFieldNumber"></a> PackedParamsFieldNumber

```csharp
public const int PackedParamsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SeedFieldNumber"></a> SeedFieldNumber

```csharp
public const int SeedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SoundeventGuidFieldNumber"></a> SoundeventGuidFieldNumber

```csharp
public const int SoundeventGuidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SoundeventHashFieldNumber"></a> SoundeventHashFieldNumber

```csharp
public const int SoundeventHashFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SourceEntityIndexFieldNumber"></a> SourceEntityIndexFieldNumber

```csharp
public const int SourceEntityIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasPackedParams"></a> HasPackedParams

```csharp
public bool HasPackedParams { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasSeed"></a> HasSeed

```csharp
public bool HasSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasSoundeventGuid"></a> HasSoundeventGuid

```csharp
public bool HasSoundeventGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasSoundeventHash"></a> HasSoundeventHash

```csharp
public bool HasSoundeventHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasSourceEntityIndex"></a> HasSourceEntityIndex

```csharp
public bool HasSourceEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_PackedParams"></a> PackedParams

```csharp
public ByteString PackedParams { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSosStartSoundEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Seed"></a> Seed

```csharp
public int Seed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SoundeventGuid"></a> SoundeventGuid

```csharp
public int SoundeventGuid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SoundeventHash"></a> SoundeventHash

```csharp
public uint SoundeventHash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_SourceEntityIndex"></a> SourceEntityIndex

```csharp
public int SourceEntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_StartTime"></a> StartTime

```csharp
public float StartTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearPackedParams"></a> ClearPackedParams\(\)

```csharp
public void ClearPackedParams()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearSeed"></a> ClearSeed\(\)

```csharp
public void ClearSeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearSoundeventGuid"></a> ClearSoundeventGuid\(\)

```csharp
public void ClearSoundeventGuid()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearSoundeventHash"></a> ClearSoundeventHash\(\)

```csharp
public void ClearSoundeventHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearSourceEntityIndex"></a> ClearSourceEntityIndex\(\)

```csharp
public void ClearSourceEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Clone"></a> Clone\(\)

```csharp
public CMsgSosStartSoundEvent Clone()
```

#### Returns

 [CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_Equals_Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_"></a> Equals\(CMsgSosStartSoundEvent\)

```csharp
public bool Equals(CMsgSosStartSoundEvent other)
```

#### Parameters

`other` [CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_"></a> MergeFrom\(CMsgSosStartSoundEvent\)

```csharp
public void MergeFrom(CMsgSosStartSoundEvent other)
```

#### Parameters

`other` [CMsgSosStartSoundEvent](Divine.Protobufs.Dota2.CMsgSosStartSoundEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSosStartSoundEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

