# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint"></a> Class CDOTAUserMsg\_MinimapDebugPoint

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MinimapDebugPoint : IMessage<CDOTAUserMsg_MinimapDebugPoint>, IEquatable<CDOTAUserMsg_MinimapDebugPoint>, IDeepCloneable<CDOTAUserMsg_MinimapDebugPoint>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)

#### Implements

IMessage<CDOTAUserMsg\_MinimapDebugPoint\>, 
[IEquatable<CDOTAUserMsg\_MinimapDebugPoint\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MinimapDebugPoint\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MinimapDebugPoint\>\(CDOTAUserMsg\_MinimapDebugPoint, params CDOTAUserMsg\_MinimapDebugPoint\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint__ctor"></a> CDOTAUserMsg\_MinimapDebugPoint\(\)

```csharp
public CDOTAUserMsg_MinimapDebugPoint()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_"></a> CDOTAUserMsg\_MinimapDebugPoint\(CDOTAUserMsg\_MinimapDebugPoint\)

```csharp
public CDOTAUserMsg_MinimapDebugPoint(CDOTAUserMsg_MinimapDebugPoint other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_SizeFieldNumber"></a> SizeFieldNumber

```csharp
public const int SizeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_HasSize"></a> HasSize

```csharp
public bool HasSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Index"></a> Index

```csharp
public int Index { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Location"></a> Location

```csharp
public CMsgVector Location { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MinimapDebugPoint> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Size"></a> Size

```csharp
public int Size { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ClearSize"></a> ClearSize\(\)

```csharp
public void ClearSize()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MinimapDebugPoint Clone()
```

#### Returns

 [CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_"></a> Equals\(CDOTAUserMsg\_MinimapDebugPoint\)

```csharp
public bool Equals(CDOTAUserMsg_MinimapDebugPoint other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_"></a> MergeFrom\(CDOTAUserMsg\_MinimapDebugPoint\)

```csharp
public void MergeFrom(CDOTAUserMsg_MinimapDebugPoint other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapDebugPoint](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapDebugPoint.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapDebugPoint_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

