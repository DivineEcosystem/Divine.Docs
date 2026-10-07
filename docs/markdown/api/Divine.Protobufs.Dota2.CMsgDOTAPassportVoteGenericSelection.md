# <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection"></a> Class CMsgDOTAPassportVoteGenericSelection

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPassportVoteGenericSelection : IMessage<CMsgDOTAPassportVoteGenericSelection>, IEquatable<CMsgDOTAPassportVoteGenericSelection>, IDeepCloneable<CMsgDOTAPassportVoteGenericSelection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)

#### Implements

IMessage<CMsgDOTAPassportVoteGenericSelection\>, 
[IEquatable<CMsgDOTAPassportVoteGenericSelection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPassportVoteGenericSelection\>, 
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
[EnumerableExtensions.In<CMsgDOTAPassportVoteGenericSelection\>\(CMsgDOTAPassportVoteGenericSelection, params CMsgDOTAPassportVoteGenericSelection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection__ctor"></a> CMsgDOTAPassportVoteGenericSelection\(\)

```csharp
public CMsgDOTAPassportVoteGenericSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection__ctor_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_"></a> CMsgDOTAPassportVoteGenericSelection\(CMsgDOTAPassportVoteGenericSelection\)

```csharp
public CMsgDOTAPassportVoteGenericSelection(CMsgDOTAPassportVoteGenericSelection other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_SelectionFieldNumber"></a> SelectionFieldNumber

```csharp
public const int SelectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_SelectionIndexFieldNumber"></a> SelectionIndexFieldNumber

```csharp
public const int SelectionIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_HasSelection"></a> HasSelection

```csharp
public bool HasSelection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_HasSelectionIndex"></a> HasSelectionIndex

```csharp
public bool HasSelectionIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPassportVoteGenericSelection> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Selection"></a> Selection

```csharp
public uint Selection { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_SelectionIndex"></a> SelectionIndex

```csharp
public DOTA_2013PassportSelectionIndices SelectionIndex { get; set; }
```

#### Property Value

 [DOTA\_2013PassportSelectionIndices](Divine.Protobufs.Dota2.DOTA\_2013PassportSelectionIndices.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_ClearSelection"></a> ClearSelection\(\)

```csharp
public void ClearSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_ClearSelectionIndex"></a> ClearSelectionIndex\(\)

```csharp
public void ClearSelectionIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPassportVoteGenericSelection Clone()
```

#### Returns

 [CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_Equals_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_"></a> Equals\(CMsgDOTAPassportVoteGenericSelection\)

```csharp
public bool Equals(CMsgDOTAPassportVoteGenericSelection other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_"></a> MergeFrom\(CMsgDOTAPassportVoteGenericSelection\)

```csharp
public void MergeFrom(CMsgDOTAPassportVoteGenericSelection other)
```

#### Parameters

`other` [CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVoteGenericSelection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

