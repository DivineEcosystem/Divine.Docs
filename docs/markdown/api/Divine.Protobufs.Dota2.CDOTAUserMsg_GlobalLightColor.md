# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor"></a> Class CDOTAUserMsg\_GlobalLightColor

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GlobalLightColor : IMessage<CDOTAUserMsg_GlobalLightColor>, IEquatable<CDOTAUserMsg_GlobalLightColor>, IDeepCloneable<CDOTAUserMsg_GlobalLightColor>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)

#### Implements

IMessage<CDOTAUserMsg\_GlobalLightColor\>, 
[IEquatable<CDOTAUserMsg\_GlobalLightColor\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GlobalLightColor\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GlobalLightColor\>\(CDOTAUserMsg\_GlobalLightColor, params CDOTAUserMsg\_GlobalLightColor\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor__ctor"></a> CDOTAUserMsg\_GlobalLightColor\(\)

```csharp
public CDOTAUserMsg_GlobalLightColor()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_"></a> CDOTAUserMsg\_GlobalLightColor\(CDOTAUserMsg\_GlobalLightColor\)

```csharp
public CDOTAUserMsg_GlobalLightColor(CDOTAUserMsg_GlobalLightColor other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GlobalLightColor> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GlobalLightColor Clone()
```

#### Returns

 [CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_"></a> Equals\(CDOTAUserMsg\_GlobalLightColor\)

```csharp
public bool Equals(CDOTAUserMsg_GlobalLightColor other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_"></a> MergeFrom\(CDOTAUserMsg\_GlobalLightColor\)

```csharp
public void MergeFrom(CDOTAUserMsg_GlobalLightColor other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightColor](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightColor.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightColor_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

