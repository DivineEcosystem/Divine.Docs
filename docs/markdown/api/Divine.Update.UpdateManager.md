# <a id="Divine_Update_UpdateManager"></a> Class UpdateManager

Namespace: [Divine.Update](Divine.Update.md)  
Assembly: Divine.dll  

```csharp
public static class UpdateManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateManager](Divine.Update.UpdateManager.md)

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

### <a id="Divine_Update_UpdateManager_SynchronizationContext"></a> SynchronizationContext

```csharp
public static UpdateSynchronizationContext SynchronizationContext { get; }
```

#### Property Value

 [UpdateSynchronizationContext](Divine.Update.UpdateSynchronizationContext.md)

### <a id="Divine_Update_UpdateManager_TaskFactory"></a> TaskFactory

```csharp
public static TaskFactory TaskFactory { get; }
```

#### Property Value

 [TaskFactory](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskfactory)

### <a id="Divine_Update_UpdateManager_Thread"></a> Thread

```csharp
public static Thread Thread { get; }
```

#### Property Value

 [Thread](https://learn.microsoft.com/dotnet/api/system.threading.thread)

## Methods

### <a id="Divine_Update_UpdateManager_BeginInvoke_System_Action_"></a> BeginInvoke\(Action\)

```csharp
public static void BeginInvoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_BeginInvoke_System_Int32_System_Action_"></a> BeginInvoke\(int, Action\)

```csharp
public static void BeginInvoke(int timeout, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_CreateGameUpdate_System_Action_"></a> CreateGameUpdate\(Action\)

```csharp
public static UpdateHandler CreateGameUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateGameUpdate_System_Int32_System_Action_"></a> CreateGameUpdate\(int, Action\)

```csharp
public static UpdateHandler CreateGameUpdate(int timeout, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateGameUpdate_System_Int32_System_Boolean_System_Action_"></a> CreateGameUpdate\(int, bool, Action\)

```csharp
public static UpdateHandler CreateGameUpdate(int timeout, bool isEnabled, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateIngameUpdate_System_Action_"></a> CreateIngameUpdate\(Action\)

```csharp
public static UpdateHandler CreateIngameUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateIngameUpdate_System_Int32_System_Action_"></a> CreateIngameUpdate\(int, Action\)

```csharp
public static UpdateHandler CreateIngameUpdate(int timeout, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateIngameUpdate_System_Int32_System_Boolean_System_Action_"></a> CreateIngameUpdate\(int, bool, Action\)

```csharp
public static UpdateHandler CreateIngameUpdate(int timeout, bool isEnabled, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateUpdate_System_Action_"></a> CreateUpdate\(Action\)

```csharp
public static UpdateHandler CreateUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateUpdate_System_Int32_System_Action_"></a> CreateUpdate\(int, Action\)

```csharp
public static UpdateHandler CreateUpdate(int timeout, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_CreateUpdate_System_Int32_System_Boolean_System_Action_"></a> CreateUpdate\(int, bool, Action\)

```csharp
public static UpdateHandler CreateUpdate(int timeout, bool isEnabled, Action callback)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_DestroyGameUpdate_System_Action_"></a> DestroyGameUpdate\(Action\)

```csharp
public static void DestroyGameUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_DestroyGameUpdate_Divine_Update_UpdateHandler_"></a> DestroyGameUpdate\(UpdateHandler\)

```csharp
public static void DestroyGameUpdate(UpdateHandler handler)
```

#### Parameters

`handler` [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_DestroyIngameUpdate_System_Action_"></a> DestroyIngameUpdate\(Action\)

```csharp
public static void DestroyIngameUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_DestroyIngameUpdate_Divine_Update_UpdateHandler_"></a> DestroyIngameUpdate\(UpdateHandler\)

```csharp
public static void DestroyIngameUpdate(UpdateHandler handler)
```

#### Parameters

`handler` [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_DestroyUpdate_System_Action_"></a> DestroyUpdate\(Action\)

```csharp
public static void DestroyUpdate(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_DestroyUpdate_Divine_Update_UpdateHandler_"></a> DestroyUpdate\(UpdateHandler\)

```csharp
public static void DestroyUpdate(UpdateHandler handler)
```

#### Parameters

`handler` [UpdateHandler](Divine.Update.UpdateHandler.md)

### <a id="Divine_Update_UpdateManager_Invoke_System_Action_"></a> Invoke\(Action\)

```csharp
public static void Invoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Update_UpdateManager_Invoke_System_Action_System_Threading_CancellationToken_"></a> Invoke\(Action, CancellationToken\)

```csharp
public static void Invoke(Action callback, CancellationToken cancellationToken)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

### <a id="Divine_Update_UpdateManager_BeginUpdate"></a> BeginUpdate

```csharp
public static event UpdateManager.UpdateEventHandler? BeginUpdate
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[UpdateEventHandler](Divine.Update.UpdateManager.UpdateEventHandler.md)?

### <a id="Divine_Update_UpdateManager_EndUpdate"></a> EndUpdate

```csharp
public static event UpdateManager.UpdateEventHandler? EndUpdate
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[UpdateEventHandler](Divine.Update.UpdateManager.UpdateEventHandler.md)?

### <a id="Divine_Update_UpdateManager_GameUpdate"></a> GameUpdate

```csharp
public static event UpdateManager.GameUpdateEventHandler? GameUpdate
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[GameUpdateEventHandler](Divine.Update.UpdateManager.GameUpdateEventHandler.md)?

### <a id="Divine_Update_UpdateManager_IngameUpdate"></a> IngameUpdate

```csharp
public static event UpdateManager.IngameUpdateEventHandler? IngameUpdate
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[IngameUpdateEventHandler](Divine.Update.UpdateManager.IngameUpdateEventHandler.md)?

### <a id="Divine_Update_UpdateManager_Update"></a> Update

```csharp
public static event UpdateManager.UpdateEventHandler? Update
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[UpdateEventHandler](Divine.Update.UpdateManager.UpdateEventHandler.md)?

### <a id="Divine_Update_UpdateManager_UpdateStage"></a> UpdateStage

```csharp
public static event UpdateManager.UpdateStageEventHandler? UpdateStage
```

#### Event Type

 [UpdateManager](Divine.Update.UpdateManager.md).[UpdateStageEventHandler](Divine.Update.UpdateManager.UpdateStageEventHandler.md)?

