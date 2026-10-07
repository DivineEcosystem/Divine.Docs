# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata"></a> Class CDOTAMatchPrivateMetadata

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata : IMessage<CDOTAMatchPrivateMetadata>, IEquatable<CDOTAMatchPrivateMetadata>, IDeepCloneable<CDOTAMatchPrivateMetadata>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata\>, 
[IEquatable<CDOTAMatchPrivateMetadata\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata\>\(CDOTAMatchPrivateMetadata, params CDOTAMatchPrivateMetadata\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata__ctor"></a> CDOTAMatchPrivateMetadata\(\)

```csharp
public CDOTAMatchPrivateMetadata()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_"></a> CDOTAMatchPrivateMetadata\(CDOTAMatchPrivateMetadata\)

```csharp
public CDOTAMatchPrivateMetadata(CDOTAMatchPrivateMetadata other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_ContributionsFieldNumber"></a> ContributionsFieldNumber

```csharp
public const int ContributionsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_ContributionUnitNamesFieldNumber"></a> ContributionUnitNamesFieldNumber

```csharp
public const int ContributionUnitNamesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_GraphWinProbabilityFieldNumber"></a> GraphWinProbabilityFieldNumber

```csharp
public const int GraphWinProbabilityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_StringNamesFieldNumber"></a> StringNamesFieldNumber

```csharp
public const int StringNamesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Contributions"></a> Contributions

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment> Contributions { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_ContributionUnitNames"></a> ContributionUnitNames

```csharp
public RepeatedField<string> ContributionUnitNames { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_GraphWinProbability"></a> GraphWinProbability

```csharp
public RepeatedField<float> GraphWinProbability { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_StringNames"></a> StringNames

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.StringName> StringNames { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Teams"></a> Teams

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_"></a> Equals\(CDOTAMatchPrivateMetadata\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_"></a> MergeFrom\(CDOTAMatchPrivateMetadata\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

