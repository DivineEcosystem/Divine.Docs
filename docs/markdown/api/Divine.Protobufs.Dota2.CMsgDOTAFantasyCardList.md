# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList"></a> Class CMsgDOTAFantasyCardList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyCardList : IMessage<CMsgDOTAFantasyCardList>, IEquatable<CMsgDOTAFantasyCardList>, IDeepCloneable<CMsgDOTAFantasyCardList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)

#### Implements

IMessage<CMsgDOTAFantasyCardList\>, 
[IEquatable<CMsgDOTAFantasyCardList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyCardList\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyCardList\>\(CMsgDOTAFantasyCardList, params CMsgDOTAFantasyCardList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList__ctor"></a> CMsgDOTAFantasyCardList\(\)

```csharp
public CMsgDOTAFantasyCardList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_"></a> CMsgDOTAFantasyCardList\(CMsgDOTAFantasyCardList\)

```csharp
public CMsgDOTAFantasyCardList(CMsgDOTAFantasyCardList other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_CardsFieldNumber"></a> CardsFieldNumber

```csharp
public const int CardsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Cards"></a> Cards

```csharp
public RepeatedField<CMsgDOTAFantasyCardList.Types.Card> Cards { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.Card.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyCardList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyCardList Clone()
```

#### Returns

 [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_"></a> Equals\(CMsgDOTAFantasyCardList\)

```csharp
public bool Equals(CMsgDOTAFantasyCardList other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_"></a> MergeFrom\(CMsgDOTAFantasyCardList\)

```csharp
public void MergeFrom(CMsgDOTAFantasyCardList other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

