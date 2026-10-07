# <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck"></a> Class CMsgSOCacheSubscriptionCheck

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheSubscriptionCheck : IMessage<CMsgSOCacheSubscriptionCheck>, IEquatable<CMsgSOCacheSubscriptionCheck>, IDeepCloneable<CMsgSOCacheSubscriptionCheck>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)

#### Implements

IMessage<CMsgSOCacheSubscriptionCheck\>, 
[IEquatable<CMsgSOCacheSubscriptionCheck\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheSubscriptionCheck\>, 
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
[EnumerableExtensions.In<CMsgSOCacheSubscriptionCheck\>\(CMsgSOCacheSubscriptionCheck, params CMsgSOCacheSubscriptionCheck\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck__ctor"></a> CMsgSOCacheSubscriptionCheck\(\)

```csharp
public CMsgSOCacheSubscriptionCheck()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck__ctor_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_"></a> CMsgSOCacheSubscriptionCheck\(CMsgSOCacheSubscriptionCheck\)

```csharp
public CMsgSOCacheSubscriptionCheck(CMsgSOCacheSubscriptionCheck other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ServiceListFieldNumber"></a> ServiceListFieldNumber

```csharp
public const int ServiceListFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_SyncVersionFieldNumber"></a> SyncVersionFieldNumber

```csharp
public const int SyncVersionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_HasSyncVersion"></a> HasSyncVersion

```csharp
public bool HasSyncVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheSubscriptionCheck> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ServiceList"></a> ServiceList

```csharp
public RepeatedField<uint> ServiceList { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_SyncVersion"></a> SyncVersion

```csharp
public ulong SyncVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ClearSyncVersion"></a> ClearSyncVersion\(\)

```csharp
public void ClearSyncVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheSubscriptionCheck Clone()
```

#### Returns

 [CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_Equals_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_"></a> Equals\(CMsgSOCacheSubscriptionCheck\)

```csharp
public bool Equals(CMsgSOCacheSubscriptionCheck other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_"></a> MergeFrom\(CMsgSOCacheSubscriptionCheck\)

```csharp
public void MergeFrom(CMsgSOCacheSubscriptionCheck other)
```

#### Parameters

`other` [CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscriptionCheck_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

