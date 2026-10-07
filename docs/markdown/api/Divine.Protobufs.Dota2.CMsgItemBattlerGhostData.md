# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData"></a> Class CMsgItemBattlerGhostData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerGhostData : IMessage<CMsgItemBattlerGhostData>, IEquatable<CMsgItemBattlerGhostData>, IDeepCloneable<CMsgItemBattlerGhostData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)

#### Implements

IMessage<CMsgItemBattlerGhostData\>, 
[IEquatable<CMsgItemBattlerGhostData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerGhostData\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerGhostData\>\(CMsgItemBattlerGhostData, params CMsgItemBattlerGhostData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData__ctor"></a> CMsgItemBattlerGhostData\(\)

```csharp
public CMsgItemBattlerGhostData()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_"></a> CMsgItemBattlerGhostData\(CMsgItemBattlerGhostData\)

```csharp
public CMsgItemBattlerGhostData(CMsgItemBattlerGhostData other)
```

#### Parameters

`other` [CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_AbilitiesFieldNumber"></a> AbilitiesFieldNumber

```csharp
public const int AbilitiesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_DayFieldNumber"></a> DayFieldNumber

```csharp
public const int DayFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_PlayerDataFieldNumber"></a> PlayerDataFieldNumber

```csharp
public const int PlayerDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Abilities"></a> Abilities

```csharp
public MapField<uint, CMsgItemBattlerItem> Abilities { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Day"></a> Day

```csharp
public int Day { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_HasDay"></a> HasDay

```csharp
public bool HasDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Items"></a> Items

```csharp
public MapField<uint, CMsgItemBattlerItem> Items { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerGhostData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_PlayerData"></a> PlayerData

```csharp
public CMsgItemBattlerPlayerData PlayerData { get; set; }
```

#### Property Value

 [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_ClearDay"></a> ClearDay\(\)

```csharp
public void ClearDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerGhostData Clone()
```

#### Returns

 [CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_"></a> Equals\(CMsgItemBattlerGhostData\)

```csharp
public bool Equals(CMsgItemBattlerGhostData other)
```

#### Parameters

`other` [CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_"></a> MergeFrom\(CMsgItemBattlerGhostData\)

```csharp
public void MergeFrom(CMsgItemBattlerGhostData other)
```

#### Parameters

`other` [CMsgItemBattlerGhostData](Divine.Protobufs.Dota2.CMsgItemBattlerGhostData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGhostData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

