# <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel"></a> Class CSODOTAPartyMember.Types.EventGameLevel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAPartyMember.Types.EventGameLevel : IMessage<CSODOTAPartyMember.Types.EventGameLevel>, IEquatable<CSODOTAPartyMember.Types.EventGameLevel>, IDeepCloneable<CSODOTAPartyMember.Types.EventGameLevel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAPartyMember.Types.EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)

#### Implements

IMessage<CSODOTAPartyMember.Types.EventGameLevel\>, 
[IEquatable<CSODOTAPartyMember.Types.EventGameLevel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAPartyMember.Types.EventGameLevel\>, 
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
[EnumerableExtensions.In<CSODOTAPartyMember.Types.EventGameLevel\>\(CSODOTAPartyMember.Types.EventGameLevel, params CSODOTAPartyMember.Types.EventGameLevel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel__ctor"></a> EventGameLevel\(\)

```csharp
public EventGameLevel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel__ctor_Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_"></a> EventGameLevel\(EventGameLevel\)

```csharp
public EventGameLevel(CSODOTAPartyMember.Types.EventGameLevel other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.md).[EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAPartyMember.Types.EventGameLevel> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.md).[EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Clone"></a> Clone\(\)

```csharp
public CSODOTAPartyMember.Types.EventGameLevel Clone()
```

#### Returns

 [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.md).[EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_Equals_Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_"></a> Equals\(EventGameLevel\)

```csharp
public bool Equals(CSODOTAPartyMember.Types.EventGameLevel other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.md).[EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_MergeFrom_Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_"></a> MergeFrom\(EventGameLevel\)

```csharp
public void MergeFrom(CSODOTAPartyMember.Types.EventGameLevel other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.md).[EventGameLevel](Divine.Protobufs.Dota2.CSODOTAPartyMember.Types.EventGameLevel.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Types_EventGameLevel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

