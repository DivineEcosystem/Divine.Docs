# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty"></a> Class CProtoItemSocket\_Empty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Empty : IMessage<CProtoItemSocket_Empty>, IEquatable<CProtoItemSocket_Empty>, IDeepCloneable<CProtoItemSocket_Empty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)

#### Implements

IMessage<CProtoItemSocket\_Empty\>, 
[IEquatable<CProtoItemSocket\_Empty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Empty\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Empty\>\(CProtoItemSocket\_Empty, params CProtoItemSocket\_Empty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty__ctor"></a> CProtoItemSocket\_Empty\(\)

```csharp
public CProtoItemSocket_Empty()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Empty_"></a> CProtoItemSocket\_Empty\(CProtoItemSocket\_Empty\)

```csharp
public CProtoItemSocket_Empty(CProtoItemSocket_Empty other)
```

#### Parameters

`other` [CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Empty> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Empty Clone()
```

#### Returns

 [CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Empty_"></a> Equals\(CProtoItemSocket\_Empty\)

```csharp
public bool Equals(CProtoItemSocket_Empty other)
```

#### Parameters

`other` [CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Empty_"></a> MergeFrom\(CProtoItemSocket\_Empty\)

```csharp
public void MergeFrom(CProtoItemSocket_Empty other)
```

#### Parameters

`other` [CProtoItemSocket\_Empty](Divine.Protobufs.Dota2.CProtoItemSocket\_Empty.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Empty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

