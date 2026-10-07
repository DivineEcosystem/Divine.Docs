# <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember"></a> Class CMsgGuildEventMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildEventMember : IMessage<CMsgGuildEventMember>, IEquatable<CMsgGuildEventMember>, IDeepCloneable<CMsgGuildEventMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)

#### Implements

IMessage<CMsgGuildEventMember\>, 
[IEquatable<CMsgGuildEventMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildEventMember\>, 
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
[EnumerableExtensions.In<CMsgGuildEventMember\>\(CMsgGuildEventMember, params CMsgGuildEventMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember__ctor"></a> CMsgGuildEventMember\(\)

```csharp
public CMsgGuildEventMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember__ctor_Divine_Protobufs_Dota2_CMsgGuildEventMember_"></a> CMsgGuildEventMember\(CMsgGuildEventMember\)

```csharp
public CMsgGuildEventMember(CMsgGuildEventMember other)
```

#### Parameters

`other` [CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_GuildPointsEarnedFieldNumber"></a> GuildPointsEarnedFieldNumber

```csharp
public const int GuildPointsEarnedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_GuildPointsEarned"></a> GuildPointsEarned

```csharp
public uint GuildPointsEarned { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_HasGuildPointsEarned"></a> HasGuildPointsEarned

```csharp
public bool HasGuildPointsEarned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildEventMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_ClearGuildPointsEarned"></a> ClearGuildPointsEarned\(\)

```csharp
public void ClearGuildPointsEarned()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_Clone"></a> Clone\(\)

```csharp
public CMsgGuildEventMember Clone()
```

#### Returns

 [CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_Equals_Divine_Protobufs_Dota2_CMsgGuildEventMember_"></a> Equals\(CMsgGuildEventMember\)

```csharp
public bool Equals(CMsgGuildEventMember other)
```

#### Parameters

`other` [CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildEventMember_"></a> MergeFrom\(CMsgGuildEventMember\)

```csharp
public void MergeFrom(CMsgGuildEventMember other)
```

#### Parameters

`other` [CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildEventMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

