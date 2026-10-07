# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild"></a> Class CMsgClientToGCCreateGuild

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateGuild : IMessage<CMsgClientToGCCreateGuild>, IEquatable<CMsgClientToGCCreateGuild>, IDeepCloneable<CMsgClientToGCCreateGuild>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)

#### Implements

IMessage<CMsgClientToGCCreateGuild\>, 
[IEquatable<CMsgClientToGCCreateGuild\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateGuild\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateGuild\>\(CMsgClientToGCCreateGuild, params CMsgClientToGCCreateGuild\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild__ctor"></a> CMsgClientToGCCreateGuild\(\)

```csharp
public CMsgClientToGCCreateGuild()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_"></a> CMsgClientToGCCreateGuild\(CMsgClientToGCCreateGuild\)

```csharp
public CMsgClientToGCCreateGuild(CMsgClientToGCCreateGuild other)
```

#### Parameters

`other` [CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_GuildChatTypeFieldNumber"></a> GuildChatTypeFieldNumber

```csharp
public const int GuildChatTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_GuildInfoFieldNumber"></a> GuildInfoFieldNumber

```csharp
public const int GuildInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_GuildChatType"></a> GuildChatType

```csharp
public EGuildChatType GuildChatType { get; set; }
```

#### Property Value

 [EGuildChatType](Divine.Protobufs.Dota2.EGuildChatType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_GuildInfo"></a> GuildInfo

```csharp
public CMsgGuildInfo GuildInfo { get; set; }
```

#### Property Value

 [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_HasGuildChatType"></a> HasGuildChatType

```csharp
public bool HasGuildChatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateGuild> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_ClearGuildChatType"></a> ClearGuildChatType\(\)

```csharp
public void ClearGuildChatType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateGuild Clone()
```

#### Returns

 [CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_"></a> Equals\(CMsgClientToGCCreateGuild\)

```csharp
public bool Equals(CMsgClientToGCCreateGuild other)
```

#### Parameters

`other` [CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_"></a> MergeFrom\(CMsgClientToGCCreateGuild\)

```csharp
public void MergeFrom(CMsgClientToGCCreateGuild other)
```

#### Parameters

`other` [CMsgClientToGCCreateGuild](Divine.Protobufs.Dota2.CMsgClientToGCCreateGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateGuild_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

