# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry"></a> Class CDOTAUserMsg\_AddQuestLogEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_AddQuestLogEntry : IMessage<CDOTAUserMsg_AddQuestLogEntry>, IEquatable<CDOTAUserMsg_AddQuestLogEntry>, IDeepCloneable<CDOTAUserMsg_AddQuestLogEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)

#### Implements

IMessage<CDOTAUserMsg\_AddQuestLogEntry\>, 
[IEquatable<CDOTAUserMsg\_AddQuestLogEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_AddQuestLogEntry\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_AddQuestLogEntry\>\(CDOTAUserMsg\_AddQuestLogEntry, params CDOTAUserMsg\_AddQuestLogEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry__ctor"></a> CDOTAUserMsg\_AddQuestLogEntry\(\)

```csharp
public CDOTAUserMsg_AddQuestLogEntry()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_"></a> CDOTAUserMsg\_AddQuestLogEntry\(CDOTAUserMsg\_AddQuestLogEntry\)

```csharp
public CDOTAUserMsg_AddQuestLogEntry(CDOTAUserMsg_AddQuestLogEntry other)
```

#### Parameters

`other` [CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_NpcDialogFieldNumber"></a> NpcDialogFieldNumber

```csharp
public const int NpcDialogFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_NpcNameFieldNumber"></a> NpcNameFieldNumber

```csharp
public const int NpcNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_HasNpcDialog"></a> HasNpcDialog

```csharp
public bool HasNpcDialog { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_HasNpcName"></a> HasNpcName

```csharp
public bool HasNpcName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_NpcDialog"></a> NpcDialog

```csharp
public string NpcDialog { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_NpcName"></a> NpcName

```csharp
public string NpcName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_AddQuestLogEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_ClearNpcDialog"></a> ClearNpcDialog\(\)

```csharp
public void ClearNpcDialog()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_ClearNpcName"></a> ClearNpcName\(\)

```csharp
public void ClearNpcName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_AddQuestLogEntry Clone()
```

#### Returns

 [CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_"></a> Equals\(CDOTAUserMsg\_AddQuestLogEntry\)

```csharp
public bool Equals(CDOTAUserMsg_AddQuestLogEntry other)
```

#### Parameters

`other` [CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_"></a> MergeFrom\(CDOTAUserMsg\_AddQuestLogEntry\)

```csharp
public void MergeFrom(CDOTAUserMsg_AddQuestLogEntry other)
```

#### Parameters

`other` [CDOTAUserMsg\_AddQuestLogEntry](Divine.Protobufs.Dota2.CDOTAUserMsg\_AddQuestLogEntry.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AddQuestLogEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

