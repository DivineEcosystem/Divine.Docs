# <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo"></a> Class CMsgDOTASeries.Types.TeamInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeries.Types.TeamInfo : IMessage<CMsgDOTASeries.Types.TeamInfo>, IEquatable<CMsgDOTASeries.Types.TeamInfo>, IDeepCloneable<CMsgDOTASeries.Types.TeamInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeries.Types.TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

#### Implements

IMessage<CMsgDOTASeries.Types.TeamInfo\>, 
[IEquatable<CMsgDOTASeries.Types.TeamInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeries.Types.TeamInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTASeries.Types.TeamInfo\>\(CMsgDOTASeries.Types.TeamInfo, params CMsgDOTASeries.Types.TeamInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo__ctor"></a> TeamInfo\(\)

```csharp
public TeamInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_"></a> TeamInfo\(TeamInfo\)

```csharp
public TeamInfo(CMsgDOTASeries.Types.TeamInfo other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamLogoUrlFieldNumber"></a> TeamLogoUrlFieldNumber

```csharp
public const int TeamLogoUrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_WagerCountFieldNumber"></a> WagerCountFieldNumber

```csharp
public const int WagerCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_HasTeamLogoUrl"></a> HasTeamLogoUrl

```csharp
public bool HasTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_HasWagerCount"></a> HasWagerCount

```csharp
public bool HasWagerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeries.Types.TeamInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamLogoUrl"></a> TeamLogoUrl

```csharp
public string TeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_WagerCount"></a> WagerCount

```csharp
public uint WagerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_ClearTeamLogoUrl"></a> ClearTeamLogoUrl\(\)

```csharp
public void ClearTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_ClearWagerCount"></a> ClearWagerCount\(\)

```csharp
public void ClearWagerCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeries.Types.TeamInfo Clone()
```

#### Returns

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_"></a> Equals\(TeamInfo\)

```csharp
public bool Equals(CMsgDOTASeries.Types.TeamInfo other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_"></a> MergeFrom\(TeamInfo\)

```csharp
public void MergeFrom(CMsgDOTASeries.Types.TeamInfo other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_TeamInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

