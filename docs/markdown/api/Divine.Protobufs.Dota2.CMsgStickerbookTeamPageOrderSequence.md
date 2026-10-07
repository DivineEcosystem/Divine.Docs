# <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence"></a> Class CMsgStickerbookTeamPageOrderSequence

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStickerbookTeamPageOrderSequence : IMessage<CMsgStickerbookTeamPageOrderSequence>, IEquatable<CMsgStickerbookTeamPageOrderSequence>, IDeepCloneable<CMsgStickerbookTeamPageOrderSequence>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

#### Implements

IMessage<CMsgStickerbookTeamPageOrderSequence\>, 
[IEquatable<CMsgStickerbookTeamPageOrderSequence\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStickerbookTeamPageOrderSequence\>, 
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
[EnumerableExtensions.In<CMsgStickerbookTeamPageOrderSequence\>\(CMsgStickerbookTeamPageOrderSequence, params CMsgStickerbookTeamPageOrderSequence\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence__ctor"></a> CMsgStickerbookTeamPageOrderSequence\(\)

```csharp
public CMsgStickerbookTeamPageOrderSequence()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence__ctor_Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_"></a> CMsgStickerbookTeamPageOrderSequence\(CMsgStickerbookTeamPageOrderSequence\)

```csharp
public CMsgStickerbookTeamPageOrderSequence(CMsgStickerbookTeamPageOrderSequence other)
```

#### Parameters

`other` [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_PageNumbersFieldNumber"></a> PageNumbersFieldNumber

```csharp
public const int PageNumbersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_PageNumbers"></a> PageNumbers

```csharp
public RepeatedField<uint> PageNumbers { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStickerbookTeamPageOrderSequence> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_Clone"></a> Clone\(\)

```csharp
public CMsgStickerbookTeamPageOrderSequence Clone()
```

#### Returns

 [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_Equals_Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_"></a> Equals\(CMsgStickerbookTeamPageOrderSequence\)

```csharp
public bool Equals(CMsgStickerbookTeamPageOrderSequence other)
```

#### Parameters

`other` [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_MergeFrom_Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_"></a> MergeFrom\(CMsgStickerbookTeamPageOrderSequence\)

```csharp
public void MergeFrom(CMsgStickerbookTeamPageOrderSequence other)
```

#### Parameters

`other` [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookTeamPageOrderSequence_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

