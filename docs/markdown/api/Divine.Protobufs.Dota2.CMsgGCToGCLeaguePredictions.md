# <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions"></a> Class CMsgGCToGCLeaguePredictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCLeaguePredictions : IMessage<CMsgGCToGCLeaguePredictions>, IEquatable<CMsgGCToGCLeaguePredictions>, IDeepCloneable<CMsgGCToGCLeaguePredictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)

#### Implements

IMessage<CMsgGCToGCLeaguePredictions\>, 
[IEquatable<CMsgGCToGCLeaguePredictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCLeaguePredictions\>, 
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
[EnumerableExtensions.In<CMsgGCToGCLeaguePredictions\>\(CMsgGCToGCLeaguePredictions, params CMsgGCToGCLeaguePredictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions__ctor"></a> CMsgGCToGCLeaguePredictions\(\)

```csharp
public CMsgGCToGCLeaguePredictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions__ctor_Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_"></a> CMsgGCToGCLeaguePredictions\(CMsgGCToGCLeaguePredictions\)

```csharp
public CMsgGCToGCLeaguePredictions(CMsgGCToGCLeaguePredictions other)
```

#### Parameters

`other` [CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCLeaguePredictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCLeaguePredictions Clone()
```

#### Returns

 [CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_Equals_Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_"></a> Equals\(CMsgGCToGCLeaguePredictions\)

```csharp
public bool Equals(CMsgGCToGCLeaguePredictions other)
```

#### Parameters

`other` [CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_"></a> MergeFrom\(CMsgGCToGCLeaguePredictions\)

```csharp
public void MergeFrom(CMsgGCToGCLeaguePredictions other)
```

#### Parameters

`other` [CMsgGCToGCLeaguePredictions](Divine.Protobufs.Dota2.CMsgGCToGCLeaguePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLeaguePredictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

