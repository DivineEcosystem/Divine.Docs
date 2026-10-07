# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange"></a> Class CProtoItemSocket\_Strange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Strange : IMessage<CProtoItemSocket_Strange>, IEquatable<CProtoItemSocket_Strange>, IDeepCloneable<CProtoItemSocket_Strange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)

#### Implements

IMessage<CProtoItemSocket\_Strange\>, 
[IEquatable<CProtoItemSocket\_Strange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Strange\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Strange\>\(CProtoItemSocket\_Strange, params CProtoItemSocket\_Strange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange__ctor"></a> CProtoItemSocket\_Strange\(\)

```csharp
public CProtoItemSocket_Strange()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Strange_"></a> CProtoItemSocket\_Strange\(CProtoItemSocket\_Strange\)

```csharp
public CProtoItemSocket_Strange(CProtoItemSocket_Strange other)
```

#### Parameters

`other` [CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_StrangeTypeFieldNumber"></a> StrangeTypeFieldNumber

```csharp
public const int StrangeTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_StrangeValueFieldNumber"></a> StrangeValueFieldNumber

```csharp
public const int StrangeValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_HasStrangeType"></a> HasStrangeType

```csharp
public bool HasStrangeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_HasStrangeValue"></a> HasStrangeValue

```csharp
public bool HasStrangeValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Strange> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_StrangeType"></a> StrangeType

```csharp
public uint StrangeType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_StrangeValue"></a> StrangeValue

```csharp
public uint StrangeValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_ClearStrangeType"></a> ClearStrangeType\(\)

```csharp
public void ClearStrangeType()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_ClearStrangeValue"></a> ClearStrangeValue\(\)

```csharp
public void ClearStrangeValue()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Strange Clone()
```

#### Returns

 [CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Strange_"></a> Equals\(CProtoItemSocket\_Strange\)

```csharp
public bool Equals(CProtoItemSocket_Strange other)
```

#### Parameters

`other` [CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Strange_"></a> MergeFrom\(CProtoItemSocket\_Strange\)

```csharp
public void MergeFrom(CProtoItemSocket_Strange other)
```

#### Parameters

`other` [CProtoItemSocket\_Strange](Divine.Protobufs.Dota2.CProtoItemSocket\_Strange.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Strange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

