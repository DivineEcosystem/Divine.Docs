# <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg"></a> Class CUserMessageTextMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageTextMsg : IMessage<CUserMessageTextMsg>, IEquatable<CUserMessageTextMsg>, IDeepCloneable<CUserMessageTextMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)

#### Implements

IMessage<CUserMessageTextMsg\>, 
[IEquatable<CUserMessageTextMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageTextMsg\>, 
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
[EnumerableExtensions.In<CUserMessageTextMsg\>\(CUserMessageTextMsg, params CUserMessageTextMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg__ctor"></a> CUserMessageTextMsg\(\)

```csharp
public CUserMessageTextMsg()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg__ctor_Divine_Protobufs_Dota2_CUserMessageTextMsg_"></a> CUserMessageTextMsg\(CUserMessageTextMsg\)

```csharp
public CUserMessageTextMsg(CUserMessageTextMsg other)
```

#### Parameters

`other` [CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_DestFieldNumber"></a> DestFieldNumber

```csharp
public const int DestFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_ParamFieldNumber"></a> ParamFieldNumber

```csharp
public const int ParamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Dest"></a> Dest

```csharp
public uint Dest { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_HasDest"></a> HasDest

```csharp
public bool HasDest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Param"></a> Param

```csharp
public RepeatedField<string> Param { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageTextMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_ClearDest"></a> ClearDest\(\)

```csharp
public void ClearDest()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Clone"></a> Clone\(\)

```csharp
public CUserMessageTextMsg Clone()
```

#### Returns

 [CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_Equals_Divine_Protobufs_Dota2_CUserMessageTextMsg_"></a> Equals\(CUserMessageTextMsg\)

```csharp
public bool Equals(CUserMessageTextMsg other)
```

#### Parameters

`other` [CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_MergeFrom_Divine_Protobufs_Dota2_CUserMessageTextMsg_"></a> MergeFrom\(CUserMessageTextMsg\)

```csharp
public void MergeFrom(CUserMessageTextMsg other)
```

#### Parameters

`other` [CUserMessageTextMsg](Divine.Protobufs.Dota2.CUserMessageTextMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageTextMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

