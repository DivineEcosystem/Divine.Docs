# <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData"></a> Class CMsgLobbyRoadToTIMatchQuestData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyRoadToTIMatchQuestData : IMessage<CMsgLobbyRoadToTIMatchQuestData>, IEquatable<CMsgLobbyRoadToTIMatchQuestData>, IDeepCloneable<CMsgLobbyRoadToTIMatchQuestData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)

#### Implements

IMessage<CMsgLobbyRoadToTIMatchQuestData\>, 
[IEquatable<CMsgLobbyRoadToTIMatchQuestData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyRoadToTIMatchQuestData\>, 
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
[EnumerableExtensions.In<CMsgLobbyRoadToTIMatchQuestData\>\(CMsgLobbyRoadToTIMatchQuestData, params CMsgLobbyRoadToTIMatchQuestData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData__ctor"></a> CMsgLobbyRoadToTIMatchQuestData\(\)

```csharp
public CMsgLobbyRoadToTIMatchQuestData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData__ctor_Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_"></a> CMsgLobbyRoadToTIMatchQuestData\(CMsgLobbyRoadToTIMatchQuestData\)

```csharp
public CMsgLobbyRoadToTIMatchQuestData(CMsgLobbyRoadToTIMatchQuestData other)
```

#### Parameters

`other` [CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestDataFieldNumber"></a> QuestDataFieldNumber

```csharp
public const int QuestDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestNumberFieldNumber"></a> QuestNumberFieldNumber

```csharp
public const int QuestNumberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestPeriodFieldNumber"></a> QuestPeriodFieldNumber

```csharp
public const int QuestPeriodFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_HasQuestNumber"></a> HasQuestNumber

```csharp
public bool HasQuestNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_HasQuestPeriod"></a> HasQuestPeriod

```csharp
public bool HasQuestPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyRoadToTIMatchQuestData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestData"></a> QuestData

```csharp
public CMsgRoadToTIAssignedQuest QuestData { get; set; }
```

#### Property Value

 [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestNumber"></a> QuestNumber

```csharp
public uint QuestNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_QuestPeriod"></a> QuestPeriod

```csharp
public uint QuestPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_ClearQuestNumber"></a> ClearQuestNumber\(\)

```csharp
public void ClearQuestNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_ClearQuestPeriod"></a> ClearQuestPeriod\(\)

```csharp
public void ClearQuestPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyRoadToTIMatchQuestData Clone()
```

#### Returns

 [CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_Equals_Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_"></a> Equals\(CMsgLobbyRoadToTIMatchQuestData\)

```csharp
public bool Equals(CMsgLobbyRoadToTIMatchQuestData other)
```

#### Parameters

`other` [CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_"></a> MergeFrom\(CMsgLobbyRoadToTIMatchQuestData\)

```csharp
public void MergeFrom(CMsgLobbyRoadToTIMatchQuestData other)
```

#### Parameters

`other` [CMsgLobbyRoadToTIMatchQuestData](Divine.Protobufs.Dota2.CMsgLobbyRoadToTIMatchQuestData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyRoadToTIMatchQuestData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

