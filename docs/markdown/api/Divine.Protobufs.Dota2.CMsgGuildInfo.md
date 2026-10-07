# <a id="Divine_Protobufs_Dota2_CMsgGuildInfo"></a> Class CMsgGuildInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildInfo : IMessage<CMsgGuildInfo>, IEquatable<CMsgGuildInfo>, IDeepCloneable<CMsgGuildInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

#### Implements

IMessage<CMsgGuildInfo\>, 
[IEquatable<CMsgGuildInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildInfo\>, 
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
[EnumerableExtensions.In<CMsgGuildInfo\>\(CMsgGuildInfo, params CMsgGuildInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo__ctor"></a> CMsgGuildInfo\(\)

```csharp
public CMsgGuildInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo__ctor_Divine_Protobufs_Dota2_CMsgGuildInfo_"></a> CMsgGuildInfo\(CMsgGuildInfo\)

```csharp
public CMsgGuildInfo(CMsgGuildInfo other)
```

#### Parameters

`other` [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_CreatedTimestampFieldNumber"></a> CreatedTimestampFieldNumber

```csharp
public const int CreatedTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_DefaultChatChannelIdFieldNumber"></a> DefaultChatChannelIdFieldNumber

```csharp
public const int DefaultChatChannelIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildChatGroupIdFieldNumber"></a> GuildChatGroupIdFieldNumber

```csharp
public const int GuildChatGroupIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildDescriptionFieldNumber"></a> GuildDescriptionFieldNumber

```csharp
public const int GuildDescriptionFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildFlagsFieldNumber"></a> GuildFlagsFieldNumber

```csharp
public const int GuildFlagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildLanguageFieldNumber"></a> GuildLanguageFieldNumber

```csharp
public const int GuildLanguageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildLogoFieldNumber"></a> GuildLogoFieldNumber

```csharp
public const int GuildLogoFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildMotdFieldNumber"></a> GuildMotdFieldNumber

```csharp
public const int GuildMotdFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildMotdTimestampFieldNumber"></a> GuildMotdTimestampFieldNumber

```csharp
public const int GuildMotdTimestampFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildNameFieldNumber"></a> GuildNameFieldNumber

```csharp
public const int GuildNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildPatternFieldNumber"></a> GuildPatternFieldNumber

```csharp
public const int GuildPatternFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildPrimaryColorFieldNumber"></a> GuildPrimaryColorFieldNumber

```csharp
public const int GuildPrimaryColorFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRefreshTimeOffsetFieldNumber"></a> GuildRefreshTimeOffsetFieldNumber

```csharp
public const int GuildRefreshTimeOffsetFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRegionFieldNumber"></a> GuildRegionFieldNumber

```csharp
public const int GuildRegionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRequiredRankTierFieldNumber"></a> GuildRequiredRankTierFieldNumber

```csharp
public const int GuildRequiredRankTierFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildSecondaryColorFieldNumber"></a> GuildSecondaryColorFieldNumber

```csharp
public const int GuildSecondaryColorFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildTagFieldNumber"></a> GuildTagFieldNumber

```csharp
public const int GuildTagFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_CreatedTimestamp"></a> CreatedTimestamp

```csharp
public uint CreatedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_DefaultChatChannelId"></a> DefaultChatChannelId

```csharp
public ulong DefaultChatChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildChatGroupId"></a> GuildChatGroupId

```csharp
public ulong GuildChatGroupId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildDescription"></a> GuildDescription

```csharp
public string GuildDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildFlags"></a> GuildFlags

```csharp
public uint GuildFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildLanguage"></a> GuildLanguage

```csharp
public uint GuildLanguage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildLogo"></a> GuildLogo

```csharp
public ulong GuildLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildMotd"></a> GuildMotd

```csharp
public string GuildMotd { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildMotdTimestamp"></a> GuildMotdTimestamp

```csharp
public uint GuildMotdTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildName"></a> GuildName

```csharp
public string GuildName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildPattern"></a> GuildPattern

```csharp
public uint GuildPattern { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildPrimaryColor"></a> GuildPrimaryColor

```csharp
public uint GuildPrimaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRefreshTimeOffset"></a> GuildRefreshTimeOffset

```csharp
public uint GuildRefreshTimeOffset { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRegion"></a> GuildRegion

```csharp
public uint GuildRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildRequiredRankTier"></a> GuildRequiredRankTier

```csharp
public uint GuildRequiredRankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildSecondaryColor"></a> GuildSecondaryColor

```csharp
public uint GuildSecondaryColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GuildTag"></a> GuildTag

```csharp
public string GuildTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasCreatedTimestamp"></a> HasCreatedTimestamp

```csharp
public bool HasCreatedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasDefaultChatChannelId"></a> HasDefaultChatChannelId

```csharp
public bool HasDefaultChatChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildChatGroupId"></a> HasGuildChatGroupId

```csharp
public bool HasGuildChatGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildDescription"></a> HasGuildDescription

```csharp
public bool HasGuildDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildFlags"></a> HasGuildFlags

```csharp
public bool HasGuildFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildLanguage"></a> HasGuildLanguage

```csharp
public bool HasGuildLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildLogo"></a> HasGuildLogo

```csharp
public bool HasGuildLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildMotd"></a> HasGuildMotd

```csharp
public bool HasGuildMotd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildMotdTimestamp"></a> HasGuildMotdTimestamp

```csharp
public bool HasGuildMotdTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildName"></a> HasGuildName

```csharp
public bool HasGuildName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildPattern"></a> HasGuildPattern

```csharp
public bool HasGuildPattern { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildPrimaryColor"></a> HasGuildPrimaryColor

```csharp
public bool HasGuildPrimaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildRefreshTimeOffset"></a> HasGuildRefreshTimeOffset

```csharp
public bool HasGuildRefreshTimeOffset { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildRegion"></a> HasGuildRegion

```csharp
public bool HasGuildRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildRequiredRankTier"></a> HasGuildRequiredRankTier

```csharp
public bool HasGuildRequiredRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildSecondaryColor"></a> HasGuildSecondaryColor

```csharp
public bool HasGuildSecondaryColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_HasGuildTag"></a> HasGuildTag

```csharp
public bool HasGuildTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearCreatedTimestamp"></a> ClearCreatedTimestamp\(\)

```csharp
public void ClearCreatedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearDefaultChatChannelId"></a> ClearDefaultChatChannelId\(\)

```csharp
public void ClearDefaultChatChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildChatGroupId"></a> ClearGuildChatGroupId\(\)

```csharp
public void ClearGuildChatGroupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildDescription"></a> ClearGuildDescription\(\)

```csharp
public void ClearGuildDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildFlags"></a> ClearGuildFlags\(\)

```csharp
public void ClearGuildFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildLanguage"></a> ClearGuildLanguage\(\)

```csharp
public void ClearGuildLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildLogo"></a> ClearGuildLogo\(\)

```csharp
public void ClearGuildLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildMotd"></a> ClearGuildMotd\(\)

```csharp
public void ClearGuildMotd()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildMotdTimestamp"></a> ClearGuildMotdTimestamp\(\)

```csharp
public void ClearGuildMotdTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildName"></a> ClearGuildName\(\)

```csharp
public void ClearGuildName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildPattern"></a> ClearGuildPattern\(\)

```csharp
public void ClearGuildPattern()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildPrimaryColor"></a> ClearGuildPrimaryColor\(\)

```csharp
public void ClearGuildPrimaryColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildRefreshTimeOffset"></a> ClearGuildRefreshTimeOffset\(\)

```csharp
public void ClearGuildRefreshTimeOffset()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildRegion"></a> ClearGuildRegion\(\)

```csharp
public void ClearGuildRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildRequiredRankTier"></a> ClearGuildRequiredRankTier\(\)

```csharp
public void ClearGuildRequiredRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildSecondaryColor"></a> ClearGuildSecondaryColor\(\)

```csharp
public void ClearGuildSecondaryColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ClearGuildTag"></a> ClearGuildTag\(\)

```csharp
public void ClearGuildTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGuildInfo Clone()
```

#### Returns

 [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_Equals_Divine_Protobufs_Dota2_CMsgGuildInfo_"></a> Equals\(CMsgGuildInfo\)

```csharp
public bool Equals(CMsgGuildInfo other)
```

#### Parameters

`other` [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildInfo_"></a> MergeFrom\(CMsgGuildInfo\)

```csharp
public void MergeFrom(CMsgGuildInfo other)
```

#### Parameters

`other` [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

