# <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce"></a> Class CEntityMessagePropagateForce

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEntityMessagePropagateForce : IMessage<CEntityMessagePropagateForce>, IEquatable<CEntityMessagePropagateForce>, IDeepCloneable<CEntityMessagePropagateForce>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)

#### Implements

IMessage<CEntityMessagePropagateForce\>, 
[IEquatable<CEntityMessagePropagateForce\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEntityMessagePropagateForce\>, 
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
[EnumerableExtensions.In<CEntityMessagePropagateForce\>\(CEntityMessagePropagateForce, params CEntityMessagePropagateForce\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce__ctor"></a> CEntityMessagePropagateForce\(\)

```csharp
public CEntityMessagePropagateForce()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce__ctor_Divine_Protobufs_Dota2_CEntityMessagePropagateForce_"></a> CEntityMessagePropagateForce\(CEntityMessagePropagateForce\)

```csharp
public CEntityMessagePropagateForce(CEntityMessagePropagateForce other)
```

#### Parameters

`other` [CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_EntityMsgFieldNumber"></a> EntityMsgFieldNumber

```csharp
public const int EntityMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_ImpulseFieldNumber"></a> ImpulseFieldNumber

```csharp
public const int ImpulseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_EntityMsg"></a> EntityMsg

```csharp
public CEntityMsg EntityMsg { get; set; }
```

#### Property Value

 [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Impulse"></a> Impulse

```csharp
public CMsgVector Impulse { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Parser"></a> Parser

```csharp
public static MessageParser<CEntityMessagePropagateForce> Parser { get; }
```

#### Property Value

 MessageParser<[CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Clone"></a> Clone\(\)

```csharp
public CEntityMessagePropagateForce Clone()
```

#### Returns

 [CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_Equals_Divine_Protobufs_Dota2_CEntityMessagePropagateForce_"></a> Equals\(CEntityMessagePropagateForce\)

```csharp
public bool Equals(CEntityMessagePropagateForce other)
```

#### Parameters

`other` [CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_MergeFrom_Divine_Protobufs_Dota2_CEntityMessagePropagateForce_"></a> MergeFrom\(CEntityMessagePropagateForce\)

```csharp
public void MergeFrom(CEntityMessagePropagateForce other)
```

#### Parameters

`other` [CEntityMessagePropagateForce](Divine.Protobufs.Dota2.CEntityMessagePropagateForce.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEntityMessagePropagateForce_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

