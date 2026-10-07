# <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner"></a> Class CScenarioGame\_RoshanSpawner

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenarioGame_RoshanSpawner : IMessage<CScenarioGame_RoshanSpawner>, IEquatable<CScenarioGame_RoshanSpawner>, IDeepCloneable<CScenarioGame_RoshanSpawner>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)

#### Implements

IMessage<CScenarioGame\_RoshanSpawner\>, 
[IEquatable<CScenarioGame\_RoshanSpawner\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenarioGame\_RoshanSpawner\>, 
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
[EnumerableExtensions.In<CScenarioGame\_RoshanSpawner\>\(CScenarioGame\_RoshanSpawner, params CScenarioGame\_RoshanSpawner\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner__ctor"></a> CScenarioGame\_RoshanSpawner\(\)

```csharp
public CScenarioGame_RoshanSpawner()
```

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner__ctor_Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_"></a> CScenarioGame\_RoshanSpawner\(CScenarioGame\_RoshanSpawner\)

```csharp
public CScenarioGame_RoshanSpawner(CScenarioGame_RoshanSpawner other)
```

#### Parameters

`other` [CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_CooldownFieldNumber"></a> CooldownFieldNumber

```csharp
public const int CooldownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_KillCountFieldNumber"></a> KillCountFieldNumber

```csharp
public const int KillCountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_KillerTeamFieldNumber"></a> KillerTeamFieldNumber

```csharp
public const int KillerTeamFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_HasCooldown"></a> HasCooldown

```csharp
public bool HasCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_HasKillCount"></a> HasKillCount

```csharp
public bool HasKillCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_HasKillerTeam"></a> HasKillerTeam

```csharp
public bool HasKillerTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_KillCount"></a> KillCount

```csharp
public int KillCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_KillerTeam"></a> KillerTeam

```csharp
public int KillerTeam { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Parser"></a> Parser

```csharp
public static MessageParser<CScenarioGame_RoshanSpawner> Parser { get; }
```

#### Property Value

 MessageParser<[CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)\>

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_State"></a> State

```csharp
public int State { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_ClearCooldown"></a> ClearCooldown\(\)

```csharp
public void ClearCooldown()
```

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_ClearKillCount"></a> ClearKillCount\(\)

```csharp
public void ClearKillCount()
```

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_ClearKillerTeam"></a> ClearKillerTeam\(\)

```csharp
public void ClearKillerTeam()
```

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Clone"></a> Clone\(\)

```csharp
public CScenarioGame_RoshanSpawner Clone()
```

#### Returns

 [CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_Equals_Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_"></a> Equals\(CScenarioGame\_RoshanSpawner\)

```csharp
public bool Equals(CScenarioGame_RoshanSpawner other)
```

#### Parameters

`other` [CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_MergeFrom_Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_"></a> MergeFrom\(CScenarioGame\_RoshanSpawner\)

```csharp
public void MergeFrom(CScenarioGame_RoshanSpawner other)
```

#### Parameters

`other` [CScenarioGame\_RoshanSpawner](Divine.Protobufs.Dota2.CScenarioGame\_RoshanSpawner.md)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioGame_RoshanSpawner_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

