# <a id="Divine_Panorama_PanoramaNode"></a> Class PanoramaNode

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public class PanoramaNode : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaNode](Divine.Panorama.PanoramaNode.md)

#### Derived

[PanoramaPanel](Divine.Panorama.PanoramaPanel.md), 
[PanoramaStyle](Divine.Panorama.PanoramaStyle.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<PanoramaNode\>\(PanoramaNode, params PanoramaNode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Panorama_PanoramaNode_ConstructorName"></a> ConstructorName

```csharp
public string ConstructorName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaNode_IsArray"></a> IsArray

```csharp
public bool IsArray { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaNode_IsNull"></a> IsNull

```csharp
public bool IsNull { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaNode_IsObject"></a> IsObject

```csharp
public bool IsObject { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaNode_IsPanel"></a> IsPanel

```csharp
public bool IsPanel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaNode_Kind"></a> Kind

```csharp
public PanoramaNodeKind Kind { get; }
```

#### Property Value

 [PanoramaNodeKind](Divine.Panorama.PanoramaNodeKind.md)

### <a id="Divine_Panorama_PanoramaNode_TypeName"></a> TypeName

```csharp
public string TypeName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Panorama_PanoramaNode_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Panorama_PanoramaNode_Finalize"></a> \~PanoramaNode\(\)

```csharp
protected ~PanoramaNode()
```

### <a id="Divine_Panorama_PanoramaNode_Get_System_String_"></a> Get\(string\)

```csharp
public PanoramaNode Get(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaNode_GetMembers"></a> GetMembers\(\)

```csharp
public string[] GetMembers()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_Panorama_PanoramaNode_GetValue__1"></a> GetValue<T\>\(\)

```csharp
public T? GetValue<T>()
```

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaNode_GetValue__1_System_String_"></a> GetValue<T\>\(string\)

```csharp
public T? GetValue<T>(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaNode_Invoke__1_System_String_System_Object___"></a> Invoke<T\>\(string, params object?\[\]\)

```csharp
public T? Invoke<T>(string method, params object?[] args)
```

#### Parameters

`method` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaNode_Invoke_System_String_System_Object___"></a> Invoke\(string, params object?\[\]\)

```csharp
public PanoramaNode Invoke(string method, params object?[] args)
```

#### Parameters

`method` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaNode_SetValue__1_System_String___0_"></a> SetValue<T\>\(string, T\)

```csharp
public void SetValue<T>(string property, T value)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaNode_ToJson_System_Boolean_System_Boolean_"></a> ToJson\(bool, bool\)

```csharp
public string ToJson(bool writeIndented = true, bool useManagedProperties = false)
```

#### Parameters

`writeIndented` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`useManagedProperties` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaNode_ToJsonNode_System_Boolean_"></a> ToJsonNode\(bool\)

```csharp
public JsonNode? ToJsonNode(bool useManagedProperties = false)
```

#### Parameters

`useManagedProperties` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)?

### <a id="Divine_Panorama_PanoramaNode_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

