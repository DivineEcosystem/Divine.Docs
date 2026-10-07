# <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes"></a> Class CMsgPlayerRecentMatchOutcomes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerRecentMatchOutcomes : IMessage<CMsgPlayerRecentMatchOutcomes>, IEquatable<CMsgPlayerRecentMatchOutcomes>, IDeepCloneable<CMsgPlayerRecentMatchOutcomes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

#### Implements

IMessage<CMsgPlayerRecentMatchOutcomes\>, 
[IEquatable<CMsgPlayerRecentMatchOutcomes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerRecentMatchOutcomes\>, 
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
[EnumerableExtensions.In<CMsgPlayerRecentMatchOutcomes\>\(CMsgPlayerRecentMatchOutcomes, params CMsgPlayerRecentMatchOutcomes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes__ctor"></a> CMsgPlayerRecentMatchOutcomes\(\)

```csharp
public CMsgPlayerRecentMatchOutcomes()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes__ctor_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_"></a> CMsgPlayerRecentMatchOutcomes\(CMsgPlayerRecentMatchOutcomes\)

```csharp
public CMsgPlayerRecentMatchOutcomes(CMsgPlayerRecentMatchOutcomes other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_MatchCountFieldNumber"></a> MatchCountFieldNumber

```csharp
public const int MatchCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_OutcomesFieldNumber"></a> OutcomesFieldNumber

```csharp
public const int OutcomesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_HasMatchCount"></a> HasMatchCount

```csharp
public bool HasMatchCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_HasOutcomes"></a> HasOutcomes

```csharp
public bool HasOutcomes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_MatchCount"></a> MatchCount

```csharp
public uint MatchCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Outcomes"></a> Outcomes

```csharp
public uint Outcomes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerRecentMatchOutcomes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_ClearMatchCount"></a> ClearMatchCount\(\)

```csharp
public void ClearMatchCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_ClearOutcomes"></a> ClearOutcomes\(\)

```csharp
public void ClearOutcomes()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerRecentMatchOutcomes Clone()
```

#### Returns

 [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_Equals_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_"></a> Equals\(CMsgPlayerRecentMatchOutcomes\)

```csharp
public bool Equals(CMsgPlayerRecentMatchOutcomes other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_"></a> MergeFrom\(CMsgPlayerRecentMatchOutcomes\)

```csharp
public void MergeFrom(CMsgPlayerRecentMatchOutcomes other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchOutcomes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

