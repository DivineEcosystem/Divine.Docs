# <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate"></a> Class CMsgGCToClientArcanaVotesUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientArcanaVotesUpdate : IMessage<CMsgGCToClientArcanaVotesUpdate>, IEquatable<CMsgGCToClientArcanaVotesUpdate>, IDeepCloneable<CMsgGCToClientArcanaVotesUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)

#### Implements

IMessage<CMsgGCToClientArcanaVotesUpdate\>, 
[IEquatable<CMsgGCToClientArcanaVotesUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientArcanaVotesUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCToClientArcanaVotesUpdate\>\(CMsgGCToClientArcanaVotesUpdate, params CMsgGCToClientArcanaVotesUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate__ctor"></a> CMsgGCToClientArcanaVotesUpdate\(\)

```csharp
public CMsgGCToClientArcanaVotesUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_"></a> CMsgGCToClientArcanaVotesUpdate\(CMsgGCToClientArcanaVotesUpdate\)

```csharp
public CMsgGCToClientArcanaVotesUpdate(CMsgGCToClientArcanaVotesUpdate other)
```

#### Parameters

`other` [CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_ArcanaVotesFieldNumber"></a> ArcanaVotesFieldNumber

```csharp
public const int ArcanaVotesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_ArcanaVotes"></a> ArcanaVotes

```csharp
public CMsgClientToGCRequestArcanaVotesRemainingResponse ArcanaVotes { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientArcanaVotesUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientArcanaVotesUpdate Clone()
```

#### Returns

 [CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_"></a> Equals\(CMsgGCToClientArcanaVotesUpdate\)

```csharp
public bool Equals(CMsgGCToClientArcanaVotesUpdate other)
```

#### Parameters

`other` [CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_"></a> MergeFrom\(CMsgGCToClientArcanaVotesUpdate\)

```csharp
public void MergeFrom(CMsgGCToClientArcanaVotesUpdate other)
```

#### Parameters

`other` [CMsgGCToClientArcanaVotesUpdate](Divine.Protobufs.Dota2.CMsgGCToClientArcanaVotesUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientArcanaVotesUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

