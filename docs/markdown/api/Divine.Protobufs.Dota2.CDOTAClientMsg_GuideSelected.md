# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected"></a> Class CDOTAClientMsg\_GuideSelected

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_GuideSelected : IMessage<CDOTAClientMsg_GuideSelected>, IEquatable<CDOTAClientMsg_GuideSelected>, IDeepCloneable<CDOTAClientMsg_GuideSelected>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)

#### Implements

IMessage<CDOTAClientMsg\_GuideSelected\>, 
[IEquatable<CDOTAClientMsg\_GuideSelected\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_GuideSelected\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_GuideSelected\>\(CDOTAClientMsg\_GuideSelected, params CDOTAClientMsg\_GuideSelected\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected__ctor"></a> CDOTAClientMsg\_GuideSelected\(\)

```csharp
public CDOTAClientMsg_GuideSelected()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_"></a> CDOTAClientMsg\_GuideSelected\(CDOTAClientMsg\_GuideSelected\)

```csharp
public CDOTAClientMsg_GuideSelected(CDOTAClientMsg_GuideSelected other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_GuideWorkshopIdFieldNumber"></a> GuideWorkshopIdFieldNumber

```csharp
public const int GuideWorkshopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_IsPlusGuideFieldNumber"></a> IsPlusGuideFieldNumber

```csharp
public const int IsPlusGuideFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_GuideWorkshopId"></a> GuideWorkshopId

```csharp
public ulong GuideWorkshopId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_HasGuideWorkshopId"></a> HasGuideWorkshopId

```csharp
public bool HasGuideWorkshopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_HasIsPlusGuide"></a> HasIsPlusGuide

```csharp
public bool HasIsPlusGuide { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_IsPlusGuide"></a> IsPlusGuide

```csharp
public bool IsPlusGuide { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_GuideSelected> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_ClearGuideWorkshopId"></a> ClearGuideWorkshopId\(\)

```csharp
public void ClearGuideWorkshopId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_ClearIsPlusGuide"></a> ClearIsPlusGuide\(\)

```csharp
public void ClearIsPlusGuide()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_GuideSelected Clone()
```

#### Returns

 [CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_"></a> Equals\(CDOTAClientMsg\_GuideSelected\)

```csharp
public bool Equals(CDOTAClientMsg_GuideSelected other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_"></a> MergeFrom\(CDOTAClientMsg\_GuideSelected\)

```csharp
public void MergeFrom(CDOTAClientMsg_GuideSelected other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelected](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelected.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelected_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

