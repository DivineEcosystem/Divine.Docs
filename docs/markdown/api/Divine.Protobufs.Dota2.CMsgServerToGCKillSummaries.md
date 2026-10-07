# <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries"></a> Class CMsgServerToGCKillSummaries

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCKillSummaries : IMessage<CMsgServerToGCKillSummaries>, IEquatable<CMsgServerToGCKillSummaries>, IDeepCloneable<CMsgServerToGCKillSummaries>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)

#### Implements

IMessage<CMsgServerToGCKillSummaries\>, 
[IEquatable<CMsgServerToGCKillSummaries\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCKillSummaries\>, 
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
[EnumerableExtensions.In<CMsgServerToGCKillSummaries\>\(CMsgServerToGCKillSummaries, params CMsgServerToGCKillSummaries\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries__ctor"></a> CMsgServerToGCKillSummaries\(\)

```csharp
public CMsgServerToGCKillSummaries()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries__ctor_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_"></a> CMsgServerToGCKillSummaries\(CMsgServerToGCKillSummaries\)

```csharp
public CMsgServerToGCKillSummaries(CMsgServerToGCKillSummaries other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_IngameeventIdFieldNumber"></a> IngameeventIdFieldNumber

```csharp
public const int IngameeventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_SummariesFieldNumber"></a> SummariesFieldNumber

```csharp
public const int SummariesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_HasIngameeventId"></a> HasIngameeventId

```csharp
public bool HasIngameeventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_IngameeventId"></a> IngameeventId

```csharp
public uint IngameeventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCKillSummaries> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Summaries"></a> Summaries

```csharp
public RepeatedField<CMsgServerToGCKillSummaries.Types.KillSummary> Summaries { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_ClearIngameeventId"></a> ClearIngameeventId\(\)

```csharp
public void ClearIngameeventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCKillSummaries Clone()
```

#### Returns

 [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Equals_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_"></a> Equals\(CMsgServerToGCKillSummaries\)

```csharp
public bool Equals(CMsgServerToGCKillSummaries other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_"></a> MergeFrom\(CMsgServerToGCKillSummaries\)

```csharp
public void MergeFrom(CMsgServerToGCKillSummaries other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

