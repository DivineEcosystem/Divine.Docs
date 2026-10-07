# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus"></a> Class CMsgTeamFanContentAutographStatus.Types.TeamStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentAutographStatus.Types.TeamStatus : IMessage<CMsgTeamFanContentAutographStatus.Types.TeamStatus>, IEquatable<CMsgTeamFanContentAutographStatus.Types.TeamStatus>, IDeepCloneable<CMsgTeamFanContentAutographStatus.Types.TeamStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentAutographStatus.Types.TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)

#### Implements

IMessage<CMsgTeamFanContentAutographStatus.Types.TeamStatus\>, 
[IEquatable<CMsgTeamFanContentAutographStatus.Types.TeamStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentAutographStatus.Types.TeamStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentAutographStatus.Types.TeamStatus\>\(CMsgTeamFanContentAutographStatus.Types.TeamStatus, params CMsgTeamFanContentAutographStatus.Types.TeamStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus__ctor"></a> TeamStatus\(\)

```csharp
public TeamStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_"></a> TeamStatus\(TeamStatus\)

```csharp
public TeamStatus(CMsgTeamFanContentAutographStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_AutographsFieldNumber"></a> AutographsFieldNumber

```csharp
public const int AutographsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_WorkshopAccountIdFieldNumber"></a> WorkshopAccountIdFieldNumber

```csharp
public const int WorkshopAccountIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Autographs"></a> Autographs

```csharp
public RepeatedField<CMsgTeamFanContentAutographStatus.Types.AutographStatus> Autographs { get; }
```

#### Property Value

 RepeatedField<[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_HasWorkshopAccountId"></a> HasWorkshopAccountId

```csharp
public bool HasWorkshopAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentAutographStatus.Types.TeamStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_WorkshopAccountId"></a> WorkshopAccountId

```csharp
public uint WorkshopAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_ClearWorkshopAccountId"></a> ClearWorkshopAccountId\(\)

```csharp
public void ClearWorkshopAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentAutographStatus.Types.TeamStatus Clone()
```

#### Returns

 [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_"></a> Equals\(TeamStatus\)

```csharp
public bool Equals(CMsgTeamFanContentAutographStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_"></a> MergeFrom\(TeamStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentAutographStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_TeamStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

