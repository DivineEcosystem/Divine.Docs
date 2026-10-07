# <a id="Divine_Memory_CString"></a> Struct CString

Namespace: [Divine.Memory](Divine.Memory.md)  
Assembly: Divine.Common.dll  

```csharp
public struct CString
```

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[EnumerableExtensions.ClearFlags<CString\>\(CString, CString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[EnumerableExtensions.GetFlagDescription<CString\>\(CString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<CString\>\(CString\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<CString\>\(CString, params CString\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<CString\>\(CString, CString, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Methods

### <a id="Divine_Memory_CString_Equals_System_String_"></a> Equals\(string\)

```csharp
public bool Equals(string other)
```

#### Parameters

`other` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CString_Equals_Divine_Memory_SpanString__"></a> Equals\(SpanString\*\)

```csharp
public bool Equals(SpanString* other)
```

#### Parameters

`other` [SpanString](Divine.Memory.SpanString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CString_Equals_Divine_Memory_CString__"></a> Equals\(CString\*\)

```csharp
public bool Equals(CString* other)
```

#### Parameters

`other` [CString](Divine.Memory.CString.md)\*

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Memory_CString_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_CString_GetLength"></a> GetLength\(\)

```csharp
public int GetLength()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Memory_CString_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Memory_CString_ToString_Divine_Memory_CString__System_Int32_"></a> ToString\(CString\*, int\)

```csharp
public static string ToString(CString* str, int length)
```

#### Parameters

`str` [CString](Divine.Memory.CString.md)\*

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

