# <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction"></a> Class CMsgGCToGCStoreProcessCDKeyTransaction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCStoreProcessCDKeyTransaction : IMessage<CMsgGCToGCStoreProcessCDKeyTransaction>, IEquatable<CMsgGCToGCStoreProcessCDKeyTransaction>, IDeepCloneable<CMsgGCToGCStoreProcessCDKeyTransaction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)

#### Implements

IMessage<CMsgGCToGCStoreProcessCDKeyTransaction\>, 
[IEquatable<CMsgGCToGCStoreProcessCDKeyTransaction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCStoreProcessCDKeyTransaction\>, 
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
[EnumerableExtensions.In<CMsgGCToGCStoreProcessCDKeyTransaction\>\(CMsgGCToGCStoreProcessCDKeyTransaction, params CMsgGCToGCStoreProcessCDKeyTransaction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction__ctor"></a> CMsgGCToGCStoreProcessCDKeyTransaction\(\)

```csharp
public CMsgGCToGCStoreProcessCDKeyTransaction()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction__ctor_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_"></a> CMsgGCToGCStoreProcessCDKeyTransaction\(CMsgGCToGCStoreProcessCDKeyTransaction\)

```csharp
public CMsgGCToGCStoreProcessCDKeyTransaction(CMsgGCToGCStoreProcessCDKeyTransaction other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_OrderFieldNumber"></a> OrderFieldNumber

```csharp
public const int OrderFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_PartnerFieldNumber"></a> PartnerFieldNumber

```csharp
public const int PartnerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_ReasonCodeFieldNumber"></a> ReasonCodeFieldNumber

```csharp
public const int ReasonCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_HasPartner"></a> HasPartner

```csharp
public bool HasPartner { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_HasReasonCode"></a> HasReasonCode

```csharp
public bool HasReasonCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Order"></a> Order

```csharp
public CMsgProcessTransactionOrder Order { get; set; }
```

#### Property Value

 [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCStoreProcessCDKeyTransaction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Partner"></a> Partner

```csharp
public uint Partner { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_ReasonCode"></a> ReasonCode

```csharp
public uint ReasonCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_ClearPartner"></a> ClearPartner\(\)

```csharp
public void ClearPartner()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_ClearReasonCode"></a> ClearReasonCode\(\)

```csharp
public void ClearReasonCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCStoreProcessCDKeyTransaction Clone()
```

#### Returns

 [CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_Equals_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_"></a> Equals\(CMsgGCToGCStoreProcessCDKeyTransaction\)

```csharp
public bool Equals(CMsgGCToGCStoreProcessCDKeyTransaction other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_"></a> MergeFrom\(CMsgGCToGCStoreProcessCDKeyTransaction\)

```csharp
public void MergeFrom(CMsgGCToGCStoreProcessCDKeyTransaction other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessCDKeyTransaction](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessCDKeyTransaction.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessCDKeyTransaction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

