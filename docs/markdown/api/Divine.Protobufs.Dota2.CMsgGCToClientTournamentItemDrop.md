# <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop"></a> Class CMsgGCToClientTournamentItemDrop

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientTournamentItemDrop : IMessage<CMsgGCToClientTournamentItemDrop>, IEquatable<CMsgGCToClientTournamentItemDrop>, IDeepCloneable<CMsgGCToClientTournamentItemDrop>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)

#### Implements

IMessage<CMsgGCToClientTournamentItemDrop\>, 
[IEquatable<CMsgGCToClientTournamentItemDrop\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientTournamentItemDrop\>, 
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
[EnumerableExtensions.In<CMsgGCToClientTournamentItemDrop\>\(CMsgGCToClientTournamentItemDrop, params CMsgGCToClientTournamentItemDrop\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop__ctor"></a> CMsgGCToClientTournamentItemDrop\(\)

```csharp
public CMsgGCToClientTournamentItemDrop()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop__ctor_Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_"></a> CMsgGCToClientTournamentItemDrop\(CMsgGCToClientTournamentItemDrop\)

```csharp
public CMsgGCToClientTournamentItemDrop(CMsgGCToClientTournamentItemDrop other)
```

#### Parameters

`other` [CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientTournamentItemDrop> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientTournamentItemDrop Clone()
```

#### Returns

 [CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_Equals_Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_"></a> Equals\(CMsgGCToClientTournamentItemDrop\)

```csharp
public bool Equals(CMsgGCToClientTournamentItemDrop other)
```

#### Parameters

`other` [CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_"></a> MergeFrom\(CMsgGCToClientTournamentItemDrop\)

```csharp
public void MergeFrom(CMsgGCToClientTournamentItemDrop other)
```

#### Parameters

`other` [CMsgGCToClientTournamentItemDrop](Divine.Protobufs.Dota2.CMsgGCToClientTournamentItemDrop.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTournamentItemDrop_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

