# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone"></a> Class CMsgBotWorldState.Types.AvoidanceZone

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.AvoidanceZone : IMessage<CMsgBotWorldState.Types.AvoidanceZone>, IEquatable<CMsgBotWorldState.Types.AvoidanceZone>, IDeepCloneable<CMsgBotWorldState.Types.AvoidanceZone>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)

#### Implements

IMessage<CMsgBotWorldState.Types.AvoidanceZone\>, 
[IEquatable<CMsgBotWorldState.Types.AvoidanceZone\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.AvoidanceZone\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.AvoidanceZone\>\(CMsgBotWorldState.Types.AvoidanceZone, params CMsgBotWorldState.Types.AvoidanceZone\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone__ctor"></a> AvoidanceZone\(\)

```csharp
public AvoidanceZone()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_"></a> AvoidanceZone\(AvoidanceZone\)

```csharp
public AvoidanceZone(CMsgBotWorldState.Types.AvoidanceZone other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_AbilityHandleFieldNumber"></a> AbilityHandleFieldNumber

```csharp
public const int AbilityHandleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterHandleFieldNumber"></a> CasterHandleFieldNumber

```csharp
public const int CasterHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterPlayerIdFieldNumber"></a> CasterPlayerIdFieldNumber

```csharp
public const int CasterPlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterUnitTypeFieldNumber"></a> CasterUnitTypeFieldNumber

```csharp
public const int CasterUnitTypeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_RadiusFieldNumber"></a> RadiusFieldNumber

```csharp
public const int RadiusFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_AbilityHandle"></a> AbilityHandle

```csharp
public uint AbilityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterHandle"></a> CasterHandle

```csharp
public uint CasterHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterPlayerId"></a> CasterPlayerId

```csharp
public int CasterPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CasterUnitType"></a> CasterUnitType

```csharp
public CMsgBotWorldState.Types.UnitType CasterUnitType { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[UnitType](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.UnitType.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasAbilityHandle"></a> HasAbilityHandle

```csharp
public bool HasAbilityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasCasterHandle"></a> HasCasterHandle

```csharp
public bool HasCasterHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasCasterPlayerId"></a> HasCasterPlayerId

```csharp
public bool HasCasterPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasCasterUnitType"></a> HasCasterUnitType

```csharp
public bool HasCasterUnitType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_HasRadius"></a> HasRadius

```csharp
public bool HasRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.AvoidanceZone> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Radius"></a> Radius

```csharp
public uint Radius { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearAbilityHandle"></a> ClearAbilityHandle\(\)

```csharp
public void ClearAbilityHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearCasterHandle"></a> ClearCasterHandle\(\)

```csharp
public void ClearCasterHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearCasterPlayerId"></a> ClearCasterPlayerId\(\)

```csharp
public void ClearCasterPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearCasterUnitType"></a> ClearCasterUnitType\(\)

```csharp
public void ClearCasterUnitType()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ClearRadius"></a> ClearRadius\(\)

```csharp
public void ClearRadius()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.AvoidanceZone Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_"></a> Equals\(AvoidanceZone\)

```csharp
public bool Equals(CMsgBotWorldState.Types.AvoidanceZone other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_"></a> MergeFrom\(AvoidanceZone\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.AvoidanceZone other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_AvoidanceZone_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

