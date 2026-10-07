# <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier"></a> Class CProtoItemSocket\_AssetModifier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket_AssetModifier : IMessage<CProtoItemSocket_AssetModifier>, IEquatable<CProtoItemSocket_AssetModifier>, IDeepCloneable<CProtoItemSocket_AssetModifier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)

#### Implements

IMessage<CProtoItemSocket\_AssetModifier\>, 
[IEquatable<CProtoItemSocket\_AssetModifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\_AssetModifier\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\_AssetModifier\>\(CProtoItemSocket\_AssetModifier, params CProtoItemSocket\_AssetModifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier__ctor"></a> CProtoItemSocket\_AssetModifier\(\)

```csharp
public CProtoItemSocket_AssetModifier()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_"></a> CProtoItemSocket\_AssetModifier\(CProtoItemSocket\_AssetModifier\)

```csharp
public CProtoItemSocket_AssetModifier(CProtoItemSocket_AssetModifier other)
```

#### Parameters

`other` [CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_AssetModifierFieldNumber"></a> AssetModifierFieldNumber

```csharp
public const int AssetModifierFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_SocketFieldNumber"></a> SocketFieldNumber

```csharp
public const int SocketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_AssetModifier"></a> AssetModifier

```csharp
public uint AssetModifier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_HasAssetModifier"></a> HasAssetModifier

```csharp
public bool HasAssetModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket_AssetModifier> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Socket"></a> Socket

```csharp
public CProtoItemSocket Socket { get; set; }
```

#### Property Value

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_ClearAssetModifier"></a> ClearAssetModifier\(\)

```csharp
public void ClearAssetModifier()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket_AssetModifier Clone()
```

#### Returns

 [CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_"></a> Equals\(CProtoItemSocket\_AssetModifier\)

```csharp
public bool Equals(CProtoItemSocket_AssetModifier other)
```

#### Parameters

`other` [CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_"></a> MergeFrom\(CProtoItemSocket\_AssetModifier\)

```csharp
public void MergeFrom(CProtoItemSocket_AssetModifier other)
```

#### Parameters

`other` [CProtoItemSocket\_AssetModifier](Divine.Protobufs.Dota2.CProtoItemSocket\_AssetModifier.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AssetModifier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

