# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy"></a> Class CMsgClientToGCCandyShopDevGrantCandy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDevGrantCandy : IMessage<CMsgClientToGCCandyShopDevGrantCandy>, IEquatable<CMsgClientToGCCandyShopDevGrantCandy>, IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDevGrantCandy\>, 
[IEquatable<CMsgClientToGCCandyShopDevGrantCandy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandy\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDevGrantCandy\>\(CMsgClientToGCCandyShopDevGrantCandy, params CMsgClientToGCCandyShopDevGrantCandy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy__ctor"></a> CMsgClientToGCCandyShopDevGrantCandy\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandy()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_"></a> CMsgClientToGCCandyShopDevGrantCandy\(CMsgClientToGCCandyShopDevGrantCandy\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandy(CMsgClientToGCCandyShopDevGrantCandy other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_CandyQuantityFieldNumber"></a> CandyQuantityFieldNumber

```csharp
public const int CandyQuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_CandyQuantity"></a> CandyQuantity

```csharp
public CMsgCandyShopCandyQuantity CandyQuantity { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDevGrantCandy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandy Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_"></a> Equals\(CMsgClientToGCCandyShopDevGrantCandy\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDevGrantCandy other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_"></a> MergeFrom\(CMsgClientToGCCandyShopDevGrantCandy\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDevGrantCandy other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandy](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

