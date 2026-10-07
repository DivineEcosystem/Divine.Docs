# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild"></a> Class CMsgClientToGCCancelInviteToGuild

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCancelInviteToGuild : IMessage<CMsgClientToGCCancelInviteToGuild>, IEquatable<CMsgClientToGCCancelInviteToGuild>, IDeepCloneable<CMsgClientToGCCancelInviteToGuild>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)

#### Implements

IMessage<CMsgClientToGCCancelInviteToGuild\>, 
[IEquatable<CMsgClientToGCCancelInviteToGuild\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCancelInviteToGuild\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCancelInviteToGuild\>\(CMsgClientToGCCancelInviteToGuild, params CMsgClientToGCCancelInviteToGuild\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild__ctor"></a> CMsgClientToGCCancelInviteToGuild\(\)

```csharp
public CMsgClientToGCCancelInviteToGuild()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_"></a> CMsgClientToGCCancelInviteToGuild\(CMsgClientToGCCancelInviteToGuild\)

```csharp
public CMsgClientToGCCancelInviteToGuild(CMsgClientToGCCancelInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCancelInviteToGuild> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCancelInviteToGuild Clone()
```

#### Returns

 [CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_"></a> Equals\(CMsgClientToGCCancelInviteToGuild\)

```csharp
public bool Equals(CMsgClientToGCCancelInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_"></a> MergeFrom\(CMsgClientToGCCancelInviteToGuild\)

```csharp
public void MergeFrom(CMsgClientToGCCancelInviteToGuild other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuild](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuild_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

