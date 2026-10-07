# <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails"></a> Class CLobbyTimedRewardDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CLobbyTimedRewardDetails : IMessage<CLobbyTimedRewardDetails>, IEquatable<CLobbyTimedRewardDetails>, IDeepCloneable<CLobbyTimedRewardDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)

#### Implements

IMessage<CLobbyTimedRewardDetails\>, 
[IEquatable<CLobbyTimedRewardDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CLobbyTimedRewardDetails\>, 
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
[EnumerableExtensions.In<CLobbyTimedRewardDetails\>\(CLobbyTimedRewardDetails, params CLobbyTimedRewardDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails__ctor"></a> CLobbyTimedRewardDetails\(\)

```csharp
public CLobbyTimedRewardDetails()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails__ctor_Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_"></a> CLobbyTimedRewardDetails\(CLobbyTimedRewardDetails\)

```csharp
public CLobbyTimedRewardDetails(CLobbyTimedRewardDetails other)
```

#### Parameters

`other` [CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_IsSupplyCrateFieldNumber"></a> IsSupplyCrateFieldNumber

```csharp
public const int IsSupplyCrateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_IsTimedDropFieldNumber"></a> IsTimedDropFieldNumber

```csharp
public const int IsTimedDropFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_HasIsSupplyCrate"></a> HasIsSupplyCrate

```csharp
public bool HasIsSupplyCrate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_HasIsTimedDrop"></a> HasIsTimedDrop

```csharp
public bool HasIsTimedDrop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_HasOrigin"></a> HasOrigin

```csharp
public bool HasOrigin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_IsSupplyCrate"></a> IsSupplyCrate

```csharp
public bool IsSupplyCrate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_IsTimedDrop"></a> IsTimedDrop

```csharp
public bool IsTimedDrop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Origin"></a> Origin

```csharp
public uint Origin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Parser"></a> Parser

```csharp
public static MessageParser<CLobbyTimedRewardDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ClearIsSupplyCrate"></a> ClearIsSupplyCrate\(\)

```csharp
public void ClearIsSupplyCrate()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ClearIsTimedDrop"></a> ClearIsTimedDrop\(\)

```csharp
public void ClearIsTimedDrop()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ClearOrigin"></a> ClearOrigin\(\)

```csharp
public void ClearOrigin()
```

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Clone"></a> Clone\(\)

```csharp
public CLobbyTimedRewardDetails Clone()
```

#### Returns

 [CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_Equals_Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_"></a> Equals\(CLobbyTimedRewardDetails\)

```csharp
public bool Equals(CLobbyTimedRewardDetails other)
```

#### Parameters

`other` [CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_MergeFrom_Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_"></a> MergeFrom\(CLobbyTimedRewardDetails\)

```csharp
public void MergeFrom(CLobbyTimedRewardDetails other)
```

#### Parameters

`other` [CLobbyTimedRewardDetails](Divine.Protobufs.Dota2.CLobbyTimedRewardDetails.md)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyTimedRewardDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

