# <a id="Divine_Protobufs_Dota2_CInButtonStatePB"></a> Class CInButtonStatePB

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CInButtonStatePB : IMessage<CInButtonStatePB>, IEquatable<CInButtonStatePB>, IDeepCloneable<CInButtonStatePB>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

#### Implements

IMessage<CInButtonStatePB\>, 
[IEquatable<CInButtonStatePB\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CInButtonStatePB\>, 
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
[EnumerableExtensions.In<CInButtonStatePB\>\(CInButtonStatePB, params CInButtonStatePB\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB__ctor"></a> CInButtonStatePB\(\)

```csharp
public CInButtonStatePB()
```

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB__ctor_Divine_Protobufs_Dota2_CInButtonStatePB_"></a> CInButtonStatePB\(CInButtonStatePB\)

```csharp
public CInButtonStatePB(CInButtonStatePB other)
```

#### Parameters

`other` [CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate1FieldNumber"></a> Buttonstate1FieldNumber

```csharp
public const int Buttonstate1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate2FieldNumber"></a> Buttonstate2FieldNumber

```csharp
public const int Buttonstate2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate3FieldNumber"></a> Buttonstate3FieldNumber

```csharp
public const int Buttonstate3FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate1"></a> Buttonstate1

```csharp
public ulong Buttonstate1 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate2"></a> Buttonstate2

```csharp
public ulong Buttonstate2 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Buttonstate3"></a> Buttonstate3

```csharp
public ulong Buttonstate3 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_HasButtonstate1"></a> HasButtonstate1

```csharp
public bool HasButtonstate1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_HasButtonstate2"></a> HasButtonstate2

```csharp
public bool HasButtonstate2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_HasButtonstate3"></a> HasButtonstate3

```csharp
public bool HasButtonstate3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Parser"></a> Parser

```csharp
public static MessageParser<CInButtonStatePB> Parser { get; }
```

#### Property Value

 MessageParser<[CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_ClearButtonstate1"></a> ClearButtonstate1\(\)

```csharp
public void ClearButtonstate1()
```

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_ClearButtonstate2"></a> ClearButtonstate2\(\)

```csharp
public void ClearButtonstate2()
```

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_ClearButtonstate3"></a> ClearButtonstate3\(\)

```csharp
public void ClearButtonstate3()
```

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Clone"></a> Clone\(\)

```csharp
public CInButtonStatePB Clone()
```

#### Returns

 [CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_Equals_Divine_Protobufs_Dota2_CInButtonStatePB_"></a> Equals\(CInButtonStatePB\)

```csharp
public bool Equals(CInButtonStatePB other)
```

#### Parameters

`other` [CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_MergeFrom_Divine_Protobufs_Dota2_CInButtonStatePB_"></a> MergeFrom\(CInButtonStatePB\)

```csharp
public void MergeFrom(CInButtonStatePB other)
```

#### Parameters

`other` [CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CInButtonStatePB_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

