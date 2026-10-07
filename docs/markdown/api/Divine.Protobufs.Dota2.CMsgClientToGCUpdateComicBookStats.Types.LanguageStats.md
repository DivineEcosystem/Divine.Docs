# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats"></a> Class CMsgClientToGCUpdateComicBookStats.Types.LanguageStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUpdateComicBookStats.Types.LanguageStats : IMessage<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats>, IEquatable<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats>, IDeepCloneable<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUpdateComicBookStats.Types.LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

#### Implements

IMessage<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats\>, 
[IEquatable<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats\>\(CMsgClientToGCUpdateComicBookStats.Types.LanguageStats, params CMsgClientToGCUpdateComicBookStats.Types.LanguageStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats__ctor"></a> LanguageStats\(\)

```csharp
public LanguageStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_"></a> LanguageStats\(LanguageStats\)

```csharp
public LanguageStats(CMsgClientToGCUpdateComicBookStats.Types.LanguageStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClientComicLanguageFieldNumber"></a> ClientComicLanguageFieldNumber

```csharp
public const int ClientComicLanguageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClientLanguageFieldNumber"></a> ClientLanguageFieldNumber

```csharp
public const int ClientLanguageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ComicIdFieldNumber"></a> ComicIdFieldNumber

```csharp
public const int ComicIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClientComicLanguage"></a> ClientComicLanguage

```csharp
public uint ClientComicLanguage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClientLanguage"></a> ClientLanguage

```csharp
public uint ClientLanguage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ComicId"></a> ComicId

```csharp
public uint ComicId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_HasClientComicLanguage"></a> HasClientComicLanguage

```csharp
public bool HasClientComicLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_HasClientLanguage"></a> HasClientLanguage

```csharp
public bool HasClientLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_HasComicId"></a> HasComicId

```csharp
public bool HasComicId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUpdateComicBookStats.Types.LanguageStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClearClientComicLanguage"></a> ClearClientComicLanguage\(\)

```csharp
public void ClearClientComicLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClearClientLanguage"></a> ClearClientLanguage\(\)

```csharp
public void ClearClientLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ClearComicId"></a> ClearComicId\(\)

```csharp
public void ClearComicId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUpdateComicBookStats.Types.LanguageStats Clone()
```

#### Returns

 [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_"></a> Equals\(LanguageStats\)

```csharp
public bool Equals(CMsgClientToGCUpdateComicBookStats.Types.LanguageStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_"></a> MergeFrom\(LanguageStats\)

```csharp
public void MergeFrom(CMsgClientToGCUpdateComicBookStats.Types.LanguageStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_LanguageStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

