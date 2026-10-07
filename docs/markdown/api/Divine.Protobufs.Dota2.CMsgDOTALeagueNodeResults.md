# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults"></a> Class CMsgDOTALeagueNodeResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNodeResults : IMessage<CMsgDOTALeagueNodeResults>, IEquatable<CMsgDOTALeagueNodeResults>, IDeepCloneable<CMsgDOTALeagueNodeResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)

#### Implements

IMessage<CMsgDOTALeagueNodeResults\>, 
[IEquatable<CMsgDOTALeagueNodeResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNodeResults\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNodeResults\>\(CMsgDOTALeagueNodeResults, params CMsgDOTALeagueNodeResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults__ctor"></a> CMsgDOTALeagueNodeResults\(\)

```csharp
public CMsgDOTALeagueNodeResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_"></a> CMsgDOTALeagueNodeResults\(CMsgDOTALeagueNodeResults\)

```csharp
public CMsgDOTALeagueNodeResults(CMsgDOTALeagueNodeResults other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_NodeResultsFieldNumber"></a> NodeResultsFieldNumber

```csharp
public const int NodeResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_NodeResults"></a> NodeResults

```csharp
public RepeatedField<CMsgDOTALeagueNodeResults.Types.Result> NodeResults { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNodeResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNodeResults Clone()
```

#### Returns

 [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_"></a> Equals\(CMsgDOTALeagueNodeResults\)

```csharp
public bool Equals(CMsgDOTALeagueNodeResults other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_"></a> MergeFrom\(CMsgDOTALeagueNodeResults\)

```csharp
public void MergeFrom(CMsgDOTALeagueNodeResults other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

