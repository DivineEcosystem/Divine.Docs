# <a id="Divine_Menu_Items_IMenuContextExtensions"></a> Interface IMenuContextExtensions

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public interface IMenuContextExtensions : IMenuExtensions, IMenuExpanderExtensions, IMenuTextExtensions, IMenuItemExtensions
```

#### Implements

[IMenuExtensions](Divine.Menu.Items.IMenuExtensions.md), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Extension Methods

[MenuExtensions.Collapse<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<IMenuContextExtensions\>\(IMenuContextExtensions, params IMenuContextExtensions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<IMenuContextExtensions\>\(IMenuContextExtensions, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<IMenuContextExtensions\>\(IMenuContextExtensions, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetSwitcher<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetSwitcher\_\_1\_\_\_0\_), 
[MenuExtensions.Save<IMenuContextExtensions\>\(IMenuContextExtensions, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<IMenuContextExtensions\>\(IMenuContextExtensions, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<IMenuContextExtensions\>\(IMenuContextExtensions, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<IMenuContextExtensions\>\(IMenuContextExtensions, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<IMenuContextExtensions\>\(IMenuContextExtensions, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetPosition<IMenuContextExtensions\>\(IMenuContextExtensions, Vector2\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetPosition\_\_1\_\_\_0\_System\_Numerics\_Vector2\_), 
[MenuExtensions.SetSearchMark<IMenuContextExtensions\>\(IMenuContextExtensions, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<IMenuContextExtensions\>\(IMenuContextExtensions, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<IMenuContextExtensions\>\(IMenuContextExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Methods

### <a id="Divine_Menu_Items_IMenuContextExtensions_SetPosition_System_Numerics_Vector2_"></a> SetPosition\(Vector2\)

```csharp
IMenuContextExtensions SetPosition(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [IMenuContextExtensions](Divine.Menu.Items.IMenuContextExtensions.md)

