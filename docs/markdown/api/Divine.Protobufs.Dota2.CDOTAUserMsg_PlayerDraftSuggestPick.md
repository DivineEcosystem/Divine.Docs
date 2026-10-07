# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick"></a> Class CDOTAUserMsg\_PlayerDraftSuggestPick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_PlayerDraftSuggestPick : IMessage<CDOTAUserMsg_PlayerDraftSuggestPick>, IEquatable<CDOTAUserMsg_PlayerDraftSuggestPick>, IDeepCloneable<CDOTAUserMsg_PlayerDraftSuggestPick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)

#### Implements

IMessage<CDOTAUserMsg\_PlayerDraftSuggestPick\>, 
[IEquatable<CDOTAUserMsg\_PlayerDraftSuggestPick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_PlayerDraftSuggestPick\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_PlayerDraftSuggestPick\>\(CDOTAUserMsg\_PlayerDraftSuggestPick, params CDOTAUserMsg\_PlayerDraftSuggestPick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick__ctor"></a> CDOTAUserMsg\_PlayerDraftSuggestPick\(\)

```csharp
public CDOTAUserMsg_PlayerDraftSuggestPick()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_"></a> CDOTAUserMsg\_PlayerDraftSuggestPick\(CDOTAUserMsg\_PlayerDraftSuggestPick\)

```csharp
public CDOTAUserMsg_PlayerDraftSuggestPick(CDOTAUserMsg_PlayerDraftSuggestPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_SuggestionPlayerIdFieldNumber"></a> SuggestionPlayerIdFieldNumber

```csharp
public const int SuggestionPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_HasSuggestionPlayerId"></a> HasSuggestionPlayerId

```csharp
public bool HasSuggestionPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_PlayerDraftSuggestPick> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_SuggestionPlayerId"></a> SuggestionPlayerId

```csharp
public int SuggestionPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_ClearSuggestionPlayerId"></a> ClearSuggestionPlayerId\(\)

```csharp
public void ClearSuggestionPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_PlayerDraftSuggestPick Clone()
```

#### Returns

 [CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_"></a> Equals\(CDOTAUserMsg\_PlayerDraftSuggestPick\)

```csharp
public bool Equals(CDOTAUserMsg_PlayerDraftSuggestPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_"></a> MergeFrom\(CDOTAUserMsg\_PlayerDraftSuggestPick\)

```csharp
public void MergeFrom(CDOTAUserMsg_PlayerDraftSuggestPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftSuggestPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftSuggestPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftSuggestPick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

