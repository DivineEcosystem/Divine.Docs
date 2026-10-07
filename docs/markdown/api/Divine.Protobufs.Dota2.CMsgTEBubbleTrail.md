# <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail"></a> Class CMsgTEBubbleTrail

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEBubbleTrail : IMessage<CMsgTEBubbleTrail>, IEquatable<CMsgTEBubbleTrail>, IDeepCloneable<CMsgTEBubbleTrail>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)

#### Implements

IMessage<CMsgTEBubbleTrail\>, 
[IEquatable<CMsgTEBubbleTrail\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEBubbleTrail\>, 
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
[EnumerableExtensions.In<CMsgTEBubbleTrail\>\(CMsgTEBubbleTrail, params CMsgTEBubbleTrail\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail__ctor"></a> CMsgTEBubbleTrail\(\)

```csharp
public CMsgTEBubbleTrail()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail__ctor_Divine_Protobufs_Dota2_CMsgTEBubbleTrail_"></a> CMsgTEBubbleTrail\(CMsgTEBubbleTrail\)

```csharp
public CMsgTEBubbleTrail(CMsgTEBubbleTrail other)
```

#### Parameters

`other` [CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_MaxsFieldNumber"></a> MaxsFieldNumber

```csharp
public const int MaxsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_MinsFieldNumber"></a> MinsFieldNumber

```csharp
public const int MinsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_SpeedFieldNumber"></a> SpeedFieldNumber

```csharp
public const int SpeedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_WaterzFieldNumber"></a> WaterzFieldNumber

```csharp
public const int WaterzFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_HasSpeed"></a> HasSpeed

```csharp
public bool HasSpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_HasWaterz"></a> HasWaterz

```csharp
public bool HasWaterz { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Maxs"></a> Maxs

```csharp
public CMsgVector Maxs { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Mins"></a> Mins

```csharp
public CMsgVector Mins { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEBubbleTrail> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Speed"></a> Speed

```csharp
public float Speed { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Waterz"></a> Waterz

```csharp
public float Waterz { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_ClearSpeed"></a> ClearSpeed\(\)

```csharp
public void ClearSpeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_ClearWaterz"></a> ClearWaterz\(\)

```csharp
public void ClearWaterz()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Clone"></a> Clone\(\)

```csharp
public CMsgTEBubbleTrail Clone()
```

#### Returns

 [CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_Equals_Divine_Protobufs_Dota2_CMsgTEBubbleTrail_"></a> Equals\(CMsgTEBubbleTrail\)

```csharp
public bool Equals(CMsgTEBubbleTrail other)
```

#### Parameters

`other` [CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_MergeFrom_Divine_Protobufs_Dota2_CMsgTEBubbleTrail_"></a> MergeFrom\(CMsgTEBubbleTrail\)

```csharp
public void MergeFrom(CMsgTEBubbleTrail other)
```

#### Parameters

`other` [CMsgTEBubbleTrail](Divine.Protobufs.Dota2.CMsgTEBubbleTrail.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEBubbleTrail_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

