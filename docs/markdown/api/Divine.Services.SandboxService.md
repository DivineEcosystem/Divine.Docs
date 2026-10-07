# <a id="Divine_Services_SandboxService"></a> Class SandboxService

Namespace: [Divine.Services](Divine.Services.md)  
Assembly: Divine.Common.dll  

```csharp
public static class SandboxService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SandboxService](Divine.Services.SandboxService.md)

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

### <a id="Divine_Services_SandboxService_GetRequiredValue__1_System_String_"></a> GetRequiredValue<T\>\(string\)

```csharp
public static T GetRequiredValue<T>(string key) where T : notnull
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Services_SandboxService_GetValue__1_System_String___0_"></a> GetValue<T\>\(string, T?\)

```csharp
public static T? GetValue<T>(string key, T? defaultValue = default) where T : notnull
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultValue` T?

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Services_SandboxService_RemoveValue_System_String_"></a> RemoveValue\(string\)

```csharp
public static bool RemoveValue(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Services_SandboxService_SendMessage_System_String_"></a> SendMessage\(string\)

```csharp
public static void SendMessage(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Services_SandboxService_SendMessage_System_String_System_Int64_"></a> SendMessage\(string, long\)

```csharp
public static void SendMessage(string name, long value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Services_SandboxService_SendMessage_System_String_System_String_"></a> SendMessage\(string, string\)

```csharp
public static void SendMessage(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Services_SandboxService_SendMessage_System_String_System_ReadOnlySpan_System_Byte__"></a> SendMessage\(string, ReadOnlySpan<byte\>\)

```csharp
public static void SendMessage(string name, ReadOnlySpan<byte> value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Services_SandboxService_SendMessage_System_String_System_Byte__System_Int32_"></a> SendMessage\(string, ref byte, int\)

```csharp
public static void SendMessage(string name, ref byte value, int count)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Services_SandboxService_SetValue__1_System_String___0_System_Boolean_"></a> SetValue<T\>\(string, T, bool\)

```csharp
public static void SetValue<T>(string key, T value, bool save = true) where T : notnull
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T

`save` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="Divine_Services_SandboxService_TryGetValue__1_System_String___0__"></a> TryGetValue<T\>\(string, out T?\)

```csharp
public static bool TryGetValue<T>(string key, out T? value) where T : notnull
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="Divine_Services_SandboxService_MessageReceived"></a> MessageReceived

```csharp
public static event SandboxService.MessageEventHandler? MessageReceived
```

#### Event Type

 [SandboxService](Divine.Services.SandboxService.md).[MessageEventHandler](Divine.Services.SandboxService.MessageEventHandler.md)?

