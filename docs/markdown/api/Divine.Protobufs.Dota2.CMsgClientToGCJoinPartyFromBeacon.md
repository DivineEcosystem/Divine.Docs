# <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon"></a> Class CMsgClientToGCJoinPartyFromBeacon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCJoinPartyFromBeacon : IMessage<CMsgClientToGCJoinPartyFromBeacon>, IEquatable<CMsgClientToGCJoinPartyFromBeacon>, IDeepCloneable<CMsgClientToGCJoinPartyFromBeacon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)

#### Implements

IMessage<CMsgClientToGCJoinPartyFromBeacon\>, 
[IEquatable<CMsgClientToGCJoinPartyFromBeacon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCJoinPartyFromBeacon\>, 
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
[EnumerableExtensions.In<CMsgClientToGCJoinPartyFromBeacon\>\(CMsgClientToGCJoinPartyFromBeacon, params CMsgClientToGCJoinPartyFromBeacon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon__ctor"></a> CMsgClientToGCJoinPartyFromBeacon\(\)

```csharp
public CMsgClientToGCJoinPartyFromBeacon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon__ctor_Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_"></a> CMsgClientToGCJoinPartyFromBeacon\(CMsgClientToGCJoinPartyFromBeacon\)

```csharp
public CMsgClientToGCJoinPartyFromBeacon(CMsgClientToGCJoinPartyFromBeacon other)
```

#### Parameters

`other` [CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_BeaconTypeFieldNumber"></a> BeaconTypeFieldNumber

```csharp
public const int BeaconTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_PartyIdFieldNumber"></a> PartyIdFieldNumber

```csharp
public const int PartyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_BeaconType"></a> BeaconType

```csharp
public int BeaconType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_HasBeaconType"></a> HasBeaconType

```csharp
public bool HasBeaconType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_HasPartyId"></a> HasPartyId

```csharp
public bool HasPartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCJoinPartyFromBeacon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_PartyId"></a> PartyId

```csharp
public ulong PartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_ClearBeaconType"></a> ClearBeaconType\(\)

```csharp
public void ClearBeaconType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_ClearPartyId"></a> ClearPartyId\(\)

```csharp
public void ClearPartyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCJoinPartyFromBeacon Clone()
```

#### Returns

 [CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_Equals_Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_"></a> Equals\(CMsgClientToGCJoinPartyFromBeacon\)

```csharp
public bool Equals(CMsgClientToGCJoinPartyFromBeacon other)
```

#### Parameters

`other` [CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_"></a> MergeFrom\(CMsgClientToGCJoinPartyFromBeacon\)

```csharp
public void MergeFrom(CMsgClientToGCJoinPartyFromBeacon other)
```

#### Parameters

`other` [CMsgClientToGCJoinPartyFromBeacon](Divine.Protobufs.Dota2.CMsgClientToGCJoinPartyFromBeacon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPartyFromBeacon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

