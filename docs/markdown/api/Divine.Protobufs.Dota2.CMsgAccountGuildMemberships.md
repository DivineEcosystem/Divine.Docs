# <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships"></a> Class CMsgAccountGuildMemberships

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAccountGuildMemberships : IMessage<CMsgAccountGuildMemberships>, IEquatable<CMsgAccountGuildMemberships>, IDeepCloneable<CMsgAccountGuildMemberships>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

#### Implements

IMessage<CMsgAccountGuildMemberships\>, 
[IEquatable<CMsgAccountGuildMemberships\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAccountGuildMemberships\>, 
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
[EnumerableExtensions.In<CMsgAccountGuildMemberships\>\(CMsgAccountGuildMemberships, params CMsgAccountGuildMemberships\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships__ctor"></a> CMsgAccountGuildMemberships\(\)

```csharp
public CMsgAccountGuildMemberships()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships__ctor_Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_"></a> CMsgAccountGuildMemberships\(CMsgAccountGuildMemberships\)

```csharp
public CMsgAccountGuildMemberships(CMsgAccountGuildMemberships other)
```

#### Parameters

`other` [CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_GuildIdsFieldNumber"></a> GuildIdsFieldNumber

```csharp
public const int GuildIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_GuildInvitesFieldNumber"></a> GuildInvitesFieldNumber

```csharp
public const int GuildInvitesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_GuildIds"></a> GuildIds

```csharp
public RepeatedField<uint> GuildIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_GuildInvites"></a> GuildInvites

```csharp
public RepeatedField<CMsgAccountGuildInvite> GuildInvites { get; }
```

#### Property Value

 RepeatedField<[CMsgAccountGuildInvite](Divine.Protobufs.Dota2.CMsgAccountGuildInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAccountGuildMemberships> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_Clone"></a> Clone\(\)

```csharp
public CMsgAccountGuildMemberships Clone()
```

#### Returns

 [CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_Equals_Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_"></a> Equals\(CMsgAccountGuildMemberships\)

```csharp
public bool Equals(CMsgAccountGuildMemberships other)
```

#### Parameters

`other` [CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_MergeFrom_Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_"></a> MergeFrom\(CMsgAccountGuildMemberships\)

```csharp
public void MergeFrom(CMsgAccountGuildMemberships other)
```

#### Parameters

`other` [CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildMemberships_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

