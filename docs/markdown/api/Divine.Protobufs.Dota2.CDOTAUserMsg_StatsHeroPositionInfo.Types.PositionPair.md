# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair"></a> Class CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair : IMessage<CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair>, IEquatable<CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair>, IDeepCloneable<CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair\>, 
[IEquatable<CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair\>\(CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair, params CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair__ctor"></a> PositionPair\(\)

```csharp
public PositionPair()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_"></a> PositionPair\(PositionPair\)

```csharp
public PositionPair(CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_PositionCategoryFieldNumber"></a> PositionCategoryFieldNumber

```csharp
public const int PositionCategoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_PositionCountFieldNumber"></a> PositionCountFieldNumber

```csharp
public const int PositionCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_HasPositionCategory"></a> HasPositionCategory

```csharp
public bool HasPositionCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_HasPositionCount"></a> HasPositionCount

```csharp
public bool HasPositionCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_PositionCategory"></a> PositionCategory

```csharp
public DOTA_POSITION_CATEGORY PositionCategory { get; set; }
```

#### Property Value

 [DOTA\_POSITION\_CATEGORY](Divine.Protobufs.Dota2.DOTA\_POSITION\_CATEGORY.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_PositionCount"></a> PositionCount

```csharp
public uint PositionCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_ClearPositionCategory"></a> ClearPositionCategory\(\)

```csharp
public void ClearPositionCategory()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_ClearPositionCount"></a> ClearPositionCount\(\)

```csharp
public void ClearPositionCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_"></a> Equals\(PositionPair\)

```csharp
public bool Equals(CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_"></a> MergeFrom\(PositionPair\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Types_PositionPair_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

