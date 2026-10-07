# <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool"></a> Class CMsgDOTALeaguePrizePool

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeaguePrizePool : IMessage<CMsgDOTALeaguePrizePool>, IEquatable<CMsgDOTALeaguePrizePool>, IDeepCloneable<CMsgDOTALeaguePrizePool>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)

#### Implements

IMessage<CMsgDOTALeaguePrizePool\>, 
[IEquatable<CMsgDOTALeaguePrizePool\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeaguePrizePool\>, 
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
[EnumerableExtensions.In<CMsgDOTALeaguePrizePool\>\(CMsgDOTALeaguePrizePool, params CMsgDOTALeaguePrizePool\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool__ctor"></a> CMsgDOTALeaguePrizePool\(\)

```csharp
public CMsgDOTALeaguePrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool__ctor_Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_"></a> CMsgDOTALeaguePrizePool\(CMsgDOTALeaguePrizePool\)

```csharp
public CMsgDOTALeaguePrizePool(CMsgDOTALeaguePrizePool other)
```

#### Parameters

`other` [CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_IncrementPerSecondFieldNumber"></a> IncrementPerSecondFieldNumber

```csharp
public const int IncrementPerSecondFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_PrizePoolFieldNumber"></a> PrizePoolFieldNumber

```csharp
public const int PrizePoolFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_HasIncrementPerSecond"></a> HasIncrementPerSecond

```csharp
public bool HasIncrementPerSecond { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_HasPrizePool"></a> HasPrizePool

```csharp
public bool HasPrizePool { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_IncrementPerSecond"></a> IncrementPerSecond

```csharp
public float IncrementPerSecond { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeaguePrizePool> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_PrizePool"></a> PrizePool

```csharp
public uint PrizePool { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_ClearIncrementPerSecond"></a> ClearIncrementPerSecond\(\)

```csharp
public void ClearIncrementPerSecond()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_ClearPrizePool"></a> ClearPrizePool\(\)

```csharp
public void ClearPrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeaguePrizePool Clone()
```

#### Returns

 [CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_Equals_Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_"></a> Equals\(CMsgDOTALeaguePrizePool\)

```csharp
public bool Equals(CMsgDOTALeaguePrizePool other)
```

#### Parameters

`other` [CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_"></a> MergeFrom\(CMsgDOTALeaguePrizePool\)

```csharp
public void MergeFrom(CMsgDOTALeaguePrizePool other)
```

#### Parameters

`other` [CMsgDOTALeaguePrizePool](Divine.Protobufs.Dota2.CMsgDOTALeaguePrizePool.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaguePrizePool_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

