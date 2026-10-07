# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions"></a> Class CDOTAClientMsg\_RequestItemSuggestions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RequestItemSuggestions : IMessage<CDOTAClientMsg_RequestItemSuggestions>, IEquatable<CDOTAClientMsg_RequestItemSuggestions>, IDeepCloneable<CDOTAClientMsg_RequestItemSuggestions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)

#### Implements

IMessage<CDOTAClientMsg\_RequestItemSuggestions\>, 
[IEquatable<CDOTAClientMsg\_RequestItemSuggestions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RequestItemSuggestions\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RequestItemSuggestions\>\(CDOTAClientMsg\_RequestItemSuggestions, params CDOTAClientMsg\_RequestItemSuggestions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions__ctor"></a> CDOTAClientMsg\_RequestItemSuggestions\(\)

```csharp
public CDOTAClientMsg_RequestItemSuggestions()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_"></a> CDOTAClientMsg\_RequestItemSuggestions\(CDOTAClientMsg\_RequestItemSuggestions\)

```csharp
public CDOTAClientMsg_RequestItemSuggestions(CDOTAClientMsg_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RequestItemSuggestions> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RequestItemSuggestions Clone()
```

#### Returns

 [CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_"></a> Equals\(CDOTAClientMsg\_RequestItemSuggestions\)

```csharp
public bool Equals(CDOTAClientMsg_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_"></a> MergeFrom\(CDOTAClientMsg\_RequestItemSuggestions\)

```csharp
public void MergeFrom(CDOTAClientMsg_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestItemSuggestions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestItemSuggestions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

