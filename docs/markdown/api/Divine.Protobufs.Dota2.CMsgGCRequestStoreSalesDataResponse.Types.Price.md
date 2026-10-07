# <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price"></a> Class CMsgGCRequestStoreSalesDataResponse.Types.Price

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRequestStoreSalesDataResponse.Types.Price : IMessage<CMsgGCRequestStoreSalesDataResponse.Types.Price>, IEquatable<CMsgGCRequestStoreSalesDataResponse.Types.Price>, IDeepCloneable<CMsgGCRequestStoreSalesDataResponse.Types.Price>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRequestStoreSalesDataResponse.Types.Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)

#### Implements

IMessage<CMsgGCRequestStoreSalesDataResponse.Types.Price\>, 
[IEquatable<CMsgGCRequestStoreSalesDataResponse.Types.Price\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRequestStoreSalesDataResponse.Types.Price\>, 
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
[EnumerableExtensions.In<CMsgGCRequestStoreSalesDataResponse.Types.Price\>\(CMsgGCRequestStoreSalesDataResponse.Types.Price, params CMsgGCRequestStoreSalesDataResponse.Types.Price\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price__ctor"></a> Price\(\)

```csharp
public Price()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price__ctor_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_"></a> Price\(Price\)

```csharp
public Price(CMsgGCRequestStoreSalesDataResponse.Types.Price other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Price_FieldNumber"></a> Price\_FieldNumber

```csharp
public const int Price_FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_HasPrice_"></a> HasPrice\_

```csharp
public bool HasPrice_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRequestStoreSalesDataResponse.Types.Price> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Price_"></a> Price\_

```csharp
public uint Price_ { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_ClearPrice_"></a> ClearPrice\_\(\)

```csharp
public void ClearPrice_()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Clone"></a> Clone\(\)

```csharp
public CMsgGCRequestStoreSalesDataResponse.Types.Price Clone()
```

#### Returns

 [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_Equals_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_"></a> Equals\(Price\)

```csharp
public bool Equals(CMsgGCRequestStoreSalesDataResponse.Types.Price other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_"></a> MergeFrom\(Price\)

```csharp
public void MergeFrom(CMsgGCRequestStoreSalesDataResponse.Types.Price other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Types_Price_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

