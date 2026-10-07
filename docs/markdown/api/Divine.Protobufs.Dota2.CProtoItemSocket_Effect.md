# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect"></a> Class CProtoItemSocket\_Effect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_Effect : IMessage<CProtoItemSocket_Effect>, IEquatable<CProtoItemSocket_Effect>, IDeepCloneable<CProtoItemSocket_Effect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)

#### Implements

IMessage<CProtoItemSocket\_Effect\>, 
[IEquatable<CProtoItemSocket\_Effect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_Effect\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_Effect\>\(CProtoItemSocket\_Effect, params CProtoItemSocket\_Effect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect__ctor"></a> CProtoItemSocket\_Effect\(\)

```csharp
public CProtoItemSocket_Effect()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_Effect_"></a> CProtoItemSocket\_Effect\(CProtoItemSocket\_Effect\)

```csharp
public CProtoItemSocket_Effect(CProtoItemSocket_Effect other)
```

#### Parameters

`other` [CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_EffectFieldNumber"></a> EffectFieldNumber

```csharp
public const int EffectFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Effect"></a> Effect

```csharp
public uint Effect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_HasEffect"></a> HasEffect

```csharp
public bool HasEffect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_Effect> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_ClearEffect"></a> ClearEffect\(\)

```csharp
public void ClearEffect()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_Effect Clone()
```

#### Returns

 [CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_Effect_"></a> Equals\(CProtoItemSocket\_Effect\)

```csharp
public bool Equals(CProtoItemSocket_Effect other)
```

#### Parameters

`other` [CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_Effect_"></a> MergeFrom\(CProtoItemSocket\_Effect\)

```csharp
public void MergeFrom(CProtoItemSocket_Effect other)
```

#### Parameters

`other` [CProtoItemSocket\_Effect](Divine.Protobufs.Dota2.CProtoItemSocket\_Effect.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Effect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

