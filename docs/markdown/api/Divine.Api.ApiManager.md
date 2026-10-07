# <a id="Divine_Api_ApiManager"></a> Class ApiManager

Namespace: [Divine.Api](Divine.Api.md)  
Assembly: Divine.dll  

```csharp
public static class ApiManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ApiManager](Divine.Api.ApiManager.md)

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

### <a id="Divine_Api_ApiManager_DumpClientSchema"></a> DumpClientSchema\(\)

```csharp
public static string DumpClientSchema()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Api_ApiManager_DumpGlobalEnumSchema"></a> DumpGlobalEnumSchema\(\)

```csharp
public static string DumpGlobalEnumSchema()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Api_ApiManager_DumpGlobalSchema"></a> DumpGlobalSchema\(\)

```csharp
public static string DumpGlobalSchema()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Api_ApiManager_DumpLuaFunctions"></a> DumpLuaFunctions\(\)

```csharp
public static string DumpLuaFunctions()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Api_ApiManager_DumpPanoramaFunctions"></a> DumpPanoramaFunctions\(\)

```csharp
public static string DumpPanoramaFunctions()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Api_ApiManager_GetBrokenRegisteredApis"></a> GetBrokenRegisteredApis\(\)

```csharp
public static IEnumerable<string> GetBrokenRegisteredApis()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Api_ApiManager_RegisterClass_System_String_"></a> RegisterClass\(string\)

```csharp
public static ApiClass RegisterClass(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ApiClass](Divine.Api.ApiClass.md)

### <a id="Divine_Api_ApiManager_SetPanoramaCall_System_Int32___System_Int32__"></a> SetPanoramaCall\(out int\*, out int\)

```csharp
public static bool SetPanoramaCall(out int* panoramaCall, out int restoreData)
```

#### Parameters

`panoramaCall` [int](https://learn.microsoft.com/dotnet/api/system.int32)\*

`restoreData` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

