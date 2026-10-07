# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building"></a> Class CMsgDotaScenario.Types.Building

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.Building : IMessage<CMsgDotaScenario.Types.Building>, IEquatable<CMsgDotaScenario.Types.Building>, IDeepCloneable<CMsgDotaScenario.Types.Building>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)

#### Implements

IMessage<CMsgDotaScenario.Types.Building\>, 
[IEquatable<CMsgDotaScenario.Types.Building\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.Building\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.Building\>\(CMsgDotaScenario.Types.Building, params CMsgDotaScenario.Types.Building\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building__ctor"></a> Building\(\)

```csharp
public Building()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_"></a> Building\(Building\)

```csharp
public Building(CMsgDotaScenario.Types.Building other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_EntityClassFieldNumber"></a> EntityClassFieldNumber

```csharp
public const int EntityClassFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_EntityNameFieldNumber"></a> EntityNameFieldNumber

```csharp
public const int EntityNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HealthFracFieldNumber"></a> HealthFracFieldNumber

```csharp
public const int HealthFracFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_IsDestroyedFieldNumber"></a> IsDestroyedFieldNumber

```csharp
public const int IsDestroyedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_EntityClass"></a> EntityClass

```csharp
public string EntityClass { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_EntityName"></a> EntityName

```csharp
public string EntityName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HasEntityClass"></a> HasEntityClass

```csharp
public bool HasEntityClass { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HasEntityName"></a> HasEntityName

```csharp
public bool HasEntityName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HasHealthFrac"></a> HasHealthFrac

```csharp
public bool HasHealthFrac { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HasIsDestroyed"></a> HasIsDestroyed

```csharp
public bool HasIsDestroyed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_HealthFrac"></a> HealthFrac

```csharp
public float HealthFrac { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_IsDestroyed"></a> IsDestroyed

```csharp
public bool IsDestroyed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.Building> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_TeamId"></a> TeamId

```csharp
public int TeamId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ClearEntityClass"></a> ClearEntityClass\(\)

```csharp
public void ClearEntityClass()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ClearEntityName"></a> ClearEntityName\(\)

```csharp
public void ClearEntityName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ClearHealthFrac"></a> ClearHealthFrac\(\)

```csharp
public void ClearHealthFrac()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ClearIsDestroyed"></a> ClearIsDestroyed\(\)

```csharp
public void ClearIsDestroyed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.Building Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_"></a> Equals\(Building\)

```csharp
public bool Equals(CMsgDotaScenario.Types.Building other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_"></a> MergeFrom\(Building\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.Building other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Building](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Building.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Building_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

