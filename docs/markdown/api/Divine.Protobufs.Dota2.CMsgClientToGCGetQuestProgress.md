# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress"></a> Class CMsgClientToGCGetQuestProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetQuestProgress : IMessage<CMsgClientToGCGetQuestProgress>, IEquatable<CMsgClientToGCGetQuestProgress>, IDeepCloneable<CMsgClientToGCGetQuestProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)

#### Implements

IMessage<CMsgClientToGCGetQuestProgress\>, 
[IEquatable<CMsgClientToGCGetQuestProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetQuestProgress\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetQuestProgress\>\(CMsgClientToGCGetQuestProgress, params CMsgClientToGCGetQuestProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress__ctor"></a> CMsgClientToGCGetQuestProgress\(\)

```csharp
public CMsgClientToGCGetQuestProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_"></a> CMsgClientToGCGetQuestProgress\(CMsgClientToGCGetQuestProgress\)

```csharp
public CMsgClientToGCGetQuestProgress(CMsgClientToGCGetQuestProgress other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_QuestIdsFieldNumber"></a> QuestIdsFieldNumber

```csharp
public const int QuestIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetQuestProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_QuestIds"></a> QuestIds

```csharp
public RepeatedField<uint> QuestIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetQuestProgress Clone()
```

#### Returns

 [CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_"></a> Equals\(CMsgClientToGCGetQuestProgress\)

```csharp
public bool Equals(CMsgClientToGCGetQuestProgress other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_"></a> MergeFrom\(CMsgClientToGCGetQuestProgress\)

```csharp
public void MergeFrom(CMsgClientToGCGetQuestProgress other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgress](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

