# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate"></a> Class CMsgGCToClientPartyBeaconUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPartyBeaconUpdate : IMessage<CMsgGCToClientPartyBeaconUpdate>, IEquatable<CMsgGCToClientPartyBeaconUpdate>, IDeepCloneable<CMsgGCToClientPartyBeaconUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)

#### Implements

IMessage<CMsgGCToClientPartyBeaconUpdate\>, 
[IEquatable<CMsgGCToClientPartyBeaconUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPartyBeaconUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPartyBeaconUpdate\>\(CMsgGCToClientPartyBeaconUpdate, params CMsgGCToClientPartyBeaconUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate__ctor"></a> CMsgGCToClientPartyBeaconUpdate\(\)

```csharp
public CMsgGCToClientPartyBeaconUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_"></a> CMsgGCToClientPartyBeaconUpdate\(CMsgGCToClientPartyBeaconUpdate\)

```csharp
public CMsgGCToClientPartyBeaconUpdate(CMsgGCToClientPartyBeaconUpdate other)
```

#### Parameters

`other` [CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_BeaconAddedFieldNumber"></a> BeaconAddedFieldNumber

```csharp
public const int BeaconAddedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_BeaconTypeFieldNumber"></a> BeaconTypeFieldNumber

```csharp
public const int BeaconTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_BeaconAdded"></a> BeaconAdded

```csharp
public bool BeaconAdded { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_BeaconType"></a> BeaconType

```csharp
public int BeaconType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_HasBeaconAdded"></a> HasBeaconAdded

```csharp
public bool HasBeaconAdded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_HasBeaconType"></a> HasBeaconType

```csharp
public bool HasBeaconType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPartyBeaconUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_ClearBeaconAdded"></a> ClearBeaconAdded\(\)

```csharp
public void ClearBeaconAdded()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_ClearBeaconType"></a> ClearBeaconType\(\)

```csharp
public void ClearBeaconType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPartyBeaconUpdate Clone()
```

#### Returns

 [CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_"></a> Equals\(CMsgGCToClientPartyBeaconUpdate\)

```csharp
public bool Equals(CMsgGCToClientPartyBeaconUpdate other)
```

#### Parameters

`other` [CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_"></a> MergeFrom\(CMsgGCToClientPartyBeaconUpdate\)

```csharp
public void MergeFrom(CMsgGCToClientPartyBeaconUpdate other)
```

#### Parameters

`other` [CMsgGCToClientPartyBeaconUpdate](Divine.Protobufs.Dota2.CMsgGCToClientPartyBeaconUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartyBeaconUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

