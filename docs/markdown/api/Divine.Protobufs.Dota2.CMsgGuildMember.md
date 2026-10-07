# <a id="Divine_Protobufs_Dota2_CMsgGuildMember"></a> Class CMsgGuildMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildMember : IMessage<CMsgGuildMember>, IEquatable<CMsgGuildMember>, IDeepCloneable<CMsgGuildMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)

#### Implements

IMessage<CMsgGuildMember\>, 
[IEquatable<CMsgGuildMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildMember\>, 
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
[EnumerableExtensions.In<CMsgGuildMember\>\(CMsgGuildMember, params CMsgGuildMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember__ctor"></a> CMsgGuildMember\(\)

```csharp
public CMsgGuildMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember__ctor_Divine_Protobufs_Dota2_CMsgGuildMember_"></a> CMsgGuildMember\(CMsgGuildMember\)

```csharp
public CMsgGuildMember(CMsgGuildMember other)
```

#### Parameters

`other` [CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberAccountIdFieldNumber"></a> MemberAccountIdFieldNumber

```csharp
public const int MemberAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberJoinedTimestampFieldNumber"></a> MemberJoinedTimestampFieldNumber

```csharp
public const int MemberJoinedTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberLastActiveTimestampFieldNumber"></a> MemberLastActiveTimestampFieldNumber

```csharp
public const int MemberLastActiveTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberRoleIdFieldNumber"></a> MemberRoleIdFieldNumber

```csharp
public const int MemberRoleIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_HasMemberAccountId"></a> HasMemberAccountId

```csharp
public bool HasMemberAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_HasMemberJoinedTimestamp"></a> HasMemberJoinedTimestamp

```csharp
public bool HasMemberJoinedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_HasMemberLastActiveTimestamp"></a> HasMemberLastActiveTimestamp

```csharp
public bool HasMemberLastActiveTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_HasMemberRoleId"></a> HasMemberRoleId

```csharp
public bool HasMemberRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberAccountId"></a> MemberAccountId

```csharp
public uint MemberAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberJoinedTimestamp"></a> MemberJoinedTimestamp

```csharp
public uint MemberJoinedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberLastActiveTimestamp"></a> MemberLastActiveTimestamp

```csharp
public uint MemberLastActiveTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MemberRoleId"></a> MemberRoleId

```csharp
public uint MemberRoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_ClearMemberAccountId"></a> ClearMemberAccountId\(\)

```csharp
public void ClearMemberAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_ClearMemberJoinedTimestamp"></a> ClearMemberJoinedTimestamp\(\)

```csharp
public void ClearMemberJoinedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_ClearMemberLastActiveTimestamp"></a> ClearMemberLastActiveTimestamp\(\)

```csharp
public void ClearMemberLastActiveTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_ClearMemberRoleId"></a> ClearMemberRoleId\(\)

```csharp
public void ClearMemberRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_Clone"></a> Clone\(\)

```csharp
public CMsgGuildMember Clone()
```

#### Returns

 [CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_Equals_Divine_Protobufs_Dota2_CMsgGuildMember_"></a> Equals\(CMsgGuildMember\)

```csharp
public bool Equals(CMsgGuildMember other)
```

#### Parameters

`other` [CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildMember_"></a> MergeFrom\(CMsgGuildMember\)

```csharp
public void MergeFrom(CMsgGuildMember other)
```

#### Parameters

`other` [CMsgGuildMember](Divine.Protobufs.Dota2.CMsgGuildMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

