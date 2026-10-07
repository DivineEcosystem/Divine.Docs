# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color"></a> Class CProtoItemSocket\_Color

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Color : IMessage<CProtoItemSocket_Color>, IEquatable<CProtoItemSocket_Color>, IDeepCloneable<CProtoItemSocket_Color>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)

#### Implements

IMessage<CProtoItemSocket\_Color\>, 
[IEquatable<CProtoItemSocket\_Color\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Color\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Color\>\(CProtoItemSocket\_Color, params CProtoItemSocket\_Color\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color__ctor"></a> CProtoItemSocket\_Color\(\)

```csharp
public CProtoItemSocket_Color()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Color_"></a> CProtoItemSocket\_Color\(CProtoItemSocket\_Color\)

```csharp
public CProtoItemSocket_Color(CProtoItemSocket_Color other)
```

#### Parameters

`other` [CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_BlueFieldNumber"></a> BlueFieldNumber

```csharp
public const int BlueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_GreenFieldNumber"></a> GreenFieldNumber

```csharp
public const int GreenFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_RedFieldNumber"></a> RedFieldNumber

```csharp
public const int RedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Blue"></a> Blue

```csharp
public uint Blue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Green"></a> Green

```csharp
public uint Green { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_HasBlue"></a> HasBlue

```csharp
public bool HasBlue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_HasGreen"></a> HasGreen

```csharp
public bool HasGreen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_HasRed"></a> HasRed

```csharp
public bool HasRed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Color> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Red"></a> Red

```csharp
public uint Red { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_ClearBlue"></a> ClearBlue\(\)

```csharp
public void ClearBlue()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_ClearGreen"></a> ClearGreen\(\)

```csharp
public void ClearGreen()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_ClearRed"></a> ClearRed\(\)

```csharp
public void ClearRed()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Color Clone()
```

#### Returns

 [CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Color_"></a> Equals\(CProtoItemSocket\_Color\)

```csharp
public bool Equals(CProtoItemSocket_Color other)
```

#### Parameters

`other` [CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Color_"></a> MergeFrom\(CProtoItemSocket\_Color\)

```csharp
public void MergeFrom(CProtoItemSocket_Color other)
```

#### Parameters

`other` [CProtoItemSocket\_Color](Divine.Protobufs.Dota2.CProtoItemSocket\_Color.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Color_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

