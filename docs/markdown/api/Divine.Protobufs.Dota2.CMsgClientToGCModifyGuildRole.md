# <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole"></a> Class CMsgClientToGCModifyGuildRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCModifyGuildRole : IMessage<CMsgClientToGCModifyGuildRole>, IEquatable<CMsgClientToGCModifyGuildRole>, IDeepCloneable<CMsgClientToGCModifyGuildRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)

#### Implements

IMessage<CMsgClientToGCModifyGuildRole\>, 
[IEquatable<CMsgClientToGCModifyGuildRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCModifyGuildRole\>, 
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
[EnumerableExtensions.In<CMsgClientToGCModifyGuildRole\>\(CMsgClientToGCModifyGuildRole, params CMsgClientToGCModifyGuildRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole__ctor"></a> CMsgClientToGCModifyGuildRole\(\)

```csharp
public CMsgClientToGCModifyGuildRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole__ctor_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_"></a> CMsgClientToGCModifyGuildRole\(CMsgClientToGCModifyGuildRole\)

```csharp
public CMsgClientToGCModifyGuildRole(CMsgClientToGCModifyGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleFlagsFieldNumber"></a> RoleFlagsFieldNumber

```csharp
public const int RoleFlagsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleIdFieldNumber"></a> RoleIdFieldNumber

```csharp
public const int RoleIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleNameFieldNumber"></a> RoleNameFieldNumber

```csharp
public const int RoleNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_HasRoleFlags"></a> HasRoleFlags

```csharp
public bool HasRoleFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_HasRoleId"></a> HasRoleId

```csharp
public bool HasRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_HasRoleName"></a> HasRoleName

```csharp
public bool HasRoleName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCModifyGuildRole> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleFlags"></a> RoleFlags

```csharp
public uint RoleFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleId"></a> RoleId

```csharp
public uint RoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_RoleName"></a> RoleName

```csharp
public string RoleName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_ClearRoleFlags"></a> ClearRoleFlags\(\)

```csharp
public void ClearRoleFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_ClearRoleId"></a> ClearRoleId\(\)

```csharp
public void ClearRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_ClearRoleName"></a> ClearRoleName\(\)

```csharp
public void ClearRoleName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCModifyGuildRole Clone()
```

#### Returns

 [CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_Equals_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_"></a> Equals\(CMsgClientToGCModifyGuildRole\)

```csharp
public bool Equals(CMsgClientToGCModifyGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_"></a> MergeFrom\(CMsgClientToGCModifyGuildRole\)

```csharp
public void MergeFrom(CMsgClientToGCModifyGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

