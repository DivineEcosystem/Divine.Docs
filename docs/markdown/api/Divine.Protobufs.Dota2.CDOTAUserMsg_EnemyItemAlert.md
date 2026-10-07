# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert"></a> Class CDOTAUserMsg\_EnemyItemAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_EnemyItemAlert : IMessage<CDOTAUserMsg_EnemyItemAlert>, IEquatable<CDOTAUserMsg_EnemyItemAlert>, IDeepCloneable<CDOTAUserMsg_EnemyItemAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_EnemyItemAlert\>, 
[IEquatable<CDOTAUserMsg\_EnemyItemAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_EnemyItemAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_EnemyItemAlert\>\(CDOTAUserMsg\_EnemyItemAlert, params CDOTAUserMsg\_EnemyItemAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert__ctor"></a> CDOTAUserMsg\_EnemyItemAlert\(\)

```csharp
public CDOTAUserMsg_EnemyItemAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_"></a> CDOTAUserMsg\_EnemyItemAlert\(CDOTAUserMsg\_EnemyItemAlert\)

```csharp
public CDOTAUserMsg_EnemyItemAlert(CDOTAUserMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_EntityIdFieldNumber"></a> EntityIdFieldNumber

```csharp
public const int EntityIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ItemLevelFieldNumber"></a> ItemLevelFieldNumber

```csharp
public const int ItemLevelFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_PrimaryChargesFieldNumber"></a> PrimaryChargesFieldNumber

```csharp
public const int PrimaryChargesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_RuneTypeFieldNumber"></a> RuneTypeFieldNumber

```csharp
public const int RuneTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_SecondaryChargesFieldNumber"></a> SecondaryChargesFieldNumber

```csharp
public const int SecondaryChargesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_EntityId"></a> EntityId

```csharp
public int EntityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasEntityId"></a> HasEntityId

```csharp
public bool HasEntityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasItemLevel"></a> HasItemLevel

```csharp
public bool HasItemLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasPrimaryCharges"></a> HasPrimaryCharges

```csharp
public bool HasPrimaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasRuneType"></a> HasRuneType

```csharp
public bool HasRuneType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasSecondaryCharges"></a> HasSecondaryCharges

```csharp
public bool HasSecondaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ItemLevel"></a> ItemLevel

```csharp
public int ItemLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_EnemyItemAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_PrimaryCharges"></a> PrimaryCharges

```csharp
public int PrimaryCharges { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_RuneType"></a> RuneType

```csharp
public int RuneType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_SecondaryCharges"></a> SecondaryCharges

```csharp
public int SecondaryCharges { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearEntityId"></a> ClearEntityId\(\)

```csharp
public void ClearEntityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearItemLevel"></a> ClearItemLevel\(\)

```csharp
public void ClearItemLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearPrimaryCharges"></a> ClearPrimaryCharges\(\)

```csharp
public void ClearPrimaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearRuneType"></a> ClearRuneType\(\)

```csharp
public void ClearRuneType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearSecondaryCharges"></a> ClearSecondaryCharges\(\)

```csharp
public void ClearSecondaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_EnemyItemAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_"></a> Equals\(CDOTAUserMsg\_EnemyItemAlert\)

```csharp
public bool Equals(CDOTAUserMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_"></a> MergeFrom\(CDOTAUserMsg\_EnemyItemAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EnemyItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EnemyItemAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

