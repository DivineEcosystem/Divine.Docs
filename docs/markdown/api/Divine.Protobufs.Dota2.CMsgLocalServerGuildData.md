# <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData"></a> Class CMsgLocalServerGuildData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLocalServerGuildData : IMessage<CMsgLocalServerGuildData>, IEquatable<CMsgLocalServerGuildData>, IDeepCloneable<CMsgLocalServerGuildData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

#### Implements

IMessage<CMsgLocalServerGuildData\>, 
[IEquatable<CMsgLocalServerGuildData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLocalServerGuildData\>, 
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
[EnumerableExtensions.In<CMsgLocalServerGuildData\>\(CMsgLocalServerGuildData, params CMsgLocalServerGuildData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData__ctor"></a> CMsgLocalServerGuildData\(\)

```csharp
public CMsgLocalServerGuildData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData__ctor_Divine_Protobufs_Dota2_CMsgLocalServerGuildData_"></a> CMsgLocalServerGuildData\(CMsgLocalServerGuildData\)

```csharp
public CMsgLocalServerGuildData(CMsgLocalServerGuildData other)
```

#### Parameters

`other` [CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildFlagsFieldNumber"></a> GuildFlagsFieldNumber

```csharp
public const int GuildFlagsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildLogoFieldNumber"></a> GuildLogoFieldNumber

```csharp
public const int GuildLogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPatternFieldNumber"></a> GuildPatternFieldNumber

```csharp
public const int GuildPatternFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPointsFieldNumber"></a> GuildPointsFieldNumber

```csharp
public const int GuildPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPrimaryColorFieldNumber"></a> GuildPrimaryColorFieldNumber

```csharp
public const int GuildPrimaryColorFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildSecondaryColorFieldNumber"></a> GuildSecondaryColorFieldNumber

```csharp
public const int GuildSecondaryColorFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildWeeklyPercentileFieldNumber"></a> GuildWeeklyPercentileFieldNumber

```csharp
public const int GuildWeeklyPercentileFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildFlags"></a> GuildFlags

```csharp
public uint GuildFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildLogo"></a> GuildLogo

```csharp
public ulong GuildLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPattern"></a> GuildPattern

```csharp
public uint GuildPattern { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPoints"></a> GuildPoints

```csharp
public uint GuildPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildPrimaryColor"></a> GuildPrimaryColor

```csharp
public uint GuildPrimaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildSecondaryColor"></a> GuildSecondaryColor

```csharp
public uint GuildSecondaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GuildWeeklyPercentile"></a> GuildWeeklyPercentile

```csharp
public uint GuildWeeklyPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildFlags"></a> HasGuildFlags

```csharp
public bool HasGuildFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildLogo"></a> HasGuildLogo

```csharp
public bool HasGuildLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildPattern"></a> HasGuildPattern

```csharp
public bool HasGuildPattern { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildPoints"></a> HasGuildPoints

```csharp
public bool HasGuildPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildPrimaryColor"></a> HasGuildPrimaryColor

```csharp
public bool HasGuildPrimaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildSecondaryColor"></a> HasGuildSecondaryColor

```csharp
public bool HasGuildSecondaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_HasGuildWeeklyPercentile"></a> HasGuildWeeklyPercentile

```csharp
public bool HasGuildWeeklyPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLocalServerGuildData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildFlags"></a> ClearGuildFlags\(\)

```csharp
public void ClearGuildFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildLogo"></a> ClearGuildLogo\(\)

```csharp
public void ClearGuildLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildPattern"></a> ClearGuildPattern\(\)

```csharp
public void ClearGuildPattern()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildPoints"></a> ClearGuildPoints\(\)

```csharp
public void ClearGuildPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildPrimaryColor"></a> ClearGuildPrimaryColor\(\)

```csharp
public void ClearGuildPrimaryColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildSecondaryColor"></a> ClearGuildSecondaryColor\(\)

```csharp
public void ClearGuildSecondaryColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ClearGuildWeeklyPercentile"></a> ClearGuildWeeklyPercentile\(\)

```csharp
public void ClearGuildWeeklyPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_Clone"></a> Clone\(\)

```csharp
public CMsgLocalServerGuildData Clone()
```

#### Returns

 [CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_Equals_Divine_Protobufs_Dota2_CMsgLocalServerGuildData_"></a> Equals\(CMsgLocalServerGuildData\)

```csharp
public bool Equals(CMsgLocalServerGuildData other)
```

#### Parameters

`other` [CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_MergeFrom_Divine_Protobufs_Dota2_CMsgLocalServerGuildData_"></a> MergeFrom\(CMsgLocalServerGuildData\)

```csharp
public void MergeFrom(CMsgLocalServerGuildData other)
```

#### Parameters

`other` [CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerGuildData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

