# <a id="Divine_Renderer_Numerics_RoundedRect"></a> Struct RoundedRect

Namespace: [Divine.Renderer.Numerics](Divine.Renderer.Numerics.md)  
Assembly: Divine.dll  

```csharp
public struct RoundedRect : IEquatable<RoundedRect>, IMultiplyOperators<RoundedRect, CornerRadius, RoundedRect>, IMultiplyOperators<RoundedRect, RoundedRect, RoundedRect>, IMultiplyOperators<RoundedRect, float, RoundedRect>, IMultiplyOperators<RoundedRect, Size, RoundedRect>, IMultiplyOperators<RoundedRect, Vector2, RoundedRect>
```

#### Implements

[IEquatable<RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IMultiplyOperators<RoundedRect, CornerRadius, RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3), 
[IMultiplyOperators<RoundedRect, RoundedRect, RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3), 
[IMultiplyOperators<RoundedRect, float, RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3), 
[IMultiplyOperators<RoundedRect, Size, RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3), 
[IMultiplyOperators<RoundedRect, Vector2, RoundedRect\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<RoundedRect\>\(RoundedRect, RoundedRect\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<RoundedRect\>\(RoundedRect\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<RoundedRect\>\(RoundedRect\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<RoundedRect\>\(RoundedRect, params RoundedRect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<RoundedRect\>\(RoundedRect, RoundedRect, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_Vortice_Mathematics_Rect_Divine_Renderer_Numerics_CornerRadius_"></a> RoundedRect\(Rect, CornerRadius\)

```csharp
public RoundedRect(Rect rect, CornerRadius cornerRadius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_Vortice_Mathematics_Rect_"></a> RoundedRect\(Rect\)

```csharp
public RoundedRect(Rect rect)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(float, float, float, float\)

```csharp
public RoundedRect(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(float, float, float, float, float\)

```csharp
public RoundedRect(float x, float y, float width, float height, float uniformRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`uniformRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(float, float, float, float, float, float\)

```csharp
public RoundedRect(float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(float, float, float, float, float, float, float, float\)

```csharp
public RoundedRect(float x, float y, float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Numerics_Vector2_Vortice_Mathematics_Size_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(Vector2, Size, float, float, float, float\)

```csharp
public RoundedRect(Vector2 location, Size size, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`location` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_Vortice_Mathematics_Rect_System_Single_System_Single_System_Single_System_Single_"></a> RoundedRect\(Rect, float, float, float, float\)

```csharp
public RoundedRect(Rect rect, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Numerics_Vector2_System_Single_System_Single_Divine_Renderer_Numerics_CornerRadius_"></a> RoundedRect\(Vector2, float, float, CornerRadius\)

```csharp
public RoundedRect(Vector2 location, float width, float height, CornerRadius cornerRadius)
```

#### Parameters

`location` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_Vortice_Mathematics_Size_Divine_Renderer_Numerics_CornerRadius_"></a> RoundedRect\(float, float, Size, CornerRadius\)

```csharp
public RoundedRect(float x, float y, Size size, CornerRadius cornerRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Numerics_Vector2_Vortice_Mathematics_Size_Divine_Renderer_Numerics_CornerRadius_"></a> RoundedRect\(Vector2, Size, CornerRadius\)

```csharp
public RoundedRect(Vector2 location, Size size, CornerRadius cornerRadius)
```

#### Parameters

`location` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect__ctor_System_Single_System_Single_System_Single_System_Single_Divine_Renderer_Numerics_CornerRadius_"></a> RoundedRect\(float, float, float, float, CornerRadius\)

```csharp
public RoundedRect(float x, float y, float width, float height, CornerRadius cornerRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

## Fields

### <a id="Divine_Renderer_Numerics_RoundedRect_CornerRadius"></a> CornerRadius

```csharp
public CornerRadius CornerRadius
```

#### Field Value

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Rect"></a> Rect

```csharp
public Rect Rect
```

#### Field Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

## Properties

### <a id="Divine_Renderer_Numerics_RoundedRect_Bottom"></a> Bottom

```csharp
public float Bottom { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_BottomLeft"></a> BottomLeft

```csharp
public readonly Vector2 BottomLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_BottomLeftRadius"></a> BottomLeftRadius

```csharp
public float BottomLeftRadius { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_BottomRight"></a> BottomRight

```csharp
public readonly Vector2 BottomRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_BottomRightRadius"></a> BottomRightRadius

```csharp
public float BottomRightRadius { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Center"></a> Center

```csharp
public readonly Vector2 Center { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_Height"></a> Height

```csharp
public float Height { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Left"></a> Left

```csharp
public float Left { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Position"></a> Position

```csharp
public Vector2 Position { readonly get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_Right"></a> Right

```csharp
public float Right { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Size"></a> Size

```csharp
public Size Size { readonly get; set; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Renderer_Numerics_RoundedRect_Top"></a> Top

```csharp
public float Top { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_TopLeft"></a> TopLeft

```csharp
public readonly Vector2 TopLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_TopLeftRadius"></a> TopLeftRadius

```csharp
public float TopLeftRadius { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_TopRight"></a> TopRight

```csharp
public readonly Vector2 TopRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_Numerics_RoundedRect_TopRightRadius"></a> TopRightRadius

```csharp
public float TopRightRadius { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Width"></a> Width

```csharp
public float Width { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_X"></a> X

```csharp
public float X { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_RoundedRect_Y"></a> Y

```csharp
public float Y { readonly get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Renderer_Numerics_RoundedRect_Add_System_Single_"></a> Add\(float\)

```csharp
public readonly RoundedRect Add(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Add_System_Single_System_Single_System_Single_System_Single_"></a> Add\(float, float, float, float\)

```csharp
public readonly RoundedRect Add(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Add_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Add\(float, float, float, float, float, float, float, float\)

```csharp
public readonly RoundedRect Add(float x, float y, float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Add_Divine_Renderer_Numerics_RoundedRect_"></a> Add\(RoundedRect\)

```csharp
public readonly RoundedRect Add(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Ceiling"></a> Ceiling\(\)

```csharp
public readonly RoundedRect Ceiling()
```

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Divide_System_Single_"></a> Divide\(float\)

```csharp
public readonly RoundedRect Divide(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Divide_System_Single_System_Single_System_Single_System_Single_"></a> Divide\(float, float, float, float\)

```csharp
public readonly RoundedRect Divide(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Divide_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Divide\(float, float, float, float, float, float, float, float\)

```csharp
public readonly RoundedRect Divide(float x, float y, float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Divide_Divine_Renderer_Numerics_RoundedRect_"></a> Divide\(RoundedRect\)

```csharp
public readonly RoundedRect Divide(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Equals_System_Object_"></a> Equals\(object?\)

Indicates whether this instance and a specified object are equal.

```csharp
public override readonly bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Renderer_Numerics_RoundedRect_Equals_Divine_Renderer_Numerics_RoundedRect_"></a> Equals\(RoundedRect\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(RoundedRect other)
```

#### Parameters

`other` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Renderer_Numerics_RoundedRect_Floor"></a> Floor\(\)

```csharp
public readonly RoundedRect Floor()
```

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Divine_Renderer_Numerics_RoundedRect_Lerp_Divine_Renderer_Numerics_RoundedRect_System_Single_"></a> Lerp\(RoundedRect, float\)

```csharp
public readonly RoundedRect Lerp(RoundedRect rect, float amount)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Multiply_System_Single_"></a> Multiply\(float\)

```csharp
public readonly RoundedRect Multiply(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Multiply_System_Single_System_Single_System_Single_System_Single_"></a> Multiply\(float, float, float, float\)

```csharp
public readonly RoundedRect Multiply(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Multiply_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Multiply\(float, float, float, float, float, float, float, float\)

```csharp
public readonly RoundedRect Multiply(float x, float y, float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Multiply_Divine_Renderer_Numerics_RoundedRect_"></a> Multiply\(RoundedRect\)

```csharp
public readonly RoundedRect Multiply(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Round"></a> Round\(\)

```csharp
public readonly RoundedRect Round()
```

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Subtract_System_Single_"></a> Subtract\(float\)

```csharp
public readonly RoundedRect Subtract(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Subtract_System_Single_System_Single_System_Single_System_Single_"></a> Subtract\(float, float, float, float\)

```csharp
public readonly RoundedRect Subtract(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Subtract_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Subtract\(float, float, float, float, float, float, float, float\)

```csharp
public readonly RoundedRect Subtract(float x, float y, float width, float height, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRightRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeftRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_Subtract_Divine_Renderer_Numerics_RoundedRect_"></a> Subtract\(RoundedRect\)

```csharp
public readonly RoundedRect Subtract(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Addition_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_Margin_"></a> operator \+\(RoundedRect, Margin\)

```csharp
public static RoundedRect operator +(RoundedRect left, Margin right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Margin](Divine.Renderer.Numerics.Margin.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Addition_Divine_Renderer_Numerics_RoundedRect_System_Numerics_Vector2_"></a> operator \+\(RoundedRect, Vector2\)

```csharp
public static RoundedRect operator +(RoundedRect left, Vector2 right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Addition_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Size_"></a> operator \+\(RoundedRect, Size\)

```csharp
public static RoundedRect operator +(RoundedRect left, Size right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Addition_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_CornerRadius_"></a> operator \+\(RoundedRect, CornerRadius\)

```csharp
public static RoundedRect operator +(RoundedRect left, CornerRadius right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Addition_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator \+\(RoundedRect, RoundedRect\)

```csharp
public static RoundedRect operator +(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Division_Divine_Renderer_Numerics_RoundedRect_System_Single_"></a> operator /\(RoundedRect, float\)

```csharp
public static RoundedRect operator /(RoundedRect left, float right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Division_Divine_Renderer_Numerics_RoundedRect_System_Numerics_Vector2_"></a> operator /\(RoundedRect, Vector2\)

```csharp
public static RoundedRect operator /(RoundedRect left, Vector2 right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Division_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Size_"></a> operator /\(RoundedRect, Size\)

```csharp
public static RoundedRect operator /(RoundedRect left, Size right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Division_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_CornerRadius_"></a> operator /\(RoundedRect, CornerRadius\)

```csharp
public static RoundedRect operator /(RoundedRect left, CornerRadius right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Division_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator /\(RoundedRect, RoundedRect\)

```csharp
public static RoundedRect operator /(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Equality_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator ==\(RoundedRect, RoundedRect\)

```csharp
public static bool operator ==(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Implicit_Divine_Renderer_Numerics_RoundedRect__Vortice_Mathematics_Rect"></a> implicit operator Rect\(RoundedRect\)

```csharp
public static implicit operator Rect(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Implicit_Divine_Renderer_Numerics_RoundedRect__Divine_Renderer_Numerics_CornerRadius"></a> implicit operator CornerRadius\(RoundedRect\)

```csharp
public static implicit operator CornerRadius(RoundedRect value)
```

#### Parameters

`value` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Inequality_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator \!=\(RoundedRect, RoundedRect\)

```csharp
public static bool operator !=(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Multiply_Divine_Renderer_Numerics_RoundedRect_System_Single_"></a> operator \*\(RoundedRect, float\)

Multiplies two values together to compute their product.

```csharp
public static RoundedRect operator *(RoundedRect left, float right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that <code class="paramref">right</code> multiplies.

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Multiply_Divine_Renderer_Numerics_RoundedRect_System_Numerics_Vector2_"></a> operator \*\(RoundedRect, Vector2\)

Multiplies two values together to compute their product.

```csharp
public static RoundedRect operator *(RoundedRect left, Vector2 right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that <code class="paramref">right</code> multiplies.

`right` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Multiply_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Size_"></a> operator \*\(RoundedRect, Size\)

Multiplies two values together to compute their product.

```csharp
public static RoundedRect operator *(RoundedRect left, Size right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that <code class="paramref">right</code> multiplies.

`right` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Multiply_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_CornerRadius_"></a> operator \*\(RoundedRect, CornerRadius\)

Multiplies two values together to compute their product.

```csharp
public static RoundedRect operator *(RoundedRect left, CornerRadius right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that <code class="paramref">right</code> multiplies.

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Multiply_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator \*\(RoundedRect, RoundedRect\)

Multiplies two values together to compute their product.

```csharp
public static RoundedRect operator *(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that <code class="paramref">right</code> multiplies.

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Subtraction_Divine_Renderer_Numerics_RoundedRect_System_Numerics_Vector2_"></a> operator \-\(RoundedRect, Vector2\)

```csharp
public static RoundedRect operator -(RoundedRect left, Vector2 right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Subtraction_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Size_"></a> operator \-\(RoundedRect, Size\)

```csharp
public static RoundedRect operator -(RoundedRect left, Size right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Subtraction_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_CornerRadius_"></a> operator \-\(RoundedRect, CornerRadius\)

```csharp
public static RoundedRect operator -(RoundedRect left, CornerRadius right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Renderer_Numerics_RoundedRect_op_Subtraction_Divine_Renderer_Numerics_RoundedRect_Divine_Renderer_Numerics_RoundedRect_"></a> operator \-\(RoundedRect, RoundedRect\)

```csharp
public static RoundedRect operator -(RoundedRect left, RoundedRect right)
```

#### Parameters

`left` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`right` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

