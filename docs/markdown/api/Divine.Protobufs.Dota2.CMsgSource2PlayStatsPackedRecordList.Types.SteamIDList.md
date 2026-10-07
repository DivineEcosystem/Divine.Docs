# <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList"></a> Class CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList : IMessage<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList>, IEquatable<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList>, IDeepCloneable<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)

#### Implements

IMessage<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList\>, 
[IEquatable<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList\>, 
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
[EnumerableExtensions.In<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList\>\(CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList, params CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList__ctor"></a> SteamIDList\(\)

```csharp
public SteamIDList()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList__ctor_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_"></a> SteamIDList\(SteamIDList\)

```csharp
public SteamIDList(CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Steamid"></a> Steamid

```csharp
public RepeatedField<ulong> Steamid { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Clone"></a> Clone\(\)

```csharp
public CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList Clone()
```

#### Returns

 [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_Equals_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_"></a> Equals\(SteamIDList\)

```csharp
public bool Equals(CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_MergeFrom_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_"></a> MergeFrom\(SteamIDList\)

```csharp
public void MergeFrom(CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[SteamIDList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.SteamIDList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_SteamIDList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

