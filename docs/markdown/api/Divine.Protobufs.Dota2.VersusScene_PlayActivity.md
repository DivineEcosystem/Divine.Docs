# <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity"></a> Class VersusScene\_PlayActivity

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class VersusScene_PlayActivity : IMessage<VersusScene_PlayActivity>, IEquatable<VersusScene_PlayActivity>, IDeepCloneable<VersusScene_PlayActivity>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

#### Implements

IMessage<VersusScene\_PlayActivity\>, 
[IEquatable<VersusScene\_PlayActivity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<VersusScene\_PlayActivity\>, 
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
[EnumerableExtensions.In<VersusScene\_PlayActivity\>\(VersusScene\_PlayActivity, params VersusScene\_PlayActivity\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity__ctor"></a> VersusScene\_PlayActivity\(\)

```csharp
public VersusScene_PlayActivity()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity__ctor_Divine_Protobufs_Dota2_VersusScene_PlayActivity_"></a> VersusScene\_PlayActivity\(VersusScene\_PlayActivity\)

```csharp
public VersusScene_PlayActivity(VersusScene_PlayActivity other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

## Fields

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_ActivitiesFieldNumber"></a> ActivitiesFieldNumber

```csharp
public const int ActivitiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_PlaybackRateFieldNumber"></a> PlaybackRateFieldNumber

```csharp
public const int PlaybackRateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Activities"></a> Activities

```csharp
public RepeatedField<VersusScene_PlayActivity.Types.ActivityInfo> Activities { get; }
```

#### Property Value

 RepeatedField<[VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)\>

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_HasPlaybackRate"></a> HasPlaybackRate

```csharp
public bool HasPlaybackRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Parser"></a> Parser

```csharp
public static MessageParser<VersusScene_PlayActivity> Parser { get; }
```

#### Property Value

 MessageParser<[VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)\>

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_PlaybackRate"></a> PlaybackRate

```csharp
public float PlaybackRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_ClearPlaybackRate"></a> ClearPlaybackRate\(\)

```csharp
public void ClearPlaybackRate()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Clone"></a> Clone\(\)

```csharp
public VersusScene_PlayActivity Clone()
```

#### Returns

 [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Equals_Divine_Protobufs_Dota2_VersusScene_PlayActivity_"></a> Equals\(VersusScene\_PlayActivity\)

```csharp
public bool Equals(VersusScene_PlayActivity other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_MergeFrom_Divine_Protobufs_Dota2_VersusScene_PlayActivity_"></a> MergeFrom\(VersusScene\_PlayActivity\)

```csharp
public void MergeFrom(VersusScene_PlayActivity other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

