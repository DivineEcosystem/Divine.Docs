# <a id="Divine_Helpers_MurmurHash3"></a> Class MurmurHash3

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.dll  

```csharp
public static class MurmurHash3
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MurmurHash3](Divine.Helpers.MurmurHash3.md)

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

### <a id="Divine_Helpers_MurmurHash3_Hash128_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash128\(ReadOnlySpan<byte\>, uint\)

```csharp
public static UInt128 Hash128(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [UInt128](https://learn.microsoft.com/dotnet/api/system.uint128)

### <a id="Divine_Helpers_MurmurHash3_Hash128_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash128\(ReadOnlySpan<char\>, uint\)

```csharp
public static UInt128 Hash128(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [UInt128](https://learn.microsoft.com/dotnet/api/system.uint128)

### <a id="Divine_Helpers_MurmurHash3_Hash128_System_ReadOnlySpan_System_Byte__System_UInt32_System_UInt64__System_UInt64__"></a> Hash128\(ReadOnlySpan<byte\>, uint, out ulong, out ulong\)

```csharp
public static void Hash128(ReadOnlySpan<byte> data, uint seed, out ulong hash1, out ulong hash2)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`hash1` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`hash2` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Helpers_MurmurHash3_Hash128LowerCase_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash128LowerCase\(ReadOnlySpan<byte\>, uint\)

```csharp
public static UInt128 Hash128LowerCase(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [UInt128](https://learn.microsoft.com/dotnet/api/system.uint128)

### <a id="Divine_Helpers_MurmurHash3_Hash128LowerCase_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash128LowerCase\(ReadOnlySpan<char\>, uint\)

```csharp
public static UInt128 Hash128LowerCase(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [UInt128](https://learn.microsoft.com/dotnet/api/system.uint128)

### <a id="Divine_Helpers_MurmurHash3_Hash32_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash32\(ReadOnlySpan<byte\>, uint\)

```csharp
public static uint Hash32(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash3_Hash32_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash32\(ReadOnlySpan<char\>, uint\)

```csharp
public static uint Hash32(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash3_Hash32LowerCase_System_ReadOnlySpan_System_Byte__System_UInt32_"></a> Hash32LowerCase\(ReadOnlySpan<byte\>, uint\)

```csharp
public static uint Hash32LowerCase(ReadOnlySpan<byte> data, uint seed)
```

#### Parameters

`data` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Helpers_MurmurHash3_Hash32LowerCase_System_ReadOnlySpan_System_Char__System_UInt32_"></a> Hash32LowerCase\(ReadOnlySpan<char\>, uint\)

```csharp
public static uint Hash32LowerCase(ReadOnlySpan<char> text, uint seed)
```

#### Parameters

`text` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`seed` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

