# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building"></a> Class CDOTAMatchPrivateMetadata.Types.Team.Types.Building

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.Team.Types.Building : IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Building>, IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Building>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Building>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.Team.Types.Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Building\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Building\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Building\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.Team.Types.Building\>\(CDOTAMatchPrivateMetadata.Types.Team.Types.Building, params CDOTAMatchPrivateMetadata.Types.Team.Types.Building\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building__ctor"></a> Building\(\)

```csharp
public Building()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_"></a> Building\(Building\)

```csharp
public Building(CDOTAMatchPrivateMetadata.Types.Team.Types.Building other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_DeathTimeFieldNumber"></a> DeathTimeFieldNumber

```csharp
public const int DeathTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_PositionQuantXFieldNumber"></a> PositionQuantXFieldNumber

```csharp
public const int PositionQuantXFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_PositionQuantYFieldNumber"></a> PositionQuantYFieldNumber

```csharp
public const int PositionQuantYFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_UnitNameFieldNumber"></a> UnitNameFieldNumber

```csharp
public const int UnitNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_DeathTime"></a> DeathTime

```csharp
public float DeathTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_HasDeathTime"></a> HasDeathTime

```csharp
public bool HasDeathTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_HasPositionQuantX"></a> HasPositionQuantX

```csharp
public bool HasPositionQuantX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_HasPositionQuantY"></a> HasPositionQuantY

```csharp
public bool HasPositionQuantY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_HasUnitName"></a> HasUnitName

```csharp
public bool HasUnitName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.Team.Types.Building> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_PositionQuantX"></a> PositionQuantX

```csharp
public uint PositionQuantX { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_PositionQuantY"></a> PositionQuantY

```csharp
public uint PositionQuantY { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_UnitName"></a> UnitName

```csharp
public string UnitName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_ClearDeathTime"></a> ClearDeathTime\(\)

```csharp
public void ClearDeathTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_ClearPositionQuantX"></a> ClearPositionQuantX\(\)

```csharp
public void ClearPositionQuantX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_ClearPositionQuantY"></a> ClearPositionQuantY\(\)

```csharp
public void ClearPositionQuantY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_ClearUnitName"></a> ClearUnitName\(\)

```csharp
public void ClearUnitName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.Team.Types.Building Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_"></a> Equals\(Building\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.Team.Types.Building other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_"></a> MergeFrom\(Building\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.Team.Types.Building other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Building_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

