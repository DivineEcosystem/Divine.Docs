# <a id="Divine_SymbolTable_SymbolTable"></a> Class SymbolTable

Namespace: [Divine.SymbolTable](Divine.SymbolTable.md)  
Assembly: Divine.dll  

```csharp
public sealed class SymbolTable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SymbolTable](Divine.SymbolTable.SymbolTable.md)

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
[EnumerableExtensions.In<SymbolTable\>\(SymbolTable, params SymbolTable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Fields

### <a id="Divine_SymbolTable_SymbolTable_InvalidSymbol"></a> InvalidSymbol

```csharp
public const ushort InvalidSymbol = 65535
```

#### Field Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

## Properties

### <a id="Divine_SymbolTable_SymbolTable_Count"></a> Count

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_SymbolTable_SymbolTable_Values"></a> Values

```csharp
public string[] Values { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

## Methods

### <a id="Divine_SymbolTable_SymbolTable_Find_System_String_"></a> Find\(string\)

```csharp
public ushort Find(string value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_SymbolTable_SymbolTable_Find_System_ReadOnlySpan_System_Byte__"></a> Find\(ReadOnlySpan<byte\>\)

```csharp
public ushort Find(ReadOnlySpan<byte> value)
```

#### Parameters

`value` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_SymbolTable_SymbolTable_GetUtf8Value_System_UInt16_"></a> GetUtf8Value\(ushort\)

```csharp
public ReadOnlySpan<byte> GetUtf8Value(ushort symbol)
```

#### Parameters

`symbol` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_SymbolTable_SymbolTable_GetValue_System_UInt16_"></a> GetValue\(ushort\)

```csharp
public string GetValue(ushort symbol)
```

#### Parameters

`symbol` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

