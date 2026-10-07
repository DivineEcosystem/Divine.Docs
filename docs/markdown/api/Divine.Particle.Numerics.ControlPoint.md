# <a id="Divine_Particle_Numerics_ControlPoint"></a> Struct ControlPoint

Namespace: [Divine.Particle.Numerics](Divine.Particle.Numerics.md)  
Assembly: Divine.dll  

```csharp
public struct ControlPoint : IEquatable<ControlPoint>
```

#### Implements

[IEquatable<ControlPoint\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<ControlPoint\>\(ControlPoint, ControlPoint\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<ControlPoint\>\(ControlPoint\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<ControlPoint\>\(ControlPoint\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<ControlPoint\>\(ControlPoint, params ControlPoint\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<ControlPoint\>\(ControlPoint, ControlPoint, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Particle_Numerics_ControlPoint__ctor_System_Int32_System_Numerics_Vector3_"></a> ControlPoint\(int, Vector3\)

```csharp
public ControlPoint(int index, Vector3 point)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`point` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Particle_Numerics_ControlPoint__ctor_System_Int32_System_Byte_"></a> ControlPoint\(int, byte\)

```csharp
public ControlPoint(int index, byte value)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Particle_Numerics_ControlPoint__ctor_System_Int32_System_Single_"></a> ControlPoint\(int, float\)

```csharp
public ControlPoint(int index, float value)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Particle_Numerics_ControlPoint__ctor_System_Int32_Vortice_Mathematics_Color_"></a> ControlPoint\(int, Color\)

```csharp
public ControlPoint(int index, Color color)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_Numerics_ControlPoint__ctor_System_Int32_System_Single_System_Single_System_Single_"></a> ControlPoint\(int, float, float, float\)

```csharp
public ControlPoint(int index, float x, float y, float z)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`z` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Divine_Particle_Numerics_ControlPoint_Index"></a> Index

```csharp
[JsonInclude]
public int Index
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Particle_Numerics_ControlPoint_Point"></a> Point

```csharp
[JsonInclude]
public Vector3 Point
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Methods

### <a id="Divine_Particle_Numerics_ControlPoint_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="Divine_Particle_Numerics_ControlPoint_Equals_Divine_Particle_Numerics_ControlPoint_"></a> Equals\(ControlPoint\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(ControlPoint other)
```

#### Parameters

`other` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Particle_Numerics_ControlPoint_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Divine_Particle_Numerics_ControlPoint_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Divine_Particle_Numerics_ControlPoint_op_Equality_Divine_Particle_Numerics_ControlPoint_Divine_Particle_Numerics_ControlPoint_"></a> operator ==\(ControlPoint, ControlPoint\)

```csharp
public static bool operator ==(ControlPoint left, ControlPoint right)
```

#### Parameters

`left` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)

`right` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Numerics_ControlPoint_op_Inequality_Divine_Particle_Numerics_ControlPoint_Divine_Particle_Numerics_ControlPoint_"></a> operator \!=\(ControlPoint, ControlPoint\)

```csharp
public static bool operator !=(ControlPoint left, ControlPoint right)
```

#### Parameters

`left` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)

`right` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

