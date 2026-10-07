# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria"></a> Class CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria : IMessage<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria\>\(CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria, params CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria__ctor"></a> AutoStyleCriteria\(\)

```csharp
public AutoStyleCriteria()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_"></a> AutoStyleCriteria\(AutoStyleCriteria\)

```csharp
public AutoStyleCriteria(CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_NameTokenFieldNumber"></a> NameTokenFieldNumber

```csharp
public const int NameTokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_HasNameToken"></a> HasNameToken

```csharp
public bool HasNameToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_NameToken"></a> NameToken

```csharp
public uint NameToken { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_ClearNameToken"></a> ClearNameToken\(\)

```csharp
public void ClearNameToken()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_"></a> Equals\(AutoStyleCriteria\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_"></a> MergeFrom\(AutoStyleCriteria\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[AutoStyleCriteria](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.AutoStyleCriteria.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_AutoStyleCriteria_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

