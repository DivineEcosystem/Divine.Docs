# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress"></a> Class CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress : IMessage<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress\>\(CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress, params CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress__ctor"></a> FeaturedGamemodeProgress\(\)

```csharp
public FeaturedGamemodeProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_"></a> FeaturedGamemodeProgress\(FeaturedGamemodeProgress\)

```csharp
public FeaturedGamemodeProgress(CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_EndValueFieldNumber"></a> EndValueFieldNumber

```csharp
public const int EndValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_MaxValueFieldNumber"></a> MaxValueFieldNumber

```csharp
public const int MaxValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_StartValueFieldNumber"></a> StartValueFieldNumber

```csharp
public const int StartValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_EndValue"></a> EndValue

```csharp
public uint EndValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_HasEndValue"></a> HasEndValue

```csharp
public bool HasEndValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_HasMaxValue"></a> HasMaxValue

```csharp
public bool HasMaxValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_HasStartValue"></a> HasStartValue

```csharp
public bool HasStartValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_MaxValue"></a> MaxValue

```csharp
public uint MaxValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_StartValue"></a> StartValue

```csharp
public uint StartValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_ClearEndValue"></a> ClearEndValue\(\)

```csharp
public void ClearEndValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_ClearMaxValue"></a> ClearMaxValue\(\)

```csharp
public void ClearMaxValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_ClearStartValue"></a> ClearStartValue\(\)

```csharp
public void ClearStartValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_"></a> Equals\(FeaturedGamemodeProgress\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_"></a> MergeFrom\(FeaturedGamemodeProgress\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[FeaturedGamemodeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.FeaturedGamemodeProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_FeaturedGamemodeProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

