# <a id="Divine_Input_InputManager"></a> Class InputManager

Namespace: [Divine.Input](Divine.Input.md)  
Assembly: Divine.dll  

```csharp
public static class InputManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputManager](Divine.Input.InputManager.md)

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

### <a id="Divine_Input_InputManager_MousePosition"></a> MousePosition

```csharp
public static Vector2 MousePosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="Divine_Input_InputManager_IsKeyDown_Divine_Input_Key_"></a> IsKeyDown\(Key\)

```csharp
public static bool IsKeyDown(Key key)
```

#### Parameters

`key` [Key](Divine.Input.Key.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Input_InputManager_IsKeyDown_Divine_Input_VirtualKey_"></a> IsKeyDown\(VirtualKey\)

```csharp
public static bool IsKeyDown(VirtualKey virtualKey)
```

#### Parameters

`virtualKey` [VirtualKey](Divine.Input.VirtualKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Input_InputManager_IsKeyDown_System_Int32_"></a> IsKeyDown\(int\)

```csharp
public static bool IsKeyDown(int virtualKey)
```

#### Parameters

`virtualKey` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Input_InputManager_KeyFromVirtualKey_System_Int32_"></a> KeyFromVirtualKey\(int\)

```csharp
public static Key KeyFromVirtualKey(int virtualKey)
```

#### Parameters

`virtualKey` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Key](Divine.Input.Key.md)

### <a id="Divine_Input_InputManager_KeyFromVirtualKey_Divine_Input_VirtualKey_"></a> KeyFromVirtualKey\(VirtualKey\)

```csharp
public static Key KeyFromVirtualKey(VirtualKey virtualKey)
```

#### Parameters

`virtualKey` [VirtualKey](Divine.Input.VirtualKey.md)

#### Returns

 [Key](Divine.Input.Key.md)

### <a id="Divine_Input_InputManager_VirtualKeyFromKey_Divine_Input_Key_"></a> VirtualKeyFromKey\(Key\)

```csharp
public static VirtualKey VirtualKeyFromKey(Key key)
```

#### Parameters

`key` [Key](Divine.Input.Key.md)

#### Returns

 [VirtualKey](Divine.Input.VirtualKey.md)

### <a id="Divine_Input_InputManager_VirtualKeyValueFromKey_Divine_Input_Key_"></a> VirtualKeyValueFromKey\(Key\)

```csharp
public static int VirtualKeyValueFromKey(Key key)
```

#### Parameters

`key` [Key](Divine.Input.Key.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Input_InputManager_KeyDown"></a> KeyDown

```csharp
public static event InputManager.KeyEventHandler KeyDown
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[KeyEventHandler](Divine.Input.InputManager.KeyEventHandler.md)

### <a id="Divine_Input_InputManager_KeyUp"></a> KeyUp

```csharp
public static event InputManager.KeyEventHandler KeyUp
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[KeyEventHandler](Divine.Input.InputManager.KeyEventHandler.md)

### <a id="Divine_Input_InputManager_MouseKeyDown"></a> MouseKeyDown

```csharp
public static event InputManager.MouseEventHandler MouseKeyDown
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[MouseEventHandler](Divine.Input.InputManager.MouseEventHandler.md)

### <a id="Divine_Input_InputManager_MouseKeyUp"></a> MouseKeyUp

```csharp
public static event InputManager.MouseEventHandler MouseKeyUp
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[MouseEventHandler](Divine.Input.InputManager.MouseEventHandler.md)

### <a id="Divine_Input_InputManager_MouseMove"></a> MouseMove

```csharp
public static event InputManager.MouseMoveEventHandler MouseMove
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[MouseMoveEventHandler](Divine.Input.InputManager.MouseMoveEventHandler.md)

### <a id="Divine_Input_InputManager_MouseWheel"></a> MouseWheel

```csharp
public static event InputManager.MouseWheelEventHandler MouseWheel
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[MouseWheelEventHandler](Divine.Input.InputManager.MouseWheelEventHandler.md)

### <a id="Divine_Input_InputManager_WindowProc"></a> WindowProc

```csharp
public static event InputManager.WindowProcEventHandler WindowProc
```

#### Event Type

 [InputManager](Divine.Input.InputManager.md).[WindowProcEventHandler](Divine.Input.InputManager.WindowProcEventHandler.md)

