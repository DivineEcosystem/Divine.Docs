# <a id="Divine_Service_Bootstrapper"></a> Class Bootstrapper

Namespace: [Divine.Service](Divine.Service.md)  
Assembly: Divine.dll  

```csharp
public abstract class Bootstrapper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bootstrapper](Divine.Service.Bootstrapper.md)

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Bootstrapper\>\(Bootstrapper, params Bootstrapper\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Methods

### <a id="Divine_Service_Bootstrapper_OnActivate"></a> OnActivate\(\)

```csharp
protected virtual void OnActivate()
```

### <a id="Divine_Service_Bootstrapper_OnActivateUnsafe"></a> OnActivateUnsafe\(\)

```csharp
protected virtual void OnActivateUnsafe()
```

### <a id="Divine_Service_Bootstrapper_OnDeactivate"></a> OnDeactivate\(\)

```csharp
protected virtual void OnDeactivate()
```

### <a id="Divine_Service_Bootstrapper_OnMainActivate"></a> OnMainActivate\(\)

```csharp
protected virtual void OnMainActivate()
```

### <a id="Divine_Service_Bootstrapper_OnMainActivateUnsafe"></a> OnMainActivateUnsafe\(\)

```csharp
protected virtual void OnMainActivateUnsafe()
```

### <a id="Divine_Service_Bootstrapper_OnMainDeactivate"></a> OnMainDeactivate\(\)

```csharp
protected virtual void OnMainDeactivate()
```

### <a id="Divine_Service_Bootstrapper_Activate"></a> Activate

```csharp
public static event Bootstrapper.ActivateEventHandler Activate
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[ActivateEventHandler](Divine.Service.Bootstrapper.ActivateEventHandler.md)

### <a id="Divine_Service_Bootstrapper_ActivateUnsafe"></a> ActivateUnsafe

```csharp
public static event Bootstrapper.ActivateUnsafeEventHandler ActivateUnsafe
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[ActivateUnsafeEventHandler](Divine.Service.Bootstrapper.ActivateUnsafeEventHandler.md)

### <a id="Divine_Service_Bootstrapper_Deactivate"></a> Deactivate

```csharp
public static event Bootstrapper.DeactivateEventHandler Deactivate
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[DeactivateEventHandler](Divine.Service.Bootstrapper.DeactivateEventHandler.md)

### <a id="Divine_Service_Bootstrapper_MainActivate"></a> MainActivate

```csharp
public static event Bootstrapper.MainActivateEventHandler MainActivate
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[MainActivateEventHandler](Divine.Service.Bootstrapper.MainActivateEventHandler.md)

### <a id="Divine_Service_Bootstrapper_MainActivateUnsafe"></a> MainActivateUnsafe

```csharp
public static event Bootstrapper.MainActivateUnsafeEventHandler MainActivateUnsafe
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[MainActivateUnsafeEventHandler](Divine.Service.Bootstrapper.MainActivateUnsafeEventHandler.md)

### <a id="Divine_Service_Bootstrapper_MainDeactivate"></a> MainDeactivate

```csharp
public static event Bootstrapper.MainDeactivateEventHandler MainDeactivate
```

#### Event Type

 [Bootstrapper](Divine.Service.Bootstrapper.md).[MainDeactivateEventHandler](Divine.Service.Bootstrapper.MainDeactivateEventHandler.md)

