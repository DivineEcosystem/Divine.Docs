# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo"></a> Class CMsgDOTATeamsInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamsInfo : IMessage<CMsgDOTATeamsInfo>, IEquatable<CMsgDOTATeamsInfo>, IDeepCloneable<CMsgDOTATeamsInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)

#### Implements

IMessage<CMsgDOTATeamsInfo\>, 
[IEquatable<CMsgDOTATeamsInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamsInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamsInfo\>\(CMsgDOTATeamsInfo, params CMsgDOTATeamsInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo__ctor"></a> CMsgDOTATeamsInfo\(\)

```csharp
public CMsgDOTATeamsInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_"></a> CMsgDOTATeamsInfo\(CMsgDOTATeamsInfo\)

```csharp
public CMsgDOTATeamsInfo(CMsgDOTATeamsInfo other)
```

#### Parameters

`other` [CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamsInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTATeamInfo> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamsInfo Clone()
```

#### Returns

 [CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_"></a> Equals\(CMsgDOTATeamsInfo\)

```csharp
public bool Equals(CMsgDOTATeamsInfo other)
```

#### Parameters

`other` [CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_"></a> MergeFrom\(CMsgDOTATeamsInfo\)

```csharp
public void MergeFrom(CMsgDOTATeamsInfo other)
```

#### Parameters

`other` [CMsgDOTATeamsInfo](Divine.Protobufs.Dota2.CMsgDOTATeamsInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamsInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

