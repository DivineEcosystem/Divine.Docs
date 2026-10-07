# <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState"></a> Class CNETMsg\_SignonState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SignonState : IMessage<CNETMsg_SignonState>, IEquatable<CNETMsg_SignonState>, IDeepCloneable<CNETMsg_SignonState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)

#### Implements

IMessage<CNETMsg\_SignonState\>, 
[IEquatable<CNETMsg\_SignonState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SignonState\>, 
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
[EnumerableExtensions.In<CNETMsg\_SignonState\>\(CNETMsg\_SignonState, params CNETMsg\_SignonState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState__ctor"></a> CNETMsg\_SignonState\(\)

```csharp
public CNETMsg_SignonState()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState__ctor_Divine_Protobufs_Dota2_CNETMsg_SignonState_"></a> CNETMsg\_SignonState\(CNETMsg\_SignonState\)

```csharp
public CNETMsg_SignonState(CNETMsg_SignonState other)
```

#### Parameters

`other` [CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_AddonsFieldNumber"></a> AddonsFieldNumber

```csharp
public const int AddonsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_MapNameFieldNumber"></a> MapNameFieldNumber

```csharp
public const int MapNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_NumServerPlayersFieldNumber"></a> NumServerPlayersFieldNumber

```csharp
public const int NumServerPlayersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_PlayersNetworkidsFieldNumber"></a> PlayersNetworkidsFieldNumber

```csharp
public const int PlayersNetworkidsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_SignonStateFieldNumber"></a> SignonStateFieldNumber

```csharp
public const int SignonStateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_SpawnCountFieldNumber"></a> SpawnCountFieldNumber

```csharp
public const int SpawnCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Addons"></a> Addons

```csharp
public string Addons { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_HasAddons"></a> HasAddons

```csharp
public bool HasAddons { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_HasMapName"></a> HasMapName

```csharp
public bool HasMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_HasNumServerPlayers"></a> HasNumServerPlayers

```csharp
public bool HasNumServerPlayers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_HasSignonState"></a> HasSignonState

```csharp
public bool HasSignonState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_HasSpawnCount"></a> HasSpawnCount

```csharp
public bool HasSpawnCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_MapName"></a> MapName

```csharp
public string MapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_NumServerPlayers"></a> NumServerPlayers

```csharp
public uint NumServerPlayers { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SignonState> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_PlayersNetworkids"></a> PlayersNetworkids

```csharp
public RepeatedField<string> PlayersNetworkids { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_SignonState"></a> SignonState

```csharp
public SignonState_t SignonState { get; set; }
```

#### Property Value

 [SignonState\_t](Divine.Protobufs.Dota2.SignonState\_t.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_SpawnCount"></a> SpawnCount

```csharp
public uint SpawnCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ClearAddons"></a> ClearAddons\(\)

```csharp
public void ClearAddons()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ClearMapName"></a> ClearMapName\(\)

```csharp
public void ClearMapName()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ClearNumServerPlayers"></a> ClearNumServerPlayers\(\)

```csharp
public void ClearNumServerPlayers()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ClearSignonState"></a> ClearSignonState\(\)

```csharp
public void ClearSignonState()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ClearSpawnCount"></a> ClearSpawnCount\(\)

```csharp
public void ClearSpawnCount()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SignonState Clone()
```

#### Returns

 [CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_Equals_Divine_Protobufs_Dota2_CNETMsg_SignonState_"></a> Equals\(CNETMsg\_SignonState\)

```csharp
public bool Equals(CNETMsg_SignonState other)
```

#### Parameters

`other` [CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SignonState_"></a> MergeFrom\(CNETMsg\_SignonState\)

```csharp
public void MergeFrom(CNETMsg_SignonState other)
```

#### Parameters

`other` [CNETMsg\_SignonState](Divine.Protobufs.Dota2.CNETMsg\_SignonState.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SignonState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

