# <a id="Divine_Renderer_Numerics_Margin"></a> Struct Margin

Namespace: [Divine.Renderer.Numerics](Divine.Renderer.Numerics.md)  
Assembly: Divine.dll  

```csharp
public struct Margin : IEquatable<Margin>, IMultiplyOperators<Margin, float, Margin>
```

#### Implements

[IEquatable<Margin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IMultiplyOperators<Margin, float, Margin\>](https://learn.microsoft.com/dotnet/api/system.numerics.imultiplyoperators\-3)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<Margin\>\(Margin, Margin\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<Margin\>\(Margin\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<Margin\>\(Margin\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<Margin\>\(Margin, params Margin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<Margin\>\(Margin, Margin, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Renderer_Numerics_Margin__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Margin\(float, float, float, float\)

```csharp
public Margin(float left, float top, float right, float bottom)
```

#### Parameters

`left` [float](https://learn.microsoft.com/dotnet/api/system.single)

`top` [float](https://learn.microsoft.com/dotnet/api/system.single)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Divine_Renderer_Numerics_Margin_Bottom"></a> Bottom

```csharp
public float Bottom
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_Margin_Left"></a> Left

```csharp
public float Left
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_Margin_Right"></a> Right

```csharp
public float Right
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_Numerics_Margin_Top"></a> Top

```csharp
public float Top
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Renderer_Numerics_Margin_Ceiling"></a> Ceiling\(\)

```csharp
public readonly Margin Ceiling()
```

#### Returns

 [Margin](Divine.Renderer.Numerics.Margin.md)

### <a id="Divine_Renderer_Numerics_Margin_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="Divine_Renderer_Numerics_Margin_Equals_Divine_Renderer_Numerics_Margin_"></a> Equals\(Margin\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(Margin other)
```

#### Parameters

`other` [Margin](Divine.Renderer.Numerics.Margin.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Renderer_Numerics_Margin_Floor"></a> Floor\(\)

```csharp
public readonly Margin Floor()
```

#### Returns

 [Margin](Divine.Renderer.Numerics.Margin.md)

### <a id="Divine_Renderer_Numerics_Margin_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Divine_Renderer_Numerics_Margin_Round"></a> Round\(\)

```csharp
public readonly Margin Round()
```

#### Returns

 [Margin](Divine.Renderer.Numerics.Margin.md)

### <a id="Divine_Renderer_Numerics_Margin_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Divine_Renderer_Numerics_Margin_op_Equality_Divine_Renderer_Numerics_Margin_Divine_Renderer_Numerics_Margin_"></a> operator ==\(Margin, Margin\)

```csharp
public static bool operator ==(Margin left, Margin right)
```

#### Parameters

`left` [Margin](Divine.Renderer.Numerics.Margin.md)

`right` [Margin](Divine.Renderer.Numerics.Margin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_Margin_op_Inequality_Divine_Renderer_Numerics_Margin_Divine_Renderer_Numerics_Margin_"></a> operator \!=\(Margin, Margin\)

```csharp
public static bool operator !=(Margin left, Margin right)
```

#### Parameters

`left` [Margin](Divine.Renderer.Numerics.Margin.md)

`right` [Margin](Divine.Renderer.Numerics.Margin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_Numerics_Margin_op_Multiply_Divine_Renderer_Numerics_Margin_System_Single_"></a> operator \*\(Margin, float\)

Multiplies two values together to compute their product.

```csharp
public static Margin operator *(Margin left, float right)
```

#### Parameters

`left` [Margin](Divine.Renderer.Numerics.Margin.md)

The value that <code class="paramref">right</code> multiplies.

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value that multiplies <code class="paramref">left</code>.

#### Returns

 [Margin](Divine.Renderer.Numerics.Margin.md)

The product of <code class="paramref">left</code> multiplied by <code class="paramref">right</code>.

