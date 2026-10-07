# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot"></a> Class CMsgPracticeLobbySetTeamSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbySetTeamSlot : IMessage<CMsgPracticeLobbySetTeamSlot>, IEquatable<CMsgPracticeLobbySetTeamSlot>, IDeepCloneable<CMsgPracticeLobbySetTeamSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)

#### Implements

IMessage<CMsgPracticeLobbySetTeamSlot\>, 
[IEquatable<CMsgPracticeLobbySetTeamSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbySetTeamSlot\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbySetTeamSlot\>\(CMsgPracticeLobbySetTeamSlot, params CMsgPracticeLobbySetTeamSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot__ctor"></a> CMsgPracticeLobbySetTeamSlot\(\)

```csharp
public CMsgPracticeLobbySetTeamSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_"></a> CMsgPracticeLobbySetTeamSlot\(CMsgPracticeLobbySetTeamSlot\)

```csharp
public CMsgPracticeLobbySetTeamSlot(CMsgPracticeLobbySetTeamSlot other)
```

#### Parameters

`other` [CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_BotDifficultyFieldNumber"></a> BotDifficultyFieldNumber

```csharp
public const int BotDifficultyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_BotDifficulty"></a> BotDifficulty

```csharp
public DOTABotDifficulty BotDifficulty { get; set; }
```

#### Property Value

 [DOTABotDifficulty](Divine.Protobufs.Dota2.DOTABotDifficulty.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_HasBotDifficulty"></a> HasBotDifficulty

```csharp
public bool HasBotDifficulty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbySetTeamSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Slot"></a> Slot

```csharp
public uint Slot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Team"></a> Team

```csharp
public DOTA_GC_TEAM Team { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_ClearBotDifficulty"></a> ClearBotDifficulty\(\)

```csharp
public void ClearBotDifficulty()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbySetTeamSlot Clone()
```

#### Returns

 [CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_"></a> Equals\(CMsgPracticeLobbySetTeamSlot\)

```csharp
public bool Equals(CMsgPracticeLobbySetTeamSlot other)
```

#### Parameters

`other` [CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_"></a> MergeFrom\(CMsgPracticeLobbySetTeamSlot\)

```csharp
public void MergeFrom(CMsgPracticeLobbySetTeamSlot other)
```

#### Parameters

`other` [CMsgPracticeLobbySetTeamSlot](Divine.Protobufs.Dota2.CMsgPracticeLobbySetTeamSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetTeamSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

