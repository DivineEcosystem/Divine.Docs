# <a id="Divine_Renderer_Numerics_CornerRadius"></a> Struct CornerRadius

Namespace: [Divine.Renderer.Numerics](Divine.Renderer.Numerics.md)  
Assembly: Divine.dll  

```csharp
public struct CornerRadius : IEquatable<CornerRadius>, IMultiplyOperators<CornerRadius, CornerRadius, CornerRadius>, IMultiplyOperators<CornerRadius, float, CornerRadius>
```

#### Implements

[IEquatable<CornerRadius\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IMultiplyOperators<CornerRadius, CornerRadius, CornerRadius\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3), 
[IMultiplyOperators<CornerRadius, float, CornerRadius\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<CornerRadius\>\(CornerRadius, CornerRadius\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<CornerRadius\>\(CornerRadius\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<CornerRadius\>\(CornerRadius\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<CornerRadius\>\(CornerRadius, params CornerRadius\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<CornerRadius\>\(CornerRadius, CornerRadius, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Renderer_Numerics_CornerRadius__ctor_System_Single_System_Single_System_Single_System_Single_"></a> CornerRadius\(float, float, float, float\)

```csharp
public CornerRadius(float topLeft, float topRight, float bottomRight, float bottomLeft)
```

#### Parameters

`topLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_CornerRadius__ctor_System_Single_"></a> CornerRadius\(float\)

```csharp
public CornerRadius(float uniformRadius)
```

#### Parameters

`uniformRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_CornerRadius__ctor_System_Numerics_Vector4_"></a> CornerRadius\(Vector4\)

```csharp
public CornerRadius(Vector4 value)
```

#### Parameters

`value` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

## Fields

### <a id="Divine_Renderer_Numerics_CornerRadius_BottomLeft"></a> BottomLeft

```csharp
public float BottomLeft
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_CornerRadius_BottomRight"></a> BottomRight

```csharp
public float BottomRight
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_CornerRadius_TopLeft"></a> TopLeft

```csharp
public float TopLeft
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_CornerRadius_TopRight"></a> TopRight

```csharp
public float TopRight
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Renderer_Numerics_CornerRadius_Add_System_Single_"></a> Add\(float\)

```csharp
public readonly CornerRadius Add(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Add_Divine_Renderer_Numerics_CornerRadius_"></a> Add\(CornerRadius\)

```csharp
public readonly CornerRadius Add(CornerRadius value)
```

#### Parameters

`value` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Add_System_Single_System_Single_System_Single_System_Single_"></a> Add\(float, float, float, float\)

```csharp
public readonly CornerRadius Add(float topLeft, float topRight, float bottomRight, float bottomLeft)
```

#### Parameters

`topLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Ceiling"></a> Ceiling\(\)

```csharp
public readonly CornerRadius Ceiling()
```

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Divide_System_Single_"></a> Divide\(float\)

```csharp
public readonly CornerRadius Divide(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Divide_Divine_Renderer_Numerics_CornerRadius_"></a> Divide\(CornerRadius\)

```csharp
public readonly CornerRadius Divide(CornerRadius value)
```

#### Parameters

`value` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Divide_System_Single_System_Single_System_Single_System_Single_"></a> Divide\(float, float, float, float\)

```csharp
public readonly CornerRadius Divide(float topLeft, float topRight, float bottomRight, float bottomLeft)
```

#### Parameters

`topLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="Divine_Renderer_Numerics_CornerRadius_Equals_Divine_Renderer_Numerics_CornerRadius_"></a> Equals\(CornerRadius\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(CornerRadius other)
```

#### Parameters

`other` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Renderer_Numerics_CornerRadius_Floor"></a> Floor\(\)

```csharp
public readonly CornerRadius Floor()
```

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Divine_Renderer_Numerics_CornerRadius_Lerp_Divine_Renderer_Numerics_CornerRadius_System_Single_"></a> Lerp\(CornerRadius, float\)

```csharp
public readonly CornerRadius Lerp(CornerRadius cornerRadius, float amount)
```

#### Parameters

`cornerRadius` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Multiply_System_Single_"></a> Multiply\(float\)

```csharp
public readonly CornerRadius Multiply(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Multiply_Divine_Renderer_Numerics_CornerRadius_"></a> Multiply\(CornerRadius\)

```csharp
public readonly CornerRadius Multiply(CornerRadius value)
```

#### Parameters

`value` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Multiply_System_Single_System_Single_System_Single_System_Single_"></a> Multiply\(float, float, float, float\)

```csharp
public readonly CornerRadius Multiply(float topLeft, float topRight, float bottomRight, float bottomLeft)
```

#### Parameters

`topLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Round"></a> Round\(\)

```csharp
public readonly CornerRadius Round()
```

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Subtract_System_Single_"></a> Subtract\(float\)

```csharp
public readonly CornerRadius Subtract(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Subtract_Divine_Renderer_Numerics_CornerRadius_"></a> Subtract\(CornerRadius\)

```csharp
public readonly CornerRadius Subtract(CornerRadius value)
```

#### Parameters

`value` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_Subtract_System_Single_System_Single_System_Single_System_Single_"></a> Subtract\(float, float, float, float\)

```csharp
public readonly CornerRadius Subtract(float topLeft, float topRight, float bottomRight, float bottomLeft)
```

#### Parameters

`topLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`topRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottomLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Addition_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator \+\(CornerRadius, CornerRadius\)

```csharp
public static CornerRadius operator +(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Division_Divine_Renderer_Numerics_CornerRadius_System_Single_"></a> operator /\(CornerRadius, float\)

```csharp
public static CornerRadius operator /(CornerRadius left, float right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Division_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator /\(CornerRadius, CornerRadius\)

```csharp
public static CornerRadius operator /(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Equality_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator ==\(CornerRadius, CornerRadius\)

```csharp
public static bool operator ==(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Explicit_Divine_Renderer_Numerics_CornerRadius__System_Numerics_Vector4"></a> explicit operator Vector4\(CornerRadius\)

```csharp
public static explicit operator Vector4(CornerRadius value)
```

#### Parameters

`value` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Inequality_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator \!=\(CornerRadius, CornerRadius\)

```csharp
public static bool operator !=(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Multiply_Divine_Renderer_Numerics_CornerRadius_System_Single_"></a> operator \*\(CornerRadius, float\)

Multiplies two values together to compute their product.

```csharp
public static CornerRadius operator *(CornerRadius left, float right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The value that <code class="paramref">right</code> multiplies.

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Multiply_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator \*\(CornerRadius, CornerRadius\)

Multiplies two values together to compute their product.

```csharp
public static CornerRadius operator *(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The value that <code class="paramref">right</code> multiplies.

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

### <a id="Divine_Renderer_Numerics_CornerRadius_op_Subtraction_Divine_Renderer_Numerics_CornerRadius_Divine_Renderer_Numerics_CornerRadius_"></a> operator \-\(CornerRadius, CornerRadius\)

```csharp
public static CornerRadius operator -(CornerRadius left, CornerRadius right)
```

#### Parameters

`left` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

`right` [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

#### Returns

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

