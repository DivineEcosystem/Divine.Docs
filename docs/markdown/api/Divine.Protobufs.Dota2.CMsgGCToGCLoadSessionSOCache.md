# <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache"></a> Class CMsgGCToGCLoadSessionSOCache

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCLoadSessionSOCache : IMessage<CMsgGCToGCLoadSessionSOCache>, IEquatable<CMsgGCToGCLoadSessionSOCache>, IDeepCloneable<CMsgGCToGCLoadSessionSOCache>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)

#### Implements

IMessage<CMsgGCToGCLoadSessionSOCache\>, 
[IEquatable<CMsgGCToGCLoadSessionSOCache\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCLoadSessionSOCache\>, 
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
[EnumerableExtensions.In<CMsgGCToGCLoadSessionSOCache\>\(CMsgGCToGCLoadSessionSOCache, params CMsgGCToGCLoadSessionSOCache\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache__ctor"></a> CMsgGCToGCLoadSessionSOCache\(\)

```csharp
public CMsgGCToGCLoadSessionSOCache()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache__ctor_Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_"></a> CMsgGCToGCLoadSessionSOCache\(CMsgGCToGCLoadSessionSOCache\)

```csharp
public CMsgGCToGCLoadSessionSOCache(CMsgGCToGCLoadSessionSOCache other)
```

#### Parameters

`other` [CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_ForwardAccountDetailsFieldNumber"></a> ForwardAccountDetailsFieldNumber

```csharp
public const int ForwardAccountDetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_ForwardAccountDetails"></a> ForwardAccountDetails

```csharp
public CMsgGCToGCForwardAccountDetails ForwardAccountDetails { get; set; }
```

#### Property Value

 [CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCLoadSessionSOCache> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCLoadSessionSOCache Clone()
```

#### Returns

 [CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_Equals_Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_"></a> Equals\(CMsgGCToGCLoadSessionSOCache\)

```csharp
public bool Equals(CMsgGCToGCLoadSessionSOCache other)
```

#### Parameters

`other` [CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_"></a> MergeFrom\(CMsgGCToGCLoadSessionSOCache\)

```csharp
public void MergeFrom(CMsgGCToGCLoadSessionSOCache other)
```

#### Parameters

`other` [CMsgGCToGCLoadSessionSOCache](Divine.Protobufs.Dota2.CMsgGCToGCLoadSessionSOCache.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCLoadSessionSOCache_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

