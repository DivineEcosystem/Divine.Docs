# <a id="Divine_Protobufs_Dota2_CNETMsg_NOP"></a> Class CNETMsg\_NOP

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_NOP : IMessage<CNETMsg_NOP>, IEquatable<CNETMsg_NOP>, IDeepCloneable<CNETMsg_NOP>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)

#### Implements

IMessage<CNETMsg\_NOP\>, 
[IEquatable<CNETMsg\_NOP\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_NOP\>, 
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
[EnumerableExtensions.In<CNETMsg\_NOP\>\(CNETMsg\_NOP, params CNETMsg\_NOP\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP__ctor"></a> CNETMsg\_NOP\(\)

```csharp
public CNETMsg_NOP()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP__ctor_Divine_Protobufs_Dota2_CNETMsg_NOP_"></a> CNETMsg\_NOP\(CNETMsg\_NOP\)

```csharp
public CNETMsg_NOP(CNETMsg_NOP other)
```

#### Parameters

`other` [CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_NOP> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_Clone"></a> Clone\(\)

```csharp
public CNETMsg_NOP Clone()
```

#### Returns

 [CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_Equals_Divine_Protobufs_Dota2_CNETMsg_NOP_"></a> Equals\(CNETMsg\_NOP\)

```csharp
public bool Equals(CNETMsg_NOP other)
```

#### Parameters

`other` [CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_NOP_"></a> MergeFrom\(CNETMsg\_NOP\)

```csharp
public void MergeFrom(CNETMsg_NOP other)
```

#### Parameters

`other` [CNETMsg\_NOP](Divine.Protobufs.Dota2.CNETMsg\_NOP.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_NOP_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

