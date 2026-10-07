# <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh"></a> Class CMsgSOCacheSubscriptionRefresh

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheSubscriptionRefresh : IMessage<CMsgSOCacheSubscriptionRefresh>, IEquatable<CMsgSOCacheSubscriptionRefresh>, IDeepCloneable<CMsgSOCacheSubscriptionRefresh>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)

#### Implements

IMessage<CMsgSOCacheSubscriptionRefresh\>, 
[IEquatable<CMsgSOCacheSubscriptionRefresh\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheSubscriptionRefresh\>, 
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
[EnumerableExtensions.In<CMsgSOCacheSubscriptionRefresh\>\(CMsgSOCacheSubscriptionRefresh, params CMsgSOCacheSubscriptionRefresh\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh__ctor"></a> CMsgSOCacheSubscriptionRefresh\(\)

```csharp
public CMsgSOCacheSubscriptionRefresh()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh__ctor_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_"></a> CMsgSOCacheSubscriptionRefresh\(CMsgSOCacheSubscriptionRefresh\)

```csharp
public CMsgSOCacheSubscriptionRefresh(CMsgSOCacheSubscriptionRefresh other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheSubscriptionRefresh> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheSubscriptionRefresh Clone()
```

#### Returns

 [CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_Equals_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_"></a> Equals\(CMsgSOCacheSubscriptionRefresh\)

```csharp
public bool Equals(CMsgSOCacheSubscriptionRefresh other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_"></a> MergeFrom\(CMsgSOCacheSubscriptionRefresh\)

```csharp
public void MergeFrom(CMsgSOCacheSubscriptionRefresh other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionRefresh](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionRefresh.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionRefresh_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

