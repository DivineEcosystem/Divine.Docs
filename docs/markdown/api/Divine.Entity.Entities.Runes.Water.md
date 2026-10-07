# <a id="Divine_Entity_Entities_Runes_Water"></a> Class Water

Namespace: [Divine.Entity.Entities.Runes](Divine.Entity.Entities.Runes.md)  
Assembly: Divine.dll  

```csharp
public sealed class Water : Rune, IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md) ← 
[Rune](Divine.Entity.Entities.Runes.Rune.md) ← 
[Water](Divine.Entity.Entities.Runes.Water.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INative](Divine.Memory.INative.md)

#### Inherited Members

[Rune.RuneType](Divine.Entity.Entities.Runes.Rune.md\#Divine\_Entity\_Entities\_Runes\_Rune\_RuneType), 
[Entity.NetworkClassInfos](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkClassInfos), 
[Entity.NetworkPropertyChanged](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkPropertyChanged), 
[Entity.AnimationChanged](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationChanged), 
[Entity.Native](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Native), 
[Entity.GetClassIdByNetworkName\(string\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetClassIdByNetworkName\_System\_String\_), 
[Entity.GetNetworkNameByClassId\(ClassId\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkNameByClassId\_Divine\_Entity\_Entities\_Components\_ClassId\_), 
[Entity.GetStandartNetworkNameByClassId\(int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetStandartNetworkNameByClassId\_System\_Int32\_), 
[Entity.IsValid](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsValid), 
[Entity.Type](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Type), 
[Entity.Handle](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Handle), 
[Entity.NetworkHandle](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkHandle), 
[Entity.Serial](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Serial), 
[Entity.Index](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Index), 
[Entity.GetHandleByIndex\(int, int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHandleByIndex\_System\_Int32\_System\_Int32\_), 
[Entity.GetSerialByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSerialByHandle\_System\_UInt32\_), 
[Entity.GetSerialByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSerialByNetworkHandle\_System\_UInt32\_), 
[Entity.GetIndexByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetIndexByHandle\_System\_UInt32\_), 
[Entity.GetIndexByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetIndexByNetworkHandle\_System\_UInt32\_), 
[Entity.GetHandleByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHandleByNetworkHandle\_System\_UInt32\_), 
[Entity.GetNetworkHandleByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkHandleByHandle\_System\_UInt32\_), 
[Entity.GetNetworkHandleByIndex\(int, int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkHandleByIndex\_System\_Int32\_System\_Int32\_), 
[Entity.InternalName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_InternalName), 
[Entity.DesignerName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_DesignerName), 
[Entity.MaximumHealth](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_MaximumHealth), 
[Entity.Health](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Health), 
[Entity.CreateTime](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_CreateTime), 
[Entity.Speed](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Speed), 
[Entity.Team](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Team), 
[Entity.Owner](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Owner), 
[Entity.Name](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Name), 
[Entity.NetworkName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkName), 
[Entity.LifeState](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_LifeState), 
[Entity.IdentityFlags](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IdentityFlags), 
[Entity.WorldGroupId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_WorldGroupId), 
[Entity.IsMainWorld](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsMainWorld), 
[Entity.IsClientWorld](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsClientWorld), 
[Entity.Flags](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Flags), 
[Entity.ClassId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ClassId), 
[Entity.ClassNetworkId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ClassNetworkId), 
[Entity.Position](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Position), 
[Entity.Angles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Angles), 
[Entity.NetworkAngles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkAngles), 
[Entity.IsAlive](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsAlive), 
[Entity.IsVisible](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsVisible), 
[Entity.IsDormant](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsDormant), 
[Entity.Rotation](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Rotation), 
[Entity.RotationRad](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_RotationRad), 
[Entity.NetworkRotation](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkRotation), 
[Entity.NetworkRotationRad](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkRotationRad), 
[Entity.AnimationName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationName), 
[Entity.AnimationSequence](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationSequence), 
[Entity.Model](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Model), 
[Entity.Scale](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Scale), 
[Entity.ColorTint](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ColorTint), 
[Entity.Glow](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Glow), 
[Entity.Particles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Particles), 
[Entity.GetSequenceName\(int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSequenceName\_System\_Int32\_), 
[Entity.Select\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Select), 
[Entity.Select\(bool\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Select\_System\_Boolean\_), 
[Entity.PlaySound\(string\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_PlaySound\_System\_String\_), 
[Entity.ToString\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ToString), 
[Entity.Equals\(object?\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Equals\_System\_Object\_), 
[Entity.Equals\(Entity?\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Equals\_Divine\_Entity\_Entities\_Entity\_), 
[Entity.GetHashCode\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHashCode), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
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
[EnumerableExtensions.In<Water\>\(Water, params Water\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EntityExtensions.IsAlly\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsEnemy\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsInRange\(Entity, Entity, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector2, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector2\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector3, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_System\_Single\_)

