# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry"></a> Class CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry : IMessage<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry>, IEquatable<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry>, IDeepCloneable<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)

#### Implements

IMessage<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry\>, 
[IEquatable<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry\>\(CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry, params CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry__ctor"></a> CFilterEntry\(\)

```csharp
public CFilterEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_"></a> CFilterEntry\(CFilterEntry\)

```csharp
public CFilterEntry(CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_NoteFieldNumber"></a> NoteFieldNumber

```csharp
public const int NoteFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_TimeAddedFieldNumber"></a> TimeAddedFieldNumber

```csharp
public const int TimeAddedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_TimeExpiresFieldNumber"></a> TimeExpiresFieldNumber

```csharp
public const int TimeExpiresFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_HasNote"></a> HasNote

```csharp
public bool HasNote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_HasTimeAdded"></a> HasTimeAdded

```csharp
public bool HasTimeAdded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_HasTimeExpires"></a> HasTimeExpires

```csharp
public bool HasTimeExpires { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Note"></a> Note

```csharp
public string Note { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_TimeAdded"></a> TimeAdded

```csharp
public uint TimeAdded { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_TimeExpires"></a> TimeExpires

```csharp
public uint TimeExpires { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_ClearNote"></a> ClearNote\(\)

```csharp
public void ClearNote()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_ClearTimeAdded"></a> ClearTimeAdded\(\)

```csharp
public void ClearTimeAdded()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_ClearTimeExpires"></a> ClearTimeExpires\(\)

```csharp
public void ClearTimeExpires()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry Clone()
```

#### Returns

 [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_"></a> Equals\(CFilterEntry\)

```csharp
public bool Equals(CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_"></a> MergeFrom\(CFilterEntry\)

```csharp
public void MergeFrom(CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry other)
```

#### Parameters

`other` [CMsgGCToClientGetFilteredPlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.md).[CFilterEntry](Divine.Protobufs.Dota2.CMsgGCToClientGetFilteredPlayersResponse.Types.CFilterEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFilteredPlayersResponse_Types_CFilterEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

