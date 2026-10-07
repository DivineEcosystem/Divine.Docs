# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity"></a> Class CMsgDotaScenario.Types.Entity

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.Entity : IMessage<CMsgDotaScenario.Types.Entity>, IEquatable<CMsgDotaScenario.Types.Entity>, IDeepCloneable<CMsgDotaScenario.Types.Entity>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)

#### Implements

IMessage<CMsgDotaScenario.Types.Entity\>, 
[IEquatable<CMsgDotaScenario.Types.Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.Entity\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.Entity\>\(CMsgDotaScenario.Types.Entity, params CMsgDotaScenario.Types.Entity\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity__ctor"></a> Entity\(\)

```csharp
public Entity()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_"></a> Entity\(Entity\)

```csharp
public Entity(CMsgDotaScenario.Types.Entity other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_CourierFieldNumber"></a> CourierFieldNumber

```csharp
public const int CourierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_DroppedItemFieldNumber"></a> DroppedItemFieldNumber

```csharp
public const int DroppedItemFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_NpcFieldNumber"></a> NpcFieldNumber

```csharp
public const int NpcFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_SpiritBearFieldNumber"></a> SpiritBearFieldNumber

```csharp
public const int SpiritBearFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Courier"></a> Courier

```csharp
public CScenarioEnt_Courier Courier { get; set; }
```

#### Property Value

 [CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_DroppedItem"></a> DroppedItem

```csharp
public CScenarioEnt_DroppedItem DroppedItem { get; set; }
```

#### Property Value

 [CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Npc"></a> Npc

```csharp
public CScenarioEnt_NPC Npc { get; set; }
```

#### Property Value

 [CScenarioEnt\_NPC](Divine.Protobufs.Dota2.CScenarioEnt\_NPC.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.Entity> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_SpiritBear"></a> SpiritBear

```csharp
public CScenarioEnt_SpiritBear SpiritBear { get; set; }
```

#### Property Value

 [CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.Entity Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_"></a> Equals\(Entity\)

```csharp
public bool Equals(CMsgDotaScenario.Types.Entity other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_"></a> MergeFrom\(Entity\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.Entity other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Entity](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Entity.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Entity_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

