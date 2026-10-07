# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge"></a> Class CDOTAMatchMetadata.Types.Team.Types.SubChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.SubChallenge : IMessage<CDOTAMatchMetadata.Types.Team.Types.SubChallenge>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.SubChallenge>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.SubChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.SubChallenge\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.SubChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.SubChallenge\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.SubChallenge\>\(CDOTAMatchMetadata.Types.Team.Types.SubChallenge, params CDOTAMatchMetadata.Types.Team.Types.SubChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge__ctor"></a> SubChallenge\(\)

```csharp
public SubChallenge()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_"></a> SubChallenge\(SubChallenge\)

```csharp
public SubChallenge(CDOTAMatchMetadata.Types.Team.Types.SubChallenge other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_CompletedFieldNumber"></a> CompletedFieldNumber

```csharp
public const int CompletedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_EndValueFieldNumber"></a> EndValueFieldNumber

```csharp
public const int EndValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_StartValueFieldNumber"></a> StartValueFieldNumber

```csharp
public const int StartValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Completed"></a> Completed

```csharp
public bool Completed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_EndValue"></a> EndValue

```csharp
public uint EndValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_HasCompleted"></a> HasCompleted

```csharp
public bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_HasEndValue"></a> HasEndValue

```csharp
public bool HasEndValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_HasStartValue"></a> HasStartValue

```csharp
public bool HasStartValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.SubChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_StartValue"></a> StartValue

```csharp
public uint StartValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_ClearCompleted"></a> ClearCompleted\(\)

```csharp
public void ClearCompleted()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_ClearEndValue"></a> ClearEndValue\(\)

```csharp
public void ClearEndValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_ClearStartValue"></a> ClearStartValue\(\)

```csharp
public void ClearStartValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.SubChallenge Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_"></a> Equals\(SubChallenge\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.SubChallenge other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_"></a> MergeFrom\(SubChallenge\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.SubChallenge other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[SubChallenge](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.SubChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_SubChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

