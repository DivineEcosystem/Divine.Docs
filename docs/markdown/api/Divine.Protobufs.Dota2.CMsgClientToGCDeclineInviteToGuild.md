# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild"></a> Class CMsgClientToGCDeclineInviteToGuild

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDeclineInviteToGuild : IMessage<CMsgClientToGCDeclineInviteToGuild>, IEquatable<CMsgClientToGCDeclineInviteToGuild>, IDeepCloneable<CMsgClientToGCDeclineInviteToGuild>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)

#### Implements

IMessage<CMsgClientToGCDeclineInviteToGuild\>, 
[IEquatable<CMsgClientToGCDeclineInviteToGuild\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDeclineInviteToGuild\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDeclineInviteToGuild\>\(CMsgClientToGCDeclineInviteToGuild, params CMsgClientToGCDeclineInviteToGuild\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild__ctor"></a> CMsgClientToGCDeclineInviteToGuild\(\)

```csharp
public CMsgClientToGCDeclineInviteToGuild()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_"></a> CMsgClientToGCDeclineInviteToGuild\(CMsgClientToGCDeclineInviteToGuild\)

```csharp
public CMsgClientToGCDeclineInviteToGuild(CMsgClientToGCDeclineInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDeclineInviteToGuild> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDeclineInviteToGuild Clone()
```

#### Returns

 [CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_"></a> Equals\(CMsgClientToGCDeclineInviteToGuild\)

```csharp
public bool Equals(CMsgClientToGCDeclineInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_"></a> MergeFrom\(CMsgClientToGCDeclineInviteToGuild\)

```csharp
public void MergeFrom(CMsgClientToGCDeclineInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuild_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

