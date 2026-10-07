# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData"></a> Class CMsgOverworldEncounterProgressData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterProgressData : IMessage<CMsgOverworldEncounterProgressData>, IEquatable<CMsgOverworldEncounterProgressData>, IDeepCloneable<CMsgOverworldEncounterProgressData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)

#### Implements

IMessage<CMsgOverworldEncounterProgressData\>, 
[IEquatable<CMsgOverworldEncounterProgressData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterProgressData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterProgressData\>\(CMsgOverworldEncounterProgressData, params CMsgOverworldEncounterProgressData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData__ctor"></a> CMsgOverworldEncounterProgressData\(\)

```csharp
public CMsgOverworldEncounterProgressData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_"></a> CMsgOverworldEncounterProgressData\(CMsgOverworldEncounterProgressData\)

```csharp
public CMsgOverworldEncounterProgressData(CMsgOverworldEncounterProgressData other)
```

#### Parameters

`other` [CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ChoiceFieldNumber"></a> ChoiceFieldNumber

```csharp
public const int ChoiceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_MaxProgressFieldNumber"></a> MaxProgressFieldNumber

```csharp
public const int MaxProgressFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_VisitedFieldNumber"></a> VisitedFieldNumber

```csharp
public const int VisitedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Choice"></a> Choice

```csharp
public int Choice { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_HasChoice"></a> HasChoice

```csharp
public bool HasChoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_HasMaxProgress"></a> HasMaxProgress

```csharp
public bool HasMaxProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_HasVisited"></a> HasVisited

```csharp
public bool HasVisited { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_MaxProgress"></a> MaxProgress

```csharp
public int MaxProgress { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterProgressData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Progress"></a> Progress

```csharp
public int Progress { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Visited"></a> Visited

```csharp
public bool Visited { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ClearChoice"></a> ClearChoice\(\)

```csharp
public void ClearChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ClearMaxProgress"></a> ClearMaxProgress\(\)

```csharp
public void ClearMaxProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ClearVisited"></a> ClearVisited\(\)

```csharp
public void ClearVisited()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterProgressData Clone()
```

#### Returns

 [CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_"></a> Equals\(CMsgOverworldEncounterProgressData\)

```csharp
public bool Equals(CMsgOverworldEncounterProgressData other)
```

#### Parameters

`other` [CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_"></a> MergeFrom\(CMsgOverworldEncounterProgressData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterProgressData other)
```

#### Parameters

`other` [CMsgOverworldEncounterProgressData](Divine.Protobufs.Dota2.CMsgOverworldEncounterProgressData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterProgressData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

