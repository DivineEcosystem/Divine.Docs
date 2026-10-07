# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults"></a> Class CMsgDOTADPCLeagueResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCLeagueResults : IMessage<CMsgDOTADPCLeagueResults>, IEquatable<CMsgDOTADPCLeagueResults>, IDeepCloneable<CMsgDOTADPCLeagueResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)

#### Implements

IMessage<CMsgDOTADPCLeagueResults\>, 
[IEquatable<CMsgDOTADPCLeagueResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCLeagueResults\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCLeagueResults\>\(CMsgDOTADPCLeagueResults, params CMsgDOTADPCLeagueResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults__ctor"></a> CMsgDOTADPCLeagueResults\(\)

```csharp
public CMsgDOTADPCLeagueResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_"></a> CMsgDOTADPCLeagueResults\(CMsgDOTADPCLeagueResults\)

```csharp
public CMsgDOTADPCLeagueResults(CMsgDOTADPCLeagueResults other)
```

#### Parameters

`other` [CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_DollarsFieldNumber"></a> DollarsFieldNumber

```csharp
public const int DollarsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Dollars"></a> Dollars

```csharp
public RepeatedField<uint> Dollars { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCLeagueResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Points"></a> Points

```csharp
public RepeatedField<uint> Points { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Results"></a> Results

```csharp
public RepeatedField<CMsgDOTADPCLeagueResults.Types.Result> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.Types.Result.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCLeagueResults Clone()
```

#### Returns

 [CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_"></a> Equals\(CMsgDOTADPCLeagueResults\)

```csharp
public bool Equals(CMsgDOTADPCLeagueResults other)
```

#### Parameters

`other` [CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_"></a> MergeFrom\(CMsgDOTADPCLeagueResults\)

```csharp
public void MergeFrom(CMsgDOTADPCLeagueResults other)
```

#### Parameters

`other` [CMsgDOTADPCLeagueResults](Divine.Protobufs.Dota2.CMsgDOTADPCLeagueResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCLeagueResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

