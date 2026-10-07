# <a id="Divine_Panorama_PanoramaContext"></a> Class PanoramaContext

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public sealed class PanoramaContext
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaContext](Divine.Panorama.PanoramaContext.md)

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
[EnumerableExtensions.In<PanoramaContext\>\(PanoramaContext, params PanoramaContext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Panorama_PanoramaContext_Id"></a> Id

```csharp
public PanoramaId Id { get; }
```

#### Property Value

 [PanoramaId](Divine.Panorama.PanoramaId.md)

### <a id="Divine_Panorama_PanoramaContext_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Methods

### <a id="Divine_Panorama_PanoramaContext_GetObject_System_String_"></a> GetObject\(string\)

```csharp
public PanoramaNode GetObject(string api)
```

#### Parameters

`api` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaContext_GetPanel"></a> GetPanel\(\)

```csharp
public PanoramaPanel GetPanel()
```

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

### <a id="Divine_Panorama_PanoramaContext_Invoke__1_System_String_System_Object___"></a> Invoke<T\>\(string, params object?\[\]\)

```csharp
public T? Invoke<T>(string api, params object?[] args)
```

#### Parameters

`api` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaContext_Invoke_System_String_System_Object___"></a> Invoke\(string, params object?\[\]\)

```csharp
public PanoramaNode Invoke(string api, params object?[] args)
```

#### Parameters

`api` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaContext_Register_System_String_System_String_"></a> Register\(string, string\)

```csharp
public void Register(string name, string functionSource)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`functionSource` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaContext_RunScript__1_System_String_"></a> RunScript<T\>\(string\)

```csharp
public T? RunScript<T>(string script)
```

#### Parameters

`script` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Panorama_PanoramaContext_RunScript_System_String_"></a> RunScript\(string\)

```csharp
public PanoramaNode RunScript(string script)
```

#### Parameters

`script` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaContext_Unregister_System_String_"></a> Unregister\(string\)

```csharp
public void Unregister(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

