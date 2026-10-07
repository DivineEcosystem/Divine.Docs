# <a id="Divine_Protobufs_Dota2_CMsgGuildInvite"></a> Class CMsgGuildInvite

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildInvite : IMessage<CMsgGuildInvite>, IEquatable<CMsgGuildInvite>, IDeepCloneable<CMsgGuildInvite>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)

#### Implements

IMessage<CMsgGuildInvite\>, 
[IEquatable<CMsgGuildInvite\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildInvite\>, 
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
[EnumerableExtensions.In<CMsgGuildInvite\>\(CMsgGuildInvite, params CMsgGuildInvite\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite__ctor"></a> CMsgGuildInvite\(\)

```csharp
public CMsgGuildInvite()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite__ctor_Divine_Protobufs_Dota2_CMsgGuildInvite_"></a> CMsgGuildInvite\(CMsgGuildInvite\)

```csharp
public CMsgGuildInvite(CMsgGuildInvite other)
```

#### Parameters

`other` [CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_RequesterAccountIdFieldNumber"></a> RequesterAccountIdFieldNumber

```csharp
public const int RequesterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_TimestampSentFieldNumber"></a> TimestampSentFieldNumber

```csharp
public const int TimestampSentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_HasRequesterAccountId"></a> HasRequesterAccountId

```csharp
public bool HasRequesterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_HasTimestampSent"></a> HasTimestampSent

```csharp
public bool HasTimestampSent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildInvite> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_RequesterAccountId"></a> RequesterAccountId

```csharp
public uint RequesterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_TimestampSent"></a> TimestampSent

```csharp
public uint TimestampSent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_ClearRequesterAccountId"></a> ClearRequesterAccountId\(\)

```csharp
public void ClearRequesterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_ClearTimestampSent"></a> ClearTimestampSent\(\)

```csharp
public void ClearTimestampSent()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_Clone"></a> Clone\(\)

```csharp
public CMsgGuildInvite Clone()
```

#### Returns

 [CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_Equals_Divine_Protobufs_Dota2_CMsgGuildInvite_"></a> Equals\(CMsgGuildInvite\)

```csharp
public bool Equals(CMsgGuildInvite other)
```

#### Parameters

`other` [CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildInvite_"></a> MergeFrom\(CMsgGuildInvite\)

```csharp
public void MergeFrom(CMsgGuildInvite other)
```

#### Parameters

`other` [CMsgGuildInvite](Divine.Protobufs.Dota2.CMsgGuildInvite.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildInvite_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

