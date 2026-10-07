# <a id="Divine_Menu_Objects_RootObject"></a> Class RootObject

Namespace: [Divine.Menu.Objects](Divine.Menu.Objects.md)  
Assembly: Divine.dll  

```csharp
public sealed class RootObject : MenuObject
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuObject](Divine.Menu.Objects.MenuObject.md) ← 
[RootObject](Divine.Menu.Objects.RootObject.md)

#### Inherited Members

[MenuObject.this\[string\]](Divine.Menu.Objects.MenuObject.md\#Divine\_Menu\_Objects\_MenuObject\_Item\_System\_String\_), 
[MenuObject.Name](Divine.Menu.Objects.MenuObject.md\#Divine\_Menu\_Objects\_MenuObject\_Name), 
[MenuObject.Base](Divine.Menu.Objects.MenuObject.md\#Divine\_Menu\_Objects\_MenuObject\_Base), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<RootObject\>\(RootObject, params RootObject\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Objects_RootObject_Context"></a> Context

```csharp
public MenuContext Context { get; }
```

#### Property Value

 [MenuContext](Divine.Menu.Items.MenuContext.md)

### <a id="Divine_Menu_Objects_RootObject_DelaySaveTime"></a> DelaySaveTime

```csharp
public float DelaySaveTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Objects_RootObject_IsContext"></a> IsContext

```csharp
public bool IsContext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Objects_RootObject_IsRequiresSave"></a> IsRequiresSave

```csharp
public bool IsRequiresSave { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Menu_Objects_RootObject_Load"></a> Load\(\)

```csharp
public void Load()
```

### <a id="Divine_Menu_Objects_RootObject_Save_Divine_Menu_Components_MenuSaveMode_"></a> Save\(MenuSaveMode\)

```csharp
public void Save(MenuSaveMode saveMode = MenuSaveMode.Force)
```

#### Parameters

`saveMode` [MenuSaveMode](Divine.Menu.Components.MenuSaveMode.md)

