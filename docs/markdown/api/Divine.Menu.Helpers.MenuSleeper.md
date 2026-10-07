# <a id="Divine_Menu_Helpers_MenuSleeper"></a> Class MenuSleeper

Namespace: [Divine.Menu.Helpers](Divine.Menu.Helpers.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuSleeper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuSleeper](Divine.Menu.Helpers.MenuSleeper.md)

#### Inherited Members

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
[EnumerableExtensions.In<MenuSleeper\>\(MenuSleeper, params MenuSleeper\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Helpers_MenuSleeper__ctor"></a> MenuSleeper\(\)

```csharp
public MenuSleeper()
```

### <a id="Divine_Menu_Helpers_MenuSleeper__ctor_System_Single_"></a> MenuSleeper\(float\)

```csharp
public MenuSleeper(float sleepSeconds)
```

#### Parameters

`sleepSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Divine_Menu_Helpers_MenuSleeper_IsSleeping"></a> IsSleeping

```csharp
public bool IsSleeping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Helpers_MenuSleeper_RemainingSleepTime"></a> RemainingSleepTime

```csharp
public float RemainingSleepTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Helpers_MenuSleeper_ExtendSleep_System_Single_"></a> ExtendSleep\(float\)

```csharp
public void ExtendSleep(float seconds)
```

#### Parameters

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Helpers_MenuSleeper_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

### <a id="Divine_Menu_Helpers_MenuSleeper_Sleep_System_Single_"></a> Sleep\(float\)

```csharp
public void Sleep(float seconds)
```

#### Parameters

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Operators

### <a id="Divine_Menu_Helpers_MenuSleeper_op_Implicit_Divine_Menu_Helpers_MenuSleeper__System_Boolean"></a> implicit operator bool\(MenuSleeper\)

```csharp
public static implicit operator bool(MenuSleeper sleeper)
```

#### Parameters

`sleeper` [MenuSleeper](Divine.Menu.Helpers.MenuSleeper.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

