# <a id="Divine_Protobufs_Dota2_CMsgGuildData"></a> Class CMsgGuildData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildData : IMessage<CMsgGuildData>, IEquatable<CMsgGuildData>, IDeepCloneable<CMsgGuildData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

#### Implements

IMessage<CMsgGuildData\>, 
[IEquatable<CMsgGuildData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildData\>, 
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
[EnumerableExtensions.In<CMsgGuildData\>\(CMsgGuildData, params CMsgGuildData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildData__ctor"></a> CMsgGuildData\(\)

```csharp
public CMsgGuildData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildData__ctor_Divine_Protobufs_Dota2_CMsgGuildData_"></a> CMsgGuildData\(CMsgGuildData\)

```csharp
public CMsgGuildData(CMsgGuildData other)
```

#### Parameters

`other` [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildInfoFieldNumber"></a> GuildInfoFieldNumber

```csharp
public const int GuildInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildInvitesFieldNumber"></a> GuildInvitesFieldNumber

```csharp
public const int GuildInvitesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildMembersFieldNumber"></a> GuildMembersFieldNumber

```csharp
public const int GuildMembersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildRolesFieldNumber"></a> GuildRolesFieldNumber

```csharp
public const int GuildRolesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildInfo"></a> GuildInfo

```csharp
public CMsgGuildInfo GuildInfo { get; set; }
```

#### Property Value

 [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildInvites"></a> GuildInvites

```csharp
public RepeatedField<CMsgGuildInvite> GuildInvites { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildMembers"></a> GuildMembers

```csharp
public RepeatedField<CMsgGuildMember> GuildMembers { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GuildRoles"></a> GuildRoles

```csharp
public RepeatedField<CMsgGuildRole> GuildRoles { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildRole](Divine.Protobufs.Dota2.CMsgGuildRole.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_Clone"></a> Clone\(\)

```csharp
public CMsgGuildData Clone()
```

#### Returns

 [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_Equals_Divine_Protobufs_Dota2_CMsgGuildData_"></a> Equals\(CMsgGuildData\)

```csharp
public bool Equals(CMsgGuildData other)
```

#### Parameters

`other` [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildData_"></a> MergeFrom\(CMsgGuildData\)

```csharp
public void MergeFrom(CMsgGuildData other)
```

#### Parameters

`other` [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

