# <a id="Divine_Media_Riff_FourCC"></a> Struct FourCC

Namespace: [Divine.Media.Riff](Divine.Media.Riff.md)  
Assembly: Divine.dll  

A FourCC descriptor.

```csharp
public struct FourCC : IEquatable<FourCC>, IFormattable
```

#### Implements

[IEquatable<FourCC\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<FourCC\>\(FourCC, FourCC\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<FourCC\>\(FourCC\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<FourCC\>\(FourCC\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<FourCC\>\(FourCC, params FourCC\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<FourCC\>\(FourCC, FourCC, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Constructors

### <a id="Divine_Media_Riff_FourCC__ctor_System_String_"></a> FourCC\(string\)

Initializes a new instance of the <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> struct.

```csharp
public FourCC(string fourCC)
```

#### Parameters

`fourCC` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fourCC value as a string .

### <a id="Divine_Media_Riff_FourCC__ctor_System_Char_System_Char_System_Char_System_Char_"></a> FourCC\(char, char, char, char\)

Initializes a new instance of the <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> struct.

```csharp
public FourCC(char byte1, char byte2, char byte3, char byte4)
```

#### Parameters

`byte1` [char](https://learn.microsoft.com/dotnet/api/system.char)

The byte1.

`byte2` [char](https://learn.microsoft.com/dotnet/api/system.char)

The byte2.

`byte3` [char](https://learn.microsoft.com/dotnet/api/system.char)

The byte3.

`byte4` [char](https://learn.microsoft.com/dotnet/api/system.char)

The byte4.

### <a id="Divine_Media_Riff_FourCC__ctor_System_UInt32_"></a> FourCC\(uint\)

Initializes a new instance of the <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> struct.

```csharp
public FourCC(uint fourCC)
```

#### Parameters

`fourCC` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The fourCC value as an uint.

### <a id="Divine_Media_Riff_FourCC__ctor_System_Int32_"></a> FourCC\(int\)

Initializes a new instance of the <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> struct.

```csharp
public FourCC(int fourCC)
```

#### Parameters

`fourCC` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The fourCC value as an int.

## Fields

### <a id="Divine_Media_Riff_FourCC_Empty"></a> Empty

Empty FourCC.

```csharp
public static readonly FourCC Empty
```

#### Field Value

 [FourCC](Divine.Media.Riff.FourCC.md)

## Methods

### <a id="Divine_Media_Riff_FourCC_Equals_Divine_Media_Riff_FourCC_"></a> Equals\(FourCC\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(FourCC other)
```

#### Parameters

`other` [FourCC](Divine.Media.Riff.FourCC.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Media_Riff_FourCC_Equals_System_Object_"></a> Equals\(object?\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Media_Riff_FourCC_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Divine_Media_Riff_FourCC_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="Divine_Media_Riff_FourCC_ToString_System_String_System_IFormatProvider_"></a> ToString\(string?, IFormatProvider?\)

Provides a custom string representation of the FourCC descriptor.

```csharp
public string ToString(string? format, IFormatProvider? formatProvider)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The format descriptor, which can be "G" (empty
    or <code>null</code> is equivalent to "G"), "I" or any valid standard
    number format.

`formatProvider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)?

The format provider for formatting
    numbers.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The requested string representation.

#### Remarks

The general format "G" is equivalent to the parameterless.
<xref href="Divine.Media.Riff.FourCC.ToString" data-throw-if-not-resolved="false"></xref>. The special format "I" returns a
string representation which can be used to construct a Media
Foundation format GUID. It is equivalent to "X08".

#### Exceptions

 [FormatException](https://learn.microsoft.com/dotnet/api/system.formatexception)

In case of
    <code class="paramref">format</code> is not "G", "I" or a valid number
    format.

## Operators

### <a id="Divine_Media_Riff_FourCC_op_Equality_Divine_Media_Riff_FourCC_Divine_Media_Riff_FourCC_"></a> operator ==\(FourCC, FourCC\)

```csharp
public static bool operator ==(FourCC left, FourCC right)
```

#### Parameters

`left` [FourCC](Divine.Media.Riff.FourCC.md)

`right` [FourCC](Divine.Media.Riff.FourCC.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Media_Riff_FourCC_op_Implicit_Divine_Media_Riff_FourCC__System_UInt32"></a> implicit operator uint\(FourCC\)

Performs an implicit conversion from <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> to <xref href="System.Int32" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator uint(FourCC d)
```

#### Parameters

`d` [FourCC](Divine.Media.Riff.FourCC.md)

The d.

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Implicit_Divine_Media_Riff_FourCC__System_Int32"></a> implicit operator int\(FourCC\)

Performs an implicit conversion from <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> to <xref href="System.Int32" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator int(FourCC d)
```

#### Parameters

`d` [FourCC](Divine.Media.Riff.FourCC.md)

The d.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Implicit_System_UInt32__Divine_Media_Riff_FourCC"></a> implicit operator FourCC\(uint\)

Performs an implicit conversion from <xref href="System.Int32" data-throw-if-not-resolved="false"></xref> to <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator FourCC(uint d)
```

#### Parameters

`d` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The d.

#### Returns

 [FourCC](Divine.Media.Riff.FourCC.md)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Implicit_System_Int32__Divine_Media_Riff_FourCC"></a> implicit operator FourCC\(int\)

Performs an implicit conversion from <xref href="System.Int32" data-throw-if-not-resolved="false"></xref> to <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator FourCC(int d)
```

#### Parameters

`d` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The d.

#### Returns

 [FourCC](Divine.Media.Riff.FourCC.md)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Implicit_Divine_Media_Riff_FourCC__System_String"></a> implicit operator string\(FourCC\)

Performs an implicit conversion from <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> to <xref href="System.String" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator string(FourCC d)
```

#### Parameters

`d` [FourCC](Divine.Media.Riff.FourCC.md)

The d.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Implicit_System_String__Divine_Media_Riff_FourCC"></a> implicit operator FourCC\(string\)

Performs an implicit conversion from <xref href="System.String" data-throw-if-not-resolved="false"></xref> to <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator FourCC(string d)
```

#### Parameters

`d` [string](https://learn.microsoft.com/dotnet/api/system.string)

The d.

#### Returns

 [FourCC](Divine.Media.Riff.FourCC.md)

The result of the conversion.

### <a id="Divine_Media_Riff_FourCC_op_Inequality_Divine_Media_Riff_FourCC_Divine_Media_Riff_FourCC_"></a> operator \!=\(FourCC, FourCC\)

```csharp
public static bool operator !=(FourCC left, FourCC right)
```

#### Parameters

`left` [FourCC](Divine.Media.Riff.FourCC.md)

`right` [FourCC](Divine.Media.Riff.FourCC.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

