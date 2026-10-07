# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges"></a> Class CMsgClientToGCCandyShopDevGrantRerollCharges

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDevGrantRerollCharges : IMessage<CMsgClientToGCCandyShopDevGrantRerollCharges>, IEquatable<CMsgClientToGCCandyShopDevGrantRerollCharges>, IDeepCloneable<CMsgClientToGCCandyShopDevGrantRerollCharges>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDevGrantRerollCharges\>, 
[IEquatable<CMsgClientToGCCandyShopDevGrantRerollCharges\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDevGrantRerollCharges\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDevGrantRerollCharges\>\(CMsgClientToGCCandyShopDevGrantRerollCharges, params CMsgClientToGCCandyShopDevGrantRerollCharges\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges__ctor"></a> CMsgClientToGCCandyShopDevGrantRerollCharges\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantRerollCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_"></a> CMsgClientToGCCandyShopDevGrantRerollCharges\(CMsgClientToGCCandyShopDevGrantRerollCharges\)

```csharp
public CMsgClientToGCCandyShopDevGrantRerollCharges(CMsgClientToGCCandyShopDevGrantRerollCharges other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_RerollChargesFieldNumber"></a> RerollChargesFieldNumber

```csharp
public const int RerollChargesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_HasRerollCharges"></a> HasRerollCharges

```csharp
public bool HasRerollCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDevGrantRerollCharges> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_RerollCharges"></a> RerollCharges

```csharp
public uint RerollCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_ClearRerollCharges"></a> ClearRerollCharges\(\)

```csharp
public void ClearRerollCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantRerollCharges Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_"></a> Equals\(CMsgClientToGCCandyShopDevGrantRerollCharges\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDevGrantRerollCharges other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_"></a> MergeFrom\(CMsgClientToGCCandyShopDevGrantRerollCharges\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDevGrantRerollCharges other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantRerollCharges](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantRerollCharges.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantRerollCharges_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

