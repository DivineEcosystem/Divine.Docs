# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails"></a> Class CMsgDOTARealtimeGameStats.Types.ItemDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.ItemDetails : IMessage<CMsgDOTARealtimeGameStats.Types.ItemDetails>, IEquatable<CMsgDOTARealtimeGameStats.Types.ItemDetails>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.ItemDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.ItemDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.ItemDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.ItemDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.ItemDetails\>\(CMsgDOTARealtimeGameStats.Types.ItemDetails, params CMsgDOTARealtimeGameStats.Types.ItemDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails__ctor"></a> ItemDetails\(\)

```csharp
public ItemDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_"></a> ItemDetails\(ItemDetails\)

```csharp
public ItemDetails(CMsgDOTARealtimeGameStats.Types.ItemDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_SoldFieldNumber"></a> SoldFieldNumber

```csharp
public const int SoldFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_StackcountFieldNumber"></a> StackcountFieldNumber

```csharp
public const int StackcountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_HasSold"></a> HasSold

```csharp
public bool HasSold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_HasStackcount"></a> HasStackcount

```csharp
public bool HasStackcount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.ItemDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Sold"></a> Sold

```csharp
public bool Sold { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Stackcount"></a> Stackcount

```csharp
public uint Stackcount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Time"></a> Time

```csharp
public int Time { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ClearSold"></a> ClearSold\(\)

```csharp
public void ClearSold()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ClearStackcount"></a> ClearStackcount\(\)

```csharp
public void ClearStackcount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.ItemDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_"></a> Equals\(ItemDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.ItemDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_"></a> MergeFrom\(ItemDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.ItemDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[ItemDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.ItemDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_ItemDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

