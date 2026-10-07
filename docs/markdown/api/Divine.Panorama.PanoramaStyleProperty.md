# <a id="Divine_Panorama_PanoramaStyleProperty"></a> Class PanoramaStyleProperty

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public sealed class PanoramaStyleProperty
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaStyleProperty](Divine.Panorama.PanoramaStyleProperty.md)

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
[EnumerableExtensions.In<PanoramaStyleProperty\>\(PanoramaStyleProperty, params PanoramaStyleProperty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Panorama_PanoramaStyleProperty__ctor_System_Byte_System_Byte_System_Boolean_System_String_System_String_System_String_System_Collections_Generic_IReadOnlyList_System_String__"></a> PanoramaStyleProperty\(byte, byte, bool, string, string, string, IReadOnlyList<string\>\)

```csharp
public PanoramaStyleProperty(byte symbol, byte mainSymbol, bool isAlias, string name, string mainName, string description, IReadOnlyList<string> suggestedValues)
```

#### Parameters

`symbol` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`mainSymbol` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`isAlias` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`mainName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`description` [string](https://learn.microsoft.com/dotnet/api/system.string)

`suggestedValues` [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Properties

### <a id="Divine_Panorama_PanoramaStyleProperty_Description"></a> Description

```csharp
public string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyleProperty_IsAlias"></a> IsAlias

```csharp
public bool IsAlias { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaStyleProperty_MainName"></a> MainName

```csharp
public string MainName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyleProperty_MainSymbol"></a> MainSymbol

```csharp
public byte MainSymbol { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Panorama_PanoramaStyleProperty_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyleProperty_SuggestedValues"></a> SuggestedValues

```csharp
public IReadOnlyList<string> SuggestedValues { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaStyleProperty_Symbol"></a> Symbol

```csharp
public byte Symbol { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

