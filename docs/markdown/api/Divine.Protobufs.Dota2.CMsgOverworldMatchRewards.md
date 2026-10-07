# <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards"></a> Class CMsgOverworldMatchRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldMatchRewards : IMessage<CMsgOverworldMatchRewards>, IEquatable<CMsgOverworldMatchRewards>, IDeepCloneable<CMsgOverworldMatchRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

#### Implements

IMessage<CMsgOverworldMatchRewards\>, 
[IEquatable<CMsgOverworldMatchRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldMatchRewards\>, 
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
[EnumerableExtensions.In<CMsgOverworldMatchRewards\>\(CMsgOverworldMatchRewards, params CMsgOverworldMatchRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards__ctor"></a> CMsgOverworldMatchRewards\(\)

```csharp
public CMsgOverworldMatchRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards__ctor_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_"></a> CMsgOverworldMatchRewards\(CMsgOverworldMatchRewards\)

```csharp
public CMsgOverworldMatchRewards(CMsgOverworldMatchRewards other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldMatchRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Players"></a> Players

```csharp
public RepeatedField<CMsgOverworldMatchRewards.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldMatchRewards Clone()
```

#### Returns

 [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Equals_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_"></a> Equals\(CMsgOverworldMatchRewards\)

```csharp
public bool Equals(CMsgOverworldMatchRewards other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_"></a> MergeFrom\(CMsgOverworldMatchRewards\)

```csharp
public void MergeFrom(CMsgOverworldMatchRewards other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

