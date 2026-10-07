# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier"></a> Class CMsgBotWorldState.Types.Modifier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.Modifier : IMessage<CMsgBotWorldState.Types.Modifier>, IEquatable<CMsgBotWorldState.Types.Modifier>, IDeepCloneable<CMsgBotWorldState.Types.Modifier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)

#### Implements

IMessage<CMsgBotWorldState.Types.Modifier\>, 
[IEquatable<CMsgBotWorldState.Types.Modifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.Modifier\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.Modifier\>\(CMsgBotWorldState.Types.Modifier, params CMsgBotWorldState.Types.Modifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier__ctor"></a> Modifier\(\)

```csharp
public Modifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_"></a> Modifier\(Modifier\)

```csharp
public Modifier(CMsgBotWorldState.Types.Modifier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AbilityHandleFieldNumber"></a> AbilityHandleFieldNumber

```csharp
public const int AbilityHandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AuxiliaryUnitsHandlesFieldNumber"></a> AuxiliaryUnitsHandlesFieldNumber

```csharp
public const int AuxiliaryUnitsHandlesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_RemainingDurationFieldNumber"></a> RemainingDurationFieldNumber

```csharp
public const int RemainingDurationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AbilityHandle"></a> AbilityHandle

```csharp
public uint AbilityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_AuxiliaryUnitsHandles"></a> AuxiliaryUnitsHandles

```csharp
public RepeatedField<uint> AuxiliaryUnitsHandles { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Handle"></a> Handle

```csharp
public uint Handle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasAbilityHandle"></a> HasAbilityHandle

```csharp
public bool HasAbilityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasRemainingDuration"></a> HasRemainingDuration

```csharp
public bool HasRemainingDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.Modifier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_RemainingDuration"></a> RemainingDuration

```csharp
public float RemainingDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_StackCount"></a> StackCount

```csharp
public uint StackCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearAbilityHandle"></a> ClearAbilityHandle\(\)

```csharp
public void ClearAbilityHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearRemainingDuration"></a> ClearRemainingDuration\(\)

```csharp
public void ClearRemainingDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.Modifier Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_"></a> Equals\(Modifier\)

```csharp
public bool Equals(CMsgBotWorldState.Types.Modifier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_"></a> MergeFrom\(Modifier\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.Modifier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Modifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Modifier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

