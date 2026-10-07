# <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList"></a> Class CMsgSource1LegacyGameEventList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource1LegacyGameEventList : IMessage<CMsgSource1LegacyGameEventList>, IEquatable<CMsgSource1LegacyGameEventList>, IDeepCloneable<CMsgSource1LegacyGameEventList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)

#### Implements

IMessage<CMsgSource1LegacyGameEventList\>, 
[IEquatable<CMsgSource1LegacyGameEventList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource1LegacyGameEventList\>, 
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
[EnumerableExtensions.In<CMsgSource1LegacyGameEventList\>\(CMsgSource1LegacyGameEventList, params CMsgSource1LegacyGameEventList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList__ctor"></a> CMsgSource1LegacyGameEventList\(\)

```csharp
public CMsgSource1LegacyGameEventList()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList__ctor_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_"></a> CMsgSource1LegacyGameEventList\(CMsgSource1LegacyGameEventList\)

```csharp
public CMsgSource1LegacyGameEventList(CMsgSource1LegacyGameEventList other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_DescriptorsFieldNumber"></a> DescriptorsFieldNumber

```csharp
public const int DescriptorsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Descriptors"></a> Descriptors

```csharp
public RepeatedField<CMsgSource1LegacyGameEventList.Types.descriptor_t> Descriptors { get; }
```

#### Property Value

 RepeatedField<[CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[descriptor\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.descriptor\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource1LegacyGameEventList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Clone"></a> Clone\(\)

```csharp
public CMsgSource1LegacyGameEventList Clone()
```

#### Returns

 [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Equals_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_"></a> Equals\(CMsgSource1LegacyGameEventList\)

```csharp
public bool Equals(CMsgSource1LegacyGameEventList other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_MergeFrom_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_"></a> MergeFrom\(CMsgSource1LegacyGameEventList\)

```csharp
public void MergeFrom(CMsgSource1LegacyGameEventList other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

