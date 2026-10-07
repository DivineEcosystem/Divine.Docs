# <a id="Divine_Memory_CharString"></a> Struct CharString

Namespace: [Divine.Memory](Divine.Memory.md)  
Assembly: Divine.Common.dll  

```csharp
public struct CharString
```

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[EnumerableExtensions.ClearFlags<CharString\>\(CharString, CharString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[EnumerableExtensions.GetFlagDescription<CharString\>\(CharString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<CharString\>\(CharString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<CharString\>\(CharString, params CharString\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<CharString\>\(CharString, CharString, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Methods

### <a id="Divine_Memory_CharString_Equals_System_String_"></a> Equals\(string\)

```csharp
public bool Equals(string other)
```

#### Parameters

`other` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CharString_Equals_Divine_Memory_SpanString__"></a> Equals\(SpanString\*\)

```csharp
public bool Equals(SpanString* other)
```

#### Parameters

`other` [SpanString](Divine.Memory.SpanString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CharString_Equals_Divine_Memory_CharString__"></a> Equals\(CharString\*\)

```csharp
public bool Equals(CharString* other)
```

#### Parameters

`other` [CharString](Divine.Memory.CharString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CharString_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_CharString_GetLength"></a> GetLength\(\)

```csharp
public int GetLength()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_CharString_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Memory_CharString_ToString_Divine_Memory_CharString__System_Int32_"></a> ToString\(CharString\*, int\)

```csharp
public static string ToString(CharString* str, int length)
```

#### Parameters

`str` [CharString](Divine.Memory.CharString.md)\*

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

