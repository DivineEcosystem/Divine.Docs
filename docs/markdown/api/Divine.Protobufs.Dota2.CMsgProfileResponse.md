# <a id="Divine_Protobufs_Dota2_CMsgProfileResponse"></a> Class CMsgProfileResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProfileResponse : IMessage<CMsgProfileResponse>, IEquatable<CMsgProfileResponse>, IDeepCloneable<CMsgProfileResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)

#### Implements

IMessage<CMsgProfileResponse\>, 
[IEquatable<CMsgProfileResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProfileResponse\>, 
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
[EnumerableExtensions.In<CMsgProfileResponse\>\(CMsgProfileResponse, params CMsgProfileResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse__ctor"></a> CMsgProfileResponse\(\)

```csharp
public CMsgProfileResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse__ctor_Divine_Protobufs_Dota2_CMsgProfileResponse_"></a> CMsgProfileResponse\(CMsgProfileResponse\)

```csharp
public CMsgProfileResponse(CMsgProfileResponse other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_BackgroundItemFieldNumber"></a> BackgroundItemFieldNumber

```csharp
public const int BackgroundItemFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_FeaturedHeroesFieldNumber"></a> FeaturedHeroesFieldNumber

```csharp
public const int FeaturedHeroesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_RecentMatchDetailsFieldNumber"></a> RecentMatchDetailsFieldNumber

```csharp
public const int RecentMatchDetailsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_RecentMatchesFieldNumber"></a> RecentMatchesFieldNumber

```csharp
public const int RecentMatchesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_StickerbookPageFieldNumber"></a> StickerbookPageFieldNumber

```csharp
public const int StickerbookPageFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_SuccessfulHeroesFieldNumber"></a> SuccessfulHeroesFieldNumber

```csharp
public const int SuccessfulHeroesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_BackgroundItem"></a> BackgroundItem

```csharp
public CSOEconItem BackgroundItem { get; set; }
```

#### Property Value

 [CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_FeaturedHeroes"></a> FeaturedHeroes

```csharp
public RepeatedField<CMsgProfileResponse.Types.FeaturedHero> FeaturedHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProfileResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_RecentMatchDetails"></a> RecentMatchDetails

```csharp
public CMsgRecentMatchInfo RecentMatchDetails { get; set; }
```

#### Property Value

 [CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_RecentMatches"></a> RecentMatches

```csharp
public RepeatedField<CMsgProfileResponse.Types.MatchInfo> RecentMatches { get; }
```

#### Property Value

 RepeatedField<[CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[MatchInfo](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.MatchInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Result"></a> Result

```csharp
public CMsgProfileResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_StickerbookPage"></a> StickerbookPage

```csharp
public CMsgStickerbookPage StickerbookPage { get; set; }
```

#### Property Value

 [CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_SuccessfulHeroes"></a> SuccessfulHeroes

```csharp
public RepeatedField<CMsgSuccessfulHero> SuccessfulHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Clone"></a> Clone\(\)

```csharp
public CMsgProfileResponse Clone()
```

#### Returns

 [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Equals_Divine_Protobufs_Dota2_CMsgProfileResponse_"></a> Equals\(CMsgProfileResponse\)

```csharp
public bool Equals(CMsgProfileResponse other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgProfileResponse_"></a> MergeFrom\(CMsgProfileResponse\)

```csharp
public void MergeFrom(CMsgProfileResponse other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

