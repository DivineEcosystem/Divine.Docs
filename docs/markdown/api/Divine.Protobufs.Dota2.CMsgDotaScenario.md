# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario"></a> Class CMsgDotaScenario

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario : IMessage<CMsgDotaScenario>, IEquatable<CMsgDotaScenario>, IDeepCloneable<CMsgDotaScenario>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)

#### Implements

IMessage<CMsgDotaScenario\>, 
[IEquatable<CMsgDotaScenario\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario\>\(CMsgDotaScenario, params CMsgDotaScenario\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario__ctor"></a> CMsgDotaScenario\(\)

```csharp
public CMsgDotaScenario()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_"></a> CMsgDotaScenario\(CMsgDotaScenario\)

```csharp
public CMsgDotaScenario(CMsgDotaScenario other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_BuildingsFieldNumber"></a> BuildingsFieldNumber

```csharp
public const int BuildingsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_EntitiesFieldNumber"></a> EntitiesFieldNumber

```csharp
public const int EntitiesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_GameFieldNumber"></a> GameFieldNumber

```csharp
public const int GameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_HeroesFieldNumber"></a> HeroesFieldNumber

```csharp
public const int HeroesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_ModifiersFieldNumber"></a> ModifiersFieldNumber

```csharp
public const int ModifiersFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_StockFieldNumber"></a> StockFieldNumber

```csharp
public const int StockFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Buildings"></a> Buildings

```csharp
public RepeatedField<CMsgDotaScenario.Types.Building> Buildings { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Entities"></a> Entities

```csharp
public RepeatedField<CMsgDotaScenario.Types.Entity> Entities { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Game"></a> Game

```csharp
public CMsgDotaScenario.Types.Game Game { get; set; }
```

#### Property Value

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Game.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Heroes"></a> Heroes

```csharp
public RepeatedField<CMsgDotaScenario.Types.Hero> Heroes { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Hero](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Hero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Items"></a> Items

```csharp
public RepeatedField<CMsgDotaScenario.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Modifiers"></a> Modifiers

```csharp
public RepeatedField<CMsgDotaScenario.Types.Modifier> Modifiers { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Stock"></a> Stock

```csharp
public RepeatedField<CMsgDotaScenario.Types.Stock> Stock { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDotaScenario.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_"></a> Equals\(CMsgDotaScenario\)

```csharp
public bool Equals(CMsgDotaScenario other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_"></a> MergeFrom\(CMsgDotaScenario\)

```csharp
public void MergeFrom(CMsgDotaScenario other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

