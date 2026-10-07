# <a id="Divine_Storage_JsonStorageOptions_1"></a> Class JsonStorageOptions<T\>

Namespace: [Divine.Storage](Divine.Storage.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class JsonStorageOptions<T> where T : JsonStorage<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[JsonStorageOptions<T\>](Divine.Storage.JsonStorageOptions\-1.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<JsonStorageOptions<T\>\>\(JsonStorageOptions<T\>, params JsonStorageOptions<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Storage_JsonStorageOptions_1__ctor"></a> JsonStorageOptions\(\)

```csharp
public JsonStorageOptions()
```

## Properties

### <a id="Divine_Storage_JsonStorageOptions_1_AutoSave"></a> AutoSave

```csharp
public bool AutoSave { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Storage_JsonStorageOptions_1_DebounceSaveDelay"></a> DebounceSaveDelay

```csharp
public TimeSpan DebounceSaveDelay { get; set; }
```

#### Property Value

 [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan)

### <a id="Divine_Storage_JsonStorageOptions_1_DirectoryPath"></a> DirectoryPath

```csharp
public string? DirectoryPath { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Storage_JsonStorageOptions_1_Extension"></a> Extension

```csharp
public string Extension { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Storage_JsonStorageOptions_1_FileName"></a> FileName

```csharp
public string FileName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Storage_JsonStorageOptions_1_FilePath"></a> FilePath

```csharp
public string FilePath { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Storage_JsonStorageOptions_1_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Storage_JsonStorageOptions_1_Serializer"></a> Serializer

```csharp
public JsonStorageSerializer<T> Serializer { get; set; }
```

#### Property Value

 [JsonStorageSerializer](Divine.Storage.JsonStorageSerializer\-1.md)<T\>

### <a id="Divine_Storage_JsonStorageOptions_1_StartupMode"></a> StartupMode

```csharp
public JsonStorageStartupMode StartupMode { get; set; }
```

#### Property Value

 [JsonStorageStartupMode](Divine.Storage.JsonStorageStartupMode.md)

## Methods

### <a id="Divine_Storage_JsonStorageOptions_1_UseJsonSerializerContext_System_Text_Json_Serialization_JsonSerializerContext_"></a> UseJsonSerializerContext\(JsonSerializerContext\)

```csharp
public JsonStorageOptions<T> UseJsonSerializerContext(JsonSerializerContext context)
```

#### Parameters

`context` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

#### Returns

 [JsonStorageOptions](Divine.Storage.JsonStorageOptions\-1.md)<T\>

### <a id="Divine_Storage_JsonStorageOptions_1_UseJsonSerializerOptions_System_Text_Json_JsonSerializerOptions_"></a> UseJsonSerializerOptions\(JsonSerializerOptions\)

```csharp
[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
public JsonStorageOptions<T> UseJsonSerializerOptions(JsonSerializerOptions options)
```

#### Parameters

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)

#### Returns

 [JsonStorageOptions](Divine.Storage.JsonStorageOptions\-1.md)<T\>

### <a id="Divine_Storage_JsonStorageOptions_1_UseJsonTypeInfo_System_Text_Json_Serialization_Metadata_JsonTypeInfo__0__"></a> UseJsonTypeInfo\(JsonTypeInfo<T\>\)

```csharp
public JsonStorageOptions<T> UseJsonTypeInfo(JsonTypeInfo<T> jsonTypeInfo)
```

#### Parameters

`jsonTypeInfo` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<T\>

#### Returns

 [JsonStorageOptions](Divine.Storage.JsonStorageOptions\-1.md)<T\>

