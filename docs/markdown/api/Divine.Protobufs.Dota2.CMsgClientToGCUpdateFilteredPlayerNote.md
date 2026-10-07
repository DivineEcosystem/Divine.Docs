# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote"></a> Class CMsgClientToGCUpdateFilteredPlayerNote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUpdateFilteredPlayerNote : IMessage<CMsgClientToGCUpdateFilteredPlayerNote>, IEquatable<CMsgClientToGCUpdateFilteredPlayerNote>, IDeepCloneable<CMsgClientToGCUpdateFilteredPlayerNote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)

#### Implements

IMessage<CMsgClientToGCUpdateFilteredPlayerNote\>, 
[IEquatable<CMsgClientToGCUpdateFilteredPlayerNote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUpdateFilteredPlayerNote\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUpdateFilteredPlayerNote\>\(CMsgClientToGCUpdateFilteredPlayerNote, params CMsgClientToGCUpdateFilteredPlayerNote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote__ctor"></a> CMsgClientToGCUpdateFilteredPlayerNote\(\)

```csharp
public CMsgClientToGCUpdateFilteredPlayerNote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_"></a> CMsgClientToGCUpdateFilteredPlayerNote\(CMsgClientToGCUpdateFilteredPlayerNote\)

```csharp
public CMsgClientToGCUpdateFilteredPlayerNote(CMsgClientToGCUpdateFilteredPlayerNote other)
```

#### Parameters

`other` [CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_NewNoteFieldNumber"></a> NewNoteFieldNumber

```csharp
public const int NewNoteFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_HasNewNote"></a> HasNewNote

```csharp
public bool HasNewNote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_NewNote"></a> NewNote

```csharp
public string NewNote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUpdateFilteredPlayerNote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_ClearNewNote"></a> ClearNewNote\(\)

```csharp
public void ClearNewNote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUpdateFilteredPlayerNote Clone()
```

#### Returns

 [CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_"></a> Equals\(CMsgClientToGCUpdateFilteredPlayerNote\)

```csharp
public bool Equals(CMsgClientToGCUpdateFilteredPlayerNote other)
```

#### Parameters

`other` [CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_"></a> MergeFrom\(CMsgClientToGCUpdateFilteredPlayerNote\)

```csharp
public void MergeFrom(CMsgClientToGCUpdateFilteredPlayerNote other)
```

#### Parameters

`other` [CMsgClientToGCUpdateFilteredPlayerNote](Divine.Protobufs.Dota2.CMsgClientToGCUpdateFilteredPlayerNote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateFilteredPlayerNote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

