# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData"></a> Class CMsgDotaFantasyCraftingUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingUserData : IMessage<CMsgDotaFantasyCraftingUserData>, IEquatable<CMsgDotaFantasyCraftingUserData>, IDeepCloneable<CMsgDotaFantasyCraftingUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingUserData\>, 
[IEquatable<CMsgDotaFantasyCraftingUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingUserData\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingUserData\>\(CMsgDotaFantasyCraftingUserData, params CMsgDotaFantasyCraftingUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData__ctor"></a> CMsgDotaFantasyCraftingUserData\(\)

```csharp
public CMsgDotaFantasyCraftingUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_"></a> CMsgDotaFantasyCraftingUserData\(CMsgDotaFantasyCraftingUserData\)

```csharp
public CMsgDotaFantasyCraftingUserData(CMsgDotaFantasyCraftingUserData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_AvailableRollsFieldNumber"></a> AvailableRollsFieldNumber

```csharp
public const int AvailableRollsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_PeriodRollTokensFieldNumber"></a> PeriodRollTokensFieldNumber

```csharp
public const int PeriodRollTokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_PeriodScoresFieldNumber"></a> PeriodScoresFieldNumber

```csharp
public const int PeriodScoresFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_AvailableRolls"></a> AvailableRolls

```csharp
public RepeatedField<uint> AvailableRolls { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_PeriodRollTokens"></a> PeriodRollTokens

```csharp
public MapField<uint, uint> PeriodRollTokens { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_PeriodScores"></a> PeriodScores

```csharp
public MapField<uint, CMsgDotaFantasyCraftingUserData.Types.PeriodScore> PeriodScores { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.md).[PeriodScore](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.Types.PeriodScore.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingUserData Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_"></a> Equals\(CMsgDotaFantasyCraftingUserData\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingUserData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_"></a> MergeFrom\(CMsgDotaFantasyCraftingUserData\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingUserData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

