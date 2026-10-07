# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes"></a> Class CMsgClientToGCRequestContestVotes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestContestVotes : IMessage<CMsgClientToGCRequestContestVotes>, IEquatable<CMsgClientToGCRequestContestVotes>, IDeepCloneable<CMsgClientToGCRequestContestVotes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)

#### Implements

IMessage<CMsgClientToGCRequestContestVotes\>, 
[IEquatable<CMsgClientToGCRequestContestVotes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestContestVotes\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestContestVotes\>\(CMsgClientToGCRequestContestVotes, params CMsgClientToGCRequestContestVotes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes__ctor"></a> CMsgClientToGCRequestContestVotes\(\)

```csharp
public CMsgClientToGCRequestContestVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_"></a> CMsgClientToGCRequestContestVotes\(CMsgClientToGCRequestContestVotes\)

```csharp
public CMsgClientToGCRequestContestVotes(CMsgClientToGCRequestContestVotes other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_ContestIdFieldNumber"></a> ContestIdFieldNumber

```csharp
public const int ContestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_ContestId"></a> ContestId

```csharp
public uint ContestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_HasContestId"></a> HasContestId

```csharp
public bool HasContestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestContestVotes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_ClearContestId"></a> ClearContestId\(\)

```csharp
public void ClearContestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestContestVotes Clone()
```

#### Returns

 [CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_"></a> Equals\(CMsgClientToGCRequestContestVotes\)

```csharp
public bool Equals(CMsgClientToGCRequestContestVotes other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_"></a> MergeFrom\(CMsgClientToGCRequestContestVotes\)

```csharp
public void MergeFrom(CMsgClientToGCRequestContestVotes other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotes](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

