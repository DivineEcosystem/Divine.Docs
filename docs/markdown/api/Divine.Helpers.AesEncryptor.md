# <a id="Divine_Helpers_AesEncryptor"></a> Class AesEncryptor

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.Common.dll  

```csharp
public static class AesEncryptor
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AesEncryptor](Divine.Helpers.AesEncryptor.md)

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

### <a id="Divine_Helpers_AesEncryptor_Decrypt_System_String_System_String_"></a> Decrypt\(string, string\)

```csharp
public static string Decrypt(string cipherText, string key)
```

#### Parameters

`cipherText` [string](https://learn.microsoft.com/dotnet/api/system.string)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_AesEncryptor_Decrypt_System_Byte___System_String_"></a> Decrypt\(byte\[\], string\)

```csharp
public static byte[] Decrypt(byte[] buffer, string key)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Helpers_AesEncryptor_Decrypt_System_IO_Stream_System_String_"></a> Decrypt\(Stream, string\)

```csharp
public static Stream Decrypt(Stream source, string key)
```

#### Parameters

`source` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="Divine_Helpers_AesEncryptor_Decrypt_System_IO_Stream_System_IO_Stream_System_String_"></a> Decrypt\(Stream, Stream, string\)

```csharp
public static void Decrypt(Stream source, Stream destination, string key)
```

#### Parameters

`source` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`destination` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_AesEncryptor_Encrypt_System_String_System_String_"></a> Encrypt\(string, string\)

```csharp
public static string Encrypt(string plainText, string key)
```

#### Parameters

`plainText` [string](https://learn.microsoft.com/dotnet/api/system.string)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_AesEncryptor_Encrypt_System_Byte___System_String_"></a> Encrypt\(byte\[\], string\)

```csharp
public static byte[] Encrypt(byte[] buffer, string key)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Helpers_AesEncryptor_Encrypt_System_IO_Stream_System_String_"></a> Encrypt\(Stream, string\)

```csharp
public static Stream Encrypt(Stream source, string key)
```

#### Parameters

`source` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="Divine_Helpers_AesEncryptor_Encrypt_System_IO_Stream_System_IO_Stream_System_String_"></a> Encrypt\(Stream, Stream, string\)

```csharp
public static void Encrypt(Stream source, Stream destination, string key)
```

#### Parameters

`source` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`destination` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

