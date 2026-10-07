# <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember"></a> Class CMsgClientToGCKickGuildMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCKickGuildMember : IMessage<CMsgClientToGCKickGuildMember>, IEquatable<CMsgClientToGCKickGuildMember>, IDeepCloneable<CMsgClientToGCKickGuildMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)

#### Implements

IMessage<CMsgClientToGCKickGuildMember\>, 
[IEquatable<CMsgClientToGCKickGuildMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCKickGuildMember\>, 
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
[EnumerableExtensions.In<CMsgClientToGCKickGuildMember\>\(CMsgClientToGCKickGuildMember, params CMsgClientToGCKickGuildMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember__ctor"></a> CMsgClientToGCKickGuildMember\(\)

```csharp
public CMsgClientToGCKickGuildMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember__ctor_Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_"></a> CMsgClientToGCKickGuildMember\(CMsgClientToGCKickGuildMember\)

```csharp
public CMsgClientToGCKickGuildMember(CMsgClientToGCKickGuildMember other)
```

#### Parameters

`other` [CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCKickGuildMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCKickGuildMember Clone()
```

#### Returns

 [CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_Equals_Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_"></a> Equals\(CMsgClientToGCKickGuildMember\)

```csharp
public bool Equals(CMsgClientToGCKickGuildMember other)
```

#### Parameters

`other` [CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_"></a> MergeFrom\(CMsgClientToGCKickGuildMember\)

```csharp
public void MergeFrom(CMsgClientToGCKickGuildMember other)
```

#### Parameters

`other` [CMsgClientToGCKickGuildMember](Divine.Protobufs.Dota2.CMsgClientToGCKickGuildMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCKickGuildMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

