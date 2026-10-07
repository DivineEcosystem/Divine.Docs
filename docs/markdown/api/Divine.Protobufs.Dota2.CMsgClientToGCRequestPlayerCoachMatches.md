# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches"></a> Class CMsgClientToGCRequestPlayerCoachMatches

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerCoachMatches : IMessage<CMsgClientToGCRequestPlayerCoachMatches>, IEquatable<CMsgClientToGCRequestPlayerCoachMatches>, IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatches>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerCoachMatches\>, 
[IEquatable<CMsgClientToGCRequestPlayerCoachMatches\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatches\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerCoachMatches\>\(CMsgClientToGCRequestPlayerCoachMatches, params CMsgClientToGCRequestPlayerCoachMatches\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches__ctor"></a> CMsgClientToGCRequestPlayerCoachMatches\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatches()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_"></a> CMsgClientToGCRequestPlayerCoachMatches\(CMsgClientToGCRequestPlayerCoachMatches\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatches(CMsgClientToGCRequestPlayerCoachMatches other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerCoachMatches> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatches Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_"></a> Equals\(CMsgClientToGCRequestPlayerCoachMatches\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerCoachMatches other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_"></a> MergeFrom\(CMsgClientToGCRequestPlayerCoachMatches\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerCoachMatches other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatches](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatches.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatches_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

