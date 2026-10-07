# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder"></a> Class CDOTAClientMsg\_PauseGameOrder

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PauseGameOrder : IMessage<CDOTAClientMsg_PauseGameOrder>, IEquatable<CDOTAClientMsg_PauseGameOrder>, IDeepCloneable<CDOTAClientMsg_PauseGameOrder>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)

#### Implements

IMessage<CDOTAClientMsg\_PauseGameOrder\>, 
[IEquatable<CDOTAClientMsg\_PauseGameOrder\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PauseGameOrder\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PauseGameOrder\>\(CDOTAClientMsg\_PauseGameOrder, params CDOTAClientMsg\_PauseGameOrder\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder__ctor"></a> CDOTAClientMsg\_PauseGameOrder\(\)

```csharp
public CDOTAClientMsg_PauseGameOrder()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_"></a> CDOTAClientMsg\_PauseGameOrder\(CDOTAClientMsg\_PauseGameOrder\)

```csharp
public CDOTAClientMsg_PauseGameOrder(CDOTAClientMsg_PauseGameOrder other)
```

#### Parameters

`other` [CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_OrderIdFieldNumber"></a> OrderIdFieldNumber

```csharp
public const int OrderIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Data"></a> Data

```csharp
public int Data { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_HasOrderId"></a> HasOrderId

```csharp
public bool HasOrderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_OrderId"></a> OrderId

```csharp
public int OrderId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PauseGameOrder> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_ClearOrderId"></a> ClearOrderId\(\)

```csharp
public void ClearOrderId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PauseGameOrder Clone()
```

#### Returns

 [CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_"></a> Equals\(CDOTAClientMsg\_PauseGameOrder\)

```csharp
public bool Equals(CDOTAClientMsg_PauseGameOrder other)
```

#### Parameters

`other` [CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_"></a> MergeFrom\(CDOTAClientMsg\_PauseGameOrder\)

```csharp
public void MergeFrom(CDOTAClientMsg_PauseGameOrder other)
```

#### Parameters

`other` [CDOTAClientMsg\_PauseGameOrder](Divine.Protobufs.Dota2.CDOTAClientMsg\_PauseGameOrder.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PauseGameOrder_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

