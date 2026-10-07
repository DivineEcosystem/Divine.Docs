# <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot"></a> Class CMsgPullTabsData.Types.Slot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPullTabsData.Types.Slot : IMessage<CMsgPullTabsData.Types.Slot>, IEquatable<CMsgPullTabsData.Types.Slot>, IDeepCloneable<CMsgPullTabsData.Types.Slot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPullTabsData.Types.Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)

#### Implements

IMessage<CMsgPullTabsData.Types.Slot\>, 
[IEquatable<CMsgPullTabsData.Types.Slot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPullTabsData.Types.Slot\>, 
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
[EnumerableExtensions.In<CMsgPullTabsData.Types.Slot\>\(CMsgPullTabsData.Types.Slot, params CMsgPullTabsData.Types.Slot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot__ctor"></a> Slot\(\)

```csharp
public Slot()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot__ctor_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_"></a> Slot\(Slot\)

```csharp
public Slot(CMsgPullTabsData.Types.Slot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_BoardIdFieldNumber"></a> BoardIdFieldNumber

```csharp
public const int BoardIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_RedeemedFieldNumber"></a> RedeemedFieldNumber

```csharp
public const int RedeemedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_BoardId"></a> BoardId

```csharp
public uint BoardId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HasBoardId"></a> HasBoardId

```csharp
public bool HasBoardId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HasRedeemed"></a> HasRedeemed

```csharp
public bool HasRedeemed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPullTabsData.Types.Slot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Redeemed"></a> Redeemed

```csharp
public bool Redeemed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ClearBoardId"></a> ClearBoardId\(\)

```csharp
public void ClearBoardId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ClearRedeemed"></a> ClearRedeemed\(\)

```csharp
public void ClearRedeemed()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Clone"></a> Clone\(\)

```csharp
public CMsgPullTabsData.Types.Slot Clone()
```

#### Returns

 [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_Equals_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_"></a> Equals\(Slot\)

```csharp
public bool Equals(CMsgPullTabsData.Types.Slot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_MergeFrom_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_"></a> MergeFrom\(Slot\)

```csharp
public void MergeFrom(CMsgPullTabsData.Types.Slot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Slot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

