# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge"></a> Class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge : IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge>, IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge>, IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge\>, 
[IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge\>\(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge, params CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge__ctor"></a> SwappedChallenge\(\)

```csharp
public SwappedChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_"></a> SwappedChallenge\(SwappedChallenge\)

```csharp
public SwappedChallenge(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_PathId1FieldNumber"></a> PathId1FieldNumber

```csharp
public const int PathId1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_PathId2FieldNumber"></a> PathId2FieldNumber

```csharp
public const int PathId2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_HasPathId1"></a> HasPathId1

```csharp
public bool HasPathId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_HasPathId2"></a> HasPathId2

```csharp
public bool HasPathId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_PathId1"></a> PathId1

```csharp
public uint PathId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_PathId2"></a> PathId2

```csharp
public uint PathId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_ClearPathId1"></a> ClearPathId1\(\)

```csharp
public void ClearPathId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_ClearPathId2"></a> ClearPathId2\(\)

```csharp
public void ClearPathId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_"></a> Equals\(SwappedChallenge\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_"></a> MergeFrom\(SwappedChallenge\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[SwappedChallenge](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.SwappedChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_SwappedChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

