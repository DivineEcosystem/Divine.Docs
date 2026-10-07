# <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC"></a> Class CScenarioEnt\_NPC

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenarioEnt_NPC : IMessage<CScenarioEnt_NPC>, IEquatable<CScenarioEnt_NPC>, IDeepCloneable<CScenarioEnt_NPC>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

#### Implements

IMessage<CScenarioEnt\_NPC\>, 
[IEquatable<CScenarioEnt\_NPC\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenarioEnt\_NPC\>, 
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
[EnumerableExtensions.In<CScenarioEnt\_NPC\>\(CScenarioEnt\_NPC, params CScenarioEnt\_NPC\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC__ctor"></a> CScenarioEnt\_NPC\(\)

```csharp
public CScenarioEnt_NPC()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC__ctor_Divine_Protobufs_Dota2_CScenarioEnt_NPC_"></a> CScenarioEnt\_NPC\(CScenarioEnt\_NPC\)

```csharp
public CScenarioEnt_NPC(CScenarioEnt_NPC other)
```

#### Parameters

`other` [CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HealthFracFieldNumber"></a> HealthFracFieldNumber

```csharp
public const int HealthFracFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_InvadeGoalFieldNumber"></a> InvadeGoalFieldNumber

```csharp
public const int InvadeGoalFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_OwningCampFieldNumber"></a> OwningCampFieldNumber

```csharp
public const int OwningCampFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_OwningCampPositionFieldNumber"></a> OwningCampPositionFieldNumber

```csharp
public const int OwningCampPositionFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_UnitNameFieldNumber"></a> UnitNameFieldNumber

```csharp
public const int UnitNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HasHealthFrac"></a> HasHealthFrac

```csharp
public bool HasHealthFrac { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HasInvadeGoal"></a> HasInvadeGoal

```csharp
public bool HasInvadeGoal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HasOwningCamp"></a> HasOwningCamp

```csharp
public bool HasOwningCamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HasUnitName"></a> HasUnitName

```csharp
public bool HasUnitName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_HealthFrac"></a> HealthFrac

```csharp
public float HealthFrac { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_InvadeGoal"></a> InvadeGoal

```csharp
public string InvadeGoal { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_OwningCamp"></a> OwningCamp

```csharp
public string OwningCamp { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_OwningCampPosition"></a> OwningCampPosition

```csharp
public CScenario_Position OwningCampPosition { get; set; }
```

#### Property Value

 [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Parser"></a> Parser

```csharp
public static MessageParser<CScenarioEnt_NPC> Parser { get; }
```

#### Property Value

 MessageParser<[CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)\>

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Position"></a> Position

```csharp
public CScenario_Position Position { get; set; }
```

#### Property Value

 [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_TeamNumber"></a> TeamNumber

```csharp
public int TeamNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_UnitName"></a> UnitName

```csharp
public string UnitName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ClearHealthFrac"></a> ClearHealthFrac\(\)

```csharp
public void ClearHealthFrac()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ClearInvadeGoal"></a> ClearInvadeGoal\(\)

```csharp
public void ClearInvadeGoal()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ClearOwningCamp"></a> ClearOwningCamp\(\)

```csharp
public void ClearOwningCamp()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ClearUnitName"></a> ClearUnitName\(\)

```csharp
public void ClearUnitName()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Clone"></a> Clone\(\)

```csharp
public CScenarioEnt_NPC Clone()
```

#### Returns

 [CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_Equals_Divine_Protobufs_Dota2_CScenarioEnt_NPC_"></a> Equals\(CScenarioEnt\_NPC\)

```csharp
public bool Equals(CScenarioEnt_NPC other)
```

#### Parameters

`other` [CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_MergeFrom_Divine_Protobufs_Dota2_CScenarioEnt_NPC_"></a> MergeFrom\(CScenarioEnt\_NPC\)

```csharp
public void MergeFrom(CScenarioEnt_NPC other)
```

#### Parameters

`other` [CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_NPC_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

