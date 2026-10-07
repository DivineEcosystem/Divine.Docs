# <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record"></a> Class CMsgServerToGCVictoryPredictions.Types.Record

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCVictoryPredictions.Types.Record : IMessage<CMsgServerToGCVictoryPredictions.Types.Record>, IEquatable<CMsgServerToGCVictoryPredictions.Types.Record>, IDeepCloneable<CMsgServerToGCVictoryPredictions.Types.Record>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCVictoryPredictions.Types.Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)

#### Implements

IMessage<CMsgServerToGCVictoryPredictions.Types.Record\>, 
[IEquatable<CMsgServerToGCVictoryPredictions.Types.Record\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCVictoryPredictions.Types.Record\>, 
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
[EnumerableExtensions.In<CMsgServerToGCVictoryPredictions.Types.Record\>\(CMsgServerToGCVictoryPredictions.Types.Record, params CMsgServerToGCVictoryPredictions.Types.Record\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record__ctor"></a> Record\(\)

```csharp
public Record()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record__ctor_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_"></a> Record\(Record\)

```csharp
public Record(CMsgServerToGCVictoryPredictions.Types.Record other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_PredictionItemsFieldNumber"></a> PredictionItemsFieldNumber

```csharp
public const int PredictionItemsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCVictoryPredictions.Types.Record> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_PredictionItems"></a> PredictionItems

```csharp
public RepeatedField<CMsgServerToGCVictoryPredictions.Types.PredictionItem> PredictionItems { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[PredictionItem](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.PredictionItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCVictoryPredictions.Types.Record Clone()
```

#### Returns

 [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_Equals_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_"></a> Equals\(Record\)

```csharp
public bool Equals(CMsgServerToGCVictoryPredictions.Types.Record other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_"></a> MergeFrom\(Record\)

```csharp
public void MergeFrom(CMsgServerToGCVictoryPredictions.Types.Record other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Types_Record_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

