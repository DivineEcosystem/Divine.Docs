# <a id="Divine_Panorama_PanoramaStyleRule"></a> Class PanoramaStyleRule

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public sealed record PanoramaStyleRule : IEquatable<PanoramaStyleRule>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaStyleRule](Divine.Panorama.PanoramaStyleRule.md)

#### Implements

[IEquatable<PanoramaStyleRule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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
[EnumerableExtensions.In<PanoramaStyleRule\>\(PanoramaStyleRule, params PanoramaStyleRule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Panorama_PanoramaStyleRule__ctor_System_String_System_String_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__System_Collections_Generic_IReadOnlySet_System_String__"></a> PanoramaStyleRule\(string, string, IReadOnlyDictionary<string, string\>, IReadOnlySet<string\>\)

```csharp
public PanoramaStyleRule(string Selector, string Source, IReadOnlyDictionary<string, string> Properties, IReadOnlySet<string> OverriddenProperties)
```

#### Parameters

`Selector` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Source` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Properties` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

`OverriddenProperties` [IReadOnlySet](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlyset\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Properties

### <a id="Divine_Panorama_PanoramaStyleRule_OverriddenProperties"></a> OverriddenProperties

```csharp
public IReadOnlySet<string> OverriddenProperties { get; init; }
```

#### Property Value

 [IReadOnlySet](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlyset\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaStyleRule_Properties"></a> Properties

```csharp
public IReadOnlyDictionary<string, string> Properties { get; init; }
```

#### Property Value

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaStyleRule_Selector"></a> Selector

```csharp
public string Selector { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyleRule_Source"></a> Source

```csharp
public string Source { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Panorama_PanoramaStyleRule_Format_System_Boolean_"></a> Format\(bool\)

```csharp
public string Format(bool markOverridden = true)
```

#### Parameters

`markOverridden` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaStyleRule_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

