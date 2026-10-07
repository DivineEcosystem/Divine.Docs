# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats"></a> Class CGCMsgMemCachedStats

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedStats : IMessage<CGCMsgMemCachedStats>, IEquatable<CGCMsgMemCachedStats>, IDeepCloneable<CGCMsgMemCachedStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)

#### Implements

IMessage<CGCMsgMemCachedStats\>, 
[IEquatable<CGCMsgMemCachedStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedStats\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedStats\>\(CGCMsgMemCachedStats, params CGCMsgMemCachedStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats__ctor"></a> CGCMsgMemCachedStats\(\)

```csharp
public CGCMsgMemCachedStats()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedStats_"></a> CGCMsgMemCachedStats\(CGCMsgMemCachedStats\)

```csharp
public CGCMsgMemCachedStats(CGCMsgMemCachedStats other)
```

#### Parameters

`other` [CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedStats> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedStats Clone()
```

#### Returns

 [CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedStats_"></a> Equals\(CGCMsgMemCachedStats\)

```csharp
public bool Equals(CGCMsgMemCachedStats other)
```

#### Parameters

`other` [CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedStats_"></a> MergeFrom\(CGCMsgMemCachedStats\)

```csharp
public void MergeFrom(CGCMsgMemCachedStats other)
```

#### Parameters

`other` [CGCMsgMemCachedStats](Divine.Protobufs.Steam.CGCMsgMemCachedStats.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

