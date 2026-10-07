# <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist"></a> Class CMsgCustomGameWhitelist

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCustomGameWhitelist : IMessage<CMsgCustomGameWhitelist>, IEquatable<CMsgCustomGameWhitelist>, IDeepCloneable<CMsgCustomGameWhitelist>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)

#### Implements

IMessage<CMsgCustomGameWhitelist\>, 
[IEquatable<CMsgCustomGameWhitelist\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCustomGameWhitelist\>, 
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
[EnumerableExtensions.In<CMsgCustomGameWhitelist\>\(CMsgCustomGameWhitelist, params CMsgCustomGameWhitelist\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist__ctor"></a> CMsgCustomGameWhitelist\(\)

```csharp
public CMsgCustomGameWhitelist()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist__ctor_Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_"></a> CMsgCustomGameWhitelist\(CMsgCustomGameWhitelist\)

```csharp
public CMsgCustomGameWhitelist(CMsgCustomGameWhitelist other)
```

#### Parameters

`other` [CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_CustomGamesWhitelistFieldNumber"></a> CustomGamesWhitelistFieldNumber

```csharp
public const int CustomGamesWhitelistFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_DisableWhitelistFieldNumber"></a> DisableWhitelistFieldNumber

```csharp
public const int DisableWhitelistFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_CustomGamesWhitelist"></a> CustomGamesWhitelist

```csharp
public RepeatedField<ulong> CustomGamesWhitelist { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_DisableWhitelist"></a> DisableWhitelist

```csharp
public bool DisableWhitelist { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_HasDisableWhitelist"></a> HasDisableWhitelist

```csharp
public bool HasDisableWhitelist { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCustomGameWhitelist> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_ClearDisableWhitelist"></a> ClearDisableWhitelist\(\)

```csharp
public void ClearDisableWhitelist()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Clone"></a> Clone\(\)

```csharp
public CMsgCustomGameWhitelist Clone()
```

#### Returns

 [CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_Equals_Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_"></a> Equals\(CMsgCustomGameWhitelist\)

```csharp
public bool Equals(CMsgCustomGameWhitelist other)
```

#### Parameters

`other` [CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_MergeFrom_Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_"></a> MergeFrom\(CMsgCustomGameWhitelist\)

```csharp
public void MergeFrom(CMsgCustomGameWhitelist other)
```

#### Parameters

`other` [CMsgCustomGameWhitelist](Divine.Protobufs.Dota2.CMsgCustomGameWhitelist.md)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameWhitelist_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

