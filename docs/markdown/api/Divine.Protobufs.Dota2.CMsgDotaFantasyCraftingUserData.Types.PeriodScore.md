# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore"></a> Class CMsgDotaFantasyCraftingUserData.Types.PeriodScore

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingUserData.Types.PeriodScore : IMessage<CMsgDotaFantasyCraftingUserData.Types.PeriodScore>, IEquatable<CMsgDotaFantasyCraftingUserData.Types.PeriodScore>, IDeepCloneable<CMsgDotaFantasyCraftingUserData.Types.PeriodScore>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingUserData.Types.PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingUserData.Types.PeriodScore\>, 
[IEquatable<CMsgDotaFantasyCraftingUserData.Types.PeriodScore\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingUserData.Types.PeriodScore\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingUserData.Types.PeriodScore\>\(CMsgDotaFantasyCraftingUserData.Types.PeriodScore, params CMsgDotaFantasyCraftingUserData.Types.PeriodScore\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore__ctor"></a> PeriodScore\(\)

```csharp
public PeriodScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_"></a> PeriodScore\(PeriodScore\)

```csharp
public PeriodScore(CMsgDotaFantasyCraftingUserData.Types.PeriodScore other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_PercentileFieldNumber"></a> PercentileFieldNumber

```csharp
public const int PercentileFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_TotalScoreFieldNumber"></a> TotalScoreFieldNumber

```csharp
public const int TotalScoreFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_HasPercentile"></a> HasPercentile

```csharp
public bool HasPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_HasTotalScore"></a> HasTotalScore

```csharp
public bool HasTotalScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingUserData.Types.PeriodScore> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Percentile"></a> Percentile

```csharp
public float Percentile { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_TotalScore"></a> TotalScore

```csharp
public float TotalScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_ClearPercentile"></a> ClearPercentile\(\)

```csharp
public void ClearPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_ClearTotalScore"></a> ClearTotalScore\(\)

```csharp
public void ClearTotalScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingUserData.Types.PeriodScore Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_"></a> Equals\(PeriodScore\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingUserData.Types.PeriodScore other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_"></a> MergeFrom\(PeriodScore\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingUserData.Types.PeriodScore other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Types_PeriodScore_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

