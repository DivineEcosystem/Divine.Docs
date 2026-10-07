# <a id="Divine_Renderer_ImageProperties"></a> Struct ImageProperties

Namespace: [Divine.Renderer](Divine.Renderer.md)  
Assembly: Divine.dll  

```csharp
public readonly struct ImageProperties
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<ImageProperties\>\(ImageProperties, ImageProperties\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<ImageProperties\>\(ImageProperties\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<ImageProperties\>\(ImageProperties\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<ImageProperties\>\(ImageProperties, params ImageProperties\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<ImageProperties\>\(ImageProperties, ImageProperties, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Properties

### <a id="Divine_Renderer_ImageProperties_Brightness"></a> Brightness

```csharp
public int Brightness { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Renderer_ImageProperties_ColorTint"></a> ColorTint

```csharp
public Color? ColorTint { get; init; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)?

### <a id="Divine_Renderer_ImageProperties_ConvertType"></a> ConvertType

```csharp
public ImageConvertType ConvertType { get; init; }
```

#### Property Value

 [ImageConvertType](Divine.Renderer.ImageConvertType.md)

### <a id="Divine_Renderer_ImageProperties_IsBlackWhite"></a> IsBlackWhite

```csharp
public bool IsBlackWhite { get; init; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_ImageProperties_IsSliced"></a> IsSliced

```csharp
public bool IsSliced { get; init; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_ImageProperties_Transform"></a> Transform

```csharp
public Matrix3x2? Transform { get; init; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)?

