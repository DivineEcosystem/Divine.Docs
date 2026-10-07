# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord"></a> Class CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord : IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord>, IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord\>\(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord, params CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord__ctor"></a> BuffRecord\(\)

```csharp
public BuffRecord()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_"></a> BuffRecord\(BuffRecord\)

```csharp
public BuffRecord(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_BuffAbilityIdFieldNumber"></a> BuffAbilityIdFieldNumber

```csharp
public const int BuffAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_BuffModifierNameFieldNumber"></a> BuffModifierNameFieldNumber

```csharp
public const int BuffModifierNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_ByHeroTargetsFieldNumber"></a> ByHeroTargetsFieldNumber

```csharp
public const int ByHeroTargetsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_BuffAbilityId"></a> BuffAbilityId

```csharp
public int BuffAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_BuffModifierName"></a> BuffModifierName

```csharp
public string BuffModifierName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_ByHeroTargets"></a> ByHeroTargets

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.Types.ByHeroTarget> ByHeroTargets { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.Types.md).[ByHeroTarget](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.Types.ByHeroTarget.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_HasBuffAbilityId"></a> HasBuffAbilityId

```csharp
public bool HasBuffAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_HasBuffModifierName"></a> HasBuffModifierName

```csharp
public bool HasBuffModifierName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_ClearBuffAbilityId"></a> ClearBuffAbilityId\(\)

```csharp
public void ClearBuffAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_ClearBuffModifierName"></a> ClearBuffModifierName\(\)

```csharp
public void ClearBuffModifierName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_"></a> Equals\(BuffRecord\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_"></a> MergeFrom\(BuffRecord\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[BuffRecord](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.BuffRecord.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_BuffRecord_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

