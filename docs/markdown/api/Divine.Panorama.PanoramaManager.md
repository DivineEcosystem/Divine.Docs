# <a id="Divine_Panorama_PanoramaManager"></a> Class PanoramaManager

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public static class PanoramaManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaManager](Divine.Panorama.PanoramaManager.md)

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

### <a id="Divine_Panorama_PanoramaManager_GetContextById_Divine_Panorama_PanoramaId_"></a> GetContextById\(PanoramaId\)

```csharp
public static PanoramaContext GetContextById(PanoramaId id)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

#### Returns

 [PanoramaContext](Divine.Panorama.PanoramaContext.md)

### <a id="Divine_Panorama_PanoramaManager_GetV8GlobalContext"></a> GetV8GlobalContext\(\)

```csharp
public static nint GetV8GlobalContext()
```

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Panorama_PanoramaManager_GetV8Isolate"></a> GetV8Isolate\(\)

```csharp
public static nint GetV8Isolate()
```

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Panorama_PanoramaManager_Invoke__1_Divine_Panorama_PanoramaId_System_String_System_Object___"></a> Invoke<T\>\(PanoramaId, string, params object?\[\]\)

```csharp
public static T? Invoke<T>(PanoramaId id, string api, params object?[] args)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`api` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaManager_Invoke_Divine_Panorama_PanoramaId_System_String_System_Object___"></a> Invoke\(PanoramaId, string, params object?\[\]\)

```csharp
public static PanoramaNode Invoke(PanoramaId id, string api, params object?[] args)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`api` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaManager_ReadStyleSheet_System_String_System_Boolean_"></a> ReadStyleSheet\(string, bool\)

```csharp
public static string ReadStyleSheet(string styleFile, bool format = false)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`format` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaManager_ReadStyleSheet_System_UInt16_"></a> ReadStyleSheet\(ushort\)

```csharp
public static ReadOnlySpan<byte> ReadStyleSheet(ushort styleFile)
```

#### Parameters

`styleFile` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Panorama_PanoramaManager_Register_Divine_Panorama_PanoramaId_System_String_System_String_"></a> Register\(PanoramaId, string, string\)

```csharp
public static void Register(PanoramaId id, string name, string functionSource)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`functionSource` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaManager_ReplaceStyleRule_System_String_System_UInt32_System_String_"></a> ReplaceStyleRule\(string, uint, string\)

```csharp
public static bool ReplaceStyleRule(string styleFile, uint location, string rule)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`location` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaManager_ReplaceStyleRule_System_ReadOnlySpan_System_Byte__System_UInt32_System_ReadOnlySpan_System_Byte__"></a> ReplaceStyleRule\(ReadOnlySpan<byte\>, uint, ReadOnlySpan<byte\>\)

```csharp
public static bool ReplaceStyleRule(ReadOnlySpan<byte> styleFile, uint location, ReadOnlySpan<byte> rule)
```

#### Parameters

`styleFile` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`location` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`rule` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaManager_ReplaceStyleRule_System_UInt16_System_UInt32_System_ReadOnlySpan_System_Byte__"></a> ReplaceStyleRule\(ushort, uint, ReadOnlySpan<byte\>\)

```csharp
public static bool ReplaceStyleRule(ushort styleFile, uint location, ReadOnlySpan<byte> rule)
```

#### Parameters

`styleFile` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

`location` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`rule` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaManager_RunScript__1_Divine_Panorama_PanoramaId_System_String_"></a> RunScript<T\>\(PanoramaId, string\)

```csharp
public static T? RunScript<T>(PanoramaId id, string script)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`script` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaManager_RunScript_Divine_Panorama_PanoramaId_System_String_"></a> RunScript\(PanoramaId, string\)

```csharp
public static PanoramaNode RunScript(PanoramaId id, string script)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`script` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaManager_Unregister_Divine_Panorama_PanoramaId_System_String_"></a> Unregister\(PanoramaId, string\)

```csharp
public static void Unregister(PanoramaId id, string name)
```

#### Parameters

`id` [PanoramaId](Divine.Panorama.PanoramaId.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaManager_RunScriptHandler"></a> RunScriptHandler

```csharp
public static event PanoramaManager.RunScriptEventHandler? RunScriptHandler
```

#### Event Type

 [PanoramaManager](Divine.Panorama.PanoramaManager.md).[RunScriptEventHandler](Divine.Panorama.PanoramaManager.RunScriptEventHandler.md)?

