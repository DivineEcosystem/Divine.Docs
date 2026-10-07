# <a id="Divine_Update_UpdateHandler"></a> Class UpdateHandler

Namespace: [Divine.Update](Divine.Update.md)  
Assembly: Divine.dll  

```csharp
public class UpdateHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateHandler](Divine.Update.UpdateHandler.md)

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
[EnumerableExtensions.In<UpdateHandler\>\(UpdateHandler, params UpdateHandler\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Update_UpdateHandler__ctor_System_Action_Divine_Update_InvokeHandler_System_Boolean_"></a> UpdateHandler\(Action, InvokeHandler, bool\)

```csharp
public UpdateHandler(Action callback, InvokeHandler executor, bool isEnabled = true)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

`executor` [InvokeHandler](Divine.Update.InvokeHandler.md)

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_UpdateHandler__ctor_System_String_System_Action_Divine_Update_InvokeHandler_System_Boolean_"></a> UpdateHandler\(string, Action, InvokeHandler, bool\)

```csharp
public UpdateHandler(string name, Action callback, InvokeHandler executor, bool isEnabled = true)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

`executor` [InvokeHandler](Divine.Update.InvokeHandler.md)

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Divine_Update_UpdateHandler_Callback"></a> Callback

```csharp
public Action Callback { get; }
```

#### Property Value

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateHandler_Executor"></a> Executor

```csharp
public InvokeHandler Executor { get; set; }
```

#### Property Value

 [InvokeHandler](Divine.Update.InvokeHandler.md)

### <a id="Divine_Update_UpdateHandler_IsEnabled"></a> IsEnabled

```csharp
public bool IsEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_UpdateHandler_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Update_UpdateHandler_Invoke"></a> Invoke\(\)

```csharp
public virtual bool Invoke()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_UpdateHandler_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

### <a id="Divine_Update_UpdateHandler_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

