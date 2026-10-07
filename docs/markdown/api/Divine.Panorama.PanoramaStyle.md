# <a id="Divine_Panorama_PanoramaStyle"></a> Class PanoramaStyle

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public sealed class PanoramaStyle : PanoramaNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaNode](Divine.Panorama.PanoramaNode.md) ← 
[PanoramaStyle](Divine.Panorama.PanoramaStyle.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[PanoramaNode.Kind](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Kind), 
[PanoramaNode.TypeName](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_TypeName), 
[PanoramaNode.ConstructorName](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ConstructorName), 
[PanoramaNode.IsPanel](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsPanel), 
[PanoramaNode.IsObject](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsObject), 
[PanoramaNode.IsArray](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsArray), 
[PanoramaNode.IsNull](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsNull), 
[PanoramaNode.Dispose\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Dispose), 
[PanoramaNode.GetValue<T\>\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetValue\_\_1), 
[PanoramaNode.GetValue<T\>\(string\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetValue\_\_1\_System\_String\_), 
[PanoramaNode.SetValue<T\>\(string, T\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_SetValue\_\_1\_System\_String\_\_\_0\_), 
[PanoramaNode.Get\(string\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Get\_System\_String\_), 
[PanoramaNode.GetMembers\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetMembers), 
[PanoramaNode.Invoke<T\>\(string, params object?\[\]\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Invoke\_\_1\_System\_String\_System\_Object\_\_\_), 
[PanoramaNode.Invoke\(string, params object?\[\]\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Invoke\_System\_String\_System\_Object\_\_\_), 
[PanoramaNode.ToJson\(bool, bool\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToJson\_System\_Boolean\_System\_Boolean\_), 
[PanoramaNode.ToJsonNode\(bool\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToJsonNode\_System\_Boolean\_), 
[PanoramaNode.ToString\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToString), 
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
[EnumerableExtensions.In<PanoramaStyle\>\(PanoramaStyle, params PanoramaStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Panorama_PanoramaStyle_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Panorama_PanoramaStyle_Properties"></a> Properties

```csharp
public static ReadOnlySpan<PanoramaStyleProperty> Properties { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[PanoramaStyleProperty](Divine.Panorama.PanoramaStyleProperty.md)\>

## Methods

### <a id="Divine_Panorama_PanoramaStyle_ClearValue_System_String_"></a> ClearValue\(string\)

```csharp
public void ClearValue(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyle_FormatRules_System_Boolean_"></a> FormatRules\(bool\)

```csharp
public string FormatRules(bool markOverridden = true)
```

#### Parameters

`markOverridden` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyle_Get_System_String_"></a> Get\(string\)

```csharp
public string? Get(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Panorama_PanoramaStyle_GetClasses"></a> GetClasses\(\)

```csharp
public string[] GetClasses()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_Panorama_PanoramaStyle_GetComputedProperties"></a> GetComputedProperties\(\)

```csharp
public IReadOnlyDictionary<string, string> GetComputedProperties()
```

#### Returns

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaStyle_GetInlineProperties"></a> GetInlineProperties\(\)

```csharp
public IReadOnlyDictionary<string, string> GetInlineProperties()
```

#### Returns

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaStyle_GetRules"></a> GetRules\(\)

```csharp
public IReadOnlyList<PanoramaStyleRule> GetRules()
```

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[PanoramaStyleRule](Divine.Panorama.PanoramaStyleRule.md)\>

### <a id="Divine_Panorama_PanoramaStyle_GetValue__1_System_String_"></a> GetValue<T\>\(string\)

```csharp
public T? GetValue<T>(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaStyle_ReadSheet_System_Int32_System_Boolean_"></a> ReadSheet\(int, bool\)

```csharp
public string ReadSheet(int index, bool format = false)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`format` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyle_ReadSheet_System_String_System_Boolean_"></a> ReadSheet\(string, bool\)

```csharp
public string ReadSheet(string styleFile, bool format = false)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`format` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyle_ReadSheet_System_UInt16_"></a> ReadSheet\(ushort\)

```csharp
public ReadOnlySpan<byte> ReadSheet(ushort styleFile)
```

#### Parameters

`styleFile` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Panorama_PanoramaStyle_ReplaceRule_System_Int32_System_UInt32_System_String_"></a> ReplaceRule\(int, uint, string\)

```csharp
public bool ReplaceRule(int index, uint location, string rule)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`location` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_ReplaceRule_System_String_System_UInt32_System_String_"></a> ReplaceRule\(string, uint, string\)

```csharp
public bool ReplaceRule(string styleFile, uint location, string rule)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`location` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_ReplaceRule_System_Int32_System_String_System_String_"></a> ReplaceRule\(int, string, string\)

```csharp
public bool ReplaceRule(int index, string selector, string rule)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_ReplaceRule_System_String_System_String_System_String_"></a> ReplaceRule\(string, string, string\)

```csharp
public bool ReplaceRule(string styleFile, string selector, string rule)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_ReplaceRule_System_String_System_Func_System_String_System_Boolean__System_String_System_String_"></a> ReplaceRule\(string, Func<string, bool\>, string, string\)

```csharp
public bool ReplaceRule(string styleFile, Func<string, bool> shouldReplace, string selector, string rule)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`shouldReplace` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

`selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rule` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_SetRuleProperty_System_Int32_System_String_System_String_System_String_"></a> SetRuleProperty\(int, string, string, string?\)

```csharp
public bool SetRuleProperty(int index, string selector, string property, string? value)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_SetRuleProperty_System_String_System_String_System_String_System_String_"></a> SetRuleProperty\(string, string, string, string?\)

```csharp
public bool SetRuleProperty(string styleFile, string selector, string property, string? value)
```

#### Parameters

`styleFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_SetValue__1_System_String___0_"></a> SetValue<T\>\(string, T\)

```csharp
public void SetValue<T>(string property, T value)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaStyle_TryGetComputedValue_System_String_System_String__"></a> TryGetComputedValue\(string, out string?\)

```csharp
public bool TryGetComputedValue(string property, out string? value)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyle_TryGetValue_System_String_System_String__"></a> TryGetValue\(string, out string?\)

```csharp
public bool TryGetValue(string property, out string? value)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

