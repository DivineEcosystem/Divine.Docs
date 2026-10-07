# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats"></a> Class CMsgSteamLearnPlayerTimedStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnPlayerTimedStats : IMessage<CMsgSteamLearnPlayerTimedStats>, IEquatable<CMsgSteamLearnPlayerTimedStats>, IDeepCloneable<CMsgSteamLearnPlayerTimedStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)

#### Implements

IMessage<CMsgSteamLearnPlayerTimedStats\>, 
[IEquatable<CMsgSteamLearnPlayerTimedStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnPlayerTimedStats\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnPlayerTimedStats\>\(CMsgSteamLearnPlayerTimedStats, params CMsgSteamLearnPlayerTimedStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats__ctor"></a> CMsgSteamLearnPlayerTimedStats\(\)

```csharp
public CMsgSteamLearnPlayerTimedStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_"></a> CMsgSteamLearnPlayerTimedStats\(CMsgSteamLearnPlayerTimedStats\)

```csharp
public CMsgSteamLearnPlayerTimedStats(CMsgSteamLearnPlayerTimedStats other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_StatBucketsFieldNumber"></a> StatBucketsFieldNumber

```csharp
public const int StatBucketsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnPlayerTimedStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_StatBuckets"></a> StatBuckets

```csharp
public RepeatedField<CMsgSteamLearnPlayerTimedStats.Types.StatBucket> StatBuckets { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnPlayerTimedStats Clone()
```

#### Returns

 [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_"></a> Equals\(CMsgSteamLearnPlayerTimedStats\)

```csharp
public bool Equals(CMsgSteamLearnPlayerTimedStats other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_"></a> MergeFrom\(CMsgSteamLearnPlayerTimedStats\)

```csharp
public void MergeFrom(CMsgSteamLearnPlayerTimedStats other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

