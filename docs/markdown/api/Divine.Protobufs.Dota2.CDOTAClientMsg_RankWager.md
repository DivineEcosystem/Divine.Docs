# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager"></a> Class CDOTAClientMsg\_RankWager

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RankWager : IMessage<CDOTAClientMsg_RankWager>, IEquatable<CDOTAClientMsg_RankWager>, IDeepCloneable<CDOTAClientMsg_RankWager>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)

#### Implements

IMessage<CDOTAClientMsg\_RankWager\>, 
[IEquatable<CDOTAClientMsg\_RankWager\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RankWager\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RankWager\>\(CDOTAClientMsg\_RankWager, params CDOTAClientMsg\_RankWager\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager__ctor"></a> CDOTAClientMsg\_RankWager\(\)

```csharp
public CDOTAClientMsg_RankWager()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_"></a> CDOTAClientMsg\_RankWager\(CDOTAClientMsg\_RankWager\)

```csharp
public CDOTAClientMsg_RankWager(CDOTAClientMsg_RankWager other)
```

#### Parameters

`other` [CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_AnnounceWagerFieldNumber"></a> AnnounceWagerFieldNumber

```csharp
public const int AnnounceWagerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_AnnounceWager"></a> AnnounceWager

```csharp
public bool AnnounceWager { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_HasAnnounceWager"></a> HasAnnounceWager

```csharp
public bool HasAnnounceWager { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RankWager> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_ClearAnnounceWager"></a> ClearAnnounceWager\(\)

```csharp
public void ClearAnnounceWager()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RankWager Clone()
```

#### Returns

 [CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_"></a> Equals\(CDOTAClientMsg\_RankWager\)

```csharp
public bool Equals(CDOTAClientMsg_RankWager other)
```

#### Parameters

`other` [CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_"></a> MergeFrom\(CDOTAClientMsg\_RankWager\)

```csharp
public void MergeFrom(CDOTAClientMsg_RankWager other)
```

#### Parameters

`other` [CDOTAClientMsg\_RankWager](Divine.Protobufs.Dota2.CDOTAClientMsg\_RankWager.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RankWager_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

