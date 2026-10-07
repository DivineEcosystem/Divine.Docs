# <a id="Divine_Protobufs_Dota2_CEntityMsg"></a> Class CEntityMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEntityMsg : IMessage<CEntityMsg>, IEquatable<CEntityMsg>, IDeepCloneable<CEntityMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

#### Implements

IMessage<CEntityMsg\>, 
[IEquatable<CEntityMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEntityMsg\>, 
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
[EnumerableExtensions.In<CEntityMsg\>\(CEntityMsg, params CEntityMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEntityMsg__ctor"></a> CEntityMsg\(\)

```csharp
public CEntityMsg()
```

### <a id="Divine_Protobufs_Dota2_CEntityMsg__ctor_Divine_Protobufs_Dota2_CEntityMsg_"></a> CEntityMsg\(CEntityMsg\)

```csharp
public CEntityMsg(CEntityMsg other)
```

#### Parameters

`other` [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEntityMsg_TargetEntityFieldNumber"></a> TargetEntityFieldNumber

```csharp
public const int TargetEntityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEntityMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEntityMsg_HasTargetEntity"></a> HasTargetEntity

```csharp
public bool HasTargetEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_Parser"></a> Parser

```csharp
public static MessageParser<CEntityMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CEntityMsg_TargetEntity"></a> TargetEntity

```csharp
public uint TargetEntity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CEntityMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_ClearTargetEntity"></a> ClearTargetEntity\(\)

```csharp
public void ClearTargetEntity()
```

### <a id="Divine_Protobufs_Dota2_CEntityMsg_Clone"></a> Clone\(\)

```csharp
public CEntityMsg Clone()
```

#### Returns

 [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_Equals_Divine_Protobufs_Dota2_CEntityMsg_"></a> Equals\(CEntityMsg\)

```csharp
public bool Equals(CEntityMsg other)
```

#### Parameters

`other` [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_MergeFrom_Divine_Protobufs_Dota2_CEntityMsg_"></a> MergeFrom\(CEntityMsg\)

```csharp
public void MergeFrom(CEntityMsg other)
```

#### Parameters

`other` [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEntityMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEntityMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

