# <a id="Divine_Protobufs_Dota2_CCLCMsg_Move"></a> Class CCLCMsg\_Move

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_Move : IMessage<CCLCMsg_Move>, IEquatable<CCLCMsg_Move>, IDeepCloneable<CCLCMsg_Move>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)

#### Implements

IMessage<CCLCMsg\_Move\>, 
[IEquatable<CCLCMsg\_Move\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_Move\>, 
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
[EnumerableExtensions.In<CCLCMsg\_Move\>\(CCLCMsg\_Move, params CCLCMsg\_Move\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move__ctor"></a> CCLCMsg\_Move\(\)

```csharp
public CCLCMsg_Move()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move__ctor_Divine_Protobufs_Dota2_CCLCMsg_Move_"></a> CCLCMsg\_Move\(CCLCMsg\_Move\)

```csharp
public CCLCMsg_Move(CCLCMsg_Move other)
```

#### Parameters

`other` [CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_LastCommandNumberFieldNumber"></a> LastCommandNumberFieldNumber

```csharp
public const int LastCommandNumberFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_HasLastCommandNumber"></a> HasLastCommandNumber

```csharp
public bool HasLastCommandNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_LastCommandNumber"></a> LastCommandNumber

```csharp
public uint LastCommandNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_Move> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_ClearLastCommandNumber"></a> ClearLastCommandNumber\(\)

```csharp
public void ClearLastCommandNumber()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_Move Clone()
```

#### Returns

 [CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_Equals_Divine_Protobufs_Dota2_CCLCMsg_Move_"></a> Equals\(CCLCMsg\_Move\)

```csharp
public bool Equals(CCLCMsg_Move other)
```

#### Parameters

`other` [CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_Move_"></a> MergeFrom\(CCLCMsg\_Move\)

```csharp
public void MergeFrom(CCLCMsg_Move other)
```

#### Parameters

`other` [CCLCMsg\_Move](Divine.Protobufs.Dota2.CCLCMsg\_Move.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Move_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

