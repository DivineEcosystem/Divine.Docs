# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards"></a> Class CMsgMonsterHunterMatchRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterMatchRewards : IMessage<CMsgMonsterHunterMatchRewards>, IEquatable<CMsgMonsterHunterMatchRewards>, IDeepCloneable<CMsgMonsterHunterMatchRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

#### Implements

IMessage<CMsgMonsterHunterMatchRewards\>, 
[IEquatable<CMsgMonsterHunterMatchRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterMatchRewards\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterMatchRewards\>\(CMsgMonsterHunterMatchRewards, params CMsgMonsterHunterMatchRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards__ctor"></a> CMsgMonsterHunterMatchRewards\(\)

```csharp
public CMsgMonsterHunterMatchRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_"></a> CMsgMonsterHunterMatchRewards\(CMsgMonsterHunterMatchRewards\)

```csharp
public CMsgMonsterHunterMatchRewards(CMsgMonsterHunterMatchRewards other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterMatchRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Players"></a> Players

```csharp
public RepeatedField<CMsgMonsterHunterMatchRewards.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterMatchRewards Clone()
```

#### Returns

 [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_"></a> Equals\(CMsgMonsterHunterMatchRewards\)

```csharp
public bool Equals(CMsgMonsterHunterMatchRewards other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_"></a> MergeFrom\(CMsgMonsterHunterMatchRewards\)

```csharp
public void MergeFrom(CMsgMonsterHunterMatchRewards other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

