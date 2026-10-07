# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements"></a> Class CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_TI7.Types.Achievements : IMessage<CMsgGCToClientBattlePassRollup_TI7.Types.Achievements>, IEquatable<CMsgGCToClientBattlePassRollup_TI7.Types.Achievements>, IDeepCloneable<CMsgGCToClientBattlePassRollup_TI7.Types.Achievements>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements\>\(CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements, params CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements__ctor"></a> Achievements\(\)

```csharp
public Achievements()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_"></a> Achievements\(Achievements\)

```csharp
public Achievements(CMsgGCToClientBattlePassRollup_TI7.Types.Achievements other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_CompletedFieldNumber"></a> CompletedFieldNumber

```csharp
public const int CompletedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_TotalFieldNumber"></a> TotalFieldNumber

```csharp
public const int TotalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Completed"></a> Completed

```csharp
public uint Completed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_HasCompleted"></a> HasCompleted

```csharp
public bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_HasTotal"></a> HasTotal

```csharp
public bool HasTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_TI7.Types.Achievements> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Total"></a> Total

```csharp
public uint Total { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_ClearCompleted"></a> ClearCompleted\(\)

```csharp
public void ClearCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_ClearTotal"></a> ClearTotal\(\)

```csharp
public void ClearTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI7.Types.Achievements Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_"></a> Equals\(Achievements\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_TI7.Types.Achievements other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_"></a> MergeFrom\(Achievements\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_TI7.Types.Achievements other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[Achievements](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.Achievements.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_Achievements_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

