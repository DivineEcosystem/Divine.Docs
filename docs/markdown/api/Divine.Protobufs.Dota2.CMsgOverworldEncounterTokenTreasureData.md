# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData"></a> Class CMsgOverworldEncounterTokenTreasureData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterTokenTreasureData : IMessage<CMsgOverworldEncounterTokenTreasureData>, IEquatable<CMsgOverworldEncounterTokenTreasureData>, IDeepCloneable<CMsgOverworldEncounterTokenTreasureData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)

#### Implements

IMessage<CMsgOverworldEncounterTokenTreasureData\>, 
[IEquatable<CMsgOverworldEncounterTokenTreasureData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterTokenTreasureData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterTokenTreasureData\>\(CMsgOverworldEncounterTokenTreasureData, params CMsgOverworldEncounterTokenTreasureData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData__ctor"></a> CMsgOverworldEncounterTokenTreasureData\(\)

```csharp
public CMsgOverworldEncounterTokenTreasureData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_"></a> CMsgOverworldEncounterTokenTreasureData\(CMsgOverworldEncounterTokenTreasureData\)

```csharp
public CMsgOverworldEncounterTokenTreasureData(CMsgOverworldEncounterTokenTreasureData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_RewardOptionsFieldNumber"></a> RewardOptionsFieldNumber

```csharp
public const int RewardOptionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterTokenTreasureData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_RewardOptions"></a> RewardOptions

```csharp
public RepeatedField<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption> RewardOptions { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterTokenTreasureData Clone()
```

#### Returns

 [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_"></a> Equals\(CMsgOverworldEncounterTokenTreasureData\)

```csharp
public bool Equals(CMsgOverworldEncounterTokenTreasureData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_"></a> MergeFrom\(CMsgOverworldEncounterTokenTreasureData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterTokenTreasureData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

