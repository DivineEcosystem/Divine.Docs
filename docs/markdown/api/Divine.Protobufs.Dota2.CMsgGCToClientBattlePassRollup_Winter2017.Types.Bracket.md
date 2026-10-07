# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket"></a> Class CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket : IMessage<CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket>, IEquatable<CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket>, IDeepCloneable<CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket\>\(CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket, params CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket__ctor"></a> Bracket\(\)

```csharp
public Bracket()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_"></a> Bracket\(Bracket\)

```csharp
public Bracket(CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_CorrectFieldNumber"></a> CorrectFieldNumber

```csharp
public const int CorrectFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Correct"></a> Correct

```csharp
public uint Correct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_HasCorrect"></a> HasCorrect

```csharp
public bool HasCorrect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_ClearCorrect"></a> ClearCorrect\(\)

```csharp
public void ClearCorrect()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_"></a> Equals\(Bracket\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_"></a> MergeFrom\(Bracket\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_Winter2017.Types.Bracket other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Bracket](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Bracket.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Bracket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

