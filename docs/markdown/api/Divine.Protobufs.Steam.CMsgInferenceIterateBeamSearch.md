# <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch"></a> Class CMsgInferenceIterateBeamSearch

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInferenceIterateBeamSearch : IMessage<CMsgInferenceIterateBeamSearch>, IEquatable<CMsgInferenceIterateBeamSearch>, IDeepCloneable<CMsgInferenceIterateBeamSearch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)

#### Implements

IMessage<CMsgInferenceIterateBeamSearch\>, 
[IEquatable<CMsgInferenceIterateBeamSearch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInferenceIterateBeamSearch\>, 
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
[EnumerableExtensions.In<CMsgInferenceIterateBeamSearch\>\(CMsgInferenceIterateBeamSearch, params CMsgInferenceIterateBeamSearch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch__ctor"></a> CMsgInferenceIterateBeamSearch\(\)

```csharp
public CMsgInferenceIterateBeamSearch()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch__ctor_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_"></a> CMsgInferenceIterateBeamSearch\(CMsgInferenceIterateBeamSearch\)

```csharp
public CMsgInferenceIterateBeamSearch(CMsgInferenceIterateBeamSearch other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_BeamLengthFieldNumber"></a> BeamLengthFieldNumber

```csharp
public const int BeamLengthFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_BeamWidthFieldNumber"></a> BeamWidthFieldNumber

```csharp
public const int BeamWidthFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemDecayFieldNumber"></a> ItemDecayFieldNumber

```csharp
public const int ItemDecayFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemScalarsFieldNumber"></a> ItemScalarsFieldNumber

```csharp
public const int ItemScalarsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemSequenceEndFieldNumber"></a> ItemSequenceEndFieldNumber

```csharp
public const int ItemSequenceEndFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemSequenceEndThresholdFieldNumber"></a> ItemSequenceEndThresholdFieldNumber

```csharp
public const int ItemSequenceEndThresholdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_NextItemCountFieldNumber"></a> NextItemCountFieldNumber

```csharp
public const int NextItemCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_RepeatMultiplierFieldNumber"></a> RepeatMultiplierFieldNumber

```csharp
public const int RepeatMultiplierFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_BeamLength"></a> BeamLength

```csharp
public uint BeamLength { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_BeamWidth"></a> BeamWidth

```csharp
public uint BeamWidth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasBeamLength"></a> HasBeamLength

```csharp
public bool HasBeamLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasBeamWidth"></a> HasBeamWidth

```csharp
public bool HasBeamWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasItemDecay"></a> HasItemDecay

```csharp
public bool HasItemDecay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasItemSequenceEnd"></a> HasItemSequenceEnd

```csharp
public bool HasItemSequenceEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasItemSequenceEndThreshold"></a> HasItemSequenceEndThreshold

```csharp
public bool HasItemSequenceEndThreshold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasNextItemCount"></a> HasNextItemCount

```csharp
public bool HasNextItemCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_HasRepeatMultiplier"></a> HasRepeatMultiplier

```csharp
public bool HasRepeatMultiplier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemDecay"></a> ItemDecay

```csharp
public float ItemDecay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemScalars"></a> ItemScalars

```csharp
public RepeatedField<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar> ItemScalars { get; }
```

#### Property Value

 RepeatedField<[CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)\>

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemSequenceEnd"></a> ItemSequenceEnd

```csharp
public uint ItemSequenceEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ItemSequenceEndThreshold"></a> ItemSequenceEndThreshold

```csharp
public float ItemSequenceEndThreshold { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_NextItemCount"></a> NextItemCount

```csharp
public uint NextItemCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInferenceIterateBeamSearch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)\>

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_RepeatMultiplier"></a> RepeatMultiplier

```csharp
public float RepeatMultiplier { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearBeamLength"></a> ClearBeamLength\(\)

```csharp
public void ClearBeamLength()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearBeamWidth"></a> ClearBeamWidth\(\)

```csharp
public void ClearBeamWidth()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearItemDecay"></a> ClearItemDecay\(\)

```csharp
public void ClearItemDecay()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearItemSequenceEnd"></a> ClearItemSequenceEnd\(\)

```csharp
public void ClearItemSequenceEnd()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearItemSequenceEndThreshold"></a> ClearItemSequenceEndThreshold\(\)

```csharp
public void ClearItemSequenceEndThreshold()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearNextItemCount"></a> ClearNextItemCount\(\)

```csharp
public void ClearNextItemCount()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ClearRepeatMultiplier"></a> ClearRepeatMultiplier\(\)

```csharp
public void ClearRepeatMultiplier()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Clone"></a> Clone\(\)

```csharp
public CMsgInferenceIterateBeamSearch Clone()
```

#### Returns

 [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Equals_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_"></a> Equals\(CMsgInferenceIterateBeamSearch\)

```csharp
public bool Equals(CMsgInferenceIterateBeamSearch other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_MergeFrom_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_"></a> MergeFrom\(CMsgInferenceIterateBeamSearch\)

```csharp
public void MergeFrom(CMsgInferenceIterateBeamSearch other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

