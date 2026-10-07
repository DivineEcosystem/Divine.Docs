# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey"></a> Class CDOTAUserMsg\_ShowSurvey

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ShowSurvey : IMessage<CDOTAUserMsg_ShowSurvey>, IEquatable<CDOTAUserMsg_ShowSurvey>, IDeepCloneable<CDOTAUserMsg_ShowSurvey>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)

#### Implements

IMessage<CDOTAUserMsg\_ShowSurvey\>, 
[IEquatable<CDOTAUserMsg\_ShowSurvey\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ShowSurvey\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ShowSurvey\>\(CDOTAUserMsg\_ShowSurvey, params CDOTAUserMsg\_ShowSurvey\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey__ctor"></a> CDOTAUserMsg\_ShowSurvey\(\)

```csharp
public CDOTAUserMsg_ShowSurvey()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_"></a> CDOTAUserMsg\_ShowSurvey\(CDOTAUserMsg\_ShowSurvey\)

```csharp
public CDOTAUserMsg_ShowSurvey(CDOTAUserMsg_ShowSurvey other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ResponseStyleFieldNumber"></a> ResponseStyleFieldNumber

```csharp
public const int ResponseStyleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_SurveyIdFieldNumber"></a> SurveyIdFieldNumber

```csharp
public const int SurveyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateAccountIdFieldNumber"></a> TeammateAccountIdFieldNumber

```csharp
public const int TeammateAccountIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateHeroIdFieldNumber"></a> TeammateHeroIdFieldNumber

```csharp
public const int TeammateHeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateNameFieldNumber"></a> TeammateNameFieldNumber

```csharp
public const int TeammateNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasResponseStyle"></a> HasResponseStyle

```csharp
public bool HasResponseStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasSurveyId"></a> HasSurveyId

```csharp
public bool HasSurveyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasTeammateAccountId"></a> HasTeammateAccountId

```csharp
public bool HasTeammateAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasTeammateHeroId"></a> HasTeammateHeroId

```csharp
public bool HasTeammateHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_HasTeammateName"></a> HasTeammateName

```csharp
public bool HasTeammateName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ShowSurvey> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ResponseStyle"></a> ResponseStyle

```csharp
public string ResponseStyle { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_SurveyId"></a> SurveyId

```csharp
public int SurveyId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateAccountId"></a> TeammateAccountId

```csharp
public uint TeammateAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateHeroId"></a> TeammateHeroId

```csharp
public int TeammateHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_TeammateName"></a> TeammateName

```csharp
public string TeammateName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearResponseStyle"></a> ClearResponseStyle\(\)

```csharp
public void ClearResponseStyle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearSurveyId"></a> ClearSurveyId\(\)

```csharp
public void ClearSurveyId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearTeammateAccountId"></a> ClearTeammateAccountId\(\)

```csharp
public void ClearTeammateAccountId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearTeammateHeroId"></a> ClearTeammateHeroId\(\)

```csharp
public void ClearTeammateHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ClearTeammateName"></a> ClearTeammateName\(\)

```csharp
public void ClearTeammateName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ShowSurvey Clone()
```

#### Returns

 [CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_"></a> Equals\(CDOTAUserMsg\_ShowSurvey\)

```csharp
public bool Equals(CDOTAUserMsg_ShowSurvey other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_"></a> MergeFrom\(CDOTAUserMsg\_ShowSurvey\)

```csharp
public void MergeFrom(CDOTAUserMsg_ShowSurvey other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowSurvey](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowSurvey.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowSurvey_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

