# <a id="Divine_Helpers_Utility"></a> Class Utility

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.Common.dll  

```csharp
public static class Utility
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Utility](Divine.Helpers.Utility.md)

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

## Properties

### <a id="Divine_Helpers_Utility_IsValidAppName"></a> IsValidAppName

```csharp
public static bool IsValidAppName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Helpers_Utility_ClearDirectory_System_String_"></a> ClearDirectory\(string\)

```csharp
public static void ClearDirectory(string directory)
```

#### Parameters

`directory` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_CreateDirectoryEveryoneAccess_System_String_"></a> CreateDirectoryEveryoneAccess\(string\)

```csharp
public static void CreateDirectoryEveryoneAccess(string directory)
```

#### Parameters

`directory` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_GetAppDirectory"></a> GetAppDirectory\(\)

```csharp
public static string GetAppDirectory()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_GetBufferHash_System_Byte___"></a> GetBufferHash\(byte\[\]\)

```csharp
public static string GetBufferHash(byte[] buffer)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_GetFileHash_System_String_"></a> GetFileHash\(string\)

```csharp
public static string GetFileHash(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_GetFilesHash_System_Collections_Generic_IEnumerable_System_String__"></a> GetFilesHash\(IEnumerable<string\>\)

```csharp
public static string GetFilesHash(IEnumerable<string> files)
```

#### Parameters

`files` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_GetStringPtrLength_System_SByte__"></a> GetStringPtrLength\(sbyte\*\)

```csharp
public static int GetStringPtrLength(sbyte* str)
```

#### Parameters

`str` [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)\*

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Helpers_Utility_GetTextHash_System_String_"></a> GetTextHash\(string\)

```csharp
public static string GetTextHash(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_SetDirectoryEveryoneAccess_System_String_"></a> SetDirectoryEveryoneAccess\(string\)

```csharp
public static void SetDirectoryEveryoneAccess(string directory)
```

#### Parameters

`directory` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_SetDirectoryEveryoneAccess_System_IO_DirectoryInfo_"></a> SetDirectoryEveryoneAccess\(DirectoryInfo\)

```csharp
public static void SetDirectoryEveryoneAccess(DirectoryInfo directory)
```

#### Parameters

`directory` [DirectoryInfo](https://learn.microsoft.com/dotnet/api/system.io.directoryinfo)

### <a id="Divine_Helpers_Utility_UnblockDirectory_System_String_"></a> UnblockDirectory\(string\)

```csharp
public static void UnblockDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_Utility_UnblockFile_System_String_"></a> UnblockFile\(string\)

```csharp
public static bool UnblockFile(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

