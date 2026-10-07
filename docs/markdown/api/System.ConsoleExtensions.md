# <a id="System_ConsoleExtensions"></a> Class ConsoleExtensions

Namespace: [System](System.md)  
Assembly: Divine.Common.dll  

```csharp
public static class ConsoleExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConsoleExtensions](System.ConsoleExtensions.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="System_ConsoleExtensions_Attach"></a> Attach\(\)

```csharp
public static bool Attach()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_Detach"></a> Detach\(\)

```csharp
public static bool Detach()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_get_ErrorWriter"></a> get\_ErrorWriter\(\)

```csharp
public static ConsoleTextWriter get_ErrorWriter()
```

#### Returns

 [ConsoleTextWriter](Divine.ConsoleImpl.ConsoleTextWriter.md)

### <a id="System_ConsoleExtensions_get_IsAttached"></a> get\_IsAttached\(\)

```csharp
public static bool get_IsAttached()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_get_IsVisible"></a> get\_IsVisible\(\)

```csharp
public static bool get_IsVisible()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_get_OutWriter"></a> get\_OutWriter\(\)

```csharp
public static ConsoleTextWriter get_OutWriter()
```

#### Returns

 [ConsoleTextWriter](Divine.ConsoleImpl.ConsoleTextWriter.md)

### <a id="System_ConsoleExtensions_Hide"></a> Hide\(\)

```csharp
public static bool Hide()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_Initialize_System_Boolean_"></a> Initialize\(bool\)

```csharp
public static void Initialize(bool forceAttach = false)
```

#### Parameters

`forceAttach` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_SetAttached_System_Boolean_"></a> SetAttached\(bool\)

```csharp
public static void SetAttached(bool attached)
```

#### Parameters

`attached` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_Show"></a> Show\(\)

```csharp
public static bool Show()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_ConsoleExtensions_Uninitialize"></a> Uninitialize\(\)

```csharp
public static void Uninitialize()
```

