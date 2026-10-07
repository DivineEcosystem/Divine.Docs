# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress"></a> Class CDOTAUserMsg\_HeroRelicProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HeroRelicProgress : IMessage<CDOTAUserMsg_HeroRelicProgress>, IEquatable<CDOTAUserMsg_HeroRelicProgress>, IDeepCloneable<CDOTAUserMsg_HeroRelicProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)

#### Implements

IMessage<CDOTAUserMsg\_HeroRelicProgress\>, 
[IEquatable<CDOTAUserMsg\_HeroRelicProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HeroRelicProgress\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HeroRelicProgress\>\(CDOTAUserMsg\_HeroRelicProgress, params CDOTAUserMsg\_HeroRelicProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress__ctor"></a> CDOTAUserMsg\_HeroRelicProgress\(\)

```csharp
public CDOTAUserMsg_HeroRelicProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_"></a> CDOTAUserMsg\_HeroRelicProgress\(CDOTAUserMsg\_HeroRelicProgress\)

```csharp
public CDOTAUserMsg_HeroRelicProgress(CDOTAUserMsg_HeroRelicProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HeroRelicTypeFieldNumber"></a> HeroRelicTypeFieldNumber

```csharp
public const int HeroRelicTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ValueDisplayFieldNumber"></a> ValueDisplayFieldNumber

```csharp
public const int ValueDisplayFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HasHeroRelicType"></a> HasHeroRelicType

```csharp
public bool HasHeroRelicType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HasValueDisplay"></a> HasValueDisplay

```csharp
public bool HasValueDisplay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_HeroRelicType"></a> HeroRelicType

```csharp
public uint HeroRelicType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HeroRelicProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ValueDisplay"></a> ValueDisplay

```csharp
public float ValueDisplay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ClearHeroRelicType"></a> ClearHeroRelicType\(\)

```csharp
public void ClearHeroRelicType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ClearValueDisplay"></a> ClearValueDisplay\(\)

```csharp
public void ClearValueDisplay()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HeroRelicProgress Clone()
```

#### Returns

 [CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_"></a> Equals\(CDOTAUserMsg\_HeroRelicProgress\)

```csharp
public bool Equals(CDOTAUserMsg_HeroRelicProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_"></a> MergeFrom\(CDOTAUserMsg\_HeroRelicProgress\)

```csharp
public void MergeFrom(CDOTAUserMsg_HeroRelicProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_HeroRelicProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_HeroRelicProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HeroRelicProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

