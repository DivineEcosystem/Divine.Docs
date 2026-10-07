# <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App"></a> Class CPublishedFile\_GetUserFiles\_Response.Types.App

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_GetUserFiles_Response.Types.App : IMessage<CPublishedFile_GetUserFiles_Response.Types.App>, IEquatable<CPublishedFile_GetUserFiles_Response.Types.App>, IDeepCloneable<CPublishedFile_GetUserFiles_Response.Types.App>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_GetUserFiles\_Response.Types.App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)

#### Implements

IMessage<CPublishedFile\_GetUserFiles\_Response.Types.App\>, 
[IEquatable<CPublishedFile\_GetUserFiles\_Response.Types.App\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_GetUserFiles\_Response.Types.App\>, 
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
[EnumerableExtensions.In<CPublishedFile\_GetUserFiles\_Response.Types.App\>\(CPublishedFile\_GetUserFiles\_Response.Types.App, params CPublishedFile\_GetUserFiles\_Response.Types.App\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App__ctor"></a> App\(\)

```csharp
public App()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App__ctor_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_"></a> App\(App\)

```csharp
public App(CPublishedFile_GetUserFiles_Response.Types.App other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_PrivateFieldNumber"></a> PrivateFieldNumber

```csharp
public const int PrivateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ShortcutidFieldNumber"></a> ShortcutidFieldNumber

```csharp
public const int ShortcutidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_HasPrivate"></a> HasPrivate

```csharp
public bool HasPrivate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_HasShortcutid"></a> HasShortcutid

```csharp
public bool HasShortcutid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_GetUserFiles_Response.Types.App> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Private"></a> Private

```csharp
public bool Private { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Shortcutid"></a> Shortcutid

```csharp
public uint Shortcutid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ClearPrivate"></a> ClearPrivate\(\)

```csharp
public void ClearPrivate()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ClearShortcutid"></a> ClearShortcutid\(\)

```csharp
public void ClearShortcutid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_GetUserFiles_Response.Types.App Clone()
```

#### Returns

 [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_Equals_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_"></a> Equals\(App\)

```csharp
public bool Equals(CPublishedFile_GetUserFiles_Response.Types.App other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_"></a> MergeFrom\(App\)

```csharp
public void MergeFrom(CPublishedFile_GetUserFiles_Response.Types.App other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Types_App_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

