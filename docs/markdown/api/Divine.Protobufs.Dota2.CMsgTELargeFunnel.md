# <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel"></a> Class CMsgTELargeFunnel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTELargeFunnel : IMessage<CMsgTELargeFunnel>, IEquatable<CMsgTELargeFunnel>, IDeepCloneable<CMsgTELargeFunnel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)

#### Implements

IMessage<CMsgTELargeFunnel\>, 
[IEquatable<CMsgTELargeFunnel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTELargeFunnel\>, 
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
[EnumerableExtensions.In<CMsgTELargeFunnel\>\(CMsgTELargeFunnel, params CMsgTELargeFunnel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel__ctor"></a> CMsgTELargeFunnel\(\)

```csharp
public CMsgTELargeFunnel()
```

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel__ctor_Divine_Protobufs_Dota2_CMsgTELargeFunnel_"></a> CMsgTELargeFunnel\(CMsgTELargeFunnel\)

```csharp
public CMsgTELargeFunnel(CMsgTELargeFunnel other)
```

#### Parameters

`other` [CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_ReversedFieldNumber"></a> ReversedFieldNumber

```csharp
public const int ReversedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_HasReversed"></a> HasReversed

```csharp
public bool HasReversed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTELargeFunnel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Reversed"></a> Reversed

```csharp
public uint Reversed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_ClearReversed"></a> ClearReversed\(\)

```csharp
public void ClearReversed()
```

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Clone"></a> Clone\(\)

```csharp
public CMsgTELargeFunnel Clone()
```

#### Returns

 [CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_Equals_Divine_Protobufs_Dota2_CMsgTELargeFunnel_"></a> Equals\(CMsgTELargeFunnel\)

```csharp
public bool Equals(CMsgTELargeFunnel other)
```

#### Parameters

`other` [CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_MergeFrom_Divine_Protobufs_Dota2_CMsgTELargeFunnel_"></a> MergeFrom\(CMsgTELargeFunnel\)

```csharp
public void MergeFrom(CMsgTELargeFunnel other)
```

#### Parameters

`other` [CMsgTELargeFunnel](Divine.Protobufs.Dota2.CMsgTELargeFunnel.md)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTELargeFunnel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

