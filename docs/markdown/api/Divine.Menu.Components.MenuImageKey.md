# <a id="Divine_Menu_Components_MenuImageKey"></a> Struct MenuImageKey

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly struct MenuImageKey
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<MenuImageKey\>\(MenuImageKey, MenuImageKey\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<MenuImageKey\>\(MenuImageKey\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<MenuImageKey\>\(MenuImageKey\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuImageKey\>\(MenuImageKey, params MenuImageKey\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<MenuImageKey\>\(MenuImageKey, MenuImageKey, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Menu_Components_MenuImageKey__ctor_System_String_System_String_Divine_Renderer_ImageType_"></a> MenuImageKey\(string, string, ImageType\)

```csharp
[SetsRequiredMembers]
public MenuImageKey(string key, string path, ImageType type)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

### <a id="Divine_Menu_Components_MenuImageKey__ctor_System_String_"></a> MenuImageKey\(string\)

```csharp
[SetsRequiredMembers]
public MenuImageKey(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuImageKey__ctor_System_String_System_String_"></a> MenuImageKey\(string, string\)

```csharp
[SetsRequiredMembers]
public MenuImageKey(string key, string path)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuImageKey__ctor_System_String_Divine_Renderer_ImageType_"></a> MenuImageKey\(string, ImageType\)

```csharp
[SetsRequiredMembers]
public MenuImageKey(string key, ImageType type)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

## Properties

### <a id="Divine_Menu_Components_MenuImageKey_Key"></a> Key

```csharp
public required string Key { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuImageKey_Path"></a> Path

```csharp
public required string Path { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuImageKey_Type"></a> Type

```csharp
public ImageType Type { get; }
```

#### Property Value

 [ImageType](Divine.Renderer.ImageType.md)

## Operators

### <a id="Divine_Menu_Components_MenuImageKey_op_Implicit_System_String__Divine_Menu_Components_MenuImageKey"></a> implicit operator MenuImageKey\(string\)

```csharp
public static implicit operator MenuImageKey(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuImageKey_op_Implicit_System_ValueTuple_System_String_System_String___Divine_Menu_Components_MenuImageKey"></a> implicit operator MenuImageKey\(\(string Key, string Path\)\)

```csharp
public static implicit operator MenuImageKey((string Key, string Path) imageKey)
```

#### Parameters

`imageKey` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.key), [string](https://learn.microsoft.com/dotnet/api/system.string) [Path](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.path)\)

#### Returns

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuImageKey_op_Implicit_System_ValueTuple_System_String_Divine_Renderer_ImageType___Divine_Menu_Components_MenuImageKey"></a> implicit operator MenuImageKey\(\(string Key, ImageType Type\)\)

```csharp
public static implicit operator MenuImageKey((string Key, ImageType Type) imageKey)
```

#### Parameters

`imageKey` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,divine.renderer.imagetype\-.key), [ImageType](Divine.Renderer.ImageType.md) [Type](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,divine.renderer.imagetype\-.type)\)

#### Returns

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuImageKey_op_Implicit_System_ValueTuple_System_String_System_String_Divine_Renderer_ImageType___Divine_Menu_Components_MenuImageKey"></a> implicit operator MenuImageKey\(\(string Key, string Path, ImageType Type\)\)

```csharp
public static implicit operator MenuImageKey((string Key, string Path, ImageType Type) imageKey)
```

#### Parameters

`imageKey` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string,divine.renderer.imagetype\-.key), [string](https://learn.microsoft.com/dotnet/api/system.string) [Path](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string,divine.renderer.imagetype\-.path), [ImageType](Divine.Renderer.ImageType.md) [Type](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string,divine.renderer.imagetype\-.type)\)

#### Returns

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuImageKey_op_Implicit_Divine_Menu_Components_MenuImageKey__System_String"></a> implicit operator string\(MenuImageKey\)

```csharp
public static implicit operator string(MenuImageKey imageKey)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

