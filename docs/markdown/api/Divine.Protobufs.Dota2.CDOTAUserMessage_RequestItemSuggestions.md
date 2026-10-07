# <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions"></a> Class CDOTAUserMessage\_RequestItemSuggestions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMessage_RequestItemSuggestions : IMessage<CDOTAUserMessage_RequestItemSuggestions>, IEquatable<CDOTAUserMessage_RequestItemSuggestions>, IDeepCloneable<CDOTAUserMessage_RequestItemSuggestions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)

#### Implements

IMessage<CDOTAUserMessage\_RequestItemSuggestions\>, 
[IEquatable<CDOTAUserMessage\_RequestItemSuggestions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMessage\_RequestItemSuggestions\>, 
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
[EnumerableExtensions.In<CDOTAUserMessage\_RequestItemSuggestions\>\(CDOTAUserMessage\_RequestItemSuggestions, params CDOTAUserMessage\_RequestItemSuggestions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions__ctor"></a> CDOTAUserMessage\_RequestItemSuggestions\(\)

```csharp
public CDOTAUserMessage_RequestItemSuggestions()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions__ctor_Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_"></a> CDOTAUserMessage\_RequestItemSuggestions\(CDOTAUserMessage\_RequestItemSuggestions\)

```csharp
public CDOTAUserMessage_RequestItemSuggestions(CDOTAUserMessage_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMessage_RequestItemSuggestions> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMessage_RequestItemSuggestions Clone()
```

#### Returns

 [CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_Equals_Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_"></a> Equals\(CDOTAUserMessage\_RequestItemSuggestions\)

```csharp
public bool Equals(CDOTAUserMessage_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_"></a> MergeFrom\(CDOTAUserMessage\_RequestItemSuggestions\)

```csharp
public void MergeFrom(CDOTAUserMessage_RequestItemSuggestions other)
```

#### Parameters

`other` [CDOTAUserMessage\_RequestItemSuggestions](Divine.Protobufs.Dota2.CDOTAUserMessage\_RequestItemSuggestions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_RequestItemSuggestions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

