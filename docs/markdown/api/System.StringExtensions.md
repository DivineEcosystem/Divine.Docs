# <a id="System_StringExtensions"></a> Class StringExtensions

Namespace: [System](System.md)  
Assembly: Divine.Common.dll  

```csharp
public static class StringExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[StringExtensions](System.StringExtensions.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="System_StringExtensions_EndsWith_System_String_System_StringComparison_System_ReadOnlySpan_System_String__"></a> EndsWith\(string, StringComparison, params ReadOnlySpan<string\>\)

```csharp
public static bool EndsWith(this string str, StringComparison comparisonType, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`comparisonType` [StringComparison](https://learn.microsoft.com/dotnet/api/system.stringcomparison)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_EndsWith_System_String_System_ReadOnlySpan_System_Char__"></a> EndsWith\(string, params ReadOnlySpan<char\>\)

```csharp
public static bool EndsWith(this string str, params ReadOnlySpan<char> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_EndsWith_System_String_System_ReadOnlySpan_System_String__"></a> EndsWith\(string, params ReadOnlySpan<string\>\)

```csharp
public static bool EndsWith(this string str, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_EndsWith_System_String_System_Boolean_System_Globalization_CultureInfo_System_ReadOnlySpan_System_String__"></a> EndsWith\(string, bool, CultureInfo?, params ReadOnlySpan<string\>\)

```csharp
public static bool EndsWith(this string str, bool ignoreCase, CultureInfo? culture, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ignoreCase` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)?

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_StartsWith_System_String_System_StringComparison_System_ReadOnlySpan_System_String__"></a> StartsWith\(string, StringComparison, params ReadOnlySpan<string\>\)

```csharp
public static bool StartsWith(this string str, StringComparison comparisonType, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`comparisonType` [StringComparison](https://learn.microsoft.com/dotnet/api/system.stringcomparison)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_StartsWith_System_String_System_ReadOnlySpan_System_Char__"></a> StartsWith\(string, params ReadOnlySpan<char\>\)

```csharp
public static bool StartsWith(this string str, params ReadOnlySpan<char> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_StartsWith_System_String_System_ReadOnlySpan_System_String__"></a> StartsWith\(string, params ReadOnlySpan<string\>\)

```csharp
public static bool StartsWith(this string str, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="System_StringExtensions_StartsWith_System_String_System_Boolean_System_Globalization_CultureInfo_System_ReadOnlySpan_System_String__"></a> StartsWith\(string, bool, CultureInfo?, params ReadOnlySpan<string\>\)

```csharp
public static bool StartsWith(this string str, bool ignoreCase, CultureInfo? culture, params ReadOnlySpan<string> values)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ignoreCase` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)?

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

