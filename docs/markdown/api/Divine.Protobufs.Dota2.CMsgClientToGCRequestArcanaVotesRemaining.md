# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining"></a> Class CMsgClientToGCRequestArcanaVotesRemaining

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestArcanaVotesRemaining : IMessage<CMsgClientToGCRequestArcanaVotesRemaining>, IEquatable<CMsgClientToGCRequestArcanaVotesRemaining>, IDeepCloneable<CMsgClientToGCRequestArcanaVotesRemaining>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)

#### Implements

IMessage<CMsgClientToGCRequestArcanaVotesRemaining\>, 
[IEquatable<CMsgClientToGCRequestArcanaVotesRemaining\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestArcanaVotesRemaining\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestArcanaVotesRemaining\>\(CMsgClientToGCRequestArcanaVotesRemaining, params CMsgClientToGCRequestArcanaVotesRemaining\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining__ctor"></a> CMsgClientToGCRequestArcanaVotesRemaining\(\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_"></a> CMsgClientToGCRequestArcanaVotesRemaining\(CMsgClientToGCRequestArcanaVotesRemaining\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemaining(CMsgClientToGCRequestArcanaVotesRemaining other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestArcanaVotesRemaining> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemaining Clone()
```

#### Returns

 [CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_"></a> Equals\(CMsgClientToGCRequestArcanaVotesRemaining\)

```csharp
public bool Equals(CMsgClientToGCRequestArcanaVotesRemaining other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_"></a> MergeFrom\(CMsgClientToGCRequestArcanaVotesRemaining\)

```csharp
public void MergeFrom(CMsgClientToGCRequestArcanaVotesRemaining other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemaining](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemaining.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemaining_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

