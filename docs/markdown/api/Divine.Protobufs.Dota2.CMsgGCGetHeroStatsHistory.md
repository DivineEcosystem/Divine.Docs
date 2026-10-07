# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory"></a> Class CMsgGCGetHeroStatsHistory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroStatsHistory : IMessage<CMsgGCGetHeroStatsHistory>, IEquatable<CMsgGCGetHeroStatsHistory>, IDeepCloneable<CMsgGCGetHeroStatsHistory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)

#### Implements

IMessage<CMsgGCGetHeroStatsHistory\>, 
[IEquatable<CMsgGCGetHeroStatsHistory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroStatsHistory\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroStatsHistory\>\(CMsgGCGetHeroStatsHistory, params CMsgGCGetHeroStatsHistory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory__ctor"></a> CMsgGCGetHeroStatsHistory\(\)

```csharp
public CMsgGCGetHeroStatsHistory()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_"></a> CMsgGCGetHeroStatsHistory\(CMsgGCGetHeroStatsHistory\)

```csharp
public CMsgGCGetHeroStatsHistory(CMsgGCGetHeroStatsHistory other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroStatsHistory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroStatsHistory Clone()
```

#### Returns

 [CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_"></a> Equals\(CMsgGCGetHeroStatsHistory\)

```csharp
public bool Equals(CMsgGCGetHeroStatsHistory other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_"></a> MergeFrom\(CMsgGCGetHeroStatsHistory\)

```csharp
public void MergeFrom(CMsgGCGetHeroStatsHistory other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistory](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

