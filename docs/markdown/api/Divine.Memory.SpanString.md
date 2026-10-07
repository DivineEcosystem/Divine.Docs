# <a id="Divine_Memory_SpanString"></a> Struct SpanString

Namespace: [Divine.Memory](Divine.Memory.md)  
Assembly: Divine.Common.dll  

```csharp
public struct SpanString
```

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[EnumerableExtensions.ClearFlags<SpanString\>\(SpanString, SpanString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[EnumerableExtensions.GetFlagDescription<SpanString\>\(SpanString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<SpanString\>\(SpanString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<SpanString\>\(SpanString, params SpanString\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<SpanString\>\(SpanString, SpanString, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Fields

### <a id="Divine_Memory_SpanString_Buffer"></a> Buffer

```csharp
public char* Buffer
```

#### Field Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)\*

### <a id="Divine_Memory_SpanString_Length"></a> Length

```csharp
public int Length
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Memory_SpanString_Alloc"></a> Alloc\(\)

```csharp
public SpanString* Alloc()
```

#### Returns

 [SpanString](Divine.Memory.SpanString.md)\*

### <a id="Divine_Memory_SpanString_Alloc_System_String_"></a> Alloc\(string\)

```csharp
public static SpanString* Alloc(string str)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [SpanString](Divine.Memory.SpanString.md)\*

### <a id="Divine_Memory_SpanString_Alloc_System_Char__"></a> Alloc\(char\*\)

```csharp
public static SpanString* Alloc(char* str)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

#### Returns

 [SpanString](Divine.Memory.SpanString.md)\*

### <a id="Divine_Memory_SpanString_Alloc_System_Char__System_Int32_"></a> Alloc\(char\*, int\)

```csharp
public static SpanString* Alloc(char* str, int length)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [SpanString](Divine.Memory.SpanString.md)\*

### <a id="Divine_Memory_SpanString_AsSpan_System_Char__"></a> AsSpan\(char\*\)

```csharp
public static SpanString* AsSpan(char* str)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

#### Returns

 [SpanString](Divine.Memory.SpanString.md)\*

### <a id="Divine_Memory_SpanString_Equals_System_String_"></a> Equals\(string\)

```csharp
public bool Equals(string other)
```

#### Parameters

`other` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_SpanString_Equals_Divine_Memory_CString__"></a> Equals\(CString\*\)

```csharp
public bool Equals(CString* other)
```

#### Parameters

`other` [CString](Divine.Memory.CString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_SpanString_Equals_Divine_Memory_SpanString__"></a> Equals\(SpanString\*\)

```csharp
public bool Equals(SpanString* other)
```

#### Parameters

`other` [SpanString](Divine.Memory.SpanString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_SpanString_Free"></a> Free\(\)

```csharp
public void Free()
```

### <a id="Divine_Memory_SpanString_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_SpanString_GetLength_System_Char__"></a> GetLength\(char\*\)

```csharp
public static int GetLength(char* str)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_SpanString_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Memory_SpanString_ToString_System_Char__"></a> ToString\(char\*\)

```csharp
public static string ToString(char* str)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Memory_SpanString_ToString_System_Char__System_Int32_"></a> ToString\(char\*, int\)

```csharp
public static string ToString(char* str, int length)
```

#### Parameters

`str` [char](https://learn.microsoft.com/dotnet/api/system.char)\*

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

