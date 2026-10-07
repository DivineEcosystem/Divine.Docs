# <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream"></a> Class CMsgTEBloodStream

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEBloodStream : IMessage<CMsgTEBloodStream>, IEquatable<CMsgTEBloodStream>, IDeepCloneable<CMsgTEBloodStream>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)

#### Implements

IMessage<CMsgTEBloodStream\>, 
[IEquatable<CMsgTEBloodStream\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEBloodStream\>, 
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
[EnumerableExtensions.In<CMsgTEBloodStream\>\(CMsgTEBloodStream, params CMsgTEBloodStream\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream__ctor"></a> CMsgTEBloodStream\(\)

```csharp
public CMsgTEBloodStream()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream__ctor_Divine_Protobufs_Dota2_CMsgTEBloodStream_"></a> CMsgTEBloodStream\(CMsgTEBloodStream\)

```csharp
public CMsgTEBloodStream(CMsgTEBloodStream other)
```

#### Parameters

`other` [CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_AmountFieldNumber"></a> AmountFieldNumber

```csharp
public const int AmountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_DirectionFieldNumber"></a> DirectionFieldNumber

```csharp
public const int DirectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Amount"></a> Amount

```csharp
public uint Amount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Direction"></a> Direction

```csharp
public CMsgVector Direction { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_HasAmount"></a> HasAmount

```csharp
public bool HasAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEBloodStream> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_ClearAmount"></a> ClearAmount\(\)

```csharp
public void ClearAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Clone"></a> Clone\(\)

```csharp
public CMsgTEBloodStream Clone()
```

#### Returns

 [CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_Equals_Divine_Protobufs_Dota2_CMsgTEBloodStream_"></a> Equals\(CMsgTEBloodStream\)

```csharp
public bool Equals(CMsgTEBloodStream other)
```

#### Parameters

`other` [CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_MergeFrom_Divine_Protobufs_Dota2_CMsgTEBloodStream_"></a> MergeFrom\(CMsgTEBloodStream\)

```csharp
public void MergeFrom(CMsgTEBloodStream other)
```

#### Parameters

`other` [CMsgTEBloodStream](Divine.Protobufs.Dota2.CMsgTEBloodStream.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEBloodStream_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

