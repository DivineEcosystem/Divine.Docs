# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile"></a> Class CMsgBotWorldState.Types.LinearProjectile

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.LinearProjectile : IMessage<CMsgBotWorldState.Types.LinearProjectile>, IEquatable<CMsgBotWorldState.Types.LinearProjectile>, IDeepCloneable<CMsgBotWorldState.Types.LinearProjectile>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)

#### Implements

IMessage<CMsgBotWorldState.Types.LinearProjectile\>, 
[IEquatable<CMsgBotWorldState.Types.LinearProjectile\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.LinearProjectile\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.LinearProjectile\>\(CMsgBotWorldState.Types.LinearProjectile, params CMsgBotWorldState.Types.LinearProjectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile__ctor"></a> LinearProjectile\(\)

```csharp
public LinearProjectile()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_"></a> LinearProjectile\(LinearProjectile\)

```csharp
public LinearProjectile(CMsgBotWorldState.Types.LinearProjectile other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_AbilityHandleFieldNumber"></a> AbilityHandleFieldNumber

```csharp
public const int AbilityHandleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterHandleFieldNumber"></a> CasterHandleFieldNumber

```csharp
public const int CasterHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterPlayerIdFieldNumber"></a> CasterPlayerIdFieldNumber

```csharp
public const int CasterPlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterUnitTypeFieldNumber"></a> CasterUnitTypeFieldNumber

```csharp
public const int CasterUnitTypeFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_RadiusFieldNumber"></a> RadiusFieldNumber

```csharp
public const int RadiusFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_VelocityFieldNumber"></a> VelocityFieldNumber

```csharp
public const int VelocityFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_AbilityHandle"></a> AbilityHandle

```csharp
public uint AbilityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterHandle"></a> CasterHandle

```csharp
public uint CasterHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterPlayerId"></a> CasterPlayerId

```csharp
public int CasterPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CasterUnitType"></a> CasterUnitType

```csharp
public CMsgBotWorldState.Types.UnitType CasterUnitType { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[UnitType](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.UnitType.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Handle"></a> Handle

```csharp
public uint Handle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasAbilityHandle"></a> HasAbilityHandle

```csharp
public bool HasAbilityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasCasterHandle"></a> HasCasterHandle

```csharp
public bool HasCasterHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasCasterPlayerId"></a> HasCasterPlayerId

```csharp
public bool HasCasterPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasCasterUnitType"></a> HasCasterUnitType

```csharp
public bool HasCasterUnitType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_HasRadius"></a> HasRadius

```csharp
public bool HasRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.LinearProjectile> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Radius"></a> Radius

```csharp
public uint Radius { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Velocity"></a> Velocity

```csharp
public CMsgBotWorldState.Types.Vector Velocity { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearAbilityHandle"></a> ClearAbilityHandle\(\)

```csharp
public void ClearAbilityHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearCasterHandle"></a> ClearCasterHandle\(\)

```csharp
public void ClearCasterHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearCasterPlayerId"></a> ClearCasterPlayerId\(\)

```csharp
public void ClearCasterPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearCasterUnitType"></a> ClearCasterUnitType\(\)

```csharp
public void ClearCasterUnitType()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ClearRadius"></a> ClearRadius\(\)

```csharp
public void ClearRadius()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.LinearProjectile Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_"></a> Equals\(LinearProjectile\)

```csharp
public bool Equals(CMsgBotWorldState.Types.LinearProjectile other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_"></a> MergeFrom\(LinearProjectile\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.LinearProjectile other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_LinearProjectile_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

