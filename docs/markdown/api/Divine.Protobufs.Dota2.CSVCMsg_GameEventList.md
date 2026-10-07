# <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList"></a> Class CSVCMsg\_GameEventList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_GameEventList : IMessage<CSVCMsg_GameEventList>, IEquatable<CSVCMsg_GameEventList>, IDeepCloneable<CSVCMsg_GameEventList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)

#### Implements

IMessage<CSVCMsg\_GameEventList\>, 
[IEquatable<CSVCMsg\_GameEventList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_GameEventList\>, 
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
[EnumerableExtensions.In<CSVCMsg\_GameEventList\>\(CSVCMsg\_GameEventList, params CSVCMsg\_GameEventList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList__ctor"></a> CSVCMsg\_GameEventList\(\)

```csharp
public CSVCMsg_GameEventList()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList__ctor_Divine_Protobufs_Dota2_CSVCMsg_GameEventList_"></a> CSVCMsg\_GameEventList\(CSVCMsg\_GameEventList\)

```csharp
public CSVCMsg_GameEventList(CSVCMsg_GameEventList other)
```

#### Parameters

`other` [CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_DescriptorsFieldNumber"></a> DescriptorsFieldNumber

```csharp
public const int DescriptorsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Descriptors"></a> Descriptors

```csharp
public RepeatedField<CSVCMsg_GameEventList.Types.descriptor_t> Descriptors { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.Types.md).[descriptor\_t](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.Types.descriptor\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_GameEventList> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_GameEventList Clone()
```

#### Returns

 [CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_Equals_Divine_Protobufs_Dota2_CSVCMsg_GameEventList_"></a> Equals\(CSVCMsg\_GameEventList\)

```csharp
public bool Equals(CSVCMsg_GameEventList other)
```

#### Parameters

`other` [CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_GameEventList_"></a> MergeFrom\(CSVCMsg\_GameEventList\)

```csharp
public void MergeFrom(CSVCMsg_GameEventList other)
```

#### Parameters

`other` [CSVCMsg\_GameEventList](Divine.Protobufs.Dota2.CSVCMsg\_GameEventList.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEventList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

