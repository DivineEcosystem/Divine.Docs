# <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams"></a> Class CMsgSosSetSoundEventParams

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSosSetSoundEventParams : IMessage<CMsgSosSetSoundEventParams>, IEquatable<CMsgSosSetSoundEventParams>, IDeepCloneable<CMsgSosSetSoundEventParams>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)

#### Implements

IMessage<CMsgSosSetSoundEventParams\>, 
[IEquatable<CMsgSosSetSoundEventParams\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSosSetSoundEventParams\>, 
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
[EnumerableExtensions.In<CMsgSosSetSoundEventParams\>\(CMsgSosSetSoundEventParams, params CMsgSosSetSoundEventParams\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams__ctor"></a> CMsgSosSetSoundEventParams\(\)

```csharp
public CMsgSosSetSoundEventParams()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams__ctor_Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_"></a> CMsgSosSetSoundEventParams\(CMsgSosSetSoundEventParams\)

```csharp
public CMsgSosSetSoundEventParams(CMsgSosSetSoundEventParams other)
```

#### Parameters

`other` [CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_PackedParamsFieldNumber"></a> PackedParamsFieldNumber

```csharp
public const int PackedParamsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_SoundeventGuidFieldNumber"></a> SoundeventGuidFieldNumber

```csharp
public const int SoundeventGuidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_HasPackedParams"></a> HasPackedParams

```csharp
public bool HasPackedParams { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_HasSoundeventGuid"></a> HasSoundeventGuid

```csharp
public bool HasSoundeventGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_PackedParams"></a> PackedParams

```csharp
public ByteString PackedParams { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSosSetSoundEventParams> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_SoundeventGuid"></a> SoundeventGuid

```csharp
public int SoundeventGuid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_ClearPackedParams"></a> ClearPackedParams\(\)

```csharp
public void ClearPackedParams()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_ClearSoundeventGuid"></a> ClearSoundeventGuid\(\)

```csharp
public void ClearSoundeventGuid()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_Clone"></a> Clone\(\)

```csharp
public CMsgSosSetSoundEventParams Clone()
```

#### Returns

 [CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_Equals_Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_"></a> Equals\(CMsgSosSetSoundEventParams\)

```csharp
public bool Equals(CMsgSosSetSoundEventParams other)
```

#### Parameters

`other` [CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_MergeFrom_Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_"></a> MergeFrom\(CMsgSosSetSoundEventParams\)

```csharp
public void MergeFrom(CMsgSosSetSoundEventParams other)
```

#### Parameters

`other` [CMsgSosSetSoundEventParams](Divine.Protobufs.Dota2.CMsgSosSetSoundEventParams.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetSoundEventParams_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

