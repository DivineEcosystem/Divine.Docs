# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole"></a> Class CMsgClientToGCSetGuildMemberRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetGuildMemberRole : IMessage<CMsgClientToGCSetGuildMemberRole>, IEquatable<CMsgClientToGCSetGuildMemberRole>, IDeepCloneable<CMsgClientToGCSetGuildMemberRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)

#### Implements

IMessage<CMsgClientToGCSetGuildMemberRole\>, 
[IEquatable<CMsgClientToGCSetGuildMemberRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetGuildMemberRole\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetGuildMemberRole\>\(CMsgClientToGCSetGuildMemberRole, params CMsgClientToGCSetGuildMemberRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole__ctor"></a> CMsgClientToGCSetGuildMemberRole\(\)

```csharp
public CMsgClientToGCSetGuildMemberRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_"></a> CMsgClientToGCSetGuildMemberRole\(CMsgClientToGCSetGuildMemberRole\)

```csharp
public CMsgClientToGCSetGuildMemberRole(CMsgClientToGCSetGuildMemberRole other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_TargetRoleIdFieldNumber"></a> TargetRoleIdFieldNumber

```csharp
public const int TargetRoleIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_HasTargetRoleId"></a> HasTargetRoleId

```csharp
public bool HasTargetRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetGuildMemberRole> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_TargetRoleId"></a> TargetRoleId

```csharp
public uint TargetRoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_ClearTargetRoleId"></a> ClearTargetRoleId\(\)

```csharp
public void ClearTargetRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetGuildMemberRole Clone()
```

#### Returns

 [CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_"></a> Equals\(CMsgClientToGCSetGuildMemberRole\)

```csharp
public bool Equals(CMsgClientToGCSetGuildMemberRole other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_"></a> MergeFrom\(CMsgClientToGCSetGuildMemberRole\)

```csharp
public void MergeFrom(CMsgClientToGCSetGuildMemberRole other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRole](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

