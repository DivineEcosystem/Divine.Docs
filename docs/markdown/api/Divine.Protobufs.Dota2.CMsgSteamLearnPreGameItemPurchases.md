# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases"></a> Class CMsgSteamLearnPreGameItemPurchases

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnPreGameItemPurchases : IMessage<CMsgSteamLearnPreGameItemPurchases>, IEquatable<CMsgSteamLearnPreGameItemPurchases>, IDeepCloneable<CMsgSteamLearnPreGameItemPurchases>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)

#### Implements

IMessage<CMsgSteamLearnPreGameItemPurchases\>, 
[IEquatable<CMsgSteamLearnPreGameItemPurchases\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnPreGameItemPurchases\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnPreGameItemPurchases\>\(CMsgSteamLearnPreGameItemPurchases, params CMsgSteamLearnPreGameItemPurchases\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases__ctor"></a> CMsgSteamLearnPreGameItemPurchases\(\)

```csharp
public CMsgSteamLearnPreGameItemPurchases()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_"></a> CMsgSteamLearnPreGameItemPurchases\(CMsgSteamLearnPreGameItemPurchases\)

```csharp
public CMsgSteamLearnPreGameItemPurchases(CMsgSteamLearnPreGameItemPurchases other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_IsRadiantTeamFieldNumber"></a> IsRadiantTeamFieldNumber

```csharp
public const int IsRadiantTeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_IsUsingDotaPlusFieldNumber"></a> IsUsingDotaPlusFieldNumber

```csharp
public const int IsUsingDotaPlusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_HasIsRadiantTeam"></a> HasIsRadiantTeam

```csharp
public bool HasIsRadiantTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_HasIsUsingDotaPlus"></a> HasIsUsingDotaPlus

```csharp
public bool HasIsUsingDotaPlus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_IsRadiantTeam"></a> IsRadiantTeam

```csharp
public uint IsRadiantTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_IsUsingDotaPlus"></a> IsUsingDotaPlus

```csharp
public bool IsUsingDotaPlus { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_ItemIds"></a> ItemIds

```csharp
public RepeatedField<int> ItemIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnPreGameItemPurchases> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_ClearIsRadiantTeam"></a> ClearIsRadiantTeam\(\)

```csharp
public void ClearIsRadiantTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_ClearIsUsingDotaPlus"></a> ClearIsUsingDotaPlus\(\)

```csharp
public void ClearIsUsingDotaPlus()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnPreGameItemPurchases Clone()
```

#### Returns

 [CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_"></a> Equals\(CMsgSteamLearnPreGameItemPurchases\)

```csharp
public bool Equals(CMsgSteamLearnPreGameItemPurchases other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_"></a> MergeFrom\(CMsgSteamLearnPreGameItemPurchases\)

```csharp
public void MergeFrom(CMsgSteamLearnPreGameItemPurchases other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchases](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchases.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchases_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

