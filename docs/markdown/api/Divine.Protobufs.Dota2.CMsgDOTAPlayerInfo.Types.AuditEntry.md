# <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry"></a> Class CMsgDOTAPlayerInfo.Types.AuditEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPlayerInfo.Types.AuditEntry : IMessage<CMsgDOTAPlayerInfo.Types.AuditEntry>, IEquatable<CMsgDOTAPlayerInfo.Types.AuditEntry>, IDeepCloneable<CMsgDOTAPlayerInfo.Types.AuditEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPlayerInfo.Types.AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)

#### Implements

IMessage<CMsgDOTAPlayerInfo.Types.AuditEntry\>, 
[IEquatable<CMsgDOTAPlayerInfo.Types.AuditEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPlayerInfo.Types.AuditEntry\>, 
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
[EnumerableExtensions.In<CMsgDOTAPlayerInfo.Types.AuditEntry\>\(CMsgDOTAPlayerInfo.Types.AuditEntry, params CMsgDOTAPlayerInfo.Types.AuditEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry__ctor"></a> AuditEntry\(\)

```csharp
public AuditEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry__ctor_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_"></a> AuditEntry\(AuditEntry\)

```csharp
public AuditEntry(CMsgDOTAPlayerInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_EndTimestampFieldNumber"></a> EndTimestampFieldNumber

```csharp
public const int EndTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamTagFieldNumber"></a> TeamTagFieldNumber

```csharp
public const int TeamTagFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamUrlLogoFieldNumber"></a> TeamUrlLogoFieldNumber

```csharp
public const int TeamUrlLogoFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_EndTimestamp"></a> EndTimestamp

```csharp
public uint EndTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasEndTimestamp"></a> HasEndTimestamp

```csharp
public bool HasEndTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasTeamTag"></a> HasTeamTag

```csharp
public bool HasTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_HasTeamUrlLogo"></a> HasTeamUrlLogo

```csharp
public bool HasTeamUrlLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPlayerInfo.Types.AuditEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamTag"></a> TeamTag

```csharp
public string TeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_TeamUrlLogo"></a> TeamUrlLogo

```csharp
public string TeamUrlLogo { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearEndTimestamp"></a> ClearEndTimestamp\(\)

```csharp
public void ClearEndTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearTeamTag"></a> ClearTeamTag\(\)

```csharp
public void ClearTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ClearTeamUrlLogo"></a> ClearTeamUrlLogo\(\)

```csharp
public void ClearTeamUrlLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPlayerInfo.Types.AuditEntry Clone()
```

#### Returns

 [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_Equals_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_"></a> Equals\(AuditEntry\)

```csharp
public bool Equals(CMsgDOTAPlayerInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_"></a> MergeFrom\(AuditEntry\)

```csharp
public void MergeFrom(CMsgDOTAPlayerInfo.Types.AuditEntry other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_AuditEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

