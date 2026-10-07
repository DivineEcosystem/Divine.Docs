# <a id="Divine_SymbolTable_SymbolTableManager"></a> Class SymbolTableManager

Namespace: [Divine.SymbolTable](Divine.SymbolTable.md)  
Assembly: Divine.dll  

```csharp
public static class SymbolTableManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SymbolTableManager](Divine.SymbolTable.SymbolTableManager.md)

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

### <a id="Divine_SymbolTable_SymbolTableManager_Find_Divine_SymbolTable_SymbolTableId_System_String_"></a> Find\(SymbolTableId, string\)

```csharp
public static ushort Find(SymbolTableId id, string value)
```

#### Parameters

`id` [SymbolTableId](Divine.SymbolTable.SymbolTableId.md)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_SymbolTable_SymbolTableManager_Find_Divine_SymbolTable_SymbolTableId_System_ReadOnlySpan_System_Byte__"></a> Find\(SymbolTableId, ReadOnlySpan<byte\>\)

```csharp
public static ushort Find(SymbolTableId id, ReadOnlySpan<byte> value)
```

#### Parameters

`id` [SymbolTableId](Divine.SymbolTable.SymbolTableId.md)

`value` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_SymbolTable_SymbolTableManager_GetTable_Divine_SymbolTable_SymbolTableId_"></a> GetTable\(SymbolTableId\)

```csharp
public static SymbolTable GetTable(SymbolTableId id)
```

#### Parameters

`id` [SymbolTableId](Divine.SymbolTable.SymbolTableId.md)

#### Returns

 [SymbolTable](Divine.SymbolTable.SymbolTable.md)

### <a id="Divine_SymbolTable_SymbolTableManager_GetUtf8Value_Divine_SymbolTable_SymbolTableId_System_UInt16_"></a> GetUtf8Value\(SymbolTableId, ushort\)

```csharp
public static ReadOnlySpan<byte> GetUtf8Value(SymbolTableId id, ushort symbol)
```

#### Parameters

`id` [SymbolTableId](Divine.SymbolTable.SymbolTableId.md)

`symbol` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_SymbolTable_SymbolTableManager_GetValue_Divine_SymbolTable_SymbolTableId_System_UInt16_"></a> GetValue\(SymbolTableId, ushort\)

```csharp
public static string GetValue(SymbolTableId id, ushort symbol)
```

#### Parameters

`id` [SymbolTableId](Divine.SymbolTable.SymbolTableId.md)

`symbol` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

