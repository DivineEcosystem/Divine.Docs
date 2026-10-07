# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph"></a> Class CProtoItemSocket\_Autograph

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Autograph : IMessage<CProtoItemSocket_Autograph>, IEquatable<CProtoItemSocket_Autograph>, IDeepCloneable<CProtoItemSocket_Autograph>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)

#### Implements

IMessage<CProtoItemSocket\_Autograph\>, 
[IEquatable<CProtoItemSocket\_Autograph\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Autograph\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Autograph\>\(CProtoItemSocket\_Autograph, params CProtoItemSocket\_Autograph\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph__ctor"></a> CProtoItemSocket\_Autograph\(\)

```csharp
public CProtoItemSocket_Autograph()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_"></a> CProtoItemSocket\_Autograph\(CProtoItemSocket\_Autograph\)

```csharp
public CProtoItemSocket_Autograph(CProtoItemSocket_Autograph other)
```

#### Parameters

`other` [CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_AutographFieldNumber"></a> AutographFieldNumber

```csharp
public const int AutographFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_AutographIdFieldNumber"></a> AutographIdFieldNumber

```csharp
public const int AutographIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_AutographScoreFieldNumber"></a> AutographScoreFieldNumber

```csharp
public const int AutographScoreFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Autograph"></a> Autograph

```csharp
public string Autograph { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_AutographId"></a> AutographId

```csharp
public uint AutographId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_AutographScore"></a> AutographScore

```csharp
public uint AutographScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_HasAutograph"></a> HasAutograph

```csharp
public bool HasAutograph { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_HasAutographId"></a> HasAutographId

```csharp
public bool HasAutographId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_HasAutographScore"></a> HasAutographScore

```csharp
public bool HasAutographScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Autograph> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_ClearAutograph"></a> ClearAutograph\(\)

```csharp
public void ClearAutograph()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_ClearAutographId"></a> ClearAutographId\(\)

```csharp
public void ClearAutographId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_ClearAutographScore"></a> ClearAutographScore\(\)

```csharp
public void ClearAutographScore()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Autograph Clone()
```

#### Returns

 [CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_"></a> Equals\(CProtoItemSocket\_Autograph\)

```csharp
public bool Equals(CProtoItemSocket_Autograph other)
```

#### Parameters

`other` [CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_"></a> MergeFrom\(CProtoItemSocket\_Autograph\)

```csharp
public void MergeFrom(CProtoItemSocket_Autograph other)
```

#### Parameters

`other` [CProtoItemSocket\_Autograph](Divine.Protobufs.Dota2.CProtoItemSocket\_Autograph.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Autograph_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

