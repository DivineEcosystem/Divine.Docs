# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat"></a> Class CMsgDOTAProfileCard.Types.Slot.Types.Stat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard.Types.Slot.Types.Stat : IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Stat>, IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Stat>, IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Stat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard.Types.Slot.Types.Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

#### Implements

IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Stat\>, 
[IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Stat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Stat\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard.Types.Slot.Types.Stat\>\(CMsgDOTAProfileCard.Types.Slot.Types.Stat, params CMsgDOTAProfileCard.Types.Slot.Types.Stat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat__ctor"></a> Stat\(\)

```csharp
public Stat()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_"></a> Stat\(Stat\)

```csharp
public Stat(CMsgDOTAProfileCard.Types.Slot.Types.Stat other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_StatIdFieldNumber"></a> StatIdFieldNumber

```csharp
public const int StatIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_StatScoreFieldNumber"></a> StatScoreFieldNumber

```csharp
public const int StatScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_HasStatId"></a> HasStatId

```csharp
public bool HasStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_HasStatScore"></a> HasStatScore

```csharp
public bool HasStatScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard.Types.Slot.Types.Stat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_StatId"></a> StatId

```csharp
public CMsgDOTAProfileCard.Types.EStatID StatId { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[EStatID](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.EStatID.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_StatScore"></a> StatScore

```csharp
public uint StatScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_ClearStatId"></a> ClearStatId\(\)

```csharp
public void ClearStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_ClearStatScore"></a> ClearStatScore\(\)

```csharp
public void ClearStatScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Stat Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_"></a> Equals\(Stat\)

```csharp
public bool Equals(CMsgDOTAProfileCard.Types.Slot.Types.Stat other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_"></a> MergeFrom\(Stat\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard.Types.Slot.Types.Stat other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Stat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

