# <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed"></a> Class CMsgSOCacheSubscribed

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheSubscribed : IMessage<CMsgSOCacheSubscribed>, IEquatable<CMsgSOCacheSubscribed>, IDeepCloneable<CMsgSOCacheSubscribed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)

#### Implements

IMessage<CMsgSOCacheSubscribed\>, 
[IEquatable<CMsgSOCacheSubscribed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheSubscribed\>, 
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
[EnumerableExtensions.In<CMsgSOCacheSubscribed\>\(CMsgSOCacheSubscribed, params CMsgSOCacheSubscribed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed__ctor"></a> CMsgSOCacheSubscribed\(\)

```csharp
public CMsgSOCacheSubscribed()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed__ctor_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_"></a> CMsgSOCacheSubscribed\(CMsgSOCacheSubscribed\)

```csharp
public CMsgSOCacheSubscribed(CMsgSOCacheSubscribed other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ObjectsFieldNumber"></a> ObjectsFieldNumber

```csharp
public const int ObjectsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ServiceListFieldNumber"></a> ServiceListFieldNumber

```csharp
public const int ServiceListFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_SyncVersionFieldNumber"></a> SyncVersionFieldNumber

```csharp
public const int SyncVersionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_HasSyncVersion"></a> HasSyncVersion

```csharp
public bool HasSyncVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Objects"></a> Objects

```csharp
public RepeatedField<CMsgSOCacheSubscribed.Types.SubscribedType> Objects { get; }
```

#### Property Value

 RepeatedField<[CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheSubscribed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ServiceList"></a> ServiceList

```csharp
public RepeatedField<uint> ServiceList { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_SyncVersion"></a> SyncVersion

```csharp
public ulong SyncVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ClearSyncVersion"></a> ClearSyncVersion\(\)

```csharp
public void ClearSyncVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheSubscribed Clone()
```

#### Returns

 [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Equals_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_"></a> Equals\(CMsgSOCacheSubscribed\)

```csharp
public bool Equals(CMsgSOCacheSubscribed other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_"></a> MergeFrom\(CMsgSOCacheSubscribed\)

```csharp
public void MergeFrom(CMsgSOCacheSubscribed other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

