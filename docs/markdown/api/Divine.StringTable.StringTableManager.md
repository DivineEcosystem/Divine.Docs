# <a id="Divine_StringTable_StringTableManager"></a> Class StringTableManager

Namespace: [Divine.StringTable](Divine.StringTable.md)  
Assembly: Divine.dll  

```csharp
public static class StringTableManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[StringTableManager](Divine.StringTable.StringTableManager.md)

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

### <a id="Divine_StringTable_StringTableManager_FindTable_System_String_"></a> FindTable\(string\)

```csharp
public static StringTable? FindTable(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [StringTable](Divine.StringTable.StringTable.md)?

### <a id="Divine_StringTable_StringTableManager_GetTable_System_Int32_"></a> GetTable\(int\)

```csharp
public static StringTable? GetTable(int id)
```

#### Parameters

`id` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [StringTable](Divine.StringTable.StringTable.md)?

### <a id="Divine_StringTable_StringTableManager_GetTableCount"></a> GetTableCount\(\)

```csharp
public static int GetTableCount()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_StringTable_StringTableManager_AllTablesRemoved"></a> AllTablesRemoved

```csharp
public static event StringTableManager.AllTablesRemovedEventHandler AllTablesRemoved
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[AllTablesRemovedEventHandler](Divine.StringTable.StringTableManager.AllTablesRemovedEventHandler.md)

### <a id="Divine_StringTable_StringTableManager_AllTablesWillBeRemoved"></a> AllTablesWillBeRemoved

```csharp
public static event StringTableManager.AllTablesWillBeRemovedEventHandler AllTablesWillBeRemoved
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[AllTablesWillBeRemovedEventHandler](Divine.StringTable.StringTableManager.AllTablesWillBeRemovedEventHandler.md)

### <a id="Divine_StringTable_StringTableManager_TableAdded"></a> TableAdded

```csharp
public static event StringTableManager.TableAddedEventHandler TableAdded
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[TableAddedEventHandler](Divine.StringTable.StringTableManager.TableAddedEventHandler.md)

### <a id="Divine_StringTable_StringTableManager_TableChanged"></a> TableChanged

```csharp
public static event StringTableManager.TableChangedEventHandler TableChanged
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[TableChangedEventHandler](Divine.StringTable.StringTableManager.TableChangedEventHandler.md)

### <a id="Divine_StringTable_StringTableManager_TableDataUpdating"></a> TableDataUpdating

```csharp
public static event StringTableManager.TableDataUpdatingEventHandler TableDataUpdating
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[TableDataUpdatingEventHandler](Divine.StringTable.StringTableManager.TableDataUpdatingEventHandler.md)

### <a id="Divine_StringTable_StringTableManager_TableValueAdding"></a> TableValueAdding

```csharp
public static event StringTableManager.TableValueAddingEventHandler TableValueAdding
```

#### Event Type

 [StringTableManager](Divine.StringTable.StringTableManager.md).[TableValueAddingEventHandler](Divine.StringTable.StringTableManager.TableValueAddingEventHandler.md)

