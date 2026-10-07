# <a id="Divine_Entity_Entities_Entity"></a> Class Entity

Namespace: [Divine.Entity.Entities](Divine.Entity.Entities.md)  
Assembly: Divine.dll  

```csharp
public class Entity : IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md)

#### Derived

[Ability](Divine.Entity.Entities.Abilities.Ability.md), 
[PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md), 
[Player](Divine.Entity.Entities.Players.Player.md), 
[Rune](Divine.Entity.Entities.Runes.Rune.md), 
[Tree](Divine.Entity.Entities.Trees.Tree.md), 
[Unit](Divine.Entity.Entities.Units.Unit.md), 
[WearableItem](Divine.Entity.Entities.Wearables.WearableItem.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INative](Divine.Memory.INative.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EntityExtensions.Distance\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[EntityExtensions.Distance2D\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance2D\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Entity\>\(Entity, params Entity\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EntityExtensions.IsAlly\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsEnemy\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsInRange\(Entity, Entity, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector2, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector2\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector3, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_System\_Single\_)

## Properties

### <a id="Divine_Entity_Entities_Entity_Angles"></a> Angles

```csharp
public Vector3 Angles { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Entity_Entities_Entity_AnimationName"></a> AnimationName

```csharp
public string AnimationName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_AnimationSequence"></a> AnimationSequence

```csharp
public int AnimationSequence { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_ClassId"></a> ClassId

```csharp
public ClassId ClassId { get; }
```

#### Property Value

 [ClassId](Divine.Entity.Entities.Components.ClassId.md)

### <a id="Divine_Entity_Entities_Entity_ClassNetworkId"></a> ClassNetworkId

```csharp
public int ClassNetworkId { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_ColorTint"></a> ColorTint

```csharp
public Color ColorTint { get; set; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Entity_Entities_Entity_CreateTime"></a> CreateTime

```csharp
public float CreateTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_DesignerName"></a> DesignerName

```csharp
public string DesignerName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_Flags"></a> Flags

```csharp
public EntityFlags Flags { get; }
```

#### Property Value

 [EntityFlags](Divine.Entity.Entities.Components.EntityFlags.md)

### <a id="Divine_Entity_Entities_Entity_Glow"></a> Glow

```csharp
public Color Glow { get; set; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Entity_Entities_Entity_Handle"></a> Handle

```csharp
public uint Handle { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_Health"></a> Health

```csharp
public int Health { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_IdentityFlags"></a> IdentityFlags

```csharp
public EntityIdentityFlags IdentityFlags { get; }
```

#### Property Value

 [EntityIdentityFlags](Divine.Entity.Entities.Components.EntityIdentityFlags.md)

### <a id="Divine_Entity_Entities_Entity_Index"></a> Index

```csharp
public int Index { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_InternalName"></a> InternalName

```csharp
public string InternalName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_IsAlive"></a> IsAlive

```csharp
public virtual bool IsAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_IsClientWorld"></a> IsClientWorld

```csharp
public bool IsClientWorld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_IsDormant"></a> IsDormant

```csharp
public bool IsDormant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_IsMainWorld"></a> IsMainWorld

```csharp
public bool IsMainWorld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_IsVisible"></a> IsVisible

```csharp
public bool IsVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_LifeState"></a> LifeState

```csharp
public LifeState LifeState { get; }
```

#### Property Value

 [LifeState](Divine.Entity.Entities.Components.LifeState.md)

### <a id="Divine_Entity_Entities_Entity_MaximumHealth"></a> MaximumHealth

```csharp
public int MaximumHealth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_Model"></a> Model

```csharp
public virtual string Model { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_Name"></a> Name

```csharp
public virtual string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Entity_Entities_Entity_NetworkAngles"></a> NetworkAngles

```csharp
public Vector3 NetworkAngles { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Entity_Entities_Entity_NetworkClassInfos"></a> NetworkClassInfos

```csharp
public static IEnumerable<ClassInfo> NetworkClassInfos { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ClassInfo](Divine.Entity.Entities.Components.ClassInfo.md)\>

### <a id="Divine_Entity_Entities_Entity_NetworkHandle"></a> NetworkHandle

```csharp
public uint NetworkHandle { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_NetworkName"></a> NetworkName

```csharp
public string NetworkName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_NetworkRotation"></a> NetworkRotation

```csharp
public float NetworkRotation { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_NetworkRotationRad"></a> NetworkRotationRad

```csharp
public float NetworkRotationRad { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_Owner"></a> Owner

```csharp
public Entity? Owner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Entity_Entities_Entity_Particles"></a> Particles

```csharp
public IEnumerable<Particle> Particles { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Particle](Divine.Particle.Particles.Particle.md)\>

### <a id="Divine_Entity_Entities_Entity_Position"></a> Position

```csharp
public Vector3 Position { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Entity_Entities_Entity_Rotation"></a> Rotation

```csharp
public float Rotation { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_RotationRad"></a> RotationRad

```csharp
public float RotationRad { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_Serial"></a> Serial

```csharp
public int Serial { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_Speed"></a> Speed

```csharp
[Obsolete("This removed by Valve 25.06.2026. Use Unit.MovementSpeed")]
public float Speed { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Entity_Team"></a> Team

```csharp
public Team Team { get; }
```

#### Property Value

 [Team](Divine.Entity.Entities.Components.Team.md)

### <a id="Divine_Entity_Entities_Entity_Type"></a> Type

```csharp
public EntityType Type { get; }
```

#### Property Value

 [EntityType](Divine.Entity.Entities.Components.EntityType.md)

### <a id="Divine_Entity_Entities_Entity_WorldGroupId"></a> WorldGroupId

```csharp
public uint WorldGroupId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Entity_Entities_Entity_Equals_System_Object_"></a> Equals\(object?\)

Determines whether the specified object is equal to the current object.

```csharp
public override sealed bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Entity_Entities_Entity_Equals_Divine_Entity_Entities_Entity_"></a> Equals\(Entity?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Entity? other)
```

#### Parameters

`other` [Entity](Divine.Entity.Entities.Entity.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Entity_Entities_Entity_GetClassIdByNetworkName_System_String_"></a> GetClassIdByNetworkName\(string\)

```csharp
public static ClassId GetClassIdByNetworkName(string networkName)
```

#### Parameters

`networkName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ClassId](Divine.Entity.Entities.Components.ClassId.md)

### <a id="Divine_Entity_Entities_Entity_GetHandleByIndex_System_Int32_System_Int32_"></a> GetHandleByIndex\(int, int\)

```csharp
public static uint GetHandleByIndex(int index, int serial)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`serial` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_GetHandleByNetworkHandle_System_UInt32_"></a> GetHandleByNetworkHandle\(uint\)

```csharp
public static uint GetHandleByNetworkHandle(uint networkHandle)
```

#### Parameters

`networkHandle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override sealed int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="Divine_Entity_Entities_Entity_GetIndexByHandle_System_UInt32_"></a> GetIndexByHandle\(uint\)

```csharp
public static int GetIndexByHandle(uint handle)
```

#### Parameters

`handle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_GetIndexByNetworkHandle_System_UInt32_"></a> GetIndexByNetworkHandle\(uint\)

```csharp
public static int GetIndexByNetworkHandle(uint networkHandle)
```

#### Parameters

`networkHandle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_GetNetworkHandleByHandle_System_UInt32_"></a> GetNetworkHandleByHandle\(uint\)

```csharp
public static uint GetNetworkHandleByHandle(uint handle)
```

#### Parameters

`handle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_GetNetworkHandleByIndex_System_Int32_System_Int32_"></a> GetNetworkHandleByIndex\(int, int\)

```csharp
public static uint GetNetworkHandleByIndex(int index, int serial)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`serial` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_GetNetworkNameByClassId_Divine_Entity_Entities_Components_ClassId_"></a> GetNetworkNameByClassId\(ClassId\)

```csharp
public static string GetNetworkNameByClassId(ClassId classId)
```

#### Parameters

`classId` [ClassId](Divine.Entity.Entities.Components.ClassId.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_GetSequenceName_System_Int32_"></a> GetSequenceName\(int\)

```csharp
public string GetSequenceName(int sequence)
```

#### Parameters

`sequence` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_GetSerialByHandle_System_UInt32_"></a> GetSerialByHandle\(uint\)

```csharp
public static int GetSerialByHandle(uint handle)
```

#### Parameters

`handle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_GetSerialByNetworkHandle_System_UInt32_"></a> GetSerialByNetworkHandle\(uint\)

```csharp
public static int GetSerialByNetworkHandle(uint networkHandle)
```

#### Parameters

`networkHandle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Entity_GetStandartNetworkNameByClassId_System_Int32_"></a> GetStandartNetworkNameByClassId\(int\)

```csharp
public static string GetStandartNetworkNameByClassId(int standartClassId)
```

#### Parameters

`standartClassId` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Entity_PlaySound_System_String_"></a> PlaySound\(string\)

```csharp
public uint PlaySound(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Entity_Select"></a> Select\(\)

```csharp
public bool Select()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_Select_System_Boolean_"></a> Select\(bool\)

```csharp
public bool Select(bool addToCurrentSelection)
```

#### Parameters

`addToCurrentSelection` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="Divine_Entity_Entities_Entity_AnimationChanged"></a> AnimationChanged

```csharp
public static event Entity.AnimationChangedEventHandler AnimationChanged
```

#### Event Type

 [Entity](Divine.Entity.Entities.Entity.md).[AnimationChangedEventHandler](Divine.Entity.Entities.Entity.AnimationChangedEventHandler.md)

### <a id="Divine_Entity_Entities_Entity_NetworkPropertyChanged"></a> NetworkPropertyChanged

```csharp
public static event Entity.NetworkPropertyChangedEventHandler NetworkPropertyChanged
```

#### Event Type

 [Entity](Divine.Entity.Entities.Entity.md).[NetworkPropertyChangedEventHandler](Divine.Entity.Entities.Entity.NetworkPropertyChangedEventHandler.md)

## Operators

### <a id="Divine_Entity_Entities_Entity_op_Equality_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> operator ==\(Entity?, Entity?\)

```csharp
public static bool operator ==(Entity? left, Entity? right)
```

#### Parameters

`left` [Entity](Divine.Entity.Entities.Entity.md)?

`right` [Entity](Divine.Entity.Entities.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Entity_op_Inequality_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> operator \!=\(Entity?, Entity?\)

```csharp
public static bool operator !=(Entity? left, Entity? right)
```

#### Parameters

`left` [Entity](Divine.Entity.Entities.Entity.md)?

`right` [Entity](Divine.Entity.Entities.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

