# <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate"></a> Class CMsgSOCacheSubscribedUpToDate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheSubscribedUpToDate : IMessage<CMsgSOCacheSubscribedUpToDate>, IEquatable<CMsgSOCacheSubscribedUpToDate>, IDeepCloneable<CMsgSOCacheSubscribedUpToDate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)

#### Implements

IMessage<CMsgSOCacheSubscribedUpToDate\>, 
[IEquatable<CMsgSOCacheSubscribedUpToDate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheSubscribedUpToDate\>, 
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
[EnumerableExtensions.In<CMsgSOCacheSubscribedUpToDate\>\(CMsgSOCacheSubscribedUpToDate, params CMsgSOCacheSubscribedUpToDate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate__ctor"></a> CMsgSOCacheSubscribedUpToDate\(\)

```csharp
public CMsgSOCacheSubscribedUpToDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate__ctor_Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_"></a> CMsgSOCacheSubscribedUpToDate\(CMsgSOCacheSubscribedUpToDate\)

```csharp
public CMsgSOCacheSubscribedUpToDate(CMsgSOCacheSubscribedUpToDate other)
```

#### Parameters

`other` [CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ServiceListFieldNumber"></a> ServiceListFieldNumber

```csharp
public const int ServiceListFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_SyncVersionFieldNumber"></a> SyncVersionFieldNumber

```csharp
public const int SyncVersionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_HasSyncVersion"></a> HasSyncVersion

```csharp
public bool HasSyncVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheSubscribedUpToDate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ServiceList"></a> ServiceList

```csharp
public RepeatedField<uint> ServiceList { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_SyncVersion"></a> SyncVersion

```csharp
public ulong SyncVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ClearSyncVersion"></a> ClearSyncVersion\(\)

```csharp
public void ClearSyncVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheSubscribedUpToDate Clone()
```

#### Returns

 [CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_Equals_Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_"></a> Equals\(CMsgSOCacheSubscribedUpToDate\)

```csharp
public bool Equals(CMsgSOCacheSubscribedUpToDate other)
```

#### Parameters

`other` [CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_"></a> MergeFrom\(CMsgSOCacheSubscribedUpToDate\)

```csharp
public void MergeFrom(CMsgSOCacheSubscribedUpToDate other)
```

#### Parameters

`other` [CMsgSOCacheSubscribedUpToDate](Divine.Protobufs.Dota2.CMsgSOCacheSubscribedUpToDate.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribedUpToDate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

