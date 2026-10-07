# <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request"></a> Class CCommunity\_GetClanAnnouncements\_Request

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCommunity_GetClanAnnouncements_Request : IMessage<CCommunity_GetClanAnnouncements_Request>, IEquatable<CCommunity_GetClanAnnouncements_Request>, IDeepCloneable<CCommunity_GetClanAnnouncements_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)

#### Implements

IMessage<CCommunity\_GetClanAnnouncements\_Request\>, 
[IEquatable<CCommunity\_GetClanAnnouncements\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCommunity\_GetClanAnnouncements\_Request\>, 
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
[EnumerableExtensions.In<CCommunity\_GetClanAnnouncements\_Request\>\(CCommunity\_GetClanAnnouncements\_Request, params CCommunity\_GetClanAnnouncements\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request__ctor"></a> CCommunity\_GetClanAnnouncements\_Request\(\)

```csharp
public CCommunity_GetClanAnnouncements_Request()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request__ctor_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_"></a> CCommunity\_GetClanAnnouncements\_Request\(CCommunity\_GetClanAnnouncements\_Request\)

```csharp
public CCommunity_GetClanAnnouncements_Request(CCommunity_GetClanAnnouncements_Request other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HiddenOnlyFieldNumber"></a> HiddenOnlyFieldNumber

```csharp
public const int HiddenOnlyFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_IncludeHiddenFieldNumber"></a> IncludeHiddenFieldNumber

```csharp
public const int IncludeHiddenFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_IncludePartnerEventsFieldNumber"></a> IncludePartnerEventsFieldNumber

```csharp
public const int IncludePartnerEventsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_LanguagePreferenceFieldNumber"></a> LanguagePreferenceFieldNumber

```csharp
public const int LanguagePreferenceFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_MaxcharsFieldNumber"></a> MaxcharsFieldNumber

```csharp
public const int MaxcharsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_OffsetFieldNumber"></a> OffsetFieldNumber

```csharp
public const int OffsetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_OnlyGidFieldNumber"></a> OnlyGidFieldNumber

```csharp
public const int OnlyGidFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RequiredTagsFieldNumber"></a> RequiredTagsFieldNumber

```csharp
public const int RequiredTagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RequireNoTagsFieldNumber"></a> RequireNoTagsFieldNumber

```csharp
public const int RequireNoTagsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RtimeOldestDateFieldNumber"></a> RtimeOldestDateFieldNumber

```csharp
public const int RtimeOldestDateFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_StripHtmlFieldNumber"></a> StripHtmlFieldNumber

```csharp
public const int StripHtmlFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasHiddenOnly"></a> HasHiddenOnly

```csharp
public bool HasHiddenOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasIncludeHidden"></a> HasIncludeHidden

```csharp
public bool HasIncludeHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasIncludePartnerEvents"></a> HasIncludePartnerEvents

```csharp
public bool HasIncludePartnerEvents { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasMaxchars"></a> HasMaxchars

```csharp
public bool HasMaxchars { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasOffset"></a> HasOffset

```csharp
public bool HasOffset { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasOnlyGid"></a> HasOnlyGid

```csharp
public bool HasOnlyGid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasRequireNoTags"></a> HasRequireNoTags

```csharp
public bool HasRequireNoTags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasRtimeOldestDate"></a> HasRtimeOldestDate

```csharp
public bool HasRtimeOldestDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HasStripHtml"></a> HasStripHtml

```csharp
public bool HasStripHtml { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_HiddenOnly"></a> HiddenOnly

```csharp
public bool HiddenOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_IncludeHidden"></a> IncludeHidden

```csharp
public bool IncludeHidden { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_IncludePartnerEvents"></a> IncludePartnerEvents

```csharp
public bool IncludePartnerEvents { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_LanguagePreference"></a> LanguagePreference

```csharp
public RepeatedField<uint> LanguagePreference { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Maxchars"></a> Maxchars

```csharp
public uint Maxchars { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Offset"></a> Offset

```csharp
public uint Offset { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_OnlyGid"></a> OnlyGid

```csharp
public bool OnlyGid { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Parser"></a> Parser

```csharp
public static MessageParser<CCommunity_GetClanAnnouncements_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)\>

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RequiredTags"></a> RequiredTags

```csharp
public RepeatedField<string> RequiredTags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RequireNoTags"></a> RequireNoTags

```csharp
public bool RequireNoTags { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_RtimeOldestDate"></a> RtimeOldestDate

```csharp
public uint RtimeOldestDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_StripHtml"></a> StripHtml

```csharp
public bool StripHtml { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearHiddenOnly"></a> ClearHiddenOnly\(\)

```csharp
public void ClearHiddenOnly()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearIncludeHidden"></a> ClearIncludeHidden\(\)

```csharp
public void ClearIncludeHidden()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearIncludePartnerEvents"></a> ClearIncludePartnerEvents\(\)

```csharp
public void ClearIncludePartnerEvents()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearMaxchars"></a> ClearMaxchars\(\)

```csharp
public void ClearMaxchars()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearOffset"></a> ClearOffset\(\)

```csharp
public void ClearOffset()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearOnlyGid"></a> ClearOnlyGid\(\)

```csharp
public void ClearOnlyGid()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearRequireNoTags"></a> ClearRequireNoTags\(\)

```csharp
public void ClearRequireNoTags()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearRtimeOldestDate"></a> ClearRtimeOldestDate\(\)

```csharp
public void ClearRtimeOldestDate()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ClearStripHtml"></a> ClearStripHtml\(\)

```csharp
public void ClearStripHtml()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Clone"></a> Clone\(\)

```csharp
public CCommunity_GetClanAnnouncements_Request Clone()
```

#### Returns

 [CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_Equals_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_"></a> Equals\(CCommunity\_GetClanAnnouncements\_Request\)

```csharp
public bool Equals(CCommunity_GetClanAnnouncements_Request other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_MergeFrom_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_"></a> MergeFrom\(CCommunity\_GetClanAnnouncements\_Request\)

```csharp
public void MergeFrom(CCommunity_GetClanAnnouncements_Request other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Request](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Request.md)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

