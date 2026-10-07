# <a id="Divine_Source2_KeyValues"></a> Class KeyValues

Namespace: [Divine.Source2](Divine.Source2.md)  
Assembly: Divine.dll  

```csharp
public sealed class KeyValues : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[KeyValues](Divine.Source2.KeyValues.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<KeyValues\>\(KeyValues, params KeyValues\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Source2_KeyValues_Children"></a> Children

```csharp
public IEnumerable<KeyValues> Children { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[KeyValues](Divine.Source2.KeyValues.md)\>

### <a id="Divine_Source2_KeyValues_IsEmpty"></a> IsEmpty

```csharp
public bool IsEmpty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Source2_KeyValues_IsOwned"></a> IsOwned

```csharp
public bool IsOwned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Source2_KeyValues_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Source2_KeyValues_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Source2_KeyValues_Item_System_Int32_"></a> this\[int\]

```csharp
public KeyValues this[int index] { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)

### <a id="Divine_Source2_KeyValues_Item_System_String_"></a> this\[string\]

```csharp
public KeyValues? this[string name] { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_Item_System_ReadOnlySpan_System_Byte__"></a> this\[ReadOnlySpan<byte\>\]

```csharp
public KeyValues? this[ReadOnlySpan<byte> name] { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_ValueType"></a> ValueType

```csharp
public KeyValuesType ValueType { get; }
```

#### Property Value

 [KeyValuesType](Divine.Source2.KeyValuesType.md)

## Methods

### <a id="Divine_Source2_KeyValues_ContainsChild_System_String_"></a> ContainsChild\(string\)

```csharp
public bool ContainsChild(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Source2_KeyValues_Create_System_String_"></a> Create\(string\)

```csharp
public static KeyValues? Create(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_Create_System_ReadOnlySpan_System_Byte__"></a> Create\(ReadOnlySpan<byte\>\)

```csharp
public static KeyValues? Create(ReadOnlySpan<byte> keyName)
```

#### Parameters

`keyName` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_CreateFromFile_System_String_"></a> CreateFromFile\(string\)

```csharp
public static KeyValues? CreateFromFile(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_CreateFromGameFile_System_String_"></a> CreateFromGameFile\(string\)

```csharp
public static KeyValues? CreateFromGameFile(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_CreateFromGameFile_System_ReadOnlySpan_System_Byte__"></a> CreateFromGameFile\(ReadOnlySpan<byte\>\)

```csharp
public static KeyValues? CreateFromGameFile(ReadOnlySpan<byte> fileName)
```

#### Parameters

`fileName` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_CreateFromString_System_String_"></a> CreateFromString\(string\)

```csharp
public static KeyValues? CreateFromString(string str)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_CreateFromString_System_ReadOnlySpan_System_Byte__"></a> CreateFromString\(ReadOnlySpan<byte\>\)

```csharp
public static KeyValues? CreateFromString(ReadOnlySpan<byte> str)
```

#### Parameters

`str` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Source2_KeyValues_Destroy"></a> Destroy\(\)

```csharp
public void Destroy()
```

### <a id="Divine_Source2_KeyValues_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Source2_KeyValues_Finalize"></a> \~KeyValues\(\)

```csharp
protected ~KeyValues()
```

### <a id="Divine_Source2_KeyValues_GetBoolean"></a> GetBoolean\(\)

```csharp
public bool GetBoolean()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Source2_KeyValues_GetColor"></a> GetColor\(\)

```csharp
public Color GetColor()
```

#### Returns

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Source2_KeyValues_GetInt32"></a> GetInt32\(\)

```csharp
public int GetInt32()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Source2_KeyValues_GetSingle"></a> GetSingle\(\)

```csharp
public float GetSingle()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Source2_KeyValues_GetString"></a> GetString\(\)

```csharp
public string GetString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Source2_KeyValues_GetUInt64"></a> GetUInt64\(\)

```csharp
public ulong GetUInt64()
```

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Source2_KeyValues_GetUtf8String"></a> GetUtf8String\(\)

```csharp
public ReadOnlySpan<byte> GetUtf8String()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Source2_KeyValues_Merge_Divine_Source2_KeyValues_"></a> Merge\(KeyValues\)

```csharp
public void Merge(KeyValues keyValue)
```

#### Parameters

`keyValue` [KeyValues](Divine.Source2.KeyValues.md)

### <a id="Divine_Source2_KeyValues_ToJson_System_Text_Json_JsonSerializerOptions_"></a> ToJson\(JsonSerializerOptions?\)

```csharp
public string ToJson(JsonSerializerOptions? options = null)
```

#### Parameters

`options` [JsonSerializerOptions](https://learn.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions)?

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Source2_KeyValues_ToJsonNode"></a> ToJsonNode\(\)

```csharp
public JsonNode ToJsonNode()
```

#### Returns

 [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)

### <a id="Divine_Source2_KeyValues_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="Divine_Source2_KeyValues_TryGetChild_System_String_Divine_Source2_KeyValues__"></a> TryGetChild\(string, out KeyValues?\)

```csharp
public bool TryGetChild(string name, out KeyValues? keyValue)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`keyValue` [KeyValues](Divine.Source2.KeyValues.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

