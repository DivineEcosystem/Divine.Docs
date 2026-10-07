# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList"></a> Class CMsgDOTARealtimeGameStats.Types.AbilityList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.AbilityList : IMessage<CMsgDOTARealtimeGameStats.Types.AbilityList>, IEquatable<CMsgDOTARealtimeGameStats.Types.AbilityList>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.AbilityList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.AbilityList\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.AbilityList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.AbilityList\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.AbilityList\>\(CMsgDOTARealtimeGameStats.Types.AbilityList, params CMsgDOTARealtimeGameStats.Types.AbilityList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList__ctor"></a> AbilityList\(\)

```csharp
public AbilityList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_"></a> AbilityList\(AbilityList\)

```csharp
public AbilityList(CMsgDOTARealtimeGameStats.Types.AbilityList other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Id"></a> Id

```csharp
public RepeatedField<int> Id { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.AbilityList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.AbilityList Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_"></a> Equals\(AbilityList\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.AbilityList other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_"></a> MergeFrom\(AbilityList\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.AbilityList other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityList](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

