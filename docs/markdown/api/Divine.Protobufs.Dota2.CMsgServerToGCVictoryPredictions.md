# <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions"></a> Class CMsgServerToGCVictoryPredictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCVictoryPredictions : IMessage<CMsgServerToGCVictoryPredictions>, IEquatable<CMsgServerToGCVictoryPredictions>, IDeepCloneable<CMsgServerToGCVictoryPredictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)

#### Implements

IMessage<CMsgServerToGCVictoryPredictions\>, 
[IEquatable<CMsgServerToGCVictoryPredictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCVictoryPredictions\>, 
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
[EnumerableExtensions.In<CMsgServerToGCVictoryPredictions\>\(CMsgServerToGCVictoryPredictions, params CMsgServerToGCVictoryPredictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions__ctor"></a> CMsgServerToGCVictoryPredictions\(\)

```csharp
public CMsgServerToGCVictoryPredictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions__ctor_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_"></a> CMsgServerToGCVictoryPredictions\(CMsgServerToGCVictoryPredictions\)

```csharp
public CMsgServerToGCVictoryPredictions(CMsgServerToGCVictoryPredictions other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_RecordsFieldNumber"></a> RecordsFieldNumber

```csharp
public const int RecordsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCVictoryPredictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Records"></a> Records

```csharp
public RepeatedField<CMsgServerToGCVictoryPredictions.Types.Record> Records { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.md).[Record](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.Types.Record.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCVictoryPredictions Clone()
```

#### Returns

 [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_Equals_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_"></a> Equals\(CMsgServerToGCVictoryPredictions\)

```csharp
public bool Equals(CMsgServerToGCVictoryPredictions other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_"></a> MergeFrom\(CMsgServerToGCVictoryPredictions\)

```csharp
public void MergeFrom(CMsgServerToGCVictoryPredictions other)
```

#### Parameters

`other` [CMsgServerToGCVictoryPredictions](Divine.Protobufs.Dota2.CMsgServerToGCVictoryPredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCVictoryPredictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

