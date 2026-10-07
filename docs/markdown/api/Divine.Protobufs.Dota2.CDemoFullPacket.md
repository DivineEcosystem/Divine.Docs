# <a id="Divine_Protobufs_Dota2_CDemoFullPacket"></a> Class CDemoFullPacket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoFullPacket : IMessage<CDemoFullPacket>, IEquatable<CDemoFullPacket>, IDeepCloneable<CDemoFullPacket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)

#### Implements

IMessage<CDemoFullPacket\>, 
[IEquatable<CDemoFullPacket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoFullPacket\>, 
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
[EnumerableExtensions.In<CDemoFullPacket\>\(CDemoFullPacket, params CDemoFullPacket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket__ctor"></a> CDemoFullPacket\(\)

```csharp
public CDemoFullPacket()
```

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket__ctor_Divine_Protobufs_Dota2_CDemoFullPacket_"></a> CDemoFullPacket\(CDemoFullPacket\)

```csharp
public CDemoFullPacket(CDemoFullPacket other)
```

#### Parameters

`other` [CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_PacketFieldNumber"></a> PacketFieldNumber

```csharp
public const int PacketFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_StringTableFieldNumber"></a> StringTableFieldNumber

```csharp
public const int StringTableFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Packet"></a> Packet

```csharp
public CDemoPacket Packet { get; set; }
```

#### Property Value

 [CDemoPacket](Divine.Protobufs.Dota2.CDemoPacket.md)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Parser"></a> Parser

```csharp
public static MessageParser<CDemoFullPacket> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_StringTable"></a> StringTable

```csharp
public CDemoStringTables StringTable { get; set; }
```

#### Property Value

 [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Clone"></a> Clone\(\)

```csharp
public CDemoFullPacket Clone()
```

#### Returns

 [CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_Equals_Divine_Protobufs_Dota2_CDemoFullPacket_"></a> Equals\(CDemoFullPacket\)

```csharp
public bool Equals(CDemoFullPacket other)
```

#### Parameters

`other` [CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_MergeFrom_Divine_Protobufs_Dota2_CDemoFullPacket_"></a> MergeFrom\(CDemoFullPacket\)

```csharp
public void MergeFrom(CDemoFullPacket other)
```

#### Parameters

`other` [CDemoFullPacket](Divine.Protobufs.Dota2.CDemoFullPacket.md)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFullPacket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

