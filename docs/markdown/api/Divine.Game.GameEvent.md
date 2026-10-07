# <a id="Divine_Game_GameEvent"></a> Class GameEvent

Namespace: [Divine.Game](Divine.Game.md)  
Assembly: Divine.dll  

```csharp
public sealed class GameEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameEvent](Divine.Game.GameEvent.md)

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
[EnumerableExtensions.In<GameEvent\>\(GameEvent, params GameEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Game_GameEvent_GameEvents"></a> GameEvents

```csharp
public static KeyValues GameEvents { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)

### <a id="Divine_Game_GameEvent_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Game_GameEvent_GetBoolean_System_String_"></a> GetBoolean\(string\)

```csharp
public bool GetBoolean(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameEvent_GetInt32_System_String_"></a> GetInt32\(string\)

```csharp
public int GetInt32(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Game_GameEvent_GetSingle_System_String_"></a> GetSingle\(string\)

```csharp
public float GetSingle(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameEvent_GetString_System_String_"></a> GetString\(string\)

```csharp
public string GetString(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Game_GameEvent_GetUInt64_System_String_"></a> GetUInt64\(string\)

```csharp
public ulong GetUInt64(string keyName)
```

#### Parameters

`keyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

