# <a id="System_Text_Json_JsonSerializerExtensions"></a> Class JsonSerializerExtensions

Namespace: [System.Text.Json](System.Text.Json.md)  
Assembly: Divine.Common.dll  

```csharp
public static class JsonSerializerExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[JsonSerializerExtensions](System.Text.Json.JsonSerializerExtensions.md)

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

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_IO_Stream___0_System_Text_Json_Serialization_Metadata_JsonTypeInfo___0__"></a> Populate<TValue\>\(Stream, TValue, JsonTypeInfo<TValue\>\)

```csharp
public static void Populate<TValue>(Stream utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo) where TValue : class
```

#### Parameters

`utf8Json` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`value` TValue

`jsonTypeInfo` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<TValue\>

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_String___0_System_Text_Json_Serialization_Metadata_JsonTypeInfo___0__"></a> Populate<TValue\>\(string, TValue, JsonTypeInfo<TValue\>\)

```csharp
public static void Populate<TValue>(string json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo) where TValue : class
```

#### Parameters

`json` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` TValue

`jsonTypeInfo` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<TValue\>

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_ReadOnlySpan_System_Byte____0_System_Text_Json_Serialization_Metadata_JsonTypeInfo___0__"></a> Populate<TValue\>\(ReadOnlySpan<byte\>, TValue, JsonTypeInfo<TValue\>\)

```csharp
public static void Populate<TValue>(ReadOnlySpan<byte> utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo) where TValue : class
```

#### Parameters

`utf8Json` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`value` TValue

`jsonTypeInfo` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<TValue\>

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_Text_Json_Nodes_JsonNode___0_System_Text_Json_Serialization_Metadata_JsonTypeInfo___0__"></a> Populate<TValue\>\(JsonNode, TValue, JsonTypeInfo<TValue\>\)

```csharp
public static void Populate<TValue>(JsonNode node, TValue value, JsonTypeInfo<TValue> jsonTypeInfo) where TValue : class
```

#### Parameters

`node` [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)

`value` TValue

`jsonTypeInfo` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<TValue\>

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_IO_Stream___0_System_Text_Json_Serialization_JsonSerializerContext_"></a> Populate<TValue\>\(Stream, TValue, JsonSerializerContext\)

```csharp
public static void Populate<TValue>(Stream utf8Json, TValue value, JsonSerializerContext context) where TValue : class
```

#### Parameters

`utf8Json` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`value` TValue

`context` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_String___0_System_Text_Json_Serialization_JsonSerializerContext_"></a> Populate<TValue\>\(string, TValue, JsonSerializerContext\)

```csharp
public static void Populate<TValue>(string json, TValue value, JsonSerializerContext context) where TValue : class
```

#### Parameters

`json` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` TValue

`context` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_ReadOnlySpan_System_Byte____0_System_Text_Json_Serialization_JsonSerializerContext_"></a> Populate<TValue\>\(ReadOnlySpan<byte\>, TValue, JsonSerializerContext\)

```csharp
public static void Populate<TValue>(ReadOnlySpan<byte> utf8Json, TValue value, JsonSerializerContext context) where TValue : class
```

#### Parameters

`utf8Json` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`value` TValue

`context` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_Text_Json_Nodes_JsonNode___0_System_Text_Json_Serialization_JsonSerializerContext_"></a> Populate<TValue\>\(JsonNode, TValue, JsonSerializerContext\)

```csharp
public static void Populate<TValue>(JsonNode node, TValue value, JsonSerializerContext context) where TValue : class
```

#### Parameters

`node` [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)

`value` TValue

`context` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_IO_Stream___0_System_Text_Json_JsonSerializerOptions_"></a> Populate<TValue\>\(Stream, TValue, JsonSerializerOptions?\)

```csharp
[RequiresDynamicCode("JSON serialization and deserialization might require runtime code generation. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
public static void Populate<TValue>(Stream utf8Json, TValue value, JsonSerializerOptions? options = null) where TValue : class
```

#### Parameters

`utf8Json` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`value` TValue

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)?

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_String___0_System_Text_Json_JsonSerializerOptions_"></a> Populate<TValue\>\(string, TValue, JsonSerializerOptions?\)

```csharp
[RequiresDynamicCode("JSON serialization and deserialization might require runtime code generation. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
public static void Populate<TValue>(string json, TValue value, JsonSerializerOptions? options = null) where TValue : class
```

#### Parameters

`json` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` TValue

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)?

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_ReadOnlySpan_System_Byte____0_System_Text_Json_JsonSerializerOptions_"></a> Populate<TValue\>\(ReadOnlySpan<byte\>, TValue, JsonSerializerOptions?\)

```csharp
[RequiresDynamicCode("JSON serialization and deserialization might require runtime code generation. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
public static void Populate<TValue>(ReadOnlySpan<byte> utf8Json, TValue value, JsonSerializerOptions? options = null) where TValue : class
```

#### Parameters

`utf8Json` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`value` TValue

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)?

#### Type Parameters

`TValue` 

### <a id="System_Text_Json_JsonSerializerExtensions_Populate__1_System_Text_Json_Nodes_JsonNode___0_System_Text_Json_JsonSerializerOptions_"></a> Populate<TValue\>\(JsonNode, TValue, JsonSerializerOptions?\)

```csharp
[RequiresDynamicCode("JSON serialization and deserialization might require runtime code generation. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes JsonTypeInfo<TValue> or JsonSerializerContext.")]
public static void Populate<TValue>(JsonNode node, TValue value, JsonSerializerOptions? options = null) where TValue : class
```

#### Parameters

`node` [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)

`value` TValue

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)?

#### Type Parameters

`TValue` 

