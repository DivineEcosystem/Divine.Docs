# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole"></a> Class CMsgClientToGCRemoveGuildRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRemoveGuildRole : IMessage<CMsgClientToGCRemoveGuildRole>, IEquatable<CMsgClientToGCRemoveGuildRole>, IDeepCloneable<CMsgClientToGCRemoveGuildRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)

#### Implements

IMessage<CMsgClientToGCRemoveGuildRole\>, 
[IEquatable<CMsgClientToGCRemoveGuildRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRemoveGuildRole\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRemoveGuildRole\>\(CMsgClientToGCRemoveGuildRole, params CMsgClientToGCRemoveGuildRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole__ctor"></a> CMsgClientToGCRemoveGuildRole\(\)

```csharp
public CMsgClientToGCRemoveGuildRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_"></a> CMsgClientToGCRemoveGuildRole\(CMsgClientToGCRemoveGuildRole\)

```csharp
public CMsgClientToGCRemoveGuildRole(CMsgClientToGCRemoveGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_RoleIdFieldNumber"></a> RoleIdFieldNumber

```csharp
public const int RoleIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_HasRoleId"></a> HasRoleId

```csharp
public bool HasRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRemoveGuildRole> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_RoleId"></a> RoleId

```csharp
public uint RoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_ClearRoleId"></a> ClearRoleId\(\)

```csharp
public void ClearRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRemoveGuildRole Clone()
```

#### Returns

 [CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_"></a> Equals\(CMsgClientToGCRemoveGuildRole\)

```csharp
public bool Equals(CMsgClientToGCRemoveGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_"></a> MergeFrom\(CMsgClientToGCRemoveGuildRole\)

```csharp
public void MergeFrom(CMsgClientToGCRemoveGuildRole other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRole](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRole.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

