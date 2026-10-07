# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate"></a> Class CDOTAUserMsg\_VoteUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_VoteUpdate : IMessage<CDOTAUserMsg_VoteUpdate>, IEquatable<CDOTAUserMsg_VoteUpdate>, IDeepCloneable<CDOTAUserMsg_VoteUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)

#### Implements

IMessage<CDOTAUserMsg\_VoteUpdate\>, 
[IEquatable<CDOTAUserMsg\_VoteUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_VoteUpdate\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_VoteUpdate\>\(CDOTAUserMsg\_VoteUpdate, params CDOTAUserMsg\_VoteUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate__ctor"></a> CDOTAUserMsg\_VoteUpdate\(\)

```csharp
public CDOTAUserMsg_VoteUpdate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_"></a> CDOTAUserMsg\_VoteUpdate\(CDOTAUserMsg\_VoteUpdate\)

```csharp
public CDOTAUserMsg_VoteUpdate(CDOTAUserMsg_VoteUpdate other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_ChoiceCountsFieldNumber"></a> ChoiceCountsFieldNumber

```csharp
public const int ChoiceCountsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_ChoiceCounts"></a> ChoiceCounts

```csharp
public RepeatedField<int> ChoiceCounts { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_VoteUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_VoteUpdate Clone()
```

#### Returns

 [CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_"></a> Equals\(CDOTAUserMsg\_VoteUpdate\)

```csharp
public bool Equals(CDOTAUserMsg_VoteUpdate other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_"></a> MergeFrom\(CDOTAUserMsg\_VoteUpdate\)

```csharp
public void MergeFrom(CDOTAUserMsg_VoteUpdate other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteUpdate](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteUpdate.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

