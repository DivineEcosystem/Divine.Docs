# <a id="Divine_Helpers_MurmurHash2"></a> Class MurmurHash2

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.dll  

```csharp
public static class MurmurHash2
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MurmurHash2](Divine.Helpers.MurmurHash2.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Helpers_MurmurHash2_Hash32_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash32\(ReadOnlySpan<byte\>, uint\)

```csharp
public static uint Hash32(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash2_Hash32_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash32\(ReadOnlySpan<char\>, uint\)

```csharp
public static uint Hash32(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash2_Hash32LowerCase_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash32LowerCase\(ReadOnlySpan<byte\>, uint\)

```csharp
public static uint Hash32LowerCase(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash2_Hash32LowerCase_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash32LowerCase\(ReadOnlySpan<char\>, uint\)

```csharp
public static uint Hash32LowerCase(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash2_Hash64A_System_ReadOnlySpan_System_Byte__System_UInt64_"></a> Hash64A\(ReadOnlySpan<byte\>, ulong\)

```csharp
public static ulong Hash64A(ReadOnlySpan<byte> data, ulong seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64A_System_ReadOnlySpan_System_Char__System_UInt64_"></a> Hash64A\(ReadOnlySpan<char\>, ulong\)

```csharp
public static ulong Hash64A(ReadOnlySpan<char> text, ulong seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64ALowerCase_System_ReadOnlySpan_System_Byte__System_UInt64_"></a> Hash64ALowerCase\(ReadOnlySpan<byte\>, ulong\)

```csharp
public static ulong Hash64ALowerCase(ReadOnlySpan<byte> data, ulong seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64ALowerCase_System_ReadOnlySpan_System_Char__System_UInt64_"></a> Hash64ALowerCase\(ReadOnlySpan<char\>, ulong\)

```csharp
public static ulong Hash64ALowerCase(ReadOnlySpan<char> text, ulong seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64B_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash64B\(ReadOnlySpan<byte\>, uint\)

```csharp
public static ulong Hash64B(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64B_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash64B\(ReadOnlySpan<char\>, uint\)

```csharp
public static ulong Hash64B(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64BLowerCase_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash64BLowerCase\(ReadOnlySpan<byte\>, uint\)

```csharp
public static ulong Hash64BLowerCase(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash2_Hash64BLowerCase_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash64BLowerCase\(ReadOnlySpan<char\>, uint\)

```csharp
public static ulong Hash64BLowerCase(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

