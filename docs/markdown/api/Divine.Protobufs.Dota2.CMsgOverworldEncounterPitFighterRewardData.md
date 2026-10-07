# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData"></a> Class CMsgOverworldEncounterPitFighterRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterPitFighterRewardData : IMessage<CMsgOverworldEncounterPitFighterRewardData>, IEquatable<CMsgOverworldEncounterPitFighterRewardData>, IDeepCloneable<CMsgOverworldEncounterPitFighterRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)

#### Implements

IMessage<CMsgOverworldEncounterPitFighterRewardData\>, 
[IEquatable<CMsgOverworldEncounterPitFighterRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterPitFighterRewardData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterPitFighterRewardData\>\(CMsgOverworldEncounterPitFighterRewardData, params CMsgOverworldEncounterPitFighterRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData__ctor"></a> CMsgOverworldEncounterPitFighterRewardData\(\)

```csharp
public CMsgOverworldEncounterPitFighterRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_"></a> CMsgOverworldEncounterPitFighterRewardData\(CMsgOverworldEncounterPitFighterRewardData\)

```csharp
public CMsgOverworldEncounterPitFighterRewardData(CMsgOverworldEncounterPitFighterRewardData other)
```

#### Parameters

`other` [CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_ChoiceFieldNumber"></a> ChoiceFieldNumber

```csharp
public const int ChoiceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_TokenIdFieldNumber"></a> TokenIdFieldNumber

```csharp
public const int TokenIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Choice"></a> Choice

```csharp
public uint Choice { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_HasChoice"></a> HasChoice

```csharp
public bool HasChoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_HasTokenId"></a> HasTokenId

```csharp
public bool HasTokenId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterPitFighterRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_TokenId"></a> TokenId

```csharp
public uint TokenId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_ClearChoice"></a> ClearChoice\(\)

```csharp
public void ClearChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_ClearTokenId"></a> ClearTokenId\(\)

```csharp
public void ClearTokenId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterPitFighterRewardData Clone()
```

#### Returns

 [CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_"></a> Equals\(CMsgOverworldEncounterPitFighterRewardData\)

```csharp
public bool Equals(CMsgOverworldEncounterPitFighterRewardData other)
```

#### Parameters

`other` [CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_"></a> MergeFrom\(CMsgOverworldEncounterPitFighterRewardData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterPitFighterRewardData other)
```

#### Parameters

`other` [CMsgOverworldEncounterPitFighterRewardData](Divine.Protobufs.Dota2.CMsgOverworldEncounterPitFighterRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterPitFighterRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

