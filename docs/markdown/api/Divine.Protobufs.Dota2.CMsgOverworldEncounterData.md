# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData"></a> Class CMsgOverworldEncounterData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterData : IMessage<CMsgOverworldEncounterData>, IEquatable<CMsgOverworldEncounterData>, IDeepCloneable<CMsgOverworldEncounterData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

#### Implements

IMessage<CMsgOverworldEncounterData\>, 
[IEquatable<CMsgOverworldEncounterData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterData\>\(CMsgOverworldEncounterData, params CMsgOverworldEncounterData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData__ctor"></a> CMsgOverworldEncounterData\(\)

```csharp
public CMsgOverworldEncounterData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterData_"></a> CMsgOverworldEncounterData\(CMsgOverworldEncounterData\)

```csharp
public CMsgOverworldEncounterData(CMsgOverworldEncounterData other)
```

#### Parameters

`other` [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_ExtraEncounterDataFieldNumber"></a> ExtraEncounterDataFieldNumber

```csharp
public const int ExtraEncounterDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_ExtraEncounterData"></a> ExtraEncounterData

```csharp
public RepeatedField<CExtraMsgBlock> ExtraEncounterData { get; }
```

#### Property Value

 RepeatedField<[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterData Clone()
```

#### Returns

 [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterData_"></a> Equals\(CMsgOverworldEncounterData\)

```csharp
public bool Equals(CMsgOverworldEncounterData other)
```

#### Parameters

`other` [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterData_"></a> MergeFrom\(CMsgOverworldEncounterData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterData other)
```

#### Parameters

`other` [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

