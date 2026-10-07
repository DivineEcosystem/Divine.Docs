# <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance"></a> Class CDOTASaveGame.Types.SaveInstance

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTASaveGame.Types.SaveInstance : IMessage<CDOTASaveGame.Types.SaveInstance>, IEquatable<CDOTASaveGame.Types.SaveInstance>, IDeepCloneable<CDOTASaveGame.Types.SaveInstance>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTASaveGame.Types.SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)

#### Implements

IMessage<CDOTASaveGame.Types.SaveInstance\>, 
[IEquatable<CDOTASaveGame.Types.SaveInstance\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTASaveGame.Types.SaveInstance\>, 
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
[EnumerableExtensions.In<CDOTASaveGame.Types.SaveInstance\>\(CDOTASaveGame.Types.SaveInstance, params CDOTASaveGame.Types.SaveInstance\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance__ctor"></a> SaveInstance\(\)

```csharp
public SaveInstance()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance__ctor_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_"></a> SaveInstance\(SaveInstance\)

```csharp
public SaveInstance(CDOTASaveGame.Types.SaveInstance other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_PlayerPositionsFieldNumber"></a> PlayerPositionsFieldNumber

```csharp
public const int PlayerPositionsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_SaveIdFieldNumber"></a> SaveIdFieldNumber

```csharp
public const int SaveIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_SaveTimeFieldNumber"></a> SaveTimeFieldNumber

```csharp
public const int SaveTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Team1ScoreFieldNumber"></a> Team1ScoreFieldNumber

```csharp
public const int Team1ScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Team2ScoreFieldNumber"></a> Team2ScoreFieldNumber

```csharp
public const int Team2ScoreFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_GameTime"></a> GameTime

```csharp
public uint GameTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_HasSaveId"></a> HasSaveId

```csharp
public bool HasSaveId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_HasSaveTime"></a> HasSaveTime

```csharp
public bool HasSaveTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_HasTeam1Score"></a> HasTeam1Score

```csharp
public bool HasTeam1Score { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_HasTeam2Score"></a> HasTeam2Score

```csharp
public bool HasTeam2Score { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Parser"></a> Parser

```csharp
public static MessageParser<CDOTASaveGame.Types.SaveInstance> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_PlayerPositions"></a> PlayerPositions

```csharp
public RepeatedField<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions> PlayerPositions { get; }
```

#### Property Value

 RepeatedField<[CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_SaveId"></a> SaveId

```csharp
public uint SaveId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_SaveTime"></a> SaveTime

```csharp
public uint SaveTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Team1Score"></a> Team1Score

```csharp
public uint Team1Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Team2Score"></a> Team2Score

```csharp
public uint Team2Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ClearSaveId"></a> ClearSaveId\(\)

```csharp
public void ClearSaveId()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ClearSaveTime"></a> ClearSaveTime\(\)

```csharp
public void ClearSaveTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ClearTeam1Score"></a> ClearTeam1Score\(\)

```csharp
public void ClearTeam1Score()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ClearTeam2Score"></a> ClearTeam2Score\(\)

```csharp
public void ClearTeam2Score()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Clone"></a> Clone\(\)

```csharp
public CDOTASaveGame.Types.SaveInstance Clone()
```

#### Returns

 [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Equals_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_"></a> Equals\(SaveInstance\)

```csharp
public bool Equals(CDOTASaveGame.Types.SaveInstance other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_MergeFrom_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_"></a> MergeFrom\(SaveInstance\)

```csharp
public void MergeFrom(CDOTASaveGame.Types.SaveInstance other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

