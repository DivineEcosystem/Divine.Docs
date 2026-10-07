# <a id="Divine_Memory_SpanArray"></a> Struct SpanArray

Namespace: [Divine.Memory](Divine.Memory.md)  
Assembly: Divine.Common.dll  

```csharp
public struct SpanArray
```

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[EnumerableExtensions.ClearFlags<SpanArray\>\(SpanArray, SpanArray\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[EnumerableExtensions.GetFlagDescription<SpanArray\>\(SpanArray\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<SpanArray\>\(SpanArray\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<SpanArray\>\(SpanArray, params SpanArray\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<SpanArray\>\(SpanArray, SpanArray, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Fields

### <a id="Divine_Memory_SpanArray_Buffer"></a> Buffer

```csharp
public byte* Buffer
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

### <a id="Divine_Memory_SpanArray_Length"></a> Length

```csharp
public long Length
```

#### Field Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

## Methods

### <a id="Divine_Memory_SpanArray_AsSpan_System_Byte__"></a> AsSpan\(byte\*\)

```csharp
public static SpanArray* AsSpan(byte* array)
```

#### Parameters

`array` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

#### Returns

 [SpanArray](Divine.Memory.SpanArray.md)\*

### <a id="Divine_Memory_SpanArray_ToArray"></a> ToArray\(\)

```csharp
public byte[] ToArray()
```

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

