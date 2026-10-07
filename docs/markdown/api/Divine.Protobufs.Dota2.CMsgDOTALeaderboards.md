# <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards"></a> Class CMsgDOTALeaderboards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeaderboards : IMessage<CMsgDOTALeaderboards>, IEquatable<CMsgDOTALeaderboards>, IDeepCloneable<CMsgDOTALeaderboards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)

#### Implements

IMessage<CMsgDOTALeaderboards\>, 
[IEquatable<CMsgDOTALeaderboards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeaderboards\>, 
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
[EnumerableExtensions.In<CMsgDOTALeaderboards\>\(CMsgDOTALeaderboards, params CMsgDOTALeaderboards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards__ctor"></a> CMsgDOTALeaderboards\(\)

```csharp
public CMsgDOTALeaderboards()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards__ctor_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_"></a> CMsgDOTALeaderboards\(CMsgDOTALeaderboards\)

```csharp
public CMsgDOTALeaderboards(CMsgDOTALeaderboards other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_LeaderboardsFieldNumber"></a> LeaderboardsFieldNumber

```csharp
public const int LeaderboardsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Leaderboards"></a> Leaderboards

```csharp
public RepeatedField<CMsgDOTALeaderboards.Types.RegionLeaderboard> Leaderboards { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeaderboards> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeaderboards Clone()
```

#### Returns

 [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Equals_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_"></a> Equals\(CMsgDOTALeaderboards\)

```csharp
public bool Equals(CMsgDOTALeaderboards other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_"></a> MergeFrom\(CMsgDOTALeaderboards\)

```csharp
public void MergeFrom(CMsgDOTALeaderboards other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

