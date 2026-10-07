# <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent"></a> Class CMsgClothStiffenAnimEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClothStiffenAnimEvent : IMessage<CMsgClothStiffenAnimEvent>, IEquatable<CMsgClothStiffenAnimEvent>, IDeepCloneable<CMsgClothStiffenAnimEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)

#### Implements

IMessage<CMsgClothStiffenAnimEvent\>, 
[IEquatable<CMsgClothStiffenAnimEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClothStiffenAnimEvent\>, 
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
[EnumerableExtensions.In<CMsgClothStiffenAnimEvent\>\(CMsgClothStiffenAnimEvent, params CMsgClothStiffenAnimEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent__ctor"></a> CMsgClothStiffenAnimEvent\(\)

```csharp
public CMsgClothStiffenAnimEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent__ctor_Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_"></a> CMsgClothStiffenAnimEvent\(CMsgClothStiffenAnimEvent\)

```csharp
public CMsgClothStiffenAnimEvent(CMsgClothStiffenAnimEvent other)
```

#### Parameters

`other` [CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_IntensityFieldNumber"></a> IntensityFieldNumber

```csharp
public const int IntensityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_LengthFieldNumber"></a> LengthFieldNumber

```csharp
public const int LengthFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SourceEntityIndexFieldNumber"></a> SourceEntityIndexFieldNumber

```csharp
public const int SourceEntityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SpeedInFieldNumber"></a> SpeedInFieldNumber

```csharp
public const int SpeedInFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SpeedOutFieldNumber"></a> SpeedOutFieldNumber

```csharp
public const int SpeedOutFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_VertexSetHashFieldNumber"></a> VertexSetHashFieldNumber

```csharp
public const int VertexSetHashFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasIntensity"></a> HasIntensity

```csharp
public bool HasIntensity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasLength"></a> HasLength

```csharp
public bool HasLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasSourceEntityIndex"></a> HasSourceEntityIndex

```csharp
public bool HasSourceEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasSpeedIn"></a> HasSpeedIn

```csharp
public bool HasSpeedIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasSpeedOut"></a> HasSpeedOut

```csharp
public bool HasSpeedOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_HasVertexSetHash"></a> HasVertexSetHash

```csharp
public bool HasVertexSetHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Intensity"></a> Intensity

```csharp
public float Intensity { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Length"></a> Length

```csharp
public float Length { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClothStiffenAnimEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SourceEntityIndex"></a> SourceEntityIndex

```csharp
public int SourceEntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SpeedIn"></a> SpeedIn

```csharp
public float SpeedIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_SpeedOut"></a> SpeedOut

```csharp
public float SpeedOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_VertexSetHash"></a> VertexSetHash

```csharp
public int VertexSetHash { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearIntensity"></a> ClearIntensity\(\)

```csharp
public void ClearIntensity()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearLength"></a> ClearLength\(\)

```csharp
public void ClearLength()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearSourceEntityIndex"></a> ClearSourceEntityIndex\(\)

```csharp
public void ClearSourceEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearSpeedIn"></a> ClearSpeedIn\(\)

```csharp
public void ClearSpeedIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearSpeedOut"></a> ClearSpeedOut\(\)

```csharp
public void ClearSpeedOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ClearVertexSetHash"></a> ClearVertexSetHash\(\)

```csharp
public void ClearVertexSetHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Clone"></a> Clone\(\)

```csharp
public CMsgClothStiffenAnimEvent Clone()
```

#### Returns

 [CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_Equals_Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_"></a> Equals\(CMsgClothStiffenAnimEvent\)

```csharp
public bool Equals(CMsgClothStiffenAnimEvent other)
```

#### Parameters

`other` [CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_"></a> MergeFrom\(CMsgClothStiffenAnimEvent\)

```csharp
public void MergeFrom(CMsgClothStiffenAnimEvent other)
```

#### Parameters

`other` [CMsgClothStiffenAnimEvent](Divine.Protobufs.Dota2.CMsgClothStiffenAnimEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClothStiffenAnimEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

