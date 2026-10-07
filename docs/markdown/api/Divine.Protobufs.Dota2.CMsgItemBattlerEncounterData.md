# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData"></a> Class CMsgItemBattlerEncounterData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerEncounterData : IMessage<CMsgItemBattlerEncounterData>, IEquatable<CMsgItemBattlerEncounterData>, IDeepCloneable<CMsgItemBattlerEncounterData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

#### Implements

IMessage<CMsgItemBattlerEncounterData\>, 
[IEquatable<CMsgItemBattlerEncounterData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerEncounterData\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerEncounterData\>\(CMsgItemBattlerEncounterData, params CMsgItemBattlerEncounterData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData__ctor"></a> CMsgItemBattlerEncounterData\(\)

```csharp
public CMsgItemBattlerEncounterData()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_"></a> CMsgItemBattlerEncounterData\(CMsgItemBattlerEncounterData\)

```csharp
public CMsgItemBattlerEncounterData(CMsgItemBattlerEncounterData other)
```

#### Parameters

`other` [CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_EncounterIdFieldNumber"></a> EncounterIdFieldNumber

```csharp
public const int EncounterIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_IsShopFieldNumber"></a> IsShopFieldNumber

```csharp
public const int IsShopFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_ShopItemsFieldNumber"></a> ShopItemsFieldNumber

```csharp
public const int ShopItemsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_EncounterId"></a> EncounterId

```csharp
public uint EncounterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_HasEncounterId"></a> HasEncounterId

```csharp
public bool HasEncounterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_HasIsShop"></a> HasIsShop

```csharp
public bool HasIsShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_IsShop"></a> IsShop

```csharp
public bool IsShop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerEncounterData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_ShopItems"></a> ShopItems

```csharp
public CMsgItemBattlerItemContainer ShopItems { get; set; }
```

#### Property Value

 [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_ClearEncounterId"></a> ClearEncounterId\(\)

```csharp
public void ClearEncounterId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_ClearIsShop"></a> ClearIsShop\(\)

```csharp
public void ClearIsShop()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerEncounterData Clone()
```

#### Returns

 [CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_"></a> Equals\(CMsgItemBattlerEncounterData\)

```csharp
public bool Equals(CMsgItemBattlerEncounterData other)
```

#### Parameters

`other` [CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_"></a> MergeFrom\(CMsgItemBattlerEncounterData\)

```csharp
public void MergeFrom(CMsgItemBattlerEncounterData other)
```

#### Parameters

`other` [CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerEncounterData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

