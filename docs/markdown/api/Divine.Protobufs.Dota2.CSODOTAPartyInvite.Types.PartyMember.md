# <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember"></a> Class CSODOTAPartyInvite.Types.PartyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAPartyInvite.Types.PartyMember : IMessage<CSODOTAPartyInvite.Types.PartyMember>, IEquatable<CSODOTAPartyInvite.Types.PartyMember>, IDeepCloneable<CSODOTAPartyInvite.Types.PartyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAPartyInvite.Types.PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)

#### Implements

IMessage<CSODOTAPartyInvite.Types.PartyMember\>, 
[IEquatable<CSODOTAPartyInvite.Types.PartyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAPartyInvite.Types.PartyMember\>, 
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
[EnumerableExtensions.In<CSODOTAPartyInvite.Types.PartyMember\>\(CSODOTAPartyInvite.Types.PartyMember, params CSODOTAPartyInvite.Types.PartyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember__ctor"></a> PartyMember\(\)

```csharp
public PartyMember()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember__ctor_Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_"></a> PartyMember\(PartyMember\)

```csharp
public PartyMember(CSODOTAPartyInvite.Types.PartyMember other)
```

#### Parameters

`other` [CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.md).[PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_IsCoachFieldNumber"></a> IsCoachFieldNumber

```csharp
public const int IsCoachFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_HasIsCoach"></a> HasIsCoach

```csharp
public bool HasIsCoach { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_IsCoach"></a> IsCoach

```csharp
public bool IsCoach { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAPartyInvite.Types.PartyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.md).[PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_ClearIsCoach"></a> ClearIsCoach\(\)

```csharp
public void ClearIsCoach()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Clone"></a> Clone\(\)

```csharp
public CSODOTAPartyInvite.Types.PartyMember Clone()
```

#### Returns

 [CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.md).[PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_Equals_Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_"></a> Equals\(PartyMember\)

```csharp
public bool Equals(CSODOTAPartyInvite.Types.PartyMember other)
```

#### Parameters

`other` [CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.md).[PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_MergeFrom_Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_"></a> MergeFrom\(PartyMember\)

```csharp
public void MergeFrom(CSODOTAPartyInvite.Types.PartyMember other)
```

#### Parameters

`other` [CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.md).[PartyMember](Divine.Protobufs.Dota2.CSODOTAPartyInvite.Types.PartyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyInvite_Types_PartyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

