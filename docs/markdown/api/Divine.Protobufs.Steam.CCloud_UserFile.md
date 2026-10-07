# <a id="Divine_Protobufs_Steam_CCloud_UserFile"></a> Class CCloud\_UserFile

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCloud_UserFile : IMessage<CCloud_UserFile>, IEquatable<CCloud_UserFile>, IDeepCloneable<CCloud_UserFile>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

#### Implements

IMessage<CCloud\_UserFile\>, 
[IEquatable<CCloud\_UserFile\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCloud\_UserFile\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CCloud\_UserFile\>\(CCloud\_UserFile, params CCloud\_UserFile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CCloud_UserFile__ctor"></a> CCloud\_UserFile\(\)

```csharp
public CCloud_UserFile()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile__ctor_Divine_Protobufs_Steam_CCloud_UserFile_"></a> CCloud\_UserFile\(CCloud\_UserFile\)

```csharp
public CCloud_UserFile(CCloud_UserFile other)
```

#### Parameters

`other` [CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

## Fields

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_FilenameFieldNumber"></a> FilenameFieldNumber

```csharp
public const int FilenameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_FileSizeFieldNumber"></a> FileSizeFieldNumber

```csharp
public const int FileSizeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_SteamidCreatorFieldNumber"></a> SteamidCreatorFieldNumber

```csharp
public const int SteamidCreatorFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_UgcidFieldNumber"></a> UgcidFieldNumber

```csharp
public const int UgcidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Filename"></a> Filename

```csharp
public string Filename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_FileSize"></a> FileSize

```csharp
public uint FileSize { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasFilename"></a> HasFilename

```csharp
public bool HasFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasFileSize"></a> HasFileSize

```csharp
public bool HasFileSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasSteamidCreator"></a> HasSteamidCreator

```csharp
public bool HasSteamidCreator { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasUgcid"></a> HasUgcid

```csharp
public bool HasUgcid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Parser"></a> Parser

```csharp
public static MessageParser<CCloud_UserFile> Parser { get; }
```

#### Property Value

 MessageParser<[CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)\>

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_SteamidCreator"></a> SteamidCreator

```csharp
public ulong SteamidCreator { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Timestamp"></a> Timestamp

```csharp
public ulong Timestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Ugcid"></a> Ugcid

```csharp
public ulong Ugcid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearFilename"></a> ClearFilename\(\)

```csharp
public void ClearFilename()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearFileSize"></a> ClearFileSize\(\)

```csharp
public void ClearFileSize()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearSteamidCreator"></a> ClearSteamidCreator\(\)

```csharp
public void ClearSteamidCreator()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearUgcid"></a> ClearUgcid\(\)

```csharp
public void ClearUgcid()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Clone"></a> Clone\(\)

```csharp
public CCloud_UserFile Clone()
```

#### Returns

 [CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_Equals_Divine_Protobufs_Steam_CCloud_UserFile_"></a> Equals\(CCloud\_UserFile\)

```csharp
public bool Equals(CCloud_UserFile other)
```

#### Parameters

`other` [CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_MergeFrom_Divine_Protobufs_Steam_CCloud_UserFile_"></a> MergeFrom\(CCloud\_UserFile\)

```csharp
public void MergeFrom(CCloud_UserFile other)
```

#### Parameters

`other` [CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_UserFile_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

