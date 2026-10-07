# <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData"></a> Class CDOTALobbyMatchQualityData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTALobbyMatchQualityData : IMessage<CDOTALobbyMatchQualityData>, IEquatable<CDOTALobbyMatchQualityData>, IDeepCloneable<CDOTALobbyMatchQualityData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)

#### Implements

IMessage<CDOTALobbyMatchQualityData\>, 
[IEquatable<CDOTALobbyMatchQualityData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTALobbyMatchQualityData\>, 
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
[EnumerableExtensions.In<CDOTALobbyMatchQualityData\>\(CDOTALobbyMatchQualityData, params CDOTALobbyMatchQualityData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData__ctor"></a> CDOTALobbyMatchQualityData\(\)

```csharp
public CDOTALobbyMatchQualityData()
```

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData__ctor_Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_"></a> CDOTALobbyMatchQualityData\(CDOTALobbyMatchQualityData\)

```csharp
public CDOTALobbyMatchQualityData(CDOTALobbyMatchQualityData other)
```

#### Parameters

`other` [CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MatchBehaviorFieldNumber"></a> MatchBehaviorFieldNumber

```csharp
public const int MatchBehaviorFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MatchSkillRangeFieldNumber"></a> MatchSkillRangeFieldNumber

```csharp
public const int MatchSkillRangeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_OverallQualityFieldNumber"></a> OverallQualityFieldNumber

```csharp
public const int OverallQualityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_TeamBalanceFieldNumber"></a> TeamBalanceFieldNumber

```csharp
public const int TeamBalanceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_HasMatchBehavior"></a> HasMatchBehavior

```csharp
public bool HasMatchBehavior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_HasMatchSkillRange"></a> HasMatchSkillRange

```csharp
public bool HasMatchSkillRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_HasOverallQuality"></a> HasOverallQuality

```csharp
public bool HasOverallQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_HasTeamBalance"></a> HasTeamBalance

```csharp
public bool HasTeamBalance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MatchBehavior"></a> MatchBehavior

```csharp
public uint MatchBehavior { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MatchSkillRange"></a> MatchSkillRange

```csharp
public uint MatchSkillRange { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_OverallQuality"></a> OverallQuality

```csharp
public uint OverallQuality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_Parser"></a> Parser

```csharp
public static MessageParser<CDOTALobbyMatchQualityData> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_TeamBalance"></a> TeamBalance

```csharp
public uint TeamBalance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_ClearMatchBehavior"></a> ClearMatchBehavior\(\)

```csharp
public void ClearMatchBehavior()
```

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_ClearMatchSkillRange"></a> ClearMatchSkillRange\(\)

```csharp
public void ClearMatchSkillRange()
```

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_ClearOverallQuality"></a> ClearOverallQuality\(\)

```csharp
public void ClearOverallQuality()
```

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_ClearTeamBalance"></a> ClearTeamBalance\(\)

```csharp
public void ClearTeamBalance()
```

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_Clone"></a> Clone\(\)

```csharp
public CDOTALobbyMatchQualityData Clone()
```

#### Returns

 [CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_Equals_Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_"></a> Equals\(CDOTALobbyMatchQualityData\)

```csharp
public bool Equals(CDOTALobbyMatchQualityData other)
```

#### Parameters

`other` [CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MergeFrom_Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_"></a> MergeFrom\(CDOTALobbyMatchQualityData\)

```csharp
public void MergeFrom(CDOTALobbyMatchQualityData other)
```

#### Parameters

`other` [CDOTALobbyMatchQualityData](Divine.Protobufs.Dota2.CDOTALobbyMatchQualityData.md)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTALobbyMatchQualityData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

