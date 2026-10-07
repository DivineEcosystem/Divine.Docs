# <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity"></a> Class CMsgCandyShopCandyQuantity

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopCandyQuantity : IMessage<CMsgCandyShopCandyQuantity>, IEquatable<CMsgCandyShopCandyQuantity>, IDeepCloneable<CMsgCandyShopCandyQuantity>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

#### Implements

IMessage<CMsgCandyShopCandyQuantity\>, 
[IEquatable<CMsgCandyShopCandyQuantity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopCandyQuantity\>, 
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
[EnumerableExtensions.In<CMsgCandyShopCandyQuantity\>\(CMsgCandyShopCandyQuantity, params CMsgCandyShopCandyQuantity\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity__ctor"></a> CMsgCandyShopCandyQuantity\(\)

```csharp
public CMsgCandyShopCandyQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity__ctor_Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_"></a> CMsgCandyShopCandyQuantity\(CMsgCandyShopCandyQuantity\)

```csharp
public CMsgCandyShopCandyQuantity(CMsgCandyShopCandyQuantity other)
```

#### Parameters

`other` [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_CandyCountsFieldNumber"></a> CandyCountsFieldNumber

```csharp
public const int CandyCountsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_CandyCounts"></a> CandyCounts

```csharp
public RepeatedField<CMsgCandyShopCandyCount> CandyCounts { get; }
```

#### Property Value

 RepeatedField<[CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopCandyQuantity> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopCandyQuantity Clone()
```

#### Returns

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_Equals_Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_"></a> Equals\(CMsgCandyShopCandyQuantity\)

```csharp
public bool Equals(CMsgCandyShopCandyQuantity other)
```

#### Parameters

`other` [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_"></a> MergeFrom\(CMsgCandyShopCandyQuantity\)

```csharp
public void MergeFrom(CMsgCandyShopCandyQuantity other)
```

#### Parameters

`other` [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyQuantity_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

