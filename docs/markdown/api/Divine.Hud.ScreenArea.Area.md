# <a id="Divine_Hud_ScreenArea_Area"></a> Class Area

Namespace: [Divine.Hud.ScreenArea](Divine.Hud.ScreenArea.md)  
Assembly: Divine.dll  

```csharp
public sealed class Area : IEquatable<Area>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Area](Divine.Hud.ScreenArea.Area.md)

#### Implements

[IEquatable<Area\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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
[EnumerableExtensions.In<Area\>\(Area, params Area\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Hud_ScreenArea_Area__ctor_System_Single_System_Single_System_Single_System_Single_System_Boolean_"></a> Area\(float, float, float, float, bool\)

```csharp
public Area(float x, float y, float width, float height, bool multiply = true)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`multiply` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="Divine_Hud_ScreenArea_Area_Height"></a> Height

```csharp
public float Height
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Hud_ScreenArea_Area_Width"></a> Width

```csharp
public float Width
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Hud_ScreenArea_Area_X"></a> X

```csharp
public float X
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Hud_ScreenArea_Area_Y"></a> Y

```csharp
public float Y
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Hud_ScreenArea_Area_Equals_System_Object_"></a> Equals\(object?\)

Determines whether the specified object is equal to the current object.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Hud_ScreenArea_Area_Equals_Divine_Hud_ScreenArea_Area_"></a> Equals\(Area?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Area? other)
```

#### Parameters

`other` [Area](Divine.Hud.ScreenArea.Area.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Hud_ScreenArea_Area_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="Divine_Hud_ScreenArea_Area_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

## Operators

### <a id="Divine_Hud_ScreenArea_Area_op_Equality_Divine_Hud_ScreenArea_Area_Divine_Hud_ScreenArea_Area_"></a> operator ==\(Area, Area?\)

```csharp
public static bool operator ==(Area left, Area? right)
```

#### Parameters

`left` [Area](Divine.Hud.ScreenArea.Area.md)

`right` [Area](Divine.Hud.ScreenArea.Area.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Hud_ScreenArea_Area_op_Implicit_Divine_Hud_ScreenArea_Area__Vortice_Mathematics_Rect"></a> implicit operator Rect\(Area\)

```csharp
public static implicit operator Rect(Area value)
```

#### Parameters

`value` [Area](Divine.Hud.ScreenArea.Area.md)

#### Returns

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_ScreenArea_Area_op_Inequality_Divine_Hud_ScreenArea_Area_Divine_Hud_ScreenArea_Area_"></a> operator \!=\(Area, Area?\)

```csharp
public static bool operator !=(Area left, Area? right)
```

#### Parameters

`left` [Area](Divine.Hud.ScreenArea.Area.md)

`right` [Area](Divine.Hud.ScreenArea.Area.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

