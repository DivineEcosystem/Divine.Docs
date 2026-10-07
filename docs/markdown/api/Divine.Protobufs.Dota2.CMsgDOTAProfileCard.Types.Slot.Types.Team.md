# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team"></a> Class CMsgDOTAProfileCard.Types.Slot.Types.Team

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard.Types.Slot.Types.Team : IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Team>, IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Team>, IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Team>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard.Types.Slot.Types.Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

#### Implements

IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Team\>, 
[IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Team\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Team\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard.Types.Slot.Types.Team\>\(CMsgDOTAProfileCard.Types.Slot.Types.Team, params CMsgDOTAProfileCard.Types.Slot.Types.Team\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team__ctor"></a> Team\(\)

```csharp
public Team()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_"></a> Team\(Team\)

```csharp
public Team(CMsgDOTAProfileCard.Types.Slot.Types.Team other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard.Types.Slot.Types.Team> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Team Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_"></a> Equals\(Team\)

```csharp
public bool Equals(CMsgDOTAProfileCard.Types.Slot.Types.Team other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_"></a> MergeFrom\(Team\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard.Types.Slot.Types.Team other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Team_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

