# <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe"></a> Class CMsgGCToGCSOCacheSubscribe

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCSOCacheSubscribe : IMessage<CMsgGCToGCSOCacheSubscribe>, IEquatable<CMsgGCToGCSOCacheSubscribe>, IDeepCloneable<CMsgGCToGCSOCacheSubscribe>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)

#### Implements

IMessage<CMsgGCToGCSOCacheSubscribe\>, 
[IEquatable<CMsgGCToGCSOCacheSubscribe\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCSOCacheSubscribe\>, 
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
[EnumerableExtensions.In<CMsgGCToGCSOCacheSubscribe\>\(CMsgGCToGCSOCacheSubscribe, params CMsgGCToGCSOCacheSubscribe\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe__ctor"></a> CMsgGCToGCSOCacheSubscribe\(\)

```csharp
public CMsgGCToGCSOCacheSubscribe()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe__ctor_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_"></a> CMsgGCToGCSOCacheSubscribe\(CMsgGCToGCSOCacheSubscribe\)

```csharp
public CMsgGCToGCSOCacheSubscribe(CMsgGCToGCSOCacheSubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HaveVersionsFieldNumber"></a> HaveVersionsFieldNumber

```csharp
public const int HaveVersionsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SubscriberFieldNumber"></a> SubscriberFieldNumber

```csharp
public const int SubscriberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SubscribeToIdFieldNumber"></a> SubscribeToIdFieldNumber

```csharp
public const int SubscribeToIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SubscribeToTypeFieldNumber"></a> SubscribeToTypeFieldNumber

```csharp
public const int SubscribeToTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SyncVersionFieldNumber"></a> SyncVersionFieldNumber

```csharp
public const int SyncVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HasSubscriber"></a> HasSubscriber

```csharp
public bool HasSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HasSubscribeToId"></a> HasSubscribeToId

```csharp
public bool HasSubscribeToId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HasSubscribeToType"></a> HasSubscribeToType

```csharp
public bool HasSubscribeToType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HasSyncVersion"></a> HasSyncVersion

```csharp
public bool HasSyncVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_HaveVersions"></a> HaveVersions

```csharp
public RepeatedField<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions> HaveVersions { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCSOCacheSubscribe> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Subscriber"></a> Subscriber

```csharp
public ulong Subscriber { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SubscribeToId"></a> SubscribeToId

```csharp
public ulong SubscribeToId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SubscribeToType"></a> SubscribeToType

```csharp
public uint SubscribeToType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_SyncVersion"></a> SyncVersion

```csharp
public ulong SyncVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_ClearSubscriber"></a> ClearSubscriber\(\)

```csharp
public void ClearSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_ClearSubscribeToId"></a> ClearSubscribeToId\(\)

```csharp
public void ClearSubscribeToId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_ClearSubscribeToType"></a> ClearSubscribeToType\(\)

```csharp
public void ClearSubscribeToType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_ClearSyncVersion"></a> ClearSyncVersion\(\)

```csharp
public void ClearSyncVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCSOCacheSubscribe Clone()
```

#### Returns

 [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Equals_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_"></a> Equals\(CMsgGCToGCSOCacheSubscribe\)

```csharp
public bool Equals(CMsgGCToGCSOCacheSubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_"></a> MergeFrom\(CMsgGCToGCSOCacheSubscribe\)

```csharp
public void MergeFrom(CMsgGCToGCSOCacheSubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

