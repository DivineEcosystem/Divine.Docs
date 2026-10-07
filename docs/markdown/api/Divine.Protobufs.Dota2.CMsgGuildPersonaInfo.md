# <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo"></a> Class CMsgGuildPersonaInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildPersonaInfo : IMessage<CMsgGuildPersonaInfo>, IEquatable<CMsgGuildPersonaInfo>, IDeepCloneable<CMsgGuildPersonaInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)

#### Implements

IMessage<CMsgGuildPersonaInfo\>, 
[IEquatable<CMsgGuildPersonaInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildPersonaInfo\>, 
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
[EnumerableExtensions.In<CMsgGuildPersonaInfo\>\(CMsgGuildPersonaInfo, params CMsgGuildPersonaInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo__ctor"></a> CMsgGuildPersonaInfo\(\)

```csharp
public CMsgGuildPersonaInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo__ctor_Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_"></a> CMsgGuildPersonaInfo\(CMsgGuildPersonaInfo\)

```csharp
public CMsgGuildPersonaInfo(CMsgGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildFlagsFieldNumber"></a> GuildFlagsFieldNumber

```csharp
public const int GuildFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildTagFieldNumber"></a> GuildTagFieldNumber

```csharp
public const int GuildTagFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildFlags"></a> GuildFlags

```csharp
public uint GuildFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GuildTag"></a> GuildTag

```csharp
public string GuildTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_HasGuildFlags"></a> HasGuildFlags

```csharp
public bool HasGuildFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_HasGuildTag"></a> HasGuildTag

```csharp
public bool HasGuildTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildPersonaInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_ClearGuildFlags"></a> ClearGuildFlags\(\)

```csharp
public void ClearGuildFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_ClearGuildTag"></a> ClearGuildTag\(\)

```csharp
public void ClearGuildTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGuildPersonaInfo Clone()
```

#### Returns

 [CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_Equals_Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_"></a> Equals\(CMsgGuildPersonaInfo\)

```csharp
public bool Equals(CMsgGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_"></a> MergeFrom\(CMsgGuildPersonaInfo\)

```csharp
public void MergeFrom(CMsgGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildPersonaInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

