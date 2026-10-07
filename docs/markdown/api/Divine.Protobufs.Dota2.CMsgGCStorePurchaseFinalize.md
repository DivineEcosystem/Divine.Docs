# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize"></a> Class CMsgGCStorePurchaseFinalize

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseFinalize : IMessage<CMsgGCStorePurchaseFinalize>, IEquatable<CMsgGCStorePurchaseFinalize>, IDeepCloneable<CMsgGCStorePurchaseFinalize>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)

#### Implements

IMessage<CMsgGCStorePurchaseFinalize\>, 
[IEquatable<CMsgGCStorePurchaseFinalize\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseFinalize\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseFinalize\>\(CMsgGCStorePurchaseFinalize, params CMsgGCStorePurchaseFinalize\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize__ctor"></a> CMsgGCStorePurchaseFinalize\(\)

```csharp
public CMsgGCStorePurchaseFinalize()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_"></a> CMsgGCStorePurchaseFinalize\(CMsgGCStorePurchaseFinalize\)

```csharp
public CMsgGCStorePurchaseFinalize(CMsgGCStorePurchaseFinalize other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_TxnIdFieldNumber"></a> TxnIdFieldNumber

```csharp
public const int TxnIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_HasTxnId"></a> HasTxnId

```csharp
public bool HasTxnId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseFinalize> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_TxnId"></a> TxnId

```csharp
public ulong TxnId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_ClearTxnId"></a> ClearTxnId\(\)

```csharp
public void ClearTxnId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseFinalize Clone()
```

#### Returns

 [CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_"></a> Equals\(CMsgGCStorePurchaseFinalize\)

```csharp
public bool Equals(CMsgGCStorePurchaseFinalize other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_"></a> MergeFrom\(CMsgGCStorePurchaseFinalize\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseFinalize other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalize](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalize.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalize_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

