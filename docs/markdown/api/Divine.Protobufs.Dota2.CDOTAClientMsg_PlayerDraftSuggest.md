# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest"></a> Class CDOTAClientMsg\_PlayerDraftSuggest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PlayerDraftSuggest : IMessage<CDOTAClientMsg_PlayerDraftSuggest>, IEquatable<CDOTAClientMsg_PlayerDraftSuggest>, IDeepCloneable<CDOTAClientMsg_PlayerDraftSuggest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)

#### Implements

IMessage<CDOTAClientMsg\_PlayerDraftSuggest\>, 
[IEquatable<CDOTAClientMsg\_PlayerDraftSuggest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PlayerDraftSuggest\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PlayerDraftSuggest\>\(CDOTAClientMsg\_PlayerDraftSuggest, params CDOTAClientMsg\_PlayerDraftSuggest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest__ctor"></a> CDOTAClientMsg\_PlayerDraftSuggest\(\)

```csharp
public CDOTAClientMsg_PlayerDraftSuggest()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_"></a> CDOTAClientMsg\_PlayerDraftSuggest\(CDOTAClientMsg\_PlayerDraftSuggest\)

```csharp
public CDOTAClientMsg_PlayerDraftSuggest(CDOTAClientMsg_PlayerDraftSuggest other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PlayerDraftSuggest> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PlayerDraftSuggest Clone()
```

#### Returns

 [CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_"></a> Equals\(CDOTAClientMsg\_PlayerDraftSuggest\)

```csharp
public bool Equals(CDOTAClientMsg_PlayerDraftSuggest other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_"></a> MergeFrom\(CDOTAClientMsg\_PlayerDraftSuggest\)

```csharp
public void MergeFrom(CDOTAClientMsg_PlayerDraftSuggest other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftSuggest](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftSuggest.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftSuggest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

