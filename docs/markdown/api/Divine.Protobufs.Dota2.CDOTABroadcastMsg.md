# <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg"></a> Class CDOTABroadcastMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTABroadcastMsg : IMessage<CDOTABroadcastMsg>, IEquatable<CDOTABroadcastMsg>, IDeepCloneable<CDOTABroadcastMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)

#### Implements

IMessage<CDOTABroadcastMsg\>, 
[IEquatable<CDOTABroadcastMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTABroadcastMsg\>, 
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
[EnumerableExtensions.In<CDOTABroadcastMsg\>\(CDOTABroadcastMsg, params CDOTABroadcastMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg__ctor"></a> CDOTABroadcastMsg\(\)

```csharp
public CDOTABroadcastMsg()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg__ctor_Divine_Protobufs_Dota2_CDOTABroadcastMsg_"></a> CDOTABroadcastMsg\(CDOTABroadcastMsg\)

```csharp
public CDOTABroadcastMsg(CDOTABroadcastMsg other)
```

#### Parameters

`other` [CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_MsgFieldNumber"></a> MsgFieldNumber

```csharp
public const int MsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_HasMsg"></a> HasMsg

```csharp
public bool HasMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Msg"></a> Msg

```csharp
public ByteString Msg { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Parser"></a> Parser

```csharp
public static MessageParser<CDOTABroadcastMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Type"></a> Type

```csharp
public EDotaBroadcastMessages Type { get; set; }
```

#### Property Value

 [EDotaBroadcastMessages](Divine.Protobufs.Dota2.EDotaBroadcastMessages.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_ClearMsg"></a> ClearMsg\(\)

```csharp
public void ClearMsg()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Clone"></a> Clone\(\)

```csharp
public CDOTABroadcastMsg Clone()
```

#### Returns

 [CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_Equals_Divine_Protobufs_Dota2_CDOTABroadcastMsg_"></a> Equals\(CDOTABroadcastMsg\)

```csharp
public bool Equals(CDOTABroadcastMsg other)
```

#### Parameters

`other` [CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_MergeFrom_Divine_Protobufs_Dota2_CDOTABroadcastMsg_"></a> MergeFrom\(CDOTABroadcastMsg\)

```csharp
public void MergeFrom(CDOTABroadcastMsg other)
```

#### Parameters

`other` [CDOTABroadcastMsg](Divine.Protobufs.Dota2.CDOTABroadcastMsg.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

