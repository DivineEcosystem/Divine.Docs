# <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground"></a> Class CMsgShowcaseBackground

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseBackground : IMessage<CMsgShowcaseBackground>, IEquatable<CMsgShowcaseBackground>, IDeepCloneable<CMsgShowcaseBackground>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)

#### Implements

IMessage<CMsgShowcaseBackground\>, 
[IEquatable<CMsgShowcaseBackground\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseBackground\>, 
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
[EnumerableExtensions.In<CMsgShowcaseBackground\>\(CMsgShowcaseBackground, params CMsgShowcaseBackground\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground__ctor"></a> CMsgShowcaseBackground\(\)

```csharp
public CMsgShowcaseBackground()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground__ctor_Divine_Protobufs_Dota2_CMsgShowcaseBackground_"></a> CMsgShowcaseBackground\(CMsgShowcaseBackground\)

```csharp
public CMsgShowcaseBackground(CMsgShowcaseBackground other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_BackgroundIdFieldNumber"></a> BackgroundIdFieldNumber

```csharp
public const int BackgroundIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_BlurFieldNumber"></a> BlurFieldNumber

```csharp
public const int BlurFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_DimFieldNumber"></a> DimFieldNumber

```csharp
public const int DimFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_LoadingScreenRefFieldNumber"></a> LoadingScreenRefFieldNumber

```csharp
public const int LoadingScreenRefFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_BackgroundId"></a> BackgroundId

```csharp
public uint BackgroundId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Blur"></a> Blur

```csharp
public uint Blur { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Data"></a> Data

```csharp
public CMsgShowcaseBackground.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Dim"></a> Dim

```csharp
public uint Dim { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_HasBackgroundId"></a> HasBackgroundId

```csharp
public bool HasBackgroundId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_HasBlur"></a> HasBlur

```csharp
public bool HasBlur { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_HasDim"></a> HasDim

```csharp
public bool HasDim { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_LoadingScreenRef"></a> LoadingScreenRef

```csharp
public CMsgShowcaseEconItemReference LoadingScreenRef { get; set; }
```

#### Property Value

 [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseBackground> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_ClearBackgroundId"></a> ClearBackgroundId\(\)

```csharp
public void ClearBackgroundId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_ClearBlur"></a> ClearBlur\(\)

```csharp
public void ClearBlur()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_ClearDim"></a> ClearDim\(\)

```csharp
public void ClearDim()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseBackground Clone()
```

#### Returns

 [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Equals_Divine_Protobufs_Dota2_CMsgShowcaseBackground_"></a> Equals\(CMsgShowcaseBackground\)

```csharp
public bool Equals(CMsgShowcaseBackground other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseBackground_"></a> MergeFrom\(CMsgShowcaseBackground\)

```csharp
public void MergeFrom(CMsgShowcaseBackground other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

