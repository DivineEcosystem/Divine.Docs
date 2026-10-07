# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility"></a> Class CMsgBotWorldState.Types.EventAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.EventAbility : IMessage<CMsgBotWorldState.Types.EventAbility>, IEquatable<CMsgBotWorldState.Types.EventAbility>, IDeepCloneable<CMsgBotWorldState.Types.EventAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)

#### Implements

IMessage<CMsgBotWorldState.Types.EventAbility\>, 
[IEquatable<CMsgBotWorldState.Types.EventAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.EventAbility\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.EventAbility\>\(CMsgBotWorldState.Types.EventAbility, params CMsgBotWorldState.Types.EventAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility__ctor"></a> EventAbility\(\)

```csharp
public EventAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_"></a> EventAbility\(EventAbility\)

```csharp
public EventAbility(CMsgBotWorldState.Types.EventAbility other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_IsChannelStartFieldNumber"></a> IsChannelStartFieldNumber

```csharp
public const int IsChannelStartFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_UnitHandleFieldNumber"></a> UnitHandleFieldNumber

```csharp
public const int UnitHandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_HasIsChannelStart"></a> HasIsChannelStart

```csharp
public bool HasIsChannelStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_HasUnitHandle"></a> HasUnitHandle

```csharp
public bool HasUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_IsChannelStart"></a> IsChannelStart

```csharp
public bool IsChannelStart { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.EventAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_UnitHandle"></a> UnitHandle

```csharp
public uint UnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_ClearIsChannelStart"></a> ClearIsChannelStart\(\)

```csharp
public void ClearIsChannelStart()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_ClearUnitHandle"></a> ClearUnitHandle\(\)

```csharp
public void ClearUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.EventAbility Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_"></a> Equals\(EventAbility\)

```csharp
public bool Equals(CMsgBotWorldState.Types.EventAbility other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_"></a> MergeFrom\(EventAbility\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.EventAbility other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

