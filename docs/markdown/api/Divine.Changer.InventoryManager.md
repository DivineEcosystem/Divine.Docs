# <a id="Divine_Changer_InventoryManager"></a> Class InventoryManager

Namespace: [Divine.Changer](Divine.Changer.md)  
Assembly: Divine.dll  

```csharp
public static class InventoryManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InventoryManager](Divine.Changer.InventoryManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Properties

### <a id="Divine_Changer_InventoryManager_ItemsGame"></a> ItemsGame

```csharp
public static KeyValues? ItemsGame { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)?

## Methods

### <a id="Divine_Changer_InventoryManager_GetHeroModel_Divine_Entity_Entities_Units_Heroes_Components_HeroId_"></a> GetHeroModel\(HeroId\)

```csharp
public static string? GetHeroModel(HeroId heroId)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Changer_InventoryManager_HasActivityModifier_System_IntPtr_System_String_"></a> HasActivityModifier\(nint, string\)

```csharp
public static bool HasActivityModifier(nint hero, string modifier)
```

#### Parameters

`hero` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`modifier` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

