# <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails"></a> Class CLobbyGuildDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CLobbyGuildDetails : IMessage<CLobbyGuildDetails>, IEquatable<CLobbyGuildDetails>, IDeepCloneable<CLobbyGuildDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)

#### Implements

IMessage<CLobbyGuildDetails\>, 
[IEquatable<CLobbyGuildDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CLobbyGuildDetails\>, 
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
[EnumerableExtensions.In<CLobbyGuildDetails\>\(CLobbyGuildDetails, params CLobbyGuildDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails__ctor"></a> CLobbyGuildDetails\(\)

```csharp
public CLobbyGuildDetails()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails__ctor_Divine_Protobufs_Dota2_CLobbyGuildDetails_"></a> CLobbyGuildDetails\(CLobbyGuildDetails\)

```csharp
public CLobbyGuildDetails(CLobbyGuildDetails other)
```

#### Parameters

`other` [CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildEventFieldNumber"></a> GuildEventFieldNumber

```csharp
public const int GuildEventFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildFlagsFieldNumber"></a> GuildFlagsFieldNumber

```csharp
public const int GuildFlagsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildLogoFieldNumber"></a> GuildLogoFieldNumber

```csharp
public const int GuildLogoFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPatternFieldNumber"></a> GuildPatternFieldNumber

```csharp
public const int GuildPatternFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPointsFieldNumber"></a> GuildPointsFieldNumber

```csharp
public const int GuildPointsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPrimaryColorFieldNumber"></a> GuildPrimaryColorFieldNumber

```csharp
public const int GuildPrimaryColorFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildSecondaryColorFieldNumber"></a> GuildSecondaryColorFieldNumber

```csharp
public const int GuildSecondaryColorFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildTagFieldNumber"></a> GuildTagFieldNumber

```csharp
public const int GuildTagFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildWeeklyPercentileFieldNumber"></a> GuildWeeklyPercentileFieldNumber

```csharp
public const int GuildWeeklyPercentileFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_TeamForGuildFieldNumber"></a> TeamForGuildFieldNumber

```csharp
public const int TeamForGuildFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildEvent"></a> GuildEvent

```csharp
public uint GuildEvent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildFlags"></a> GuildFlags

```csharp
public uint GuildFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildLogo"></a> GuildLogo

```csharp
public ulong GuildLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPattern"></a> GuildPattern

```csharp
public uint GuildPattern { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPoints"></a> GuildPoints

```csharp
public uint GuildPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildPrimaryColor"></a> GuildPrimaryColor

```csharp
public uint GuildPrimaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildSecondaryColor"></a> GuildSecondaryColor

```csharp
public uint GuildSecondaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildTag"></a> GuildTag

```csharp
public string GuildTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GuildWeeklyPercentile"></a> GuildWeeklyPercentile

```csharp
public uint GuildWeeklyPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildEvent"></a> HasGuildEvent

```csharp
public bool HasGuildEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildFlags"></a> HasGuildFlags

```csharp
public bool HasGuildFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildLogo"></a> HasGuildLogo

```csharp
public bool HasGuildLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildPattern"></a> HasGuildPattern

```csharp
public bool HasGuildPattern { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildPoints"></a> HasGuildPoints

```csharp
public bool HasGuildPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildPrimaryColor"></a> HasGuildPrimaryColor

```csharp
public bool HasGuildPrimaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildSecondaryColor"></a> HasGuildSecondaryColor

```csharp
public bool HasGuildSecondaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildTag"></a> HasGuildTag

```csharp
public bool HasGuildTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasGuildWeeklyPercentile"></a> HasGuildWeeklyPercentile

```csharp
public bool HasGuildWeeklyPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_HasTeamForGuild"></a> HasTeamForGuild

```csharp
public bool HasTeamForGuild { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_Parser"></a> Parser

```csharp
public static MessageParser<CLobbyGuildDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_TeamForGuild"></a> TeamForGuild

```csharp
public DOTA_GC_TEAM TeamForGuild { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildEvent"></a> ClearGuildEvent\(\)

```csharp
public void ClearGuildEvent()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildFlags"></a> ClearGuildFlags\(\)

```csharp
public void ClearGuildFlags()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildLogo"></a> ClearGuildLogo\(\)

```csharp
public void ClearGuildLogo()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildPattern"></a> ClearGuildPattern\(\)

```csharp
public void ClearGuildPattern()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildPoints"></a> ClearGuildPoints\(\)

```csharp
public void ClearGuildPoints()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildPrimaryColor"></a> ClearGuildPrimaryColor\(\)

```csharp
public void ClearGuildPrimaryColor()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildSecondaryColor"></a> ClearGuildSecondaryColor\(\)

```csharp
public void ClearGuildSecondaryColor()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildTag"></a> ClearGuildTag\(\)

```csharp
public void ClearGuildTag()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearGuildWeeklyPercentile"></a> ClearGuildWeeklyPercentile\(\)

```csharp
public void ClearGuildWeeklyPercentile()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ClearTeamForGuild"></a> ClearTeamForGuild\(\)

```csharp
public void ClearTeamForGuild()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_Clone"></a> Clone\(\)

```csharp
public CLobbyGuildDetails Clone()
```

#### Returns

 [CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_Equals_Divine_Protobufs_Dota2_CLobbyGuildDetails_"></a> Equals\(CLobbyGuildDetails\)

```csharp
public bool Equals(CLobbyGuildDetails other)
```

#### Parameters

`other` [CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_MergeFrom_Divine_Protobufs_Dota2_CLobbyGuildDetails_"></a> MergeFrom\(CLobbyGuildDetails\)

```csharp
public void MergeFrom(CLobbyGuildDetails other)
```

#### Parameters

`other` [CLobbyGuildDetails](Divine.Protobufs.Dota2.CLobbyGuildDetails.md)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

