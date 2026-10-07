# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags"></a> Class CMsgClientToGCCandyShopOpenBags

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopOpenBags : IMessage<CMsgClientToGCCandyShopOpenBags>, IEquatable<CMsgClientToGCCandyShopOpenBags>, IDeepCloneable<CMsgClientToGCCandyShopOpenBags>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)

#### Implements

IMessage<CMsgClientToGCCandyShopOpenBags\>, 
[IEquatable<CMsgClientToGCCandyShopOpenBags\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopOpenBags\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopOpenBags\>\(CMsgClientToGCCandyShopOpenBags, params CMsgClientToGCCandyShopOpenBags\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags__ctor"></a> CMsgClientToGCCandyShopOpenBags\(\)

```csharp
public CMsgClientToGCCandyShopOpenBags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_"></a> CMsgClientToGCCandyShopOpenBags\(CMsgClientToGCCandyShopOpenBags\)

```csharp
public CMsgClientToGCCandyShopOpenBags(CMsgClientToGCCandyShopOpenBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_BagCountFieldNumber"></a> BagCountFieldNumber

```csharp
public const int BagCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_BagCount"></a> BagCount

```csharp
public uint BagCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_HasBagCount"></a> HasBagCount

```csharp
public bool HasBagCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopOpenBags> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_ClearBagCount"></a> ClearBagCount\(\)

```csharp
public void ClearBagCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopOpenBags Clone()
```

#### Returns

 [CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_"></a> Equals\(CMsgClientToGCCandyShopOpenBags\)

```csharp
public bool Equals(CMsgClientToGCCandyShopOpenBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_"></a> MergeFrom\(CMsgClientToGCCandyShopOpenBags\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopOpenBags other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBags](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBags.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBags_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

