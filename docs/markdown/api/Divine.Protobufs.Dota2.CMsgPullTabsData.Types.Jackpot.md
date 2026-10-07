# <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot"></a> Class CMsgPullTabsData.Types.Jackpot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPullTabsData.Types.Jackpot : IMessage<CMsgPullTabsData.Types.Jackpot>, IEquatable<CMsgPullTabsData.Types.Jackpot>, IDeepCloneable<CMsgPullTabsData.Types.Jackpot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPullTabsData.Types.Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)

#### Implements

IMessage<CMsgPullTabsData.Types.Jackpot\>, 
[IEquatable<CMsgPullTabsData.Types.Jackpot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPullTabsData.Types.Jackpot\>, 
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
[EnumerableExtensions.In<CMsgPullTabsData.Types.Jackpot\>\(CMsgPullTabsData.Types.Jackpot, params CMsgPullTabsData.Types.Jackpot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot__ctor"></a> Jackpot\(\)

```csharp
public Jackpot()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot__ctor_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_"></a> Jackpot\(Jackpot\)

```csharp
public Jackpot(CMsgPullTabsData.Types.Jackpot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_BoardIdFieldNumber"></a> BoardIdFieldNumber

```csharp
public const int BoardIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_BoardId"></a> BoardId

```csharp
public uint BoardId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_HasBoardId"></a> HasBoardId

```csharp
public bool HasBoardId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPullTabsData.Types.Jackpot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ClearBoardId"></a> ClearBoardId\(\)

```csharp
public void ClearBoardId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_Clone"></a> Clone\(\)

```csharp
public CMsgPullTabsData.Types.Jackpot Clone()
```

#### Returns

 [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_Equals_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_"></a> Equals\(Jackpot\)

```csharp
public bool Equals(CMsgPullTabsData.Types.Jackpot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_MergeFrom_Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_"></a> MergeFrom\(Jackpot\)

```csharp
public void MergeFrom(CMsgPullTabsData.Types.Jackpot other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Types_Jackpot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

