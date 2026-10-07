# <a id="Divine_Protobufs_Dota2_CMsgGuildRole"></a> Class CMsgGuildRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildRole : IMessage<CMsgGuildRole>, IEquatable<CMsgGuildRole>, IDeepCloneable<CMsgGuildRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)

#### Implements

IMessage<CMsgGuildRole\>, 
[IEquatable<CMsgGuildRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildRole\>, 
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
[EnumerableExtensions.In<CMsgGuildRole\>\(CMsgGuildRole, params CMsgGuildRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole__ctor"></a> CMsgGuildRole\(\)

```csharp
public CMsgGuildRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole__ctor_Divine_Protobufs_Dota2_CMsgGuildRole_"></a> CMsgGuildRole\(CMsgGuildRole\)

```csharp
public CMsgGuildRole(CMsgGuildRole other)
```

#### Parameters

`other` [CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleFlagsFieldNumber"></a> RoleFlagsFieldNumber

```csharp
public const int RoleFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleIdFieldNumber"></a> RoleIdFieldNumber

```csharp
public const int RoleIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleNameFieldNumber"></a> RoleNameFieldNumber

```csharp
public const int RoleNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleOrderFieldNumber"></a> RoleOrderFieldNumber

```csharp
public const int RoleOrderFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_HasRoleFlags"></a> HasRoleFlags

```csharp
public bool HasRoleFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_HasRoleId"></a> HasRoleId

```csharp
public bool HasRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_HasRoleName"></a> HasRoleName

```csharp
public bool HasRoleName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_HasRoleOrder"></a> HasRoleOrder

```csharp
public bool HasRoleOrder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildRole> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleFlags"></a> RoleFlags

```csharp
public uint RoleFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleId"></a> RoleId

```csharp
public uint RoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleName"></a> RoleName

```csharp
public string RoleName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_RoleOrder"></a> RoleOrder

```csharp
public uint RoleOrder { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_ClearRoleFlags"></a> ClearRoleFlags\(\)

```csharp
public void ClearRoleFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_ClearRoleId"></a> ClearRoleId\(\)

```csharp
public void ClearRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_ClearRoleName"></a> ClearRoleName\(\)

```csharp
public void ClearRoleName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_ClearRoleOrder"></a> ClearRoleOrder\(\)

```csharp
public void ClearRoleOrder()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_Clone"></a> Clone\(\)

```csharp
public CMsgGuildRole Clone()
```

#### Returns

 [CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_Equals_Divine_Protobufs_Dota2_CMsgGuildRole_"></a> Equals\(CMsgGuildRole\)

```csharp
public bool Equals(CMsgGuildRole other)
```

#### Parameters

`other` [CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildRole_"></a> MergeFrom\(CMsgGuildRole\)

```csharp
public void MergeFrom(CMsgGuildRole other)
```

#### Parameters

`other` [CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

