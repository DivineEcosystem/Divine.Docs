# <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection"></a> Class CMsgDOTACompendiumSelection

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACompendiumSelection : IMessage<CMsgDOTACompendiumSelection>, IEquatable<CMsgDOTACompendiumSelection>, IDeepCloneable<CMsgDOTACompendiumSelection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)

#### Implements

IMessage<CMsgDOTACompendiumSelection\>, 
[IEquatable<CMsgDOTACompendiumSelection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACompendiumSelection\>, 
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
[EnumerableExtensions.In<CMsgDOTACompendiumSelection\>\(CMsgDOTACompendiumSelection, params CMsgDOTACompendiumSelection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection__ctor"></a> CMsgDOTACompendiumSelection\(\)

```csharp
public CMsgDOTACompendiumSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection__ctor_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_"></a> CMsgDOTACompendiumSelection\(CMsgDOTACompendiumSelection\)

```csharp
public CMsgDOTACompendiumSelection(CMsgDOTACompendiumSelection other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_LeagueidFieldNumber"></a> LeagueidFieldNumber

```csharp
public const int LeagueidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_SelectionFieldNumber"></a> SelectionFieldNumber

```csharp
public const int SelectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_SelectionIndexFieldNumber"></a> SelectionIndexFieldNumber

```csharp
public const int SelectionIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_HasLeagueid"></a> HasLeagueid

```csharp
public bool HasLeagueid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_HasSelection"></a> HasSelection

```csharp
public bool HasSelection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_HasSelectionIndex"></a> HasSelectionIndex

```csharp
public bool HasSelectionIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Leagueid"></a> Leagueid

```csharp
public uint Leagueid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACompendiumSelection> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Selection"></a> Selection

```csharp
public uint Selection { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_SelectionIndex"></a> SelectionIndex

```csharp
public uint SelectionIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_ClearLeagueid"></a> ClearLeagueid\(\)

```csharp
public void ClearLeagueid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_ClearSelection"></a> ClearSelection\(\)

```csharp
public void ClearSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_ClearSelectionIndex"></a> ClearSelectionIndex\(\)

```csharp
public void ClearSelectionIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACompendiumSelection Clone()
```

#### Returns

 [CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_Equals_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_"></a> Equals\(CMsgDOTACompendiumSelection\)

```csharp
public bool Equals(CMsgDOTACompendiumSelection other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_"></a> MergeFrom\(CMsgDOTACompendiumSelection\)

```csharp
public void MergeFrom(CMsgDOTACompendiumSelection other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

