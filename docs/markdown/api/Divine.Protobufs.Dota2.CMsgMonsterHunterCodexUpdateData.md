# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData"></a> Class CMsgMonsterHunterCodexUpdateData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterCodexUpdateData : IMessage<CMsgMonsterHunterCodexUpdateData>, IEquatable<CMsgMonsterHunterCodexUpdateData>, IDeepCloneable<CMsgMonsterHunterCodexUpdateData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

#### Implements

IMessage<CMsgMonsterHunterCodexUpdateData\>, 
[IEquatable<CMsgMonsterHunterCodexUpdateData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterCodexUpdateData\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterCodexUpdateData\>\(CMsgMonsterHunterCodexUpdateData, params CMsgMonsterHunterCodexUpdateData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData__ctor"></a> CMsgMonsterHunterCodexUpdateData\(\)

```csharp
public CMsgMonsterHunterCodexUpdateData()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_"></a> CMsgMonsterHunterCodexUpdateData\(CMsgMonsterHunterCodexUpdateData\)

```csharp
public CMsgMonsterHunterCodexUpdateData(CMsgMonsterHunterCodexUpdateData other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_AlliesFieldNumber"></a> AlliesFieldNumber

```csharp
public const int AlliesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_EnemiesFieldNumber"></a> EnemiesFieldNumber

```csharp
public const int EnemiesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_PlayerHeroFieldNumber"></a> PlayerHeroFieldNumber

```csharp
public const int PlayerHeroFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_PlayerKillsFieldNumber"></a> PlayerKillsFieldNumber

```csharp
public const int PlayerKillsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Allies"></a> Allies

```csharp
public RepeatedField<int> Allies { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Enemies"></a> Enemies

```csharp
public RepeatedField<int> Enemies { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_HasPlayerHero"></a> HasPlayerHero

```csharp
public bool HasPlayerHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterCodexUpdateData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_PlayerHero"></a> PlayerHero

```csharp
public int PlayerHero { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_PlayerKills"></a> PlayerKills

```csharp
public RepeatedField<CMsgMonsterHunterCodexUpdateData.Types.KillInfo> PlayerKills { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_ClearPlayerHero"></a> ClearPlayerHero\(\)

```csharp
public void ClearPlayerHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterCodexUpdateData Clone()
```

#### Returns

 [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_"></a> Equals\(CMsgMonsterHunterCodexUpdateData\)

```csharp
public bool Equals(CMsgMonsterHunterCodexUpdateData other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_"></a> MergeFrom\(CMsgMonsterHunterCodexUpdateData\)

```csharp
public void MergeFrom(CMsgMonsterHunterCodexUpdateData other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

