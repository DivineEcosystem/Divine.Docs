# <a id="Divine_Protobufs_Dota2_CDemoPacket"></a> Class CDemoPacket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoPacket : IMessage<CDemoPacket>, IEquatable<CDemoPacket>, IDeepCloneable<CDemoPacket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

#### Implements

IMessage<CDemoPacket\>, 
[IEquatable<CDemoPacket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoPacket\>, 
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
[EnumerableExtensions.In<CDemoPacket\>\(CDemoPacket, params CDemoPacket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoPacket__ctor"></a> CDemoPacket\(\)

```csharp
public CDemoPacket()
```

### <a id="Divine_Protobufs_Dota2_CDemoPacket__ctor_Divine_Protobufs_Dota2_CDemoPacket_"></a> CDemoPacket\(CDemoPacket\)

```csharp
public CDemoPacket(CDemoPacket other)
```

#### Parameters

`other` [CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoPacket_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoPacket_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Parser"></a> Parser

```csharp
public static MessageParser<CDemoPacket> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoPacket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Clone"></a> Clone\(\)

```csharp
public CDemoPacket Clone()
```

#### Returns

 [CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_Equals_Divine_Protobufs_Dota2_CDemoPacket_"></a> Equals\(CDemoPacket\)

```csharp
public bool Equals(CDemoPacket other)
```

#### Parameters

`other` [CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_MergeFrom_Divine_Protobufs_Dota2_CDemoPacket_"></a> MergeFrom\(CDemoPacket\)

```csharp
public void MergeFrom(CDemoPacket other)
```

#### Parameters

`other` [CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoPacket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoPacket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

