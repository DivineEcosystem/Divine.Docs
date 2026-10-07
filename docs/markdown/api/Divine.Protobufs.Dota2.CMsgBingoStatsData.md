# <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData"></a> Class CMsgBingoStatsData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoStatsData : IMessage<CMsgBingoStatsData>, IEquatable<CMsgBingoStatsData>, IDeepCloneable<CMsgBingoStatsData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

#### Implements

IMessage<CMsgBingoStatsData\>, 
[IEquatable<CMsgBingoStatsData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoStatsData\>, 
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
[EnumerableExtensions.In<CMsgBingoStatsData\>\(CMsgBingoStatsData, params CMsgBingoStatsData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData__ctor"></a> CMsgBingoStatsData\(\)

```csharp
public CMsgBingoStatsData()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData__ctor_Divine_Protobufs_Dota2_CMsgBingoStatsData_"></a> CMsgBingoStatsData\(CMsgBingoStatsData\)

```csharp
public CMsgBingoStatsData(CMsgBingoStatsData other)
```

#### Parameters

`other` [CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_StatsDataFieldNumber"></a> StatsDataFieldNumber

```csharp
public const int StatsDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoStatsData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_StatsData"></a> StatsData

```csharp
public RepeatedField<CMsgBingoIndividualStatData> StatsData { get; }
```

#### Property Value

 RepeatedField<[CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_Clone"></a> Clone\(\)

```csharp
public CMsgBingoStatsData Clone()
```

#### Returns

 [CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_Equals_Divine_Protobufs_Dota2_CMsgBingoStatsData_"></a> Equals\(CMsgBingoStatsData\)

```csharp
public bool Equals(CMsgBingoStatsData other)
```

#### Parameters

`other` [CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoStatsData_"></a> MergeFrom\(CMsgBingoStatsData\)

```csharp
public void MergeFrom(CMsgBingoStatsData other)
```

#### Parameters

`other` [CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoStatsData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

