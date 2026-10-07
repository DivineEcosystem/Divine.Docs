# <a id="Divine_Storage_JsonStorageSerializer_1"></a> Struct JsonStorageSerializer<T\>

Namespace: [Divine.Storage](Divine.Storage.md)  
Assembly: Divine.Common.dll  

```csharp
public readonly struct JsonStorageSerializer<T> : IUnion where T : JsonStorage<T>
```

#### Type Parameters

`T` 

#### Implements

[IUnion](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.iunion)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[EnumerableExtensions.ClearFlags<JsonStorageSerializer<T\>\>\(JsonStorageSerializer<T\>, JsonStorageSerializer<T\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[EnumerableExtensions.GetFlagDescription<JsonStorageSerializer<T\>\>\(JsonStorageSerializer<T\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<JsonStorageSerializer<T\>\>\(JsonStorageSerializer<T\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<JsonStorageSerializer<T\>\>\(JsonStorageSerializer<T\>, params JsonStorageSerializer<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<JsonStorageSerializer<T\>\>\(JsonStorageSerializer<T\>, JsonStorageSerializer<T\>, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Storage_JsonStorageSerializer_1__ctor_System_Text_Json_JsonSerializerOptions_"></a> JsonStorageSerializer\(JsonSerializerOptions\)

```csharp
public JsonStorageSerializer(JsonSerializerOptions value)
```

#### Parameters

`value` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)

### <a id="Divine_Storage_JsonStorageSerializer_1__ctor_System_Text_Json_Serialization_JsonSerializerContext_"></a> JsonStorageSerializer\(JsonSerializerContext\)

```csharp
public JsonStorageSerializer(JsonSerializerContext value)
```

#### Parameters

`value` [JsonSerializerContext](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.jsonserializercontext)

### <a id="Divine_Storage_JsonStorageSerializer_1__ctor_System_Text_Json_Serialization_Metadata_JsonTypeInfo__0__"></a> JsonStorageSerializer\(JsonTypeInfo<T\>\)

```csharp
public JsonStorageSerializer(JsonTypeInfo<T> value)
```

#### Parameters

`value` [JsonTypeInfo](https://learn.microsoft.com/dotnet/api/system.text.json.serialization.metadata.jsontypeinfo\-1)<T\>

## Properties

### <a id="Divine_Storage_JsonStorageSerializer_1_Value"></a> Value

```csharp
public object? Value { get; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)?

