# <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData"></a> Class CP2P\_FightingGame\_GameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_FightingGame_GameData : IMessage<CP2P_FightingGame_GameData>, IEquatable<CP2P_FightingGame_GameData>, IDeepCloneable<CP2P_FightingGame_GameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)

#### Implements

IMessage<CP2P\_FightingGame\_GameData\>, 
[IEquatable<CP2P\_FightingGame\_GameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_FightingGame\_GameData\>, 
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
[EnumerableExtensions.In<CP2P\_FightingGame\_GameData\>\(CP2P\_FightingGame\_GameData, params CP2P\_FightingGame\_GameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData__ctor"></a> CP2P\_FightingGame\_GameData\(\)

```csharp
public CP2P_FightingGame_GameData()
```

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData__ctor_Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_"></a> CP2P\_FightingGame\_GameData\(CP2P\_FightingGame\_GameData\)

```csharp
public CP2P_FightingGame_GameData(CP2P_FightingGame_GameData other)
```

#### Parameters

`other` [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_CharacterSelectFieldNumber"></a> CharacterSelectFieldNumber

```csharp
public const int CharacterSelectFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_FightFieldNumber"></a> FightFieldNumber

```csharp
public const int FightFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_LoadedFieldNumber"></a> LoadedFieldNumber

```csharp
public const int LoadedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_CharacterSelect"></a> CharacterSelect

```csharp
public CMsgFightingGame_GameData_CharacterSelect CharacterSelect { get; set; }
```

#### Property Value

 [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Fight"></a> Fight

```csharp
public CMsgFightingGame_GameData_Fighting Fight { get; set; }
```

#### Property Value

 [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Loaded"></a> Loaded

```csharp
public CMsgFightingGame_GameData_Loaded Loaded { get; set; }
```

#### Property Value

 [CMsgFightingGame\_GameData\_Loaded](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Loaded.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_FightingGame_GameData> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_State"></a> State

```csharp
public CP2P_FightingGame_GameData.Types.EState State { get; set; }
```

#### Property Value

 [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md).[Types](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.Types.md).[EState](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.Types.EState.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_StateDataCase"></a> StateDataCase

```csharp
public CP2P_FightingGame_GameData.StateDataOneofCase StateDataCase { get; }
```

#### Property Value

 [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md).[StateDataOneofCase](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.StateDataOneofCase.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_ClearStateData"></a> ClearStateData\(\)

```csharp
public void ClearStateData()
```

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Clone"></a> Clone\(\)

```csharp
public CP2P_FightingGame_GameData Clone()
```

#### Returns

 [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_Equals_Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_"></a> Equals\(CP2P\_FightingGame\_GameData\)

```csharp
public bool Equals(CP2P_FightingGame_GameData other)
```

#### Parameters

`other` [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_MergeFrom_Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_"></a> MergeFrom\(CP2P\_FightingGame\_GameData\)

```csharp
public void MergeFrom(CP2P_FightingGame_GameData other)
```

#### Parameters

`other` [CP2P\_FightingGame\_GameData](Divine.Protobufs.Dota2.CP2P\_FightingGame\_GameData.md)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_FightingGame_GameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

