# <a id="Divine_Protobufs_Dota2_CPartySearchClientParty"></a> Class CPartySearchClientParty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPartySearchClientParty : IMessage<CPartySearchClientParty>, IEquatable<CPartySearchClientParty>, IDeepCloneable<CPartySearchClientParty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)

#### Implements

IMessage<CPartySearchClientParty\>, 
[IEquatable<CPartySearchClientParty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPartySearchClientParty\>, 
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
[EnumerableExtensions.In<CPartySearchClientParty\>\(CPartySearchClientParty, params CPartySearchClientParty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty__ctor"></a> CPartySearchClientParty\(\)

```csharp
public CPartySearchClientParty()
```

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty__ctor_Divine_Protobufs_Dota2_CPartySearchClientParty_"></a> CPartySearchClientParty\(CPartySearchClientParty\)

```csharp
public CPartySearchClientParty(CPartySearchClientParty other)
```

#### Parameters

`other` [CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_BeaconTypeFieldNumber"></a> BeaconTypeFieldNumber

```csharp
public const int BeaconTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_PartyIdFieldNumber"></a> PartyIdFieldNumber

```csharp
public const int PartyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_PartyMembersFieldNumber"></a> PartyMembersFieldNumber

```csharp
public const int PartyMembersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_BeaconType"></a> BeaconType

```csharp
public int BeaconType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_HasBeaconType"></a> HasBeaconType

```csharp
public bool HasBeaconType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_HasPartyId"></a> HasPartyId

```csharp
public bool HasPartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_Parser"></a> Parser

```csharp
public static MessageParser<CPartySearchClientParty> Parser { get; }
```

#### Property Value

 MessageParser<[CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)\>

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_PartyId"></a> PartyId

```csharp
public ulong PartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_PartyMembers"></a> PartyMembers

```csharp
public RepeatedField<uint> PartyMembers { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_ClearBeaconType"></a> ClearBeaconType\(\)

```csharp
public void ClearBeaconType()
```

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_ClearPartyId"></a> ClearPartyId\(\)

```csharp
public void ClearPartyId()
```

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_Clone"></a> Clone\(\)

```csharp
public CPartySearchClientParty Clone()
```

#### Returns

 [CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_Equals_Divine_Protobufs_Dota2_CPartySearchClientParty_"></a> Equals\(CPartySearchClientParty\)

```csharp
public bool Equals(CPartySearchClientParty other)
```

#### Parameters

`other` [CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_MergeFrom_Divine_Protobufs_Dota2_CPartySearchClientParty_"></a> MergeFrom\(CPartySearchClientParty\)

```csharp
public void MergeFrom(CPartySearchClientParty other)
```

#### Parameters

`other` [CPartySearchClientParty](Divine.Protobufs.Dota2.CPartySearchClientParty.md)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CPartySearchClientParty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

