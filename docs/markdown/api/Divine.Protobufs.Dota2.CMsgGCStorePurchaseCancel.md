# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel"></a> Class CMsgGCStorePurchaseCancel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseCancel : IMessage<CMsgGCStorePurchaseCancel>, IEquatable<CMsgGCStorePurchaseCancel>, IDeepCloneable<CMsgGCStorePurchaseCancel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)

#### Implements

IMessage<CMsgGCStorePurchaseCancel\>, 
[IEquatable<CMsgGCStorePurchaseCancel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseCancel\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseCancel\>\(CMsgGCStorePurchaseCancel, params CMsgGCStorePurchaseCancel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel__ctor"></a> CMsgGCStorePurchaseCancel\(\)

```csharp
public CMsgGCStorePurchaseCancel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_"></a> CMsgGCStorePurchaseCancel\(CMsgGCStorePurchaseCancel\)

```csharp
public CMsgGCStorePurchaseCancel(CMsgGCStorePurchaseCancel other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_TxnIdFieldNumber"></a> TxnIdFieldNumber

```csharp
public const int TxnIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_HasTxnId"></a> HasTxnId

```csharp
public bool HasTxnId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseCancel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_TxnId"></a> TxnId

```csharp
public ulong TxnId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_ClearTxnId"></a> ClearTxnId\(\)

```csharp
public void ClearTxnId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseCancel Clone()
```

#### Returns

 [CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_"></a> Equals\(CMsgGCStorePurchaseCancel\)

```csharp
public bool Equals(CMsgGCStorePurchaseCancel other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_"></a> MergeFrom\(CMsgGCStorePurchaseCancel\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseCancel other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancel](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancel.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

