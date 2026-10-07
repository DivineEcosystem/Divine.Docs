# <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff"></a> Class CMsgGCToClientAggregateMetricsBackoff

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientAggregateMetricsBackoff : IMessage<CMsgGCToClientAggregateMetricsBackoff>, IEquatable<CMsgGCToClientAggregateMetricsBackoff>, IDeepCloneable<CMsgGCToClientAggregateMetricsBackoff>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)

#### Implements

IMessage<CMsgGCToClientAggregateMetricsBackoff\>, 
[IEquatable<CMsgGCToClientAggregateMetricsBackoff\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientAggregateMetricsBackoff\>, 
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
[EnumerableExtensions.In<CMsgGCToClientAggregateMetricsBackoff\>\(CMsgGCToClientAggregateMetricsBackoff, params CMsgGCToClientAggregateMetricsBackoff\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff__ctor"></a> CMsgGCToClientAggregateMetricsBackoff\(\)

```csharp
public CMsgGCToClientAggregateMetricsBackoff()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff__ctor_Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_"></a> CMsgGCToClientAggregateMetricsBackoff\(CMsgGCToClientAggregateMetricsBackoff\)

```csharp
public CMsgGCToClientAggregateMetricsBackoff(CMsgGCToClientAggregateMetricsBackoff other)
```

#### Parameters

`other` [CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_UploadRateModifierFieldNumber"></a> UploadRateModifierFieldNumber

```csharp
public const int UploadRateModifierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_HasUploadRateModifier"></a> HasUploadRateModifier

```csharp
public bool HasUploadRateModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientAggregateMetricsBackoff> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_UploadRateModifier"></a> UploadRateModifier

```csharp
public float UploadRateModifier { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_ClearUploadRateModifier"></a> ClearUploadRateModifier\(\)

```csharp
public void ClearUploadRateModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientAggregateMetricsBackoff Clone()
```

#### Returns

 [CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_Equals_Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_"></a> Equals\(CMsgGCToClientAggregateMetricsBackoff\)

```csharp
public bool Equals(CMsgGCToClientAggregateMetricsBackoff other)
```

#### Parameters

`other` [CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_"></a> MergeFrom\(CMsgGCToClientAggregateMetricsBackoff\)

```csharp
public void MergeFrom(CMsgGCToClientAggregateMetricsBackoff other)
```

#### Parameters

`other` [CMsgGCToClientAggregateMetricsBackoff](Divine.Protobufs.Dota2.CMsgGCToClientAggregateMetricsBackoff.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientAggregateMetricsBackoff_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

