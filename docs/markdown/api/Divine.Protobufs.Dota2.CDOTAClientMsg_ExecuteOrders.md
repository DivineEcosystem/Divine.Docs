# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders"></a> Class CDOTAClientMsg\_ExecuteOrders

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ExecuteOrders : IMessage<CDOTAClientMsg_ExecuteOrders>, IEquatable<CDOTAClientMsg_ExecuteOrders>, IDeepCloneable<CDOTAClientMsg_ExecuteOrders>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)

#### Implements

IMessage<CDOTAClientMsg\_ExecuteOrders\>, 
[IEquatable<CDOTAClientMsg\_ExecuteOrders\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ExecuteOrders\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ExecuteOrders\>\(CDOTAClientMsg\_ExecuteOrders, params CDOTAClientMsg\_ExecuteOrders\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders__ctor"></a> CDOTAClientMsg\_ExecuteOrders\(\)

```csharp
public CDOTAClientMsg_ExecuteOrders()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_"></a> CDOTAClientMsg\_ExecuteOrders\(CDOTAClientMsg\_ExecuteOrders\)

```csharp
public CDOTAClientMsg_ExecuteOrders(CDOTAClientMsg_ExecuteOrders other)
```

#### Parameters

`other` [CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_LastOrderLatencyFieldNumber"></a> LastOrderLatencyFieldNumber

```csharp
public const int LastOrderLatencyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_OrdersFieldNumber"></a> OrdersFieldNumber

```csharp
public const int OrdersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_HasLastOrderLatency"></a> HasLastOrderLatency

```csharp
public bool HasLastOrderLatency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_LastOrderLatency"></a> LastOrderLatency

```csharp
public uint LastOrderLatency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Orders"></a> Orders

```csharp
public RepeatedField<CDOTAMsg_UnitOrder> Orders { get; }
```

#### Property Value

 RepeatedField<[CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ExecuteOrders> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_ClearLastOrderLatency"></a> ClearLastOrderLatency\(\)

```csharp
public void ClearLastOrderLatency()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ExecuteOrders Clone()
```

#### Returns

 [CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_"></a> Equals\(CDOTAClientMsg\_ExecuteOrders\)

```csharp
public bool Equals(CDOTAClientMsg_ExecuteOrders other)
```

#### Parameters

`other` [CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_"></a> MergeFrom\(CDOTAClientMsg\_ExecuteOrders\)

```csharp
public void MergeFrom(CDOTAClientMsg_ExecuteOrders other)
```

#### Parameters

`other` [CDOTAClientMsg\_ExecuteOrders](Divine.Protobufs.Dota2.CDOTAClientMsg\_ExecuteOrders.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ExecuteOrders_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

