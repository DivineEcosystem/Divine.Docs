# <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement"></a> Class CMsgGCToGCStoreProcessSettlement

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCStoreProcessSettlement : IMessage<CMsgGCToGCStoreProcessSettlement>, IEquatable<CMsgGCToGCStoreProcessSettlement>, IDeepCloneable<CMsgGCToGCStoreProcessSettlement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)

#### Implements

IMessage<CMsgGCToGCStoreProcessSettlement\>, 
[IEquatable<CMsgGCToGCStoreProcessSettlement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCStoreProcessSettlement\>, 
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
[EnumerableExtensions.In<CMsgGCToGCStoreProcessSettlement\>\(CMsgGCToGCStoreProcessSettlement, params CMsgGCToGCStoreProcessSettlement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement__ctor"></a> CMsgGCToGCStoreProcessSettlement\(\)

```csharp
public CMsgGCToGCStoreProcessSettlement()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement__ctor_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_"></a> CMsgGCToGCStoreProcessSettlement\(CMsgGCToGCStoreProcessSettlement\)

```csharp
public CMsgGCToGCStoreProcessSettlement(CMsgGCToGCStoreProcessSettlement other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_OrderFieldNumber"></a> OrderFieldNumber

```csharp
public const int OrderFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Order"></a> Order

```csharp
public CMsgProcessTransactionOrder Order { get; set; }
```

#### Property Value

 [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCStoreProcessSettlement> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCStoreProcessSettlement Clone()
```

#### Returns

 [CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_Equals_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_"></a> Equals\(CMsgGCToGCStoreProcessSettlement\)

```csharp
public bool Equals(CMsgGCToGCStoreProcessSettlement other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_"></a> MergeFrom\(CMsgGCToGCStoreProcessSettlement\)

```csharp
public void MergeFrom(CMsgGCToGCStoreProcessSettlement other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlement](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlement.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

