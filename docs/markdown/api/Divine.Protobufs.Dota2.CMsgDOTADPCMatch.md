# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch"></a> Class CMsgDOTADPCMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCMatch : IMessage<CMsgDOTADPCMatch>, IEquatable<CMsgDOTADPCMatch>, IDeepCloneable<CMsgDOTADPCMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)

#### Implements

IMessage<CMsgDOTADPCMatch\>, 
[IEquatable<CMsgDOTADPCMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCMatch\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCMatch\>\(CMsgDOTADPCMatch, params CMsgDOTADPCMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch__ctor"></a> CMsgDOTADPCMatch\(\)

```csharp
public CMsgDOTADPCMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCMatch_"></a> CMsgDOTADPCMatch\(CMsgDOTADPCMatch\)

```csharp
public CMsgDOTADPCMatch(CMsgDOTADPCMatch other)
```

#### Parameters

`other` [CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_MatchFieldNumber"></a> MatchFieldNumber

```csharp
public const int MatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_MetadataFieldNumber"></a> MetadataFieldNumber

```csharp
public const int MetadataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Match"></a> Match

```csharp
public CMsgDOTAMatch Match { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Metadata"></a> Metadata

```csharp
public CDOTAMatchMetadata Metadata { get; set; }
```

#### Property Value

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCMatch Clone()
```

#### Returns

 [CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCMatch_"></a> Equals\(CMsgDOTADPCMatch\)

```csharp
public bool Equals(CMsgDOTADPCMatch other)
```

#### Parameters

`other` [CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCMatch_"></a> MergeFrom\(CMsgDOTADPCMatch\)

```csharp
public void MergeFrom(CMsgDOTADPCMatch other)
```

#### Parameters

`other` [CMsgDOTADPCMatch](Divine.Protobufs.Dota2.CMsgDOTADPCMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

