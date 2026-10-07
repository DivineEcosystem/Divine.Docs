# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel"></a> Class CDOTAClientMsg\_ChatWheel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChatWheel : IMessage<CDOTAClientMsg_ChatWheel>, IEquatable<CDOTAClientMsg_ChatWheel>, IDeepCloneable<CDOTAClientMsg_ChatWheel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)

#### Implements

IMessage<CDOTAClientMsg\_ChatWheel\>, 
[IEquatable<CDOTAClientMsg\_ChatWheel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChatWheel\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChatWheel\>\(CDOTAClientMsg\_ChatWheel, params CDOTAClientMsg\_ChatWheel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel__ctor"></a> CDOTAClientMsg\_ChatWheel\(\)

```csharp
public CDOTAClientMsg_ChatWheel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_"></a> CDOTAClientMsg\_ChatWheel\(CDOTAClientMsg\_ChatWheel\)

```csharp
public CDOTAClientMsg_ChatWheel(CDOTAClientMsg_ChatWheel other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ChatMessageIdFieldNumber"></a> ChatMessageIdFieldNumber

```csharp
public const int ChatMessageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_EmoticonIdFieldNumber"></a> EmoticonIdFieldNumber

```csharp
public const int EmoticonIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ParamHeroIdFieldNumber"></a> ParamHeroIdFieldNumber

```csharp
public const int ParamHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ChatMessageId"></a> ChatMessageId

```csharp
public uint ChatMessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_EmoticonId"></a> EmoticonId

```csharp
public uint EmoticonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_HasChatMessageId"></a> HasChatMessageId

```csharp
public bool HasChatMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_HasEmoticonId"></a> HasEmoticonId

```csharp
public bool HasEmoticonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_HasParamHeroId"></a> HasParamHeroId

```csharp
public bool HasParamHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ParamHeroId"></a> ParamHeroId

```csharp
public int ParamHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChatWheel> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ClearChatMessageId"></a> ClearChatMessageId\(\)

```csharp
public void ClearChatMessageId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ClearEmoticonId"></a> ClearEmoticonId\(\)

```csharp
public void ClearEmoticonId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ClearParamHeroId"></a> ClearParamHeroId\(\)

```csharp
public void ClearParamHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChatWheel Clone()
```

#### Returns

 [CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_"></a> Equals\(CDOTAClientMsg\_ChatWheel\)

```csharp
public bool Equals(CDOTAClientMsg_ChatWheel other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_"></a> MergeFrom\(CDOTAClientMsg\_ChatWheel\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChatWheel other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatWheel](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatWheel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

