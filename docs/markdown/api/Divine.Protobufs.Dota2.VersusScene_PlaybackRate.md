# <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate"></a> Class VersusScene\_PlaybackRate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class VersusScene_PlaybackRate : IMessage<VersusScene_PlaybackRate>, IEquatable<VersusScene_PlaybackRate>, IDeepCloneable<VersusScene_PlaybackRate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

#### Implements

IMessage<VersusScene\_PlaybackRate\>, 
[IEquatable<VersusScene\_PlaybackRate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<VersusScene\_PlaybackRate\>, 
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
[EnumerableExtensions.In<VersusScene\_PlaybackRate\>\(VersusScene\_PlaybackRate, params VersusScene\_PlaybackRate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate__ctor"></a> VersusScene\_PlaybackRate\(\)

```csharp
public VersusScene_PlaybackRate()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate__ctor_Divine_Protobufs_Dota2_VersusScene_PlaybackRate_"></a> VersusScene\_PlaybackRate\(VersusScene\_PlaybackRate\)

```csharp
public VersusScene_PlaybackRate(VersusScene_PlaybackRate other)
```

#### Parameters

`other` [VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_RateFieldNumber"></a> RateFieldNumber

```csharp
public const int RateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_HasRate"></a> HasRate

```csharp
public bool HasRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Parser"></a> Parser

```csharp
public static MessageParser<VersusScene_PlaybackRate> Parser { get; }
```

#### Property Value

 MessageParser<[VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)\>

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Rate"></a> Rate

```csharp
public float Rate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_ClearRate"></a> ClearRate\(\)

```csharp
public void ClearRate()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Clone"></a> Clone\(\)

```csharp
public VersusScene_PlaybackRate Clone()
```

#### Returns

 [VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_Equals_Divine_Protobufs_Dota2_VersusScene_PlaybackRate_"></a> Equals\(VersusScene\_PlaybackRate\)

```csharp
public bool Equals(VersusScene_PlaybackRate other)
```

#### Parameters

`other` [VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_MergeFrom_Divine_Protobufs_Dota2_VersusScene_PlaybackRate_"></a> MergeFrom\(VersusScene\_PlaybackRate\)

```csharp
public void MergeFrom(VersusScene_PlaybackRate other)
```

#### Parameters

`other` [VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlaybackRate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

