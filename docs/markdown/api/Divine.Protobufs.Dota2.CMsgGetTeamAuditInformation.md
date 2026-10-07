# <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation"></a> Class CMsgGetTeamAuditInformation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGetTeamAuditInformation : IMessage<CMsgGetTeamAuditInformation>, IEquatable<CMsgGetTeamAuditInformation>, IDeepCloneable<CMsgGetTeamAuditInformation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)

#### Implements

IMessage<CMsgGetTeamAuditInformation\>, 
[IEquatable<CMsgGetTeamAuditInformation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGetTeamAuditInformation\>, 
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
[EnumerableExtensions.In<CMsgGetTeamAuditInformation\>\(CMsgGetTeamAuditInformation, params CMsgGetTeamAuditInformation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation__ctor"></a> CMsgGetTeamAuditInformation\(\)

```csharp
public CMsgGetTeamAuditInformation()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation__ctor_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_"></a> CMsgGetTeamAuditInformation\(CMsgGetTeamAuditInformation\)

```csharp
public CMsgGetTeamAuditInformation(CMsgGetTeamAuditInformation other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_ActionsFieldNumber"></a> ActionsFieldNumber

```csharp
public const int ActionsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_LastUpdatedFieldNumber"></a> LastUpdatedFieldNumber

```csharp
public const int LastUpdatedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Actions"></a> Actions

```csharp
public RepeatedField<CMsgGetTeamAuditInformation.Types.Action> Actions { get; }
```

#### Property Value

 RepeatedField<[CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_HasLastUpdated"></a> HasLastUpdated

```csharp
public bool HasLastUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_LastUpdated"></a> LastUpdated

```csharp
public uint LastUpdated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGetTeamAuditInformation> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_ClearLastUpdated"></a> ClearLastUpdated\(\)

```csharp
public void ClearLastUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Clone"></a> Clone\(\)

```csharp
public CMsgGetTeamAuditInformation Clone()
```

#### Returns

 [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Equals_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_"></a> Equals\(CMsgGetTeamAuditInformation\)

```csharp
public bool Equals(CMsgGetTeamAuditInformation other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_MergeFrom_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_"></a> MergeFrom\(CMsgGetTeamAuditInformation\)

```csharp
public void MergeFrom(CMsgGetTeamAuditInformation other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

