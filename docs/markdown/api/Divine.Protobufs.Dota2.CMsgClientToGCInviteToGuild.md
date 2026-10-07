# <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild"></a> Class CMsgClientToGCInviteToGuild

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCInviteToGuild : IMessage<CMsgClientToGCInviteToGuild>, IEquatable<CMsgClientToGCInviteToGuild>, IDeepCloneable<CMsgClientToGCInviteToGuild>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)

#### Implements

IMessage<CMsgClientToGCInviteToGuild\>, 
[IEquatable<CMsgClientToGCInviteToGuild\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCInviteToGuild\>, 
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
[EnumerableExtensions.In<CMsgClientToGCInviteToGuild\>\(CMsgClientToGCInviteToGuild, params CMsgClientToGCInviteToGuild\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild__ctor"></a> CMsgClientToGCInviteToGuild\(\)

```csharp
public CMsgClientToGCInviteToGuild()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild__ctor_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_"></a> CMsgClientToGCInviteToGuild\(CMsgClientToGCInviteToGuild\)

```csharp
public CMsgClientToGCInviteToGuild(CMsgClientToGCInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCInviteToGuild> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCInviteToGuild Clone()
```

#### Returns

 [CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_Equals_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_"></a> Equals\(CMsgClientToGCInviteToGuild\)

```csharp
public bool Equals(CMsgClientToGCInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_"></a> MergeFrom\(CMsgClientToGCInviteToGuild\)

```csharp
public void MergeFrom(CMsgClientToGCInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuild_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

