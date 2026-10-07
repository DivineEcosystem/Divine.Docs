# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags"></a> Class CMsgClientToGCCandyShopDevGrantCandyBags

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDevGrantCandyBags : IMessage<CMsgClientToGCCandyShopDevGrantCandyBags>, IEquatable<CMsgClientToGCCandyShopDevGrantCandyBags>, IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandyBags>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDevGrantCandyBags\>, 
[IEquatable<CMsgClientToGCCandyShopDevGrantCandyBags\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandyBags\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDevGrantCandyBags\>\(CMsgClientToGCCandyShopDevGrantCandyBags, params CMsgClientToGCCandyShopDevGrantCandyBags\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags__ctor"></a> CMsgClientToGCCandyShopDevGrantCandyBags\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyBags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_"></a> CMsgClientToGCCandyShopDevGrantCandyBags\(CMsgClientToGCCandyShopDevGrantCandyBags\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyBags(CMsgClientToGCCandyShopDevGrantCandyBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDevGrantCandyBags> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyBags Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_"></a> Equals\(CMsgClientToGCCandyShopDevGrantCandyBags\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDevGrantCandyBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_"></a> MergeFrom\(CMsgClientToGCCandyShopDevGrantCandyBags\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDevGrantCandyBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyBags.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyBags_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

