# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData"></a> Class CMsgOverworldEncounterTokenQuestData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterTokenQuestData : IMessage<CMsgOverworldEncounterTokenQuestData>, IEquatable<CMsgOverworldEncounterTokenQuestData>, IDeepCloneable<CMsgOverworldEncounterTokenQuestData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)

#### Implements

IMessage<CMsgOverworldEncounterTokenQuestData\>, 
[IEquatable<CMsgOverworldEncounterTokenQuestData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterTokenQuestData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterTokenQuestData\>\(CMsgOverworldEncounterTokenQuestData, params CMsgOverworldEncounterTokenQuestData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData__ctor"></a> CMsgOverworldEncounterTokenQuestData\(\)

```csharp
public CMsgOverworldEncounterTokenQuestData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_"></a> CMsgOverworldEncounterTokenQuestData\(CMsgOverworldEncounterTokenQuestData\)

```csharp
public CMsgOverworldEncounterTokenQuestData(CMsgOverworldEncounterTokenQuestData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_QuestsFieldNumber"></a> QuestsFieldNumber

```csharp
public const int QuestsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterTokenQuestData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Quests"></a> Quests

```csharp
public RepeatedField<CMsgOverworldEncounterTokenQuestData.Types.Quest> Quests { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.Types.Quest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterTokenQuestData Clone()
```

#### Returns

 [CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_"></a> Equals\(CMsgOverworldEncounterTokenQuestData\)

```csharp
public bool Equals(CMsgOverworldEncounterTokenQuestData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_"></a> MergeFrom\(CMsgOverworldEncounterTokenQuestData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterTokenQuestData other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenQuestData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenQuestData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenQuestData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

