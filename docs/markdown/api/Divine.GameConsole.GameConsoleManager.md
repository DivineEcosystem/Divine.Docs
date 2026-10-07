# <a id="Divine_GameConsole_GameConsoleManager"></a> Class GameConsoleManager

Namespace: [Divine.GameConsole](Divine.GameConsole.md)  
Assembly: Divine.dll  

```csharp
public static class GameConsoleManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameConsoleManager](Divine.GameConsole.GameConsoleManager.md)

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

## Methods

### <a id="Divine_GameConsole_GameConsoleManager_ExecuteCommand_System_String_"></a> ExecuteCommand\(string\)

```csharp
public static void ExecuteCommand(string command)
```

#### Parameters

`command` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_GameConsole_GameConsoleManager_GetBoolean_System_String_"></a> GetBoolean\(string\)

```csharp
public static bool GetBoolean(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_GameConsole_GameConsoleManager_GetInt32_System_String_"></a> GetInt32\(string\)

```csharp
public static int GetInt32(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_GameConsole_GameConsoleManager_GetSingle_System_String_"></a> GetSingle\(string\)

```csharp
public static float GetSingle(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_GameConsole_GameConsoleManager_GetString_System_String_"></a> GetString\(string\)

```csharp
public static string GetString(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_GameConsole_GameConsoleManager_SetValue_System_String_System_String_"></a> SetValue\(string, string\)

```csharp
public static void SetValue(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_GameConsole_GameConsoleManager_SetValue_System_String_System_Boolean_"></a> SetValue\(string, bool\)

```csharp
public static void SetValue(string name, bool value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_GameConsole_GameConsoleManager_SetValue_System_String_System_Single_"></a> SetValue\(string, float\)

```csharp
public static void SetValue(string name, float value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_GameConsole_GameConsoleManager_SetValue_System_String_System_Int32_"></a> SetValue\(string, int\)

```csharp
public static void SetValue(string name, int value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

