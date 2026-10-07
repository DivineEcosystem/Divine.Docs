# <a id="Divine_Service_DivineService"></a> Class DivineService

Namespace: [Divine.Service](Divine.Service.md)  
Assembly: Divine.dll  

```csharp
public static class DivineService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DivineService](Divine.Service.DivineService.md)

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

### <a id="Divine_Service_DivineService_AccessToken"></a> AccessToken

```csharp
public static string AccessToken { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Service_DivineService_DotaPlus"></a> DotaPlus

```csharp
public static bool DotaPlus { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Service_DivineService_GameDirectory"></a> GameDirectory

```csharp
public static string GameDirectory { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Service_DivineService_HasSubscription"></a> HasSubscription

```csharp
public static bool HasSubscription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Service_DivineService_InventoryChanger"></a> InventoryChanger

```csharp
public static bool InventoryChanger { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Service_DivineService_InventoryChangerLogging"></a> InventoryChangerLogging

```csharp
public static bool InventoryChangerLogging { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Service_DivineService_IsSpecialUser"></a> IsSpecialUser

```csharp
public static bool IsSpecialUser { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Service_DivineService_Plugins"></a> Plugins

```csharp
public static string Plugins { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Service_DivineService_UserName"></a> UserName

```csharp
public static string UserName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Service_DivineService_FullReload"></a> FullReload\(\)

```csharp
public static void FullReload()
```

### <a id="Divine_Service_DivineService_FullUnload"></a> FullUnload\(\)

```csharp
public static void FullUnload()
```

### <a id="Divine_Service_DivineService_GetSubscriptionExpirationTime"></a> GetSubscriptionExpirationTime\(\)

```csharp
public static DateTime GetSubscriptionExpirationTime()
```

#### Returns

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Divine_Service_DivineService_RaiseUnhandledException_System_Exception_"></a> RaiseUnhandledException\(Exception\)

```csharp
public static void RaiseUnhandledException(Exception e)
```

#### Parameters

`e` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

### <a id="Divine_Service_DivineService_Reload"></a> Reload\(\)

```csharp
public static void Reload()
```

### <a id="Divine_Service_DivineService_Unload"></a> Unload\(\)

```csharp
public static void Unload()
```

### <a id="Divine_Service_DivineService_UnhandledException"></a> UnhandledException

```csharp
public static event DivineService.UnhandledExceptionEventHandler? UnhandledException
```

#### Event Type

 [DivineService](Divine.Service.DivineService.md).[UnhandledExceptionEventHandler](Divine.Service.DivineService.UnhandledExceptionEventHandler.md)?

