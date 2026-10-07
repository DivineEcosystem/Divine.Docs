# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo"></a> Class CDOTAUserMsg\_StatsHeroPositionInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsHeroPositionInfo : IMessage<CDOTAUserMsg_StatsHeroPositionInfo>, IEquatable<CDOTAUserMsg_StatsHeroPositionInfo>, IDeepCloneable<CDOTAUserMsg_StatsHeroPositionInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsHeroPositionInfo\>, 
[IEquatable<CDOTAUserMsg\_StatsHeroPositionInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsHeroPositionInfo\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsHeroPositionInfo\>\(CDOTAUserMsg\_StatsHeroPositionInfo, params CDOTAUserMsg\_StatsHeroPositionInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo__ctor"></a> CDOTAUserMsg\_StatsHeroPositionInfo\(\)

```csharp
public CDOTAUserMsg_StatsHeroPositionInfo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_"></a> CDOTAUserMsg\_StatsHeroPositionInfo\(CDOTAUserMsg\_StatsHeroPositionInfo\)

```csharp
public CDOTAUserMsg_StatsHeroPositionInfo(CDOTAUserMsg_StatsHeroPositionInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_AveragePositionFieldNumber"></a> AveragePositionFieldNumber

```csharp
public const int AveragePositionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_PositionDetailsFieldNumber"></a> PositionDetailsFieldNumber

```csharp
public const int PositionDetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_AveragePosition"></a> AveragePosition

```csharp
public float AveragePosition { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_HasAveragePosition"></a> HasAveragePosition

```csharp
public bool HasAveragePosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsHeroPositionInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_PositionDetails"></a> PositionDetails

```csharp
public RepeatedField<CDOTAUserMsg_StatsHeroPositionInfo.Types.PositionPair> PositionDetails { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.md).[PositionPair](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.Types.PositionPair.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_ClearAveragePosition"></a> ClearAveragePosition\(\)

```csharp
public void ClearAveragePosition()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsHeroPositionInfo Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_"></a> Equals\(CDOTAUserMsg\_StatsHeroPositionInfo\)

```csharp
public bool Equals(CDOTAUserMsg_StatsHeroPositionInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_"></a> MergeFrom\(CDOTAUserMsg\_StatsHeroPositionInfo\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsHeroPositionInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroPositionInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

