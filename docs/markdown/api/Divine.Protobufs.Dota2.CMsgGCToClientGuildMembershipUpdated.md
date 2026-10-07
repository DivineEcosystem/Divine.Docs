# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated"></a> Class CMsgGCToClientGuildMembershipUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGuildMembershipUpdated : IMessage<CMsgGCToClientGuildMembershipUpdated>, IEquatable<CMsgGCToClientGuildMembershipUpdated>, IDeepCloneable<CMsgGCToClientGuildMembershipUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)

#### Implements

IMessage<CMsgGCToClientGuildMembershipUpdated\>, 
[IEquatable<CMsgGCToClientGuildMembershipUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGuildMembershipUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGuildMembershipUpdated\>\(CMsgGCToClientGuildMembershipUpdated, params CMsgGCToClientGuildMembershipUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated__ctor"></a> CMsgGCToClientGuildMembershipUpdated\(\)

```csharp
public CMsgGCToClientGuildMembershipUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_"></a> CMsgGCToClientGuildMembershipUpdated\(CMsgGCToClientGuildMembershipUpdated\)

```csharp
public CMsgGCToClientGuildMembershipUpdated(CMsgGCToClientGuildMembershipUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_GuildMembershipsFieldNumber"></a> GuildMembershipsFieldNumber

```csharp
public const int GuildMembershipsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_GuildMemberships"></a> GuildMemberships

```csharp
public CMsgAccountGuildMemberships GuildMemberships { get; set; }
```

#### Property Value

 [CMsgAccountGuildMemberships](Divine.Protobufs.Dota2.CMsgAccountGuildMemberships.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGuildMembershipUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGuildMembershipUpdated Clone()
```

#### Returns

 [CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_"></a> Equals\(CMsgGCToClientGuildMembershipUpdated\)

```csharp
public bool Equals(CMsgGCToClientGuildMembershipUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_"></a> MergeFrom\(CMsgGCToClientGuildMembershipUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientGuildMembershipUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildMembershipUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildMembershipUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildMembershipUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

