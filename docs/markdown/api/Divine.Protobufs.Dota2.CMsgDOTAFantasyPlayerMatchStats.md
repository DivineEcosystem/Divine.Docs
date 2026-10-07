# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats"></a> Class CMsgDOTAFantasyPlayerMatchStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyPlayerMatchStats : IMessage<CMsgDOTAFantasyPlayerMatchStats>, IEquatable<CMsgDOTAFantasyPlayerMatchStats>, IDeepCloneable<CMsgDOTAFantasyPlayerMatchStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)

#### Implements

IMessage<CMsgDOTAFantasyPlayerMatchStats\>, 
[IEquatable<CMsgDOTAFantasyPlayerMatchStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyPlayerMatchStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyPlayerMatchStats\>\(CMsgDOTAFantasyPlayerMatchStats, params CMsgDOTAFantasyPlayerMatchStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats__ctor"></a> CMsgDOTAFantasyPlayerMatchStats\(\)

```csharp
public CMsgDOTAFantasyPlayerMatchStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_"></a> CMsgDOTAFantasyPlayerMatchStats\(CMsgDOTAFantasyPlayerMatchStats\)

```csharp
public CMsgDOTAFantasyPlayerMatchStats(CMsgDOTAFantasyPlayerMatchStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAFantasyPlayerStats> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyPlayerMatchStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyPlayerMatchStats Clone()
```

#### Returns

 [CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_"></a> Equals\(CMsgDOTAFantasyPlayerMatchStats\)

```csharp
public bool Equals(CMsgDOTAFantasyPlayerMatchStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_"></a> MergeFrom\(CMsgDOTAFantasyPlayerMatchStats\)

```csharp
public void MergeFrom(CMsgDOTAFantasyPlayerMatchStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyPlayerMatchStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerMatchStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyPlayerMatchStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

