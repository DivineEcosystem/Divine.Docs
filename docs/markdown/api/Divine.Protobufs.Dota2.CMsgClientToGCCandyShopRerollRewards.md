# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards"></a> Class CMsgClientToGCCandyShopRerollRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopRerollRewards : IMessage<CMsgClientToGCCandyShopRerollRewards>, IEquatable<CMsgClientToGCCandyShopRerollRewards>, IDeepCloneable<CMsgClientToGCCandyShopRerollRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)

#### Implements

IMessage<CMsgClientToGCCandyShopRerollRewards\>, 
[IEquatable<CMsgClientToGCCandyShopRerollRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopRerollRewards\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopRerollRewards\>\(CMsgClientToGCCandyShopRerollRewards, params CMsgClientToGCCandyShopRerollRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards__ctor"></a> CMsgClientToGCCandyShopRerollRewards\(\)

```csharp
public CMsgClientToGCCandyShopRerollRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_"></a> CMsgClientToGCCandyShopRerollRewards\(CMsgClientToGCCandyShopRerollRewards\)

```csharp
public CMsgClientToGCCandyShopRerollRewards(CMsgClientToGCCandyShopRerollRewards other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopRerollRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopRerollRewards Clone()
```

#### Returns

 [CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_"></a> Equals\(CMsgClientToGCCandyShopRerollRewards\)

```csharp
public bool Equals(CMsgClientToGCCandyShopRerollRewards other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_"></a> MergeFrom\(CMsgClientToGCCandyShopRerollRewards\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopRerollRewards other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopRerollRewards](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopRerollRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopRerollRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

