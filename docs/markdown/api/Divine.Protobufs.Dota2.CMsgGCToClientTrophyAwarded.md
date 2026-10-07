# <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded"></a> Class CMsgGCToClientTrophyAwarded

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientTrophyAwarded : IMessage<CMsgGCToClientTrophyAwarded>, IEquatable<CMsgGCToClientTrophyAwarded>, IDeepCloneable<CMsgGCToClientTrophyAwarded>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)

#### Implements

IMessage<CMsgGCToClientTrophyAwarded\>, 
[IEquatable<CMsgGCToClientTrophyAwarded\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientTrophyAwarded\>, 
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
[EnumerableExtensions.In<CMsgGCToClientTrophyAwarded\>\(CMsgGCToClientTrophyAwarded, params CMsgGCToClientTrophyAwarded\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded__ctor"></a> CMsgGCToClientTrophyAwarded\(\)

```csharp
public CMsgGCToClientTrophyAwarded()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded__ctor_Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_"></a> CMsgGCToClientTrophyAwarded\(CMsgGCToClientTrophyAwarded\)

```csharp
public CMsgGCToClientTrophyAwarded(CMsgGCToClientTrophyAwarded other)
```

#### Parameters

`other` [CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_LastUpdatedFieldNumber"></a> LastUpdatedFieldNumber

```csharp
public const int LastUpdatedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyIdFieldNumber"></a> TrophyIdFieldNumber

```csharp
public const int TrophyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyOldScoreFieldNumber"></a> TrophyOldScoreFieldNumber

```csharp
public const int TrophyOldScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyScoreFieldNumber"></a> TrophyScoreFieldNumber

```csharp
public const int TrophyScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_HasLastUpdated"></a> HasLastUpdated

```csharp
public bool HasLastUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_HasTrophyId"></a> HasTrophyId

```csharp
public bool HasTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_HasTrophyOldScore"></a> HasTrophyOldScore

```csharp
public bool HasTrophyOldScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_HasTrophyScore"></a> HasTrophyScore

```csharp
public bool HasTrophyScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_LastUpdated"></a> LastUpdated

```csharp
public uint LastUpdated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientTrophyAwarded> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyId"></a> TrophyId

```csharp
public uint TrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyOldScore"></a> TrophyOldScore

```csharp
public uint TrophyOldScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_TrophyScore"></a> TrophyScore

```csharp
public uint TrophyScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_ClearLastUpdated"></a> ClearLastUpdated\(\)

```csharp
public void ClearLastUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_ClearTrophyId"></a> ClearTrophyId\(\)

```csharp
public void ClearTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_ClearTrophyOldScore"></a> ClearTrophyOldScore\(\)

```csharp
public void ClearTrophyOldScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_ClearTrophyScore"></a> ClearTrophyScore\(\)

```csharp
public void ClearTrophyScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientTrophyAwarded Clone()
```

#### Returns

 [CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_Equals_Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_"></a> Equals\(CMsgGCToClientTrophyAwarded\)

```csharp
public bool Equals(CMsgGCToClientTrophyAwarded other)
```

#### Parameters

`other` [CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_"></a> MergeFrom\(CMsgGCToClientTrophyAwarded\)

```csharp
public void MergeFrom(CMsgGCToClientTrophyAwarded other)
```

#### Parameters

`other` [CMsgGCToClientTrophyAwarded](Divine.Protobufs.Dota2.CMsgGCToClientTrophyAwarded.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTrophyAwarded_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

