# <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series"></a> Class CMsgDOTARequestMatchesResponse.Types.Series

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARequestMatchesResponse.Types.Series : IMessage<CMsgDOTARequestMatchesResponse.Types.Series>, IEquatable<CMsgDOTARequestMatchesResponse.Types.Series>, IDeepCloneable<CMsgDOTARequestMatchesResponse.Types.Series>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARequestMatchesResponse.Types.Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)

#### Implements

IMessage<CMsgDOTARequestMatchesResponse.Types.Series\>, 
[IEquatable<CMsgDOTARequestMatchesResponse.Types.Series\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARequestMatchesResponse.Types.Series\>, 
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
[EnumerableExtensions.In<CMsgDOTARequestMatchesResponse.Types.Series\>\(CMsgDOTARequestMatchesResponse.Types.Series, params CMsgDOTARequestMatchesResponse.Types.Series\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series__ctor"></a> Series\(\)

```csharp
public Series()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series__ctor_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_"></a> Series\(Series\)

```csharp
public Series(CMsgDOTARequestMatchesResponse.Types.Series other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_SeriesTypeFieldNumber"></a> SeriesTypeFieldNumber

```csharp
public const int SeriesTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_HasSeriesType"></a> HasSeriesType

```csharp
public bool HasSeriesType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAMatch> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARequestMatchesResponse.Types.Series> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_SeriesType"></a> SeriesType

```csharp
public uint SeriesType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_ClearSeriesType"></a> ClearSeriesType\(\)

```csharp
public void ClearSeriesType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARequestMatchesResponse.Types.Series Clone()
```

#### Returns

 [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_Equals_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_"></a> Equals\(Series\)

```csharp
public bool Equals(CMsgDOTARequestMatchesResponse.Types.Series other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_"></a> MergeFrom\(Series\)

```csharp
public void MergeFrom(CMsgDOTARequestMatchesResponse.Types.Series other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Types_Series_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

