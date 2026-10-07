# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef"></a> Class CMsgDotaScenario.Types.EntityRef

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.EntityRef : IMessage<CMsgDotaScenario.Types.EntityRef>, IEquatable<CMsgDotaScenario.Types.EntityRef>, IDeepCloneable<CMsgDotaScenario.Types.EntityRef>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

#### Implements

IMessage<CMsgDotaScenario.Types.EntityRef\>, 
[IEquatable<CMsgDotaScenario.Types.EntityRef\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.EntityRef\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.EntityRef\>\(CMsgDotaScenario.Types.EntityRef, params CMsgDotaScenario.Types.EntityRef\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef__ctor"></a> EntityRef\(\)

```csharp
public EntityRef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_"></a> EntityRef\(EntityRef\)

```csharp
public EntityRef(CMsgDotaScenario.Types.EntityRef other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_AbilityNameFieldNumber"></a> AbilityNameFieldNumber

```csharp
public const int AbilityNameFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_EntityIdxFieldNumber"></a> EntityIdxFieldNumber

```csharp
public const int EntityIdxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_NeutralStashIdFieldNumber"></a> NeutralStashIdFieldNumber

```csharp
public const int NeutralStashIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_RoshanFieldNumber"></a> RoshanFieldNumber

```csharp
public const int RoshanFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_AbilityName"></a> AbilityName

```csharp
public string AbilityName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_EntityIdx"></a> EntityIdx

```csharp
public int EntityIdx { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_HasAbilityName"></a> HasAbilityName

```csharp
public bool HasAbilityName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_HasEntityIdx"></a> HasEntityIdx

```csharp
public bool HasEntityIdx { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_HasNeutralStashId"></a> HasNeutralStashId

```csharp
public bool HasNeutralStashId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_HasRoshan"></a> HasRoshan

```csharp
public bool HasRoshan { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_NeutralStashId"></a> NeutralStashId

```csharp
public int NeutralStashId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.EntityRef> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Roshan"></a> Roshan

```csharp
public bool Roshan { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ClearAbilityName"></a> ClearAbilityName\(\)

```csharp
public void ClearAbilityName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ClearEntityIdx"></a> ClearEntityIdx\(\)

```csharp
public void ClearEntityIdx()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ClearNeutralStashId"></a> ClearNeutralStashId\(\)

```csharp
public void ClearNeutralStashId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ClearRoshan"></a> ClearRoshan\(\)

```csharp
public void ClearRoshan()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.EntityRef Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_"></a> Equals\(EntityRef\)

```csharp
public bool Equals(CMsgDotaScenario.Types.EntityRef other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_"></a> MergeFrom\(EntityRef\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.EntityRef other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_EntityRef_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

