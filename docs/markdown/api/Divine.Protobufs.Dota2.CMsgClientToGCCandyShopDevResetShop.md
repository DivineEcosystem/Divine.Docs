# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop"></a> Class CMsgClientToGCCandyShopDevResetShop

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDevResetShop : IMessage<CMsgClientToGCCandyShopDevResetShop>, IEquatable<CMsgClientToGCCandyShopDevResetShop>, IDeepCloneable<CMsgClientToGCCandyShopDevResetShop>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDevResetShop\>, 
[IEquatable<CMsgClientToGCCandyShopDevResetShop\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDevResetShop\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDevResetShop\>\(CMsgClientToGCCandyShopDevResetShop, params CMsgClientToGCCandyShopDevResetShop\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop__ctor"></a> CMsgClientToGCCandyShopDevResetShop\(\)

```csharp
public CMsgClientToGCCandyShopDevResetShop()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_"></a> CMsgClientToGCCandyShopDevResetShop\(CMsgClientToGCCandyShopDevResetShop\)

```csharp
public CMsgClientToGCCandyShopDevResetShop(CMsgClientToGCCandyShopDevResetShop other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDevResetShop> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDevResetShop Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_"></a> Equals\(CMsgClientToGCCandyShopDevResetShop\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDevResetShop other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_"></a> MergeFrom\(CMsgClientToGCCandyShopDevResetShop\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDevResetShop other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevResetShop](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevResetShop.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevResetShop_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

